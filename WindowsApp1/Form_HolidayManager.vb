Imports Oracle.ManagedDataAccess.Client

Public Class Form_HolidayManager
    Dim DBName As String = SystemInformation.UserName
    Dim TargetUser As String = ""
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
    Private Sub Button_HolidayManagerClose_Click(sender As Object, e As EventArgs) Handles Button_HolidayManagerClose.Click
        Me.Close()
    End Sub

    Private Sub Button_HolidayManagerDisplay_Click(sender As Object, e As EventArgs) Handles Button_HolidayManagerDisplay.Click
        'ListView初期化
        ListView_HolidayManager.Items.Clear()
        'DataGridViewの行を数えて、全行のデータを削除
        If DataGridView_HolidayManager.Rows.Count > 0 Then
            For i = 0 To DataGridView_HolidayManager.Rows.Count - 1 Step 1
                DataGridView_HolidayManager.Rows.RemoveAt(0)
            Next
        End If
        Dim TargetYear As Integer = Integer.Parse(DateTimePicker_HolidayManagerTargetYear.Value.ToString("yyyy"))
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        Dim SQLPublic As String = "SELECT * FROM tm_kintai_publicholiday"
        'DataAdapterオブジェクトを生成
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        Dim daPublic As New OracleDataAdapter(SQLPublic, con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daHoliday)
        'DataTableオブジェクトを生成
        Dim dtHoliday As New DataTable()
        Dim dtPublic As New DataTable()
        'DataTableとデータベースに同期させる
        daHoliday.Fill(dtHoliday)
        daPublic.Fill(dtPublic)
        '選択された年の休日を取得してリストに表示
        For IdxMonth As Integer = 1 To 12
            '[Idxmonth]月の日数を変数Daysに格納
            Dim Days As Integer = Date.DaysInMonth(DateTimePicker_HolidayManagerTargetYear.Value.Year, IdxMonth)
            For IdxDay As Integer = 1 To Days
                Dim TargetDay As Date = New Date(TargetYear, IdxMonth, IdxDay)
                Dim TargetWeek As String = TargetDay.ToString("ddd")
                '祝日検索
                Dim drlistPublic As DataRow() = dtPublic.Select("holiday = '" + TargetDay.ToString + "'")
                Dim IsPublicHoliday As Boolean = drlistPublic.Length > 0
                Dim Item1 As New ListViewItem
                If TargetWeek = "土" Or TargetWeek = "日" Or IsPublicHoliday Then
                    If IsPublicHoliday Then
                        Item1.Text = TargetDay.ToString("MM月dd日") + "（休）"
                    Else
                        Item1.Text = TargetDay.ToString("MM月dd日") + "（" + TargetWeek + "）"
                    End If
                    'フィルタリングする
                    Dim TargetDay_S As String = TargetDay.Date.ToString
                    Dim drlist1 As DataRow() = dtHoliday.Select("workingday = '" + TargetDay_S + "' AND pre_confirm_flg = 0")
                    Dim drlist2 As DataRow() = dtHoliday.Select("workingday = '" + TargetDay_S + "' AND pre_confirm_flg = 1 AND confirm_flg = 0")
                    Dim drlist3 As DataRow() = dtHoliday.Select("workingday = '" + TargetDay_S + "' AND pre_confirm_flg = 1 AND confirm_flg = 1")
                    Dim drlist4 As DataRow() = dtHoliday.Select("workingday = '" + TargetDay_S + "' AND pre_confirm_flg = 1 AND confirm_flg IS NULL")
                    '要確認件数
                    Item1.SubItems.Add(drlist1.Length + drlist2.Length)
                    '確認済件数
                    Item1.SubItems.Add(drlist3.Length + drlist4.Length)
                    If TargetWeek = "日" Or IsPublicHoliday Then
                        Item1.BackColor = Color.MistyRose
                    Else
                        Item1.BackColor = Color.LightCyan
                    End If
                    If drlist1.Length + drlist2.Length + drlist3.Length + drlist4.Length > 0 Then
                        ListView_HolidayManager.Items.Add(Item1)
                    End If
                End If
            Next
        Next
        con = Nothing
        'ListViewのすべての列を自動調節
        ListView_HolidayManager.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Form_HolidayManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_HolidayManagerDisplay.PerformClick()
    End Sub

    Private Sub ListView_HolidayManager_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_HolidayManager.SelectedIndexChanged
        If ListView_HolidayManager.SelectedItems.Count > 0 Then
            Dim TargetItem As ListViewItem = ListView_HolidayManager.SelectedItems(0)
            Dim TargetDay As String = DateTimePicker_HolidayManagerTargetYear.Value.ToString("yyyy") + "/" + TargetItem.Text.Substring(0, 2) + "/" + TargetItem.Text.Substring(3, 2)
            'DataGridViewの行を数えて、全行のデータを削除
            If DataGridView_HolidayManager.Rows.Count > 0 Then
                For i = 0 To DataGridView_HolidayManager.Rows.Count - 1 Step 1
                    DataGridView_HolidayManager.Rows.RemoveAt(0)
                Next
            End If
            'OracleConnectionオブジェクトを生成
            Dim con As New OracleConnection(Constr)
            'SQL文を作成
            Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
            Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
            Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
            Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
            Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
            'DataAdapterオブジェクトを生成
            Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
            Dim daUser As New OracleDataAdapter(SQLUser, con)
            Dim daBureau As New OracleDataAdapter(SQLBureau, con)
            Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
            Dim daDivision As New OracleDataAdapter(SQLDivision, con)
            'OracleCommandBuilderオブジェクトを生成
            Dim cmdbuilder As New OracleCommandBuilder(daHoliday)
            'DataTableオブジェクトを生成
            Dim dtHoliday As New DataTable()
            Dim dtUser As New DataTable()
            Dim dtBureau As New DataTable()
            Dim dtDepartment As New DataTable()
            Dim dtDivision As New DataTable()
            'DataTableとデータベースに同期させる
            daHoliday.Fill(dtHoliday)
            daUser.Fill(dtUser)
            daBureau.Fill(dtBureau)
            daDepartment.Fill(dtDepartment)
            daDivision.Fill(dtDivision)
            'フィルタリングする
            Dim drlist As DataRow() = dtHoliday.Select("workingday = '" + TargetDay + "'")
            '休日出勤データをDataGridViewに表示
            If drlist.Length > 0 Then
                Dim Idx As Integer = 0
                For Each dr As DataRow In drlist
                    DataGridView_HolidayManager.Rows.Add()
                    '社員データ取得
                    TargetUser = dr("user_id")
                    Dim drlistUser As DataRow() = dtUser.Select("user_name = '" + TargetUser + "'")
                    For Each drUser As DataRow In drlistUser
                        '所属データ取得
                        Dim TargetBureauId As String = drUser("bureau_no").ToString
                        Dim TargetDepartmentId As String = drUser("department_no").ToString
                        Dim TargetDivisionId As String = drUser("division_no").ToString
                        Dim TargetBureau As String = Nothing
                        Dim TargetDepartment As String = Nothing
                        Dim TargetDivision As String = Nothing
                        If TargetBureauId <> "0" Then
                            Dim drlistBureau As DataRow() = dtBureau.Select("id_no = '" + TargetBureauId + "'")
                            For Each drBureau As DataRow In drlistBureau
                                TargetBureau = drBureau("bureau_name")
                            Next
                        End If
                        If TargetDepartmentId <> "0" Then
                            Dim drlistDepartment As DataRow() = dtDepartment.Select("id_no = '" + TargetDepartmentId + "'")
                            For Each drDepartment As DataRow In drlistDepartment
                                TargetDepartment = drDepartment("department_name")
                            Next
                        End If
                        If TargetDivisionId <> "0" Then
                            Dim drlistDivision As DataRow() = dtDivision.Select("id_no = '" + TargetDivisionId + "'")
                            For Each drDivision As DataRow In drlistDivision
                                TargetDivision = drDivision("division_name")
                            Next
                        End If
                        DataGridView_HolidayManager(0, Idx).Value = TargetBureau + Environment.NewLine + TargetDepartment + Environment.NewLine + TargetDivision
                        DataGridView_HolidayManager(1, Idx).Value = drUser("full_name")
                    Next
                    DataGridView_HolidayManager(2, Idx).Value = Date.Parse(dr("planned_holiday")).ToString("yyyy年MM月dd日（ddd）")
                    If dr("pre_confirm_flg") = 1 Then
                        DataGridView_HolidayManager(3, Idx).Value = "確認済"
                        DataGridView_HolidayManager(3, Idx).Style.BackColor = Color.LightGray
                    Else
                        DataGridView_HolidayManager(3, Idx).Value = "確認"
                    End If
                    If dr("holiday") Is DBNull.Value Then
                        DataGridView_HolidayManager(4, Idx).Value = "（未取得）"
                    Else
                        DataGridView_HolidayManager(4, Idx).Value = Date.Parse(dr("holiday")).ToString("yyyy年MM月dd日（ddd）")
                    End If
                    If dr("confirm_flg") IsNot DBNull.Value Then
                        If dr("confirm_flg") = 1 Then
                            DataGridView_HolidayManager(5, Idx).Value = "確認済"
                            DataGridView_HolidayManager(5, Idx).Style.BackColor = Color.LightGray
                        Else
                            DataGridView_HolidayManager(5, Idx).Value = "確認"
                        End If
                    Else
                        DataGridView_HolidayManager(5, Idx).Style.BackColor = Color.White
                    End If
                    Idx = Idx + 1
                Next
                DataGridView_HolidayManager.ClearSelection()
            End If
            con = Nothing
        End If
    End Sub

    Private Sub DataGridView_HolidayManager_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_HolidayManager.CellContentClick
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daHoliday)
        'DataTableオブジェクトを生成
        Dim dtHoliday As New DataTable()
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daHoliday.Fill(dtHoliday)
        daUser.Fill(dtUser)
        '確認ボタンが押下された時の処理
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim TargetFullName As String = ""
        If dgv.Columns(e.ColumnIndex).Name = "Column_PreVerify" Then
            If DataGridView_HolidayManager(e.ColumnIndex, e.RowIndex).Value = "確認" Then
                'Userテーブルを参照し、FullNameからUserNameを取得
                TargetFullName = DataGridView_HolidayManager(1, e.RowIndex).Value
                Dim drlistUser As DataRow() = dtUser.Select("full_name = '" + TargetFullName + "'")
                If drlistUser.Length > 0 Then
                    For Each drUser As DataRow In drlistUser
                        TargetUser = drUser("user_name")
                    Next
                End If
                Dim TargetItem As ListViewItem = ListView_HolidayManager.SelectedItems(0)
                Dim TargetDay As String = DateTimePicker_HolidayManagerTargetYear.Value.ToString("yyyy") + "/" + TargetItem.Text.Substring(0, 2) + "/" + TargetItem.Text.Substring(3, 2)
                'フィルタリングする
                Dim drlist As DataRow() = dtHoliday.Select("user_id = '" + TargetUser + "' AND workingday = '" + TargetDay + "'")
                'HolidayWorkingデータ更新処理
                For Each dr As DataRow In drlist
                    dr("pre_confirm_flg") = 1
                    dr("pre_confirm_date") = Date.Now
                    dr("pre_confirm_user") = DBName
                    dr("update_date") = Date.Now
                    dr("update_program") = "KINTAI_KANRI_SYSTEM"
                    dr("update_user") = DBName
                    daHoliday.Update(dtHoliday)
                Next
                DataGridView_HolidayManager(3, e.RowIndex).Value = "確認済"
                DataGridView_HolidayManager(3, e.RowIndex).Style.BackColor = Color.LightGray
            End If
        ElseIf dgv.Columns(e.ColumnIndex).Name = "Column_AfterVerify" Then
            If DataGridView_HolidayManager(e.ColumnIndex, e.RowIndex).Value = "確認" Then
                'Userテーブルを参照し、FullNameからUserNameを取得
                TargetFullName = DataGridView_HolidayManager(1, e.RowIndex).Value
                Dim drlistUser As DataRow() = dtUser.Select("full_name = '" + TargetFullName + "'")
                If drlistUser.Length > 0 Then
                    For Each drUser As DataRow In drlistUser
                        TargetUser = drUser("user_name")
                    Next
                End If
                Dim TargetItem As ListViewItem = ListView_HolidayManager.SelectedItems(0)
                Dim TargetDay As String = DateTimePicker_HolidayManagerTargetYear.Value.ToString("yyyy") + "/" + TargetItem.Text.Substring(0, 2) + "/" + TargetItem.Text.Substring(3, 2)
                'フィルタリングする
                Dim drlist As DataRow() = dtHoliday.Select("user_id = '" + TargetUser + "' AND workingday = '" + TargetDay + "'")
                'HolidayWorkingデータ更新処理
                For Each dr As DataRow In drlist
                    dr("confirm_flg") = 1
                    dr("confirm_date") = Date.Now
                    dr("confirm_user") = DBName
                    dr("update_date") = Date.Now
                    dr("update_program") = "KINTAI_KANRI_SYSTEM"
                    dr("update_user") = DBName
                    daHoliday.Update(dtHoliday)
                Next
                DataGridView_HolidayManager(5, e.RowIndex).Value = "確認済"
                DataGridView_HolidayManager(5, e.RowIndex).Style.BackColor = Color.LightGray
            End If
        End If
        DataGridView_HolidayManager.ClearSelection()
        con = Nothing
    End Sub
End Class