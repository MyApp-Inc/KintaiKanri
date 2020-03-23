Imports Oracle.ManagedDataAccess.Client
Public Class Form_VerifiedHistory
    Dim Role As Integer = 0
    Dim TargetUserName As String = ""
    Dim DBName As String = SystemInformation.UserName
    Dim StartDay As String = ""
    Dim EndDay As String = ""
    Dim Constr As String = "user id=pcs;password=pcs;data source=" +
                            "  (DESCRIPTION =" +
                            "      (ADDRESS_LIST =" +
                            "        (ADDRESS = (PROTOCOL = TCP)(HOST = cl-oda-scn-b)(PORT = 1521))" +
                            "      )" +
                            "      (CONNECT_DATA =" +
                            "        (SERVER = DEDICATED)" +
                            "        (SERVICE_NAME = dev1)" +
                            "      )" +
                            "    )" +
                            ";Pooling=false"
    Private Sub Button_VerifiedHistoryClose_Click(sender As Object, e As EventArgs) Handles Button_VerifiedHistoryClose.Click
        Me.Close()
    End Sub

    Private Sub Button_VerifiedHistoryDisplay_Click(sender As Object, e As EventArgs) Handles Button_VerifiedHistoryDisplay.Click
        'ListView初期化
        ListView_VerifiedHistory.Items.Clear()
        '選択された年月を取得
        Dim SelectedYear As String = DateTimePicker_VerifiedHistory.Value.ToString("yyyy")
        Dim SelectedMonth As String = DateTimePicker_VerifiedHistory.Value.ToString("MM")
        '選択月の日数を変数Daysに格納
        Dim Days As Integer = Date.DaysInMonth(DateTimePicker_VerifiedHistory.Value.Year, DateTimePicker_VerifiedHistory.Value.Month)
        'DB検索用文字列を作成（選択年月月初から月末までの範囲）
        StartDay = SelectedYear + "/" + SelectedMonth + "/" + "01"
        EndDay = SelectedYear + "/" + SelectedMonth + "/" + Days.ToString
        '行を数えて、全行のデータを削除
        If DataGridView_VerifiedHistory.Rows.Count > 0 Then
            For i = 0 To DataGridView_VerifiedHistory.Rows.Count - 1 Step 1
                DataGridView_VerifiedHistory.Rows.RemoveAt(0)
            Next
        End If
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtOverTime As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daOverTime.Fill(dtOverTime)
        'フィルタリングする
        Dim drlistMe As DataRow() = dtUser.Select("user_name = '" + DBName + "'")
        '検索結果により分岐（UserTableテーブルにデータがあれば、Roleを取得）
        If drlistMe.Length > 0 Then
            For Each drMe As DataRow In drlistMe
                Role = drMe("role_kbn")
                Dim Division As String = drMe("division_no")
                Dim Department As String = drMe("department_no")
                Dim Bureau As String = drMe("bureau_no")
                'RoleによってSQL分生成
                '同所属かつ自分の役職未満のユーザーを取得
                Dim drlistUser As DataRow()
                Select Case Role
                    Case 1
                        drlistUser = dtUser.Select("bureau_no = '" + Bureau + "' AND department_no = '" + Department + "' AND division_no = '" + Division + "' AND role_kbn <= '0'")
                    Case 2
                        drlistUser = dtUser.Select("bureau_no = '" + Bureau + "' AND department_no = '" + Department + "' AND role_kbn <= '1'")
                    Case 3
                        drlistUser = dtUser.Select("bureau_no = '" + Bureau + "' AND role_kbn <= '2'")
                    Case Else
                        drlistUser = dtUser.Select("role_kbn <= '3'")
                End Select
                '対象ユーザーが存在すれば、承認済時間外勤務時間合計を取得
                If drlistUser.Length > 0 Then
                    Dim drlistOverTime As DataRow()
                    Dim TargetName As String = ""
                    Dim OverTimeSum As TimeSpan = TimeSpan.Zero
                    Dim Flag As Boolean = False
                    '対象ユーザー1人1人について、選択年月の承認データがあるかどうかチェック
                    For Each drUser As DataRow In drlistUser
                        Dim Item1 As New ListViewItem
                        TargetName = drUser("user_name")
                        drlistOverTime = dtOverTime.Select("workingday >= '" + StartDay + "' AND workingday <= '" + EndDay + "' AND user_id = '" + TargetName + "'")
                        If drlistOverTime.Length > 0 Then
                            For Each dr As DataRow In drlistOverTime
                                'If (dr("approval_division_kbn") * dr("approval_department_kbn") * dr("approval_bureau_kbn") * dr("approval_manager_kbn")) Mod 2 <> 0 Then
                                Dim EarlyWorkingTime As TimeSpan = Date.Parse(dr("user_start_time")).TimeOfDay - Date.Parse(dr("planned_start_time")).TimeOfDay
                                    Dim CalculatedEndTime As TimeSpan = Date.Parse(dr("user_end_time")).TimeOfDay - EarlyWorkingTime
                                    Dim ExtraBreakTime As TimeSpan = Date.Parse(dr("planned_break_time")).TimeOfDay - TimeSpan.FromMinutes(45)
                                    Dim OverTime As TimeSpan = Date.Parse(dr("planned_end_time")).TimeOfDay - CalculatedEndTime - ExtraBreakTime
                                    If OverTime < TimeSpan.Zero Then
                                        OverTime = TimeSpan.Zero
                                    End If
                                    OverTimeSum += OverTime
                                    Flag = True
                                'End If
                            Next
                            If Flag Then
                                Item1.Text = drUser("full_name")
                                Item1.SubItems.Add(Math.Round(OverTimeSum.TotalHours, 2))
                                ListView_VerifiedHistory.Items.Add(Item1)
                                Flag = False
                                OverTimeSum = TimeSpan.Zero
                            End If
                        End If
                    Next
                End If
            Next
        End If
        con = Nothing
        'ListView1のすべての列を自動調節
        ListView_VerifiedHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView_VerifiedHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_VerifiedHistory.SelectedIndexChanged
        If ListView_VerifiedHistory.SelectedItems.Count > 0 Then
            Dim TargetItem As ListViewItem = ListView_VerifiedHistory.SelectedItems(0)
            Dim TargetFullName As String = TargetItem.Text
            'DataGridViewの行を数えて、全行のデータを削除
            If DataGridView_VerifiedHistory.Rows.Count > 0 Then
                For i = 0 To DataGridView_VerifiedHistory.Rows.Count - 1 Step 1
                    DataGridView_VerifiedHistory.Rows.RemoveAt(0)
                Next
            End If
            'OracleConnectionオブジェクトを生成
            Dim con As New OracleConnection(Constr)
            'SQL文を作成
            Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
            Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
            Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
            'DataAdapterオブジェクトを生成
            Dim daUser As New OracleDataAdapter(SQLUser, con)
            Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
            Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
            'DataTableオブジェクトを生成
            Dim dtUser As New DataTable()
            Dim dtOverTime As New DataTable()
            Dim dtHoliday As New DataTable()
            'DataTableとデータベースに同期させる
            daUser.Fill(dtUser)
            daOverTime.Fill(dtOverTime)
            daHoliday.Fill(dtHoliday)
            'Userテーブルを参照し、FullNameからUserNameを取得
            Dim drlistUser As DataRow() = dtUser.Select("full_name = '" + TargetFullName + "'")
            If drlistUser.Length > 0 Then
                For Each drUser As DataRow In drlistUser
                    TargetUserName = drUser("user_name")
                    'OverTimeテーブルを参照し、承認データを取得
                    Dim drlistOverTime As DataRow() = dtOverTime.Select("workingday >= '" + StartDay + "' AND workingday <= '" + EndDay + "' AND user_id = '" + TargetUserName + "'")
                    If drlistOverTime.Length > 0 Then
                        Dim Idx As Integer = 0
                        For Each dr As DataRow In drlistOverTime
                            '承認済データかどうかを判定
                            If dr("approval_division_kbn") <> 2 And dr("approval_department_kbn") <> 2 And dr("approval_bureau_kbn") <> 2 And dr("approval_manager_kbn") <> 2 Then
                                Dim TargetDay As String = dr("workingday")
                                Dim EarlyWorkingTime As TimeSpan = Date.Parse(dr("user_start_time")).TimeOfDay - Date.Parse(dr("planned_start_time")).TimeOfDay
                                Dim CalculatedEndTime As TimeSpan = Date.Parse(dr("user_end_time")).TimeOfDay - EarlyWorkingTime
                                Dim ExtraBreakTime As TimeSpan = Date.Parse(dr("planned_break_time")).TimeOfDay - TimeSpan.FromMinutes(45)
                                Dim OverTime As TimeSpan = Date.Parse(dr("planned_end_time")).TimeOfDay - CalculatedEndTime - ExtraBreakTime
                                Dim EndTime As String = Date.Parse(dr("planned_end_time")).ToString("H:mm")
                                If Date.Parse(dr("planned_end_time")).ToString("yyyy/MM/dd") <> "2019/01/01" Then
                                    OverTime += TimeSpan.FromDays(1)
                                    EndTime = "翌" + Date.Parse(dr("planned_end_time")).ToString("H:mm")
                                End If
                                Dim StartTime As String = ""
                                If CalculatedEndTime.Days >= 1 Then
                                    CalculatedEndTime -= TimeSpan.FromDays(1)
                                    StartTime = "翌" + Date.Parse("2019/01/01 " + CalculatedEndTime.ToString).ToString("H:mm")
                                Else
                                    StartTime = Date.Parse("2019/01/01 " + CalculatedEndTime.ToString).ToString("H:mm")
                                End If
                                DataGridView_VerifiedHistory.Rows.Add()
                                DataGridView_VerifiedHistory(0, Idx).Value = Date.Parse(TargetDay).ToString("yyyy年M月dd日（ddd）")
                                DataGridView_VerifiedHistory(1, Idx).Value = Date.Parse(dr("planned_start_time")).ToString("H:mm") + " ～ " + EndTime
                                If OverTime.Ticks < 0 Then
                                    DataGridView_VerifiedHistory(2, Idx).Value = Date.Parse(dr("planned_start_time")).ToString("H:mm") + " ～ " + EndTime +
                                                                        Environment.NewLine + "（入力不正データ）"
                                Else
                                    DataGridView_VerifiedHistory(2, Idx).Value = StartTime + " ～ " + EndTime + Environment.NewLine +
                                                                                "（" + Date.Parse("2019/01/01 " + OverTime.ToString).ToString("H時間mm分") + "）"
                                End If
                                DataGridView_VerifiedHistory(3, Idx).Value = Date.Parse(dr("planned_break_time")).ToString("H時間mm分")
                                '休日勤務の場合、業務内容及び理由欄に振替休日指示日を追加
                                Dim drlistHoliday As DataRow() = dtHoliday.Select("user_id = '" + TargetUserName + "' AND workingday = '" + TargetDay + "'")
                                If drlistHoliday.Length > 0 Then
                                    For Each drH As DataRow In drlistHoliday
                                        Dim Holiday As String = Date.Parse(drH("planned_holiday")).ToString("yyyy年M月d日（ddd）")
                                        DataGridView_VerifiedHistory(4, Idx).Value = dr("reason") + Environment.NewLine + "振替休日指示日：" + Holiday
                                        If drH("holiday") Is DBNull.Value Then
                                            DataGridView_VerifiedHistory(5, Idx).Value = "未取得"
                                            DataGridView_VerifiedHistory(5, Idx).Style.ForeColor = Color.Red
                                        Else
                                            DataGridView_VerifiedHistory(5, Idx).Value = Date.Parse(drH("holiday")).ToString("yyyy年M月d日（ddd）")
                                            DataGridView_VerifiedHistory(5, Idx).Style.ForeColor = Color.Black
                                        End If
                                    Next
                                Else
                                    DataGridView_VerifiedHistory(4, Idx).Value = dr("reason")
                                End If
                                '承認状況を表示
                                If dr("approval_division_kbn") = 2 Or dr("approval_department_kbn") = 2 Or dr("approval_bureau_kbn") = 2 Or dr("approval_manager_kbn") = 2 Then
                                    DataGridView_VerifiedHistory(6, Idx).Value = "却下"
                                    DataGridView_VerifiedHistory(6, Idx).Style.ForeColor = Color.Red
                                    DataGridView_VerifiedHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightPink
                                ElseIf dr("approval_division_kbn") = 0 Then
                                    DataGridView_VerifiedHistory(6, Idx).Value = "課長申請中"
                                    DataGridView_VerifiedHistory(6, Idx).Style.ForeColor = Color.Black
                                    DataGridView_VerifiedHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                                ElseIf dr("approval_department_kbn") = 0 Then
                                    DataGridView_VerifiedHistory(6, Idx).Value = "部長申請中"
                                    DataGridView_VerifiedHistory(6, Idx).Style.ForeColor = Color.Black
                                    DataGridView_VerifiedHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                                ElseIf dr("approval_bureau_kbn") = 0 Then
                                    DataGridView_VerifiedHistory(6, Idx).Value = "本部長申請中"
                                    DataGridView_VerifiedHistory(6, Idx).Style.ForeColor = Color.Black
                                    DataGridView_VerifiedHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                                ElseIf dr("approval_manager_kbn") = 0 Then
                                    DataGridView_VerifiedHistory(6, Idx).Value = "管理本部長申請中"
                                    DataGridView_VerifiedHistory(6, Idx).Style.ForeColor = Color.Black
                                    DataGridView_VerifiedHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                                Else
                                    DataGridView_VerifiedHistory(6, Idx).Value = "承認"
                                    DataGridView_VerifiedHistory(6, Idx).Style.ForeColor = Color.Blue
                                    DataGridView_VerifiedHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightCyan
                                End If
                                Idx = Idx + 1
                            End If
                        Next
                        DataGridView_VerifiedHistory.Sort(DataGridView_VerifiedHistory.Columns(0), ComponentModel.ListSortDirection.Ascending)
                        DataGridView_VerifiedHistory.ClearSelection()
                    End If
                Next
            End If

            con = Nothing
        End If
    End Sub

    Private Sub Form_VerifiedHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_VerifiedHistoryDisplay.PerformClick()
    End Sub
End Class