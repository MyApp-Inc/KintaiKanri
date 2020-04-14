Imports Oracle.ManagedDataAccess.Client

Public Class Form_VerifiedList
    Dim Role As Integer = 0
    Dim TargetUserName As String = ""
    Dim TargetEndTime As String = ""
    Dim DBName As String = SystemInformation.UserName
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
    Private Sub Button_VerifiedListClose_Click(sender As Object, e As EventArgs) Handles Button_VerifiedListClose.Click
        Me.Close()
    End Sub

    Private Sub Form_VerifiedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_VerifiedListReload.PerformClick()
    End Sub

    Private Sub ListView_Verified_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Verified.SelectedIndexChanged
        If ListView_Verified.SelectedItems.Count > 0 Then
            Dim TargetItem As ListViewItem = ListView_Verified.SelectedItems(0)
            Dim TargetFullName As String = TargetItem.Text
            'DataGridViewの行を数えて、全行のデータを削除
            If DataGridView_TimeCardVerify.Rows.Count > 0 Then
                For i = 0 To DataGridView_TimeCardVerify.Rows.Count - 1 Step 1
                    DataGridView_TimeCardVerify.Rows.RemoveAt(0)
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
                Next
            End If
            'OverTimeテーブルを参照し、Nameから未承認勤怠データを取得
            Dim drlistOverTime As DataRow()
            Select Case Role
                Case 1
                    drlistOverTime = dtOverTime.Select("user_id = '" + TargetUserName + "' AND approval_division_kbn = '0'")
                Case 2
                    drlistOverTime = dtOverTime.Select("user_id = '" + TargetUserName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND approval_department_kbn = '0'")
                Case 3
                    drlistOverTime = dtOverTime.Select("user_id = '" + TargetUserName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                               (approval_department_kbn = '1' OR approval_department_kbn = '9') AND
                                                                                                approval_bureau_kbn = '0'")
                Case Else
                    drlistOverTime = dtOverTime.Select("user_id = '" + TargetUserName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                               (approval_department_kbn = '1' OR approval_department_kbn = '9') AND
                                                                                               (approval_bureau_kbn = '1' OR approval_bureau_kbn = '9') AND
                                                                                                approval_manager_kbn = '0'")
            End Select
            If drlistOverTime.Length > 0 Then
                Dim Idx As Integer = 0
                For Each dr As DataRow In drlistOverTime
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
                    DataGridView_TimeCardVerify.Rows.Add()
                    DataGridView_TimeCardVerify(0, Idx).Value = Date.Parse(TargetDay).ToString("yyyy年MM月dd日（ddd）")
                    DataGridView_TimeCardVerify(1, Idx).Value = Date.Parse(dr("planned_start_time")).ToString("H:mm") + " ～ " + EndTime
                    If OverTime.Ticks < 0 Then
                        DataGridView_TimeCardVerify(2, Idx).Value = Date.Parse(dr("planned_start_time")).ToString("H:mm") + " ～ " + EndTime +
                                                                Environment.NewLine + "（入力不正データ）"
                    Else
                        DataGridView_TimeCardVerify(2, Idx).Value = StartTime + " ～ " + EndTime + Environment.NewLine +
                                                                    "（" + Date.Parse("2019/01/01 " + OverTime.ToString).ToString("H時間mm分") + "）"
                    End If
                    DataGridView_TimeCardVerify(3, Idx).Value = Date.Parse(dr("planned_break_time")).ToString("H時間mm分")
                    '休日勤務の場合、業務内容及び理由欄に振替休日指示日を追加
                    Dim drlistHoliday As DataRow() = dtHoliday.Select("user_id = '" + TargetUserName + "' AND workingday = '" + TargetDay + "'")
                    If drlistHoliday.Length > 0 Then
                        For Each drH As DataRow In drlistHoliday
                            Dim Holiday As String = Date.Parse(drH("planned_holiday")).ToString("yyyy年MM月dd日（ddd）")
                            DataGridView_TimeCardVerify(4, Idx).Value = dr("reason") + Environment.NewLine + "振替休日指示日：" + Holiday
                        Next
                    Else
                        DataGridView_TimeCardVerify(4, Idx).Value = dr("reason")
                    End If
                    Idx = Idx + 1
                Next
                DataGridView_TimeCardVerify.Sort(DataGridView_TimeCardVerify.Columns(0), ComponentModel.ListSortDirection.Ascending)
                DataGridView_TimeCardVerify.ClearSelection()
            End If
            con = Nothing
        End If
    End Sub

    Private Sub DataGridView_TimeCardVerify_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_TimeCardVerify.CellContentClick
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        'SqlCommandBuilderオブジェクトを生成
        Dim cmdbuilder1 As New OracleCommandBuilder(daUser)
        Dim cmdbuilder2 As New OracleCommandBuilder(daOverTime)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtOverTime As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daOverTime.Fill(dtOverTime)

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim TargetRow As Integer
        Dim Targetyy As String
        Dim TargetMM As String
        Dim Targetdd As String
        Dim TargetDate As Date
        If dgv.Columns(e.ColumnIndex).Name = "Column_Verify" Then
            '承認ボタンがクリックされた時の処理
            TargetRow = e.RowIndex
            Targetyy = DataGridView_TimeCardVerify(0, TargetRow).Value.ToString.Substring(0, 4)
            TargetMM = DataGridView_TimeCardVerify(0, TargetRow).Value.ToString.Substring(5, 2)
            Targetdd = DataGridView_TimeCardVerify(0, TargetRow).Value.ToString.Substring(8, 2)
            TargetDate = Date.Parse(Targetyy + "/" + TargetMM + "/" + Targetdd)
            'フィルタリングする
            Dim drlist As DataRow() = dtOverTime.Select("user_id = '" + TargetUserName + "' AND workingday = '" + TargetDate + "'")
            'TimeCardデータ更新処理（承認）
            For Each dr As DataRow In drlist
                Select Case Role
                    Case 1
                        dr("approval_division_kbn") = 1
                        dr("approval_division_date") = Date.Now
                        dr("approval_division_user") = DBName
                    Case 2
                        dr("approval_department_kbn") = 1
                        dr("approval_department_date") = Date.Now
                        dr("approval_department_user") = DBName
                    Case 3
                        dr("approval_bureau_kbn") = 1
                        dr("approval_bureau_date") = Date.Now
                        dr("approval_bureau_user") = DBName
                    Case Else
                        dr("approval_manager_kbn") = 1
                        dr("approval_manager_date") = Date.Now
                        dr("approval_manager_user") = DBName
                End Select
                dr("update_date") = Date.Now
                dr("update_program") = "KINTAI_KANRI_SYSTEM"
                dr("update_user") = DBName
                daOverTime.Update(dtOverTime)
            Next
            DataGridView_TimeCardVerify.Rows.RemoveAt(TargetRow)
        ElseIf dgv.Columns(e.ColumnIndex).Name = "Column_Reject" Then
            '却下ボタンがクリックされた時の処理
            TargetRow = e.RowIndex
            Targetyy = DataGridView_TimeCardVerify(0, TargetRow).Value.ToString.Substring(0, 4)
            TargetMM = DataGridView_TimeCardVerify(0, TargetRow).Value.ToString.Substring(5, 2)
            Targetdd = DataGridView_TimeCardVerify(0, TargetRow).Value.ToString.Substring(8, 2)
            TargetDate = Date.Parse(Targetyy + "/" + TargetMM + "/" + Targetdd)
            'フィルタリングする
            Dim drlist As DataRow() = dtOverTime.Select("user_id = '" + TargetUserName + "' AND workingday = '" + TargetDate + "'")
            'TimeCardデータ更新処理（却下）
            For Each dr As DataRow In drlist
                Select Case Role
                    Case 1
                        dr("approval_division_kbn") = 2
                    Case 2
                        dr("approval_department_kbn") = 2
                    Case 3
                        dr("approval_bureau_kbn") = 2
                    Case Else
                        dr("approval_manager_kbn") = 2
                End Select
                dr("update_date") = Date.Now
                dr("update_program") = "KINTAI_KANRI_SYSTEM"
                dr("update_user") = DBName
                daOverTime.Update(dtOverTime)
            Next
            DataGridView_TimeCardVerify.Rows.RemoveAt(TargetRow)
        End If
        con = Nothing
    End Sub

    Private Sub Button_VerifiedListPast_Click(sender As Object, e As EventArgs) Handles Button_VerifiedListPast.Click
        'フォームのインスタンスを生成する
        Dim cForm_VerifiedHistory As New Form_VerifiedHistory
        'モーダルでフォームを表示する
        cForm_VerifiedHistory.ShowInTaskbar = False
        cForm_VerifiedHistory.ShowDialog(Me)
    End Sub

    Private Sub Button_VerifiedListReload_Click(sender As Object, e As EventArgs) Handles Button_VerifiedListReload.Click
        'ListView初期化
        ListView_Verified.Items.Clear()
        'DataGridViewの行を数えて、全行のデータを削除
        If DataGridView_TimeCardVerify.Rows.Count > 0 Then
            For i = 0 To DataGridView_TimeCardVerify.Rows.Count - 1 Step 1
                DataGridView_TimeCardVerify.Rows.RemoveAt(0)
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
                '対象ユーザーが存在すれば、承認待ち件数を取得
                If drlistUser.Length > 0 Then
                    Dim drlistOverTime As DataRow()
                    Dim TargetName As String
                    '対象ユーザー1人1人について、承認待ちデータがあるかどうかチェック
                    For Each drUser As DataRow In drlistUser
                        Dim Item1 As New ListViewItem
                        TargetName = drUser("user_name")
                        Select Case Role
                            Case 1
                                drlistOverTime = dtOverTime.Select("user_id = '" + TargetName + "' AND approval_division_kbn = '0'")
                            Case 2
                                drlistOverTime = dtOverTime.Select("user_id = '" + TargetName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                                        approval_department_kbn = '0'")
                            Case 3
                                drlistOverTime = dtOverTime.Select("user_id = '" + TargetName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                                           (approval_department_kbn = '1' OR approval_department_kbn = '9') AND
                                                                                                            approval_bureau_kbn = '0'")
                            Case Else
                                drlistOverTime = dtOverTime.Select("user_id = '" + TargetName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                                           (approval_department_kbn = '1' OR approval_department_kbn = '9') AND
                                                                                                           (approval_bureau_kbn = '1' OR approval_bureau_kbn = '9') AND
                                                                                                            approval_manager_kbn = '0'")
                        End Select
                        If drlistOverTime.Length > 0 Then
                            Item1.Text = drUser("full_name")
                            Item1.SubItems.Add(drlistOverTime.Length)
                            ListView_Verified.Items.Add(Item1)
                        End If
                    Next
                End If
            Next
        End If
        con = Nothing
        'ListViewのすべての列を自動調節
        ListView_Verified.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
End Class