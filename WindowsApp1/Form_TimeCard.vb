Imports Oracle.ManagedDataAccess.Client

Public Class Form_TimeCard
    Dim NowYear As String = Date.Now.ToString("yyyy")
    Dim NowMonth As String = Date.Now.ToString("MM")
    Dim Today As String = Date.Now.ToString("yyyy/MM/dd")
    Dim IsHolidayWorking As Boolean = False
    Dim UserName As String = Form_Main.Label_UserName.Text
    Dim UserRole As Integer = 0
    Dim DBName As String = SystemInformation.UserName
    Dim UserStartTime As TimeSpan
    Dim UserEndTime As TimeSpan
    Dim IsEnableEdit As Boolean = False
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
    Private Sub Button_TimeCardEnd_Click(sender As Object, e As EventArgs) Handles Button_TimeCardEnd.Click
        Me.Close()
    End Sub

    Private Sub Button_TimeCardDisplay_Click(sender As Object, e As EventArgs) Handles Button_TimeCardDisplay.Click
        '画面右側の表示項目変更
        Label_TimeCardEditDate.Text = "申請する日付を左表から選択"
        Label_TimeCardEditStartTime.Visible = False
        DateTimePicker_StartTime.Visible = False
        Label_TimeCardEditEndTime.Visible = False
        DateTimePicker_EndTime.Visible = False
        Label_Tomorrow.Visible = False
        Label_TimeCardEditBreakTime.Visible = False
        DateTimePicker_BreakTime.Visible = False
        Label_TimeCardEditReason.Visible = False
        TextBox_ReasonOfWorking.Visible = False
        Label_TimeCardEditHoliday.Visible = False
        DateTimePicker_Holiday.Visible = False
        Label_TimeCardEditOverTime.Visible = False
        Label_TimeCardReasonAlart.Visible = False
        Button_TimeCardEdit.Visible = False
        Label_ReportHoliday.Visible = False
        Label_ExecutedHoliday.Visible = False
        DateTimePicker_ExecutedHoliday.Visible = False
        Button_ReportHoliday.Visible = False
        Button_TimeCardCancel.Visible = False
        '選択された年月を取得
        Dim SelectedYear As String = DateTimePicker_TimeCard.Value.ToString("yyyy")
        Dim SelectedMonth As String = DateTimePicker_TimeCard.Value.ToString("MM")
        '選択月の日数を変数Daysに格納
        Dim Days As Integer = Date.DaysInMonth(DateTimePicker_TimeCard.Value.Year, DateTimePicker_TimeCard.Value.Month)
        'DB検索用文字列を作成（選択年月月初から月末までの範囲）
        Dim StartDay As String = SelectedYear + "/" + SelectedMonth + "/" + "01"
        Dim EndDay As String = SelectedYear + "/" + SelectedMonth + "/" + Days.ToString
        '行を数えて、全行のデータを削除
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
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        Dim SQLPublic As String = "SELECT * FROM tm_kintai_publicholiday"
        'DataAdapterオブジェクトを生成
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        Dim daPublic As New OracleDataAdapter(SQLPublic, con)
        'DataTableオブジェクトを生成
        Dim dtOverTime As New DataTable()
        Dim dtPublic As New DataTable()
        'DataTableとデータベースに同期させる
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

    Private Sub Form_TimeCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        'フィルタリング
        Dim drlistUser As DataRow() = dtUser.Select("user_name = '" + UserName + "'")
        For Each drUser As DataRow In drlistUser
            UserStartTime = Date.Parse(drUser("start_time")).TimeOfDay
            UserEndTime = Date.Parse(drUser("end_time")).TimeOfDay
        Next
        Label_TimeCardName.Text = Form_Main.Label_Name.Text + "さんの勤務開始・終了時刻一覧"
        Button_TimeCardDisplay.PerformClick()
        con = Nothing
    End Sub

    Private Sub DataGridView_TimeCard_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_TimeCard.CellContentClick
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        'DataAdapterオブジェクトを生成
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        'DataTableオブジェクトを生成
        Dim dtOverTime As New DataTable()
        Dim dtHoliday As New DataTable()
        'DataTableとデータベースに同期させる
        daOverTime.Fill(dtOverTime)
        daHoliday.Fill(dtHoliday)
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim TargetDay As String = dgv(0, dgv.CurrentCell.RowIndex).Value
        Dim TargetDate As String = DateTimePicker_TimeCard.Value.ToString("yyyy/MM/") + TargetDay.Substring(0, 2)
        Label_TimeCardEditDate.Text = DateTimePicker_TimeCard.Value.ToString("yyyy年MM月") + TargetDay
        'フィルタリング
        Dim drlistOverTime As DataRow() = dtOverTime.Select("user_id = '" + UserName + "' AND workingday = '" + TargetDate + "'")
        Dim drlistHoliday As DataRow() = dtHoliday.Select("user_id = '" + UserName + "' AND workingday = '" + TargetDate + "'")
        If drlistOverTime.Length > 0 Then
            For Each drOverTime As DataRow In drlistOverTime
                DateTimePicker_StartTime.Value = Date.Parse(drOverTime("planned_start_time"))
                DateTimePicker_EndTime.Value = Date.Parse(drOverTime("planned_end_time"))
                If Date.Parse(drOverTime("planned_end_time")).ToString("yyyy/MM/dd") <> Date.Parse(drOverTime("planned_start_time")).ToString("yyyy/MM/dd") Then
                    Label_Tomorrow.Visible = True
                Else
                    Label_Tomorrow.Visible = False
                End If
                DateTimePicker_BreakTime.Value = Date.Parse(drOverTime("planned_break_time"))
                If drOverTime("reason") Is DBNull.Value Then
                    TextBox_ReasonOfWorking.Text = Nothing
                Else
                    TextBox_ReasonOfWorking.Text = drOverTime("reason")
                End If
            Next
        Else
            DateTimePicker_StartTime.Value = "2019/01/01 " + UserStartTime.ToString
            DateTimePicker_EndTime.Value = "2019/01/01 " + (UserEndTime + TimeSpan.FromMinutes(15)).ToString
            Label_Tomorrow.Visible = False
            DateTimePicker_BreakTime.Value = "2019/01/01 01:00:00"
            TextBox_ReasonOfWorking.Text = Nothing
            Label_TimeCardEditOverTime.Text = "残業時間 ： 0時間00分"
        End If
        If drlistHoliday.Length > 0 Then
            For Each drHoliday As DataRow In drlistHoliday
                DateTimePicker_Holiday.Value = Date.Parse(drHoliday("planned_holiday"))
            Next
        Else
            DateTimePicker_Holiday.Value = Date.Now.Date
        End If
        '画面右側の表示項目変更
        Label_TimeCardEditStartTime.Visible = True
        DateTimePicker_StartTime.Visible = True
        Label_TimeCardEditEndTime.Visible = True
        DateTimePicker_EndTime.Visible = True
        Label_TimeCardEditBreakTime.Visible = True
        DateTimePicker_BreakTime.Visible = True
        Label_TimeCardEditReason.Visible = True
        TextBox_ReasonOfWorking.Visible = True
        Button_TimeCardEdit.Visible = True
        Label_TimeCardEditOverTime.Visible = True
        Label_TimeCardReasonAlart.Visible = True
        If dgv(4, dgv.CurrentCell.RowIndex).Value Is Nothing Then
            Label_TimeCardEditHoliday.Visible = False
            DateTimePicker_Holiday.Visible = False
            IsHolidayWorking = False
            Label_ReportHoliday.Visible = False
            Label_ExecutedHoliday.Visible = False
            DateTimePicker_ExecutedHoliday.Visible = False
            Button_ReportHoliday.Visible = False
        ElseIf dgv(4, dgv.CurrentCell.RowIndex).Value.ToString = "休日" Then
            Label_TimeCardEditHoliday.Visible = True
            DateTimePicker_Holiday.Visible = True
            IsHolidayWorking = True
            Label_ReportHoliday.Visible = False
            Label_ExecutedHoliday.Visible = False
            DateTimePicker_ExecutedHoliday.Visible = False
            Button_ReportHoliday.Visible = False
        ElseIf dgv(4, dgv.CurrentCell.RowIndex).Value.ToString.Substring(0, 4) = "振替予定" Then
            If dgv(5, dgv.CurrentCell.RowIndex).Value.ToString = "却下（要修正）" Then
                Label_TimeCardEditHoliday.Visible = True
                DateTimePicker_Holiday.Visible = True
                IsHolidayWorking = True
                Label_ReportHoliday.Visible = False
                Label_ExecutedHoliday.Visible = False
                DateTimePicker_ExecutedHoliday.Visible = False
                Button_ReportHoliday.Visible = False
            Else
                Label_TimeCardEditHoliday.Visible = False
                DateTimePicker_Holiday.Visible = False
                IsHolidayWorking = False
                Label_ReportHoliday.Visible = True
                Label_ExecutedHoliday.Visible = True
                DateTimePicker_ExecutedHoliday.Visible = True
                Button_ReportHoliday.Visible = True
            End If
        End If
        Select Case dgv(5, dgv.CurrentCell.RowIndex).Value
            Case Nothing, "不要"
                IsEnableEdit = True
                Button_TimeCardCancel.Visible = False
            Case "却下（要修正）"
                IsEnableEdit = True
                Button_TimeCardCancel.Visible = True
            Case "承認"
                IsEnableEdit = False
                Button_TimeCardCancel.Visible = False
            Case Else
                IsEnableEdit = False
                Button_TimeCardCancel.Visible = True
        End Select
        OverTimeValidation()
        con = Nothing
    End Sub

    Private Sub Button_TimeCardEdit_Click(sender As Object, e As EventArgs) Handles Button_TimeCardEdit.Click
        If Label_TimeCardEditDate.Text.Substring(0, 1) <> "2" Then
            MsgBox("修正する日付を左表から選択してください。", vbOKOnly, "日付選択エラー")
        ElseIf DateTimePicker_StartTime.Value > DateTimePicker_EndTime.Value And Label_Tomorrow.Visible = False Then
            MsgBox("勤務終了時刻は勤務開始時刻よりも後の時刻で入力してください。", vbOKOnly, "時刻入力エラー")
        ElseIf TextBox_ReasonOfWorking.Text = Nothing Then
            MsgBox("業務内容及び理由を入力してください。", vbOKOnly, "入力エラー")
        Else
            'OracleConnectionオブジェクトを生成
            Dim con As New OracleConnection(Constr)
            'SQL文を作成
            Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
            Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
            Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
            Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
            Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
            'DataAdapterオブジェクトを生成
            Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
            Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
            Dim daUser As New OracleDataAdapter(SQLUser, con)
            Dim daBureau As New OracleDataAdapter(SQLBureau, con)
            Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
            'OracleCommandBuilderオブジェクトを生成
            Dim cmdbuilder1 As New OracleCommandBuilder(daOverTime)
            Dim cmdbuilder2 As New OracleCommandBuilder(daHoliday)
            'DataTableオブジェクトを生成
            Dim dtOverTime As New DataTable()
            Dim dtHoliday As New DataTable()
            Dim dtUser As New DataTable()
            Dim dtBureau As New DataTable()
            Dim dtDepartment As New DataTable()
            'DataTableとデータベースに同期させる
            daOverTime.Fill(dtOverTime)
            daHoliday.Fill(dtHoliday)
            daUser.Fill(dtUser)
            daBureau.Fill(dtBureau)
            daDepartment.Fill(dtDepartment)
            'フィルタリングする
            Dim drlistUser As DataRow() = dtUser.Select("user_name = '" + UserName + "'")
            Dim UserStartTime As String = ""
            Dim UserEndTime As String = ""
            Dim IdBureau As Integer = 0
            Dim IdDepartment As Integer = 0
            Dim IdDivision As Integer = 0
            Dim IsDummyBureau As Integer = 0
            Dim IsDummyDepartment As Integer = 0
            'Userテーブルからデータをを取得
            If drlistUser.Length > 0 Then
                For Each drUser As DataRow In drlistUser
                    UserRole = drUser("role_kbn")
                    UserStartTime = drUser("start_time").ToString
                    UserEndTime = drUser("end_time").ToString
                    IdBureau = drUser("bureau_no")
                    IdDepartment = drUser("department_no")
                    IdDivision = drUser("division_no")
                    '所属本部ダミーフラグを取得
                    Dim drlistBureau As DataRow() = dtBureau.Select("id_no = '" + IdBureau.ToString + "'")
                    For Each drBureau As DataRow In drlistBureau
                        IsDummyBureau = drBureau("is_dummy_flg")
                    Next
                    '所属部ダミーフラグを取得
                    Dim drlistDepartment As DataRow() = dtDepartment.Select("id_no = '" + IdDepartment.ToString + "'")
                    For Each drDepartment As DataRow In drlistDepartment
                        IsDummyDepartment = drDepartment("is_dummy_flg")
                    Next
                Next
            End If
            'フィルタリングする
            Dim Targetyy As String = Label_TimeCardEditDate.Text.Substring(0, 4)
            Dim TargetMM As String = Label_TimeCardEditDate.Text.Substring(5, 2)
            Dim Targetdd As String = Label_TimeCardEditDate.Text.Substring(8, 2)
            Dim TargetDate As Date = Date.Parse(Targetyy + "/" + TargetMM + "/" + Targetdd)
            Dim drlist As DataRow() = dtOverTime.Select("user_id = '" + UserName + "' AND workingday = '" + TargetDate + "'")
            '検索結果により分岐（追加申請or修正申請）
            If drlist.Length = 0 Then
                '新規申請（OverTimeテーブルにデータ追加）
                Dim row As DataRow = dtOverTime.NewRow '追加行を宣言
                'IDを採番
                Dim Id As Integer = dtOverTime.Rows.Count
                Do
                    Id += 1
                    Dim drlistId As DataRow() = dtOverTime.Select("id_no = '" + Id.ToString + "'")
                    If drlistId.Count = 0 Then
                        Exit Do
                    End If
                Loop
                row("id_no") = Id
                row("user_id") = UserName
                row("workingday") = TargetDate
                row("user_start_time") = UserStartTime
                row("user_end_time") = UserEndTime
                row("planned_start_time") = DateTimePicker_StartTime.Value
                If Label_Tomorrow.Visible Then
                    row("planned_end_time") = DateTimePicker_EndTime.Value.AddDays(1)
                Else
                    row("planned_end_time") = DateTimePicker_EndTime.Value
                End If
                row("planned_break_time") = DateTimePicker_BreakTime.Value
                row("reason") = TextBox_ReasonOfWorking.Text
                If IdDivision = 0 Or UserRole >= 1 Then
                    row("approval_division_kbn") = 9
                Else
                    row("approval_division_kbn") = 0
                End If
                '20時を超えるか、休日申請の場合、部長・本部長・管理本部長へ申請
                If Label_Tomorrow.Visible Or DateTimePicker_EndTime.Value > Date.Parse("2019/01/01 20:00:00") Or IsHolidayWorking Then
                    If IdDepartment = 0 Or UserRole >= 2 Or IsDummyDepartment = 1 Then
                        row("approval_department_kbn") = 9
                    Else
                        row("approval_department_kbn") = 0
                    End If
                    If IdBureau = 0 Or UserRole >= 3 Or IsDummyBureau = 1 Then
                        row("approval_bureau_kbn") = 9
                    Else
                        row("approval_bureau_kbn") = 0
                    End If
                    row("approval_manager_kbn") = 0
                Else
                    row("approval_department_kbn") = 9
                    row("approval_bureau_kbn") = 9
                    row("approval_manager_kbn") = 9
                End If
                row("create_date") = Date.Now
                row("update_date") = Date.Now
                row("create_program") = "KINTAI_KANRI_SYSTEM"
                row("update_program") = "KINTAI_KANRI_SYSTEM"
                row("create_user") = DBName
                row("update_user") = DBName
                'テーブルの末尾に追加
                dtOverTime.Rows.Add(row)
                daOverTime.Update(dtOverTime)
            Else
                '修正申請（OverTimeテーブルのデータを更新）
                For Each dr As DataRow In drlist
                    dr("planned_start_time") = DateTimePicker_StartTime.Value
                    If Label_Tomorrow.Visible Then
                        dr("planned_end_time") = DateTimePicker_EndTime.Value.AddDays(1)
                    Else
                        dr("planned_end_time") = DateTimePicker_EndTime.Value
                    End If
                    dr("planned_break_time") = DateTimePicker_BreakTime.Value
                    dr("reason") = TextBox_ReasonOfWorking.Text
                    If IdDivision = 0 Or UserRole >= 1 Then
                        dr("approval_division_kbn") = 9
                    Else
                        dr("approval_division_kbn") = 0
                    End If
                    '20時を超えるか、休日申請の場合、部長・本部長・管理本部長へ申請
                    If Label_Tomorrow.Visible Or DateTimePicker_EndTime.Value > Date.Parse("2019/01/01 20:00:00") Or IsHolidayWorking Then
                        If IdDepartment = 0 Or UserRole >= 2 Or IsDummyDepartment = 1 Then
                            dr("approval_department_kbn") = 9
                        Else
                            dr("approval_department_kbn") = 0
                        End If
                        If IdBureau = 0 Or UserRole >= 3 Or IsDummyBureau = 1 Then
                            dr("approval_bureau_kbn") = 9
                        Else
                            dr("approval_bureau_kbn") = 0
                        End If
                        dr("approval_manager_kbn") = 0
                    Else
                        dr("approval_department_kbn") = 9
                        dr("approval_bureau_kbn") = 9
                        dr("approval_manager_kbn") = 9
                    End If
                    dr("update_date") = Date.Now
                    dr("update_program") = "KINTAI_KANRI_SYSTEM"
                    dr("update_user") = DBName
                    daOverTime.Update(dtOverTime)
                Next
            End If
            '休日勤務申請の場合、HolidayWorkingテーブルにデータ追加
            If IsHolidayWorking Then
                'フィルタリング
                Dim targetDay As String = Label_TimeCardEditDate.Text.Substring(0, 4) + "/" + Label_TimeCardEditDate.Text.Substring(5, 2) + "/" + Label_TimeCardEditDate.Text.Substring(8, 2)
                Dim drlistHoliday As DataRow() = dtHoliday.Select("user_id = '" + UserName + "' AND workingday = '" + targetDay + "'")
                If drlistHoliday.Length = 0 Then
                    Dim row As DataRow = dtHoliday.NewRow '追加行を宣言
                    'IDを採番
                    Dim Id As Integer = dtHoliday.Rows.Count
                    Do
                        Id += 1
                        Dim drlistId As DataRow() = dtHoliday.Select("id_no = '" + Id.ToString + "'")
                        If drlistId.Count = 0 Then
                            Exit Do
                        End If
                    Loop
                    row("id_no") = dtHoliday.Rows.Count + 1
                    row("user_id") = UserName
                    row("workingday") = TargetDate.Date
                    row("planned_holiday") = DateTimePicker_Holiday.Value.Date
                    row("pre_confirm_flg") = 0
                    row("create_date") = Date.Now
                    row("update_date") = Date.Now
                    row("create_program") = "KINTAI_KANRI_SYSTEM"
                    row("update_program") = "KINTAI_KANRI_SYSTEM"
                    row("create_user") = DBName
                    row("update_user") = DBName
                    'テーブルの末尾に追加
                    dtHoliday.Rows.Add(row)
                    daHoliday.Update(dtHoliday)
                Else
                    For Each drH As DataRow In drlistHoliday
                        drH("planned_holiday") = DateTimePicker_Holiday.Value.Date
                        drH("pre_confirm_flg") = 0
                        drH("update_date") = Date.Now
                        drH("update_program") = "KINTAI_KANRI_SYSTEM"
                        drH("update_user") = DBName
                        daHoliday.Update(dtHoliday)
                    Next
                End If
            End If
            Button_TimeCardDisplay.PerformClick()
            DataGridView_TimeCard.ClearSelection()
            con = Nothing
        End If
    End Sub

    Private Sub Button_ReportHoliday_Click(sender As Object, e As EventArgs) Handles Button_ReportHoliday.Click
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        'DataAdapterオブジェクトを生成
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daHoliday)
        'DataTableオブジェクトを生成
        Dim dtHoliday As New DataTable()
        'DataTableとデータベースに同期させる
        daHoliday.Fill(dtHoliday)
        'フィルタリング
        Dim targetDay As String = Label_TimeCardEditDate.Text.Substring(0, 4) + "/" + Label_TimeCardEditDate.Text.Substring(5, 2) + "/" + Label_TimeCardEditDate.Text.Substring(8, 2)
        Dim drlist As DataRow() = dtHoliday.Select("user_id = '" + UserName + "' AND workingday = '" + targetDay + "'")
        For Each dr As DataRow In drlist
            dr("holiday") = DateTimePicker_ExecutedHoliday.Value.Date
            dr("confirm_flg") = 0
            dr("update_date") = Date.Now
            dr("update_program") = "KINTAI_KANRI_SYSTEM"
            dr("update_user") = DBName
            daHoliday.Update(dtHoliday)
        Next
        Dim TargetRow As Integer = DataGridView_TimeCard.CurrentCell.RowIndex
        DataGridView_TimeCard(4, TargetRow).Value = "振替実施：" + DateTimePicker_ExecutedHoliday.Value.ToString("yyyy年MM月dd日")
        DataGridView_TimeCard(4, TargetRow).Style.ForeColor = Color.Blue
        Button_TimeCardDisplay.PerformClick()
        DataGridView_TimeCard.ClearSelection()
        con = Nothing
    End Sub

    Public Sub OverTimeValidation()
        Dim PlannedStartTime As TimeSpan = DateTimePicker_StartTime.Value.TimeOfDay
        Dim PlannedEndTime As TimeSpan = DateTimePicker_EndTime.Value.TimeOfDay
        If PlannedStartTime > PlannedEndTime Then
            Label_Tomorrow.Visible = True
            PlannedEndTime = PlannedEndTime + TimeSpan.FromDays(1)
        Else
            Label_Tomorrow.Visible = False
        End If
        Dim PlannedBreakTime As TimeSpan = DateTimePicker_BreakTime.Value.TimeOfDay
        Dim EarlyWorkingTime As TimeSpan = UserStartTime - PlannedStartTime
        Dim CalculatedEndTime As TimeSpan = UserEndTime - EarlyWorkingTime
        Dim ExtraBreakTime As TimeSpan = PlannedBreakTime - TimeSpan.FromMinutes(45)
        Dim OverTime As TimeSpan = PlannedEndTime - CalculatedEndTime - ExtraBreakTime
        If OverTime.Ticks < 0 Then
            Label_TimeCardEditOverTime.Text = "残業時間不正（マイナス時間）"
            Label_TimeCardEditOverTime.ForeColor = Color.Red
        Else
            Label_TimeCardEditOverTime.Text = "残業時間 ： " + OverTime.Hours.ToString + "時間" + OverTime.Minutes.ToString + "分"
            Label_TimeCardEditOverTime.ForeColor = Color.Blue
        End If
        If TextBox_ReasonOfWorking.Text = Nothing Then
            Label_TimeCardReasonAlart.Text = "業務内容及び理由未入力"
            Label_TimeCardReasonAlart.ForeColor = Color.Red
        Else
            Label_TimeCardReasonAlart.Text = "業務内容及び理由入力済"
            Label_TimeCardReasonAlart.ForeColor = Color.Blue
        End If
        If OverTime.Ticks < 0 Or TextBox_ReasonOfWorking.Text = Nothing Or IsEnableEdit = False Then
            Button_TimeCardEdit.Enabled = False
        Else
            Button_TimeCardEdit.Enabled = True
        End If
    End Sub

    Private Sub DateTimePicker_StartTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_StartTime.ValueChanged
        OverTimeValidation()
    End Sub

    Private Sub DateTimePicker_EndTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_EndTime.ValueChanged
        OverTimeValidation()
    End Sub

    Private Sub DateTimePicker_BreakTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_BreakTime.ValueChanged
        OverTimeValidation()
    End Sub

    Private Sub TextBox_ReasonOfWorking_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ReasonOfWorking.TextChanged
        OverTimeValidation()
    End Sub

    Private Sub Button_TimeCardCancel_Click(sender As Object, e As EventArgs) Handles Button_TimeCardCancel.Click
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder1 As New OracleCommandBuilder(daOverTime)
        Dim cmdbuilder2 As New OracleCommandBuilder(daHoliday)
        'DataTableオブジェクトを生成
        Dim dtOverTime As New DataTable()
        Dim dtHoliday As New DataTable()
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daOverTime.Fill(dtOverTime)
        daHoliday.Fill(dtHoliday)
        daUser.Fill(dtUser)
        'フィルタリングする
        Dim Targetyy As String = Label_TimeCardEditDate.Text.Substring(0, 4)
        Dim TargetMM As String = Label_TimeCardEditDate.Text.Substring(5, 2)
        Dim Targetdd As String = Label_TimeCardEditDate.Text.Substring(8, 2)
        Dim TargetDate As Date = Date.Parse(Targetyy + "/" + TargetMM + "/" + Targetdd)
        Dim drlist As DataRow() = dtOverTime.Select("user_id = '" + UserName + "' AND workingday = '" + TargetDate + "'")
        'OverTimeテーブルの当該レコードを削除
        If drlist.Length > 0 Then
            For Each dr As DataRow In drlist
                dr.Delete()
                daOverTime.Update(dtOverTime)
            Next
        End If
        '休日勤務申請の場合、HolidayWorkingテーブルの当該レコードを削除
        If DateTimePicker_ExecutedHoliday.Visible Then
            'フィルタリング
            Dim targetDay As String = Label_TimeCardEditDate.Text.Substring(0, 4) + "/" + Label_TimeCardEditDate.Text.Substring(5, 2) + "/" + Label_TimeCardEditDate.Text.Substring(8, 2)
            Dim drlistHoliday As DataRow() = dtHoliday.Select("user_id = '" + UserName + "' AND workingday = '" + targetDay + "'")
            If drlistHoliday.Length > 0 Then
                For Each drH As DataRow In drlistHoliday
                    drH.Delete()
                    daHoliday.Update(dtHoliday)
                Next
            End If
        End If
        Button_TimeCardDisplay.PerformClick()
        DataGridView_TimeCard.ClearSelection()
        con = Nothing
    End Sub
End Class