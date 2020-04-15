Imports Oracle.ManagedDataAccess.Client
Public Class Form_CheckTimeCard
    Public DBName As String = SystemInformation.UserName
    Public Role As Integer = 0
    Public StrToday As String = Date.Today.ToString("yyyy/MM/dd")
    Public TargetItem As ListViewItem
    Public TargetFullName As String
    ReadOnly Constr As String = "user id=pcs;password=pcs;data source=" +
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
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Close()
    End Sub

    Private Sub Form_CheckTimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListView初期化
        ListView_User.Items.Clear()
        'DataGridViewの行を数えて、全行のデータを削除
        If DataGridView_TimeCard.Rows.Count > 0 Then
            For i = 0 To DataGridView_TimeCard.Rows.Count - 1 Step 1
                DataGridView_TimeCard.Rows.RemoveAt(0)
            Next
        End If
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLTimeCard As String = "SELECT * FROM tt_kintai_timecard"
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        'DataAdapterオブジェクトを生成
        Dim daTimeCard As New OracleDataAdapter(SQLTimeCard, con)
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        'DataTableオブジェクトを生成
        Dim dtTimeCard As New DataTable()
        Dim dtUser As New DataTable()
        Dim dtOverTime As New DataTable()
        'DataTableとデータベースに同期させる
        daTimeCard.Fill(dtTimeCard)
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
                '対象ユーザーが存在すれば、直近の勤務時間を取得
                If drlistUser.Length > 0 Then
                    Dim drlistTimeCard As DataRow()
                    Dim TargetName As String
                    '対象ユーザー1人1人について、昨日以前のタイムカードを降順で取得
                    For Each drUser As DataRow In drlistUser
                        Dim Item1 As New ListViewItem
                        TargetName = drUser("user_name")
                        drlistTimeCard = dtTimeCard.Select("user_id = '" + TargetName + "' AND workingday < '" + StrToday + "'", "workingday DESC")

                        If drlistTimeCard.Length > 0 Then
                            Dim drTimeCard As DataRow = drlistTimeCard(0)
                            Item1.Text = drUser("full_name")
                            Dim WorkingTime As String = Date.Parse(drTimeCard("workingday")).ToString("M月d日(ddd)") + " " +
                                                        Date.Parse(drTimeCard("start_time")).ToString("H時mm分") + " ～ " +
                                                        Date.Parse(drTimeCard("end_time")).ToString("H時mm分")
                            Item1.SubItems.Add(WorkingTime)
                            ListView_User.Items.Add(Item1)
                        End If
                    Next
                End If
            Next
        End If
        con = Nothing
        'ListViewのすべての列を自動調節
        ListView_User.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView_User_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_User.SelectedIndexChanged
        If ListView_User.SelectedItems.Count > 0 Then
            TargetItem = ListView_User.SelectedItems(0)
            TargetFullName = TargetItem.Text
            Label_OverTimeSum.Visible = True
            DateTimePicker_TimeCard.Enabled = True
            Button_TimeCardDisplay.Enabled = True
            Button_TimeCardDisplay.PerformClick()
        End If
    End Sub

    Private Sub Button_TimeCardDisplay_Click(sender As Object, e As EventArgs) Handles Button_TimeCardDisplay.Click
        '選択された年月を取得
        Dim SelectedYear As String = DateTimePicker_TimeCard.Value.ToString("yyyy")
        Dim SelectedMonth As String = DateTimePicker_TimeCard.Value.ToString("MM")
        '選択月の日数を変数Daysに格納
        Dim Days As Integer = Date.DaysInMonth(DateTimePicker_TimeCard.Value.Year, DateTimePicker_TimeCard.Value.Month)
        'DB検索用文字列を作成（選択年月月初から月末までの範囲）
        Dim StartDay As String = SelectedYear + "/" + SelectedMonth + "/" + "01"
        Dim EndDay As String = SelectedYear + "/" + SelectedMonth + "/" + Days.ToString
        'DataGridViewの行を数えて、全行のデータを削除
        If DataGridView_TimeCard.Rows.Count > 0 Then
            For i = 0 To DataGridView_TimeCard.Rows.Count - 1 Step 1
                DataGridView_TimeCard.Rows.RemoveAt(0)
            Next
        End If
        'DataGridViewにタイムカード表示
        For Idx As Integer = 1 To Days
            DataGridView_TimeCard.Rows.Add()
            DataGridView_TimeCard.CurrentCell = DataGridView_TimeCard(0, Idx - 1)
            Dim TheDay = New DateTime(SelectedYear, SelectedMonth, Idx)
            Dim TheWeek As String = TheDay.ToString("ddd")
            Dim Idx_S As String
            '日付が１桁の場合ゼロ埋め
            If Idx < 10 Then
                Idx_S = "0" + Idx.ToString
            Else
                Idx_S = Idx.ToString
            End If
            DataGridView_TimeCard.CurrentCell.Value = Idx_S + "日（" + TheWeek + "）"
            '曜日によって色分け
            Select Case TheWeek
                Case "土"
                    DataGridView_TimeCard.CurrentCell.Style.ForeColor = Color.Blue
                    DataGridView_TimeCard(4, Idx - 1).Value = "休日"
                    DataGridView_TimeCard(4, Idx - 1).Style.ForeColor = Color.Red
                    DataGridView_TimeCard.Rows(Idx - 1).DefaultCellStyle.BackColor = Color.LightGray
                Case "日"
                    DataGridView_TimeCard.CurrentCell.Style.ForeColor = Color.Red
                    DataGridView_TimeCard(4, Idx - 1).Value = "休日"
                    DataGridView_TimeCard(4, Idx - 1).Style.ForeColor = Color.Red
                    DataGridView_TimeCard.Rows(Idx - 1).DefaultCellStyle.BackColor = Color.LightGray
                Case Else
                    DataGridView_TimeCard.CurrentCell.Style.ForeColor = Color.Black
            End Select
        Next

        Dim TargetDayStart As String = DateTimePicker_TimeCard.Value.ToString("yyyy/MM/01")
        Dim TargetDayEnd As String = Date.Parse(TargetDayStart).AddMonths(1).AddDays(-1.0).ToString("yyyy/MM/dd")
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        Dim SQLPublic As String = "SELECT * FROM tm_kintai_publicholiday"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        Dim daPublic As New OracleDataAdapter(SQLPublic, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtOverTime As New DataTable()
        Dim dtPublic As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daOverTime.Fill(dtOverTime)
        daPublic.Fill(dtPublic)
        'フィルタリングする
        Dim drlistPublic As DataRow() = dtPublic.Select("holiday >= '" + TargetDayStart + "' AND holiday <= '" + TargetDayEnd + "'")
        '祝日を取得してDataGridViewに反映
        If drlistPublic.Length > 0 Then
            For Each dr As DataRow In drlistPublic
                Dim TargetDay As Integer = Date.Parse(dr("holiday")).Day
                Dim TargetDay_S As String
                '日付が１桁の場合ゼロ埋め
                If TargetDay < 10 Then
                    TargetDay_S = "0" + TargetDay.ToString
                Else
                    TargetDay_S = TargetDay.ToString
                End If
                DataGridView_TimeCard(0, TargetDay - 1).Value = TargetDay_S + "日（休）"
                DataGridView_TimeCard(0, TargetDay - 1).Style.ForeColor = Color.Red
                DataGridView_TimeCard(4, TargetDay - 1).Value = "休日"
                DataGridView_TimeCard(4, TargetDay - 1).Style.ForeColor = Color.Red
                DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.LightGray
            Next
        End If
        'Userテーブルを参照し、FullNameからUserNameを取得
        Dim UserName As String = Nothing
        Dim drlistUser As DataRow() = dtUser.Select("full_name = '" + TargetFullName + "'")
        If drlistUser.Length > 0 Then
            For Each drUser As DataRow In drlistUser
                UserName = drUser("user_name")
            Next
        End If
        'フィルタリングする
        Dim drlistOverTime As DataRow() = dtOverTime.Select("user_id = '" + UserName + "' AND workingday >= '" + TargetDayStart + "' AND workingday <= '" + TargetDayEnd + "'")
        'OverTimeテーブルから取得したデータをDataGridViewに反映
        If drlistOverTime.Length > 0 Then
            Dim OverTimeSum As TimeSpan = TimeSpan.Zero
            For Each dr As DataRow In drlistOverTime
                Dim TargetDay As Integer = Integer.Parse(dr("workingday").ToString.Substring(8, 2))
                Dim OverTimeStart As String = Date.Parse(dr("planned_start_time")).ToString("H:mm")
                Dim OverTimeEnd As String = Date.Parse(dr("planned_end_time")).ToString("H:mm")
                '日またぎ申請の場合、「翌」の文字を付与
                If Date.Parse(dr("planned_end_time")).ToString("yyyy/MM/dd") <> "2019/01/01" Then
                    OverTimeEnd = "翌" + OverTimeEnd
                End If
                Dim OverTimeBreak As String = Date.Parse(dr("planned_break_time")).ToString("H時間mm分")
                DataGridView_TimeCard(3, TargetDay - 1).Value = OverTimeStart + "～" + OverTimeEnd + "（休憩" + OverTimeBreak + "）"
                '承認状況判定
                If dr("approval_division_kbn") = 2 Or dr("approval_department_kbn") = 2 Or dr("approval_bureau_kbn") = 2 Or dr("approval_manager_kbn") = 2 Then
                    DataGridView_TimeCard(5, TargetDay - 1).Value = "却下（要修正）"
                    DataGridView_TimeCard(5, TargetDay - 1).Style.ForeColor = Color.Red
                    DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.LightPink
                ElseIf dr("approval_division_kbn") = 0 Then
                    DataGridView_TimeCard(5, TargetDay - 1).Value = "課長申請中"
                    DataGridView_TimeCard(5, TargetDay - 1).Style.ForeColor = Color.Black
                    DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.LightYellow
                ElseIf dr("approval_department_kbn") = 0 Then
                    DataGridView_TimeCard(5, TargetDay - 1).Value = "部長申請中"
                    DataGridView_TimeCard(5, TargetDay - 1).Style.ForeColor = Color.Black
                    DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.LightYellow
                ElseIf dr("approval_bureau_kbn") = 0 Then
                    DataGridView_TimeCard(5, TargetDay - 1).Value = "本部長申請中"
                    DataGridView_TimeCard(5, TargetDay - 1).Style.ForeColor = Color.Black
                    DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.LightYellow
                ElseIf dr("approval_manager_kbn") = 0 Then
                    DataGridView_TimeCard(5, TargetDay - 1).Value = "管理本部長申請中"
                    DataGridView_TimeCard(5, TargetDay - 1).Style.ForeColor = Color.Black
                    DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.LightYellow
                Else
                    DataGridView_TimeCard(5, TargetDay - 1).Value = "承認"
                    DataGridView_TimeCard(5, TargetDay - 1).Style.ForeColor = Color.Blue
                    DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.LightCyan
                End If
                '残業時間合計を集計
                Dim EarlyWorkingTime As TimeSpan = Date.Parse(dr("user_start_time")).TimeOfDay - Date.Parse(dr("planned_start_time")).TimeOfDay
                Dim CalculatedEndTime As TimeSpan = Date.Parse(dr("user_end_time")).TimeOfDay - EarlyWorkingTime
                Dim ExtraBreakTime As TimeSpan = Date.Parse(dr("planned_break_time")).TimeOfDay - TimeSpan.FromMinutes(45)
                Dim OverTime As TimeSpan = Date.Parse(dr("planned_end_time")).TimeOfDay - CalculatedEndTime - ExtraBreakTime
                If Date.Parse(dr("planned_end_time")).ToString("yyyy/MM/dd") <> "2019/01/01" Then
                    OverTime += TimeSpan.FromDays(1)
                End If
                If OverTime < TimeSpan.Zero Then
                    OverTime = TimeSpan.Zero
                End If
                OverTimeSum += OverTime
            Next
            '残業時間合計を表示
            Label_OverTimeSum.Text = "当月の残業時間合計：" + OverTimeSum.Hours.ToString + "時間" + OverTimeSum.Minutes.ToString + "分"
        Else
            Label_OverTimeSum.Text = "当月の残業時間合計：0時間00分"
        End If
        'SQL文を作成
        Dim SQL As String = "SELECT * FROM tt_kintai_timecard"
        'DataAdapterオブジェクトを生成
        Dim da As New OracleDataAdapter(SQL, con)
        'DataTableオブジェクトを生成
        Dim dt As New DataTable()
        'DataTableとデータベースに同期させる
        da.Fill(dt)
        'フィルタリングする
        Dim drlist As DataRow() = dt.Select("user_id = '" + UserName + "' AND workingday >= '" + StartDay + "' AND workingday <= '" + EndDay + "'")
        'TimeCardテーブルから取得したデータをDataGridViewに反映
        If drlist.Length > 0 Then
            For Each dr As DataRow In drlist
                Dim TargetDay As Integer = Integer.Parse(dr("workingday").ToString.Substring(8, 2))
                DataGridView_TimeCard(1, TargetDay - 1).Value = Date.Parse(dr("start_time")).ToString("H:mm")
                '日またぎ勤務の場合、勤務終了時刻に「翌」の文字を付与
                If Date.Parse(dr("end_time")).ToString("yyyy/MM/dd") <> Date.Parse(dr("workingday")).ToString("yyyy/MM/dd") Then
                    DataGridView_TimeCard(2, TargetDay - 1).Value = "翌" + Date.Parse(dr("end_time")).ToString("H:mm")
                Else
                    DataGridView_TimeCard(2, TargetDay - 1).Value = Date.Parse(dr("end_time")).ToString("H:mm")
                End If
                If DataGridView_TimeCard(5, TargetDay - 1).Value = Nothing Then
                    DataGridView_TimeCard(5, TargetDay - 1).Value = "不要"
                    DataGridView_TimeCard(5, TargetDay - 1).Style.ForeColor = Color.Gray
                    DataGridView_TimeCard.Rows(TargetDay - 1).DefaultCellStyle.BackColor = Color.White
                End If
            Next
        End If
        'HolidayWorkingテーブルから休日出勤履歴を取得して表示
        'SQL文を作成
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        'DataAdapterオブジェクトを生成
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        'DataTableオブジェクトを生成
        Dim dtHoliday As New DataTable()
        'DataTableとデータベースに同期させる
        daHoliday.Fill(dtHoliday)
        'フィルタリング
        Dim drlistHoliday As DataRow() = dtHoliday.Select("user_id = '" + UserName + "' AND workingday >= '" + TargetDayStart + "' AND workingday <= '" + TargetDayEnd + "'")
        '振替実施計画を表示
        If drlistHoliday.Length > 0 Then
            For Each dr As DataRow In drlistHoliday
                Dim TargetRow As Integer = Integer.Parse(dr("workingday").ToString.Substring(8, 2)) - 1
                If dr("holiday") IsNot DBNull.Value Then
                    DataGridView_TimeCard(4, TargetRow).Value = "振替実施：" + Date.Parse(dr("holiday")).ToString("yyyy年MM月dd日")
                    DataGridView_TimeCard(4, TargetRow).Style.ForeColor = Color.Blue
                Else
                    DataGridView_TimeCard(4, TargetRow).Value = "振替予定：" + Date.Parse(dr("planned_holiday")).ToString("yyyy年MM月dd日")
                    DataGridView_TimeCard(4, TargetRow).Style.ForeColor = Color.Green
                End If
            Next
        End If
        '振替休日を表示
        Dim drlistHoliday2 As DataRow() = dtHoliday.Select("user_id = '" + UserName + "' AND holiDay >= '" + TargetDayStart + "' AND holiDay <= '" + TargetDayEnd + "'")
        If drlistHoliday2.Length > 0 Then
            For Each dr As DataRow In drlistHoliday2
                Dim TargetRow As Integer = Integer.Parse(dr("holiday").ToString.Substring(8, 2)) - 1
                DataGridView_TimeCard(4, TargetRow).Value = "振替休日：" + Date.Parse(dr("workingday")).ToString("yyyy年MM月dd日") + "勤務"
                DataGridView_TimeCard(4, TargetRow).Style.ForeColor = Color.PaleVioletRed
                DataGridView_TimeCard.Rows(TargetRow).DefaultCellStyle.BackColor = Color.LightGray
            Next
        End If
        DataGridView_TimeCard.CurrentCell = DataGridView_TimeCard(0, 0)
        DataGridView_TimeCard.ClearSelection()
        con = Nothing
    End Sub
End Class