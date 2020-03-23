Imports Oracle.ManagedDataAccess.Client
Public Class Form_Print
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
    Dim CSVPath As String = Environment.CurrentDirectory
    Dim DBUser As String = SystemInformation.UserName
    Dim TargetUserId As String = ""
    Dim TargetUserDivisionId As Integer = 0
    Dim TargetUserDepartmentId As Integer = 0
    Dim TargetUserBureauId As Integer = 0
    Dim TargetUserDivision As String = ""
    Dim TargetUserDepartment As String = ""
    Dim TargetUserBureau As String = ""
    Dim ApprovalDivisionUser As String = ""
    Dim ApprovalDepartmentUser As String = ""
    Dim ApprovalBureauUser As String = ""
    Dim ApprovalManagerUser As String = ""
    ''' <summary>
    ''' DataTableの内容をCSVファイルに保存する
    ''' </summary>
    ''' <param name="dt">CSVに変換するDataTable</param>
    ''' <param name="csvPath">保存先のCSVファイルのパス</param>
    ''' <param name="writeHeader">ヘッダを書き込む時はtrue。</param>
    Public Sub ConvertDataTableToCsv(
        dt As DataTable, csvPath As String, writeHeader As Boolean)
        'CSVファイルに書き込むときに使うEncoding
        Dim enc As Text.Encoding =
        System.Text.Encoding.GetEncoding("Shift_JIS")

        '書き込むファイルを開く
        Dim sr As New IO.StreamWriter(csvPath, False, enc)

        Dim colCount As Integer = dt.Columns.Count
        Dim lastColIndex As Integer = colCount - 1
        Dim i As Integer

        'ヘッダを書き込む
        If writeHeader Then
            For i = 0 To colCount - 1
                'ヘッダの取得
                Dim field As String = dt.Columns(i).Caption
                '"で囲む
                field = EncloseDoubleQuotesIfNeed(field)
                'フィールドを書き込む
                sr.Write(field)
                'カンマを書き込む
                If lastColIndex > i Then
                    sr.Write(","c)
                End If
            Next
            '改行する
            sr.Write(vbCrLf)
        End If

        'レコードを書き込む
        Dim row As DataRow
        For Each row In dt.Rows
            For i = 0 To colCount - 1
                'フィールドの取得
                Dim field As String = row(i).ToString()
                '"で囲む
                field = EncloseDoubleQuotesIfNeed(field)
                'フィールドを書き込む
                sr.Write(field)
                'カンマを書き込む
                If lastColIndex > i Then
                    sr.Write(","c)
                End If
            Next
            '改行する
            sr.Write(vbCrLf)
        Next

        '閉じる
        sr.Close()
    End Sub

    ''' <summary>
    ''' 必要ならば、文字列をダブルクォートで囲む
    ''' </summary>
    Private Function EncloseDoubleQuotesIfNeed(field As String) As String
        If NeedEncloseDoubleQuotes(field) Then
            Return EncloseDoubleQuotes(field)
        End If
        Return field
    End Function

    ''' <summary>
    ''' 文字列をダブルクォートで囲む
    ''' </summary>
    Private Function EncloseDoubleQuotes(field As String) As String
        If field.IndexOf(""""c) > -1 Then
            '"を""とする
            field = field.Replace("""", """""")
        End If
        Return """" & field & """"
    End Function

    ''' <summary>
    ''' 文字列をダブルクォートで囲む必要があるか調べる
    ''' </summary>
    Private Function NeedEncloseDoubleQuotes(field As String) As Boolean
        Return field.IndexOf(""""c) > -1 OrElse
        field.IndexOf(","c) > -1 OrElse
        field.IndexOf(ControlChars.Cr) > -1 OrElse
        field.IndexOf(ControlChars.Lf) > -1 OrElse
        field.StartsWith(" ") OrElse
        field.StartsWith(vbTab) OrElse
        field.EndsWith(" ") OrElse
        field.EndsWith(vbTab)
    End Function
    Private Sub Button_PrintEnd_Click(sender As Object, e As EventArgs) Handles Button_PrintEnd.Click
        Me.Close()
    End Sub

    Private Sub Button_PrintOverTime_Click(sender As Object, e As EventArgs) Handles Button_PrintOverTime.Click
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daOverTime As New OracleDataAdapter(SQLOverTime, con)
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        Dim daDivision As New OracleDataAdapter(SQLDivision, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtOverTime As New DataTable()
        Dim dtBureau As New DataTable()
        Dim dtDepartment As New DataTable()
        Dim dtDivision As New DataTable()
        Dim dtCSV As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daOverTime.Fill(dtOverTime)
        daBureau.Fill(dtBureau)
        daDepartment.Fill(dtDepartment)
        daDivision.Fill(dtDivision)
        'CSV出力用DataTableオブジェクトに列を追加
        dtCSV.Columns.Add("ID", Type.GetType("System.Int32"))
        dtCSV.Columns.Add("本部", Type.GetType("System.String"))
        dtCSV.Columns.Add("部", Type.GetType("System.String"))
        dtCSV.Columns.Add("課", Type.GetType("System.String"))
        dtCSV.Columns.Add("氏名", Type.GetType("System.String"))
        dtCSV.Columns.Add("該当日", Type.GetType("System.String"))
        dtCSV.Columns.Add("勤務開始時刻", Type.GetType("System.String"))
        dtCSV.Columns.Add("勤務終了時刻", Type.GetType("System.String"))
        dtCSV.Columns.Add("残業開始時刻", Type.GetType("System.String"))
        dtCSV.Columns.Add("残業終了時刻", Type.GetType("System.String"))
        dtCSV.Columns.Add("申請休憩時間", Type.GetType("System.String"))
        dtCSV.Columns.Add("残業時間", Type.GetType("System.String"))
        dtCSV.Columns.Add("業務内容及び理由", Type.GetType("System.String"))
        dtCSV.Columns.Add("課長承認日", Type.GetType("System.String"))
        dtCSV.Columns.Add("課長承認氏名", Type.GetType("System.String"))
        dtCSV.Columns.Add("部長承認日", Type.GetType("System.String"))
        dtCSV.Columns.Add("部長承認氏名", Type.GetType("System.String"))
        dtCSV.Columns.Add("本部長承認日", Type.GetType("System.String"))
        dtCSV.Columns.Add("本部長承認氏名", Type.GetType("System.String"))
        dtCSV.Columns.Add("管理本部長承認日", Type.GetType("System.String"))
        dtCSV.Columns.Add("管理本部長承認氏名", Type.GetType("System.String"))
        dtCSV.Columns.Add("申請日", Type.GetType("System.String"))
        dtCSV.Columns.Add("社員番号", Type.GetType("System.String"))
        '時間外勤務テーブルフィルタリング（自分自身かつ指定期間内のデータ）
        Dim IsExistData As Boolean = False
        Dim drlistOverTime As DataRow() = dtOverTime.Select("user_id = '" + DBUser + "' AND workingday >= '" + DateTimePicker_PrintStart.Value + "' AND workingday <= '" + DateTimePicker_PrintEnd.Value + "'")
        If drlistOverTime.Length > 0 Then
            For Each drOverTime As DataRow In drlistOverTime
                '承認済データかどうかを判定
                If drOverTime("approval_division_kbn") * drOverTime("approval_department_kbn") * drOverTime("approval_bureau_kbn") * drOverTime("approval_manager_kbn") Mod 2 <> 0 Then
                    IsExistData = True
                    Dim drCSV As DataRow = dtCSV.NewRow '追加行を宣言
                    drCSV("ID") = drOverTime("id_no")
                    TargetUserId = drOverTime("user_id")
                    'ユーザーテーブルを検索して所属と氏名を取得
                    Dim drlistUser As DataRow() = dtUser.Select("user_name = '" + TargetUserId + "'")
                    For Each drUser As DataRow In drlistUser
                        TargetUserBureauId = drUser("bureau_no")
                        TargetUserDepartmentId = drUser("department_no")
                        TargetUserDivisionId = drUser("division_no")
                        '本部テーブル検索
                        If TargetUserBureauId <> 0 Then
                            Dim drlistBureau As DataRow() = dtBureau.Select("id_no = '" + TargetUserBureauId.ToString + "'")
                            For Each drBureau As DataRow In drlistBureau
                                TargetUserBureau = drBureau("bureau_name")
                            Next
                        Else
                            TargetUserBureau = Nothing
                        End If
                        drCSV("本部") = TargetUserBureau
                        '部テーブル検索
                        If TargetUserDepartmentId <> 0 Then
                            Dim drlistDepartment As DataRow() = dtDepartment.Select("id_no = '" + TargetUserDepartmentId.ToString + "'")
                            For Each drDepartment As DataRow In drlistDepartment
                                TargetUserDepartment = drDepartment("department_name")
                            Next
                        Else
                            TargetUserDepartment = Nothing
                        End If
                        drCSV("部") = TargetUserDepartment
                        '課テーブル検索
                        If TargetUserDivisionId <> 0 Then
                            Dim drlistDivision As DataRow() = dtDivision.Select("id_no = '" + TargetUserDivisionId.ToString + "'")
                            For Each drDivision As DataRow In drlistDivision
                                TargetUserDivision = drDivision("division_name")
                            Next
                        Else
                            TargetUserDivision = Nothing
                        End If
                        drCSV("課") = TargetUserDivision
                        '氏名・社員番号取得
                        drCSV("氏名") = drUser("full_name")
                        drCSV("社員番号") = drUser("employee_no")
                    Next
                    '残業時間を計算
                    Dim EarlyWorkingTime As TimeSpan = Date.Parse(drOverTime("user_start_time")).TimeOfDay - Date.Parse(drOverTime("planned_start_time")).TimeOfDay
                    Dim CalculatedEndTime As TimeSpan = Date.Parse(drOverTime("user_end_time")).TimeOfDay - EarlyWorkingTime
                    Dim ExtraBreakTime As TimeSpan = Date.Parse(drOverTime("planned_break_time")).TimeOfDay - TimeSpan.FromMinutes(45)
                    Dim OverTime As TimeSpan = Date.Parse(drOverTime("planned_end_time")).TimeOfDay - CalculatedEndTime - ExtraBreakTime
                    If Date.Parse(drOverTime("planned_end_time")).ToString("yyyy/MM/dd") <> "2019/01/01" Then
                        OverTime += TimeSpan.FromDays(1)
                    End If
                    If OverTime < TimeSpan.Zero Then
                        OverTime = TimeSpan.Zero
                    End If
                    '該当日～申請休憩時間を取得
                    drCSV("該当日") = Date.Parse(drOverTime("workingday")).ToString("yyyy年M月d日（ddd）")
                    drCSV("勤務開始時刻") = Date.Parse(drOverTime("planned_start_time")).ToString("H時mm分")
                    If Date.Parse(drOverTime("planned_end_time")).ToString("yyyy/MM/dd") <> "2019/01/01" Then
                        drCSV("勤務終了時刻") = "翌" + Date.Parse(drOverTime("planned_end_time")).ToString("H時mm分")
                    Else
                        drCSV("勤務終了時刻") = Date.Parse(drOverTime("planned_end_time")).ToString("H時mm分")
                    End If
                    drCSV("残業開始時刻") = Date.Parse("2019/01/01 " + CalculatedEndTime.ToString).ToString("H時mm分")
                    If Date.Parse(drOverTime("planned_end_time")).ToString("yyyy/MM/dd") <> "2019/01/01" Then
                        drCSV("残業終了時刻") = "翌" + Date.Parse(drOverTime("planned_end_time")).ToString("H時mm分")
                    Else
                        drCSV("残業終了時刻") = Date.Parse(drOverTime("planned_end_time")).ToString("H時mm分")
                    End If
                    drCSV("申請休憩時間") = Date.Parse(drOverTime("planned_break_time")).ToString("H時間mm分")
                    drCSV("残業時間") = Date.Parse("2019/01/01 " + OverTime.ToString).ToString("H時間mm分")
                    '業務内容及び理由を取得
                    drCSV("業務内容及び理由") = drOverTime("reason")
                    '課長承認状況を取得
                    If drOverTime("approval_division_kbn") = 1 And drOverTime("approval_division_user") IsNot DBNull.Value Then '承認
                        '承認日取得
                        drCSV("課長承認日") = Date.Parse(drOverTime("approval_division_date")).ToString("yyyy/M/d")
                        '承認氏名取得
                        ApprovalDivisionUser = drOverTime("approval_division_user")
                        Dim drlistDivisionUser As DataRow() = dtUser.Select("user_name = '" + ApprovalDivisionUser + "'")
                        For Each drDivisionUser As DataRow In drlistDivisionUser
                            drCSV("課長承認氏名") = drDivisionUser("full_name")
                        Next
                    Else    '不要
                        drCSV("課長承認日") = "不要"
                        drCSV("課長承認氏名") = "不要"
                    End If
                    '部長承認ユーザー検索
                    If drOverTime("approval_department_kbn") = 1 And drOverTime("approval_department_user") IsNot DBNull.Value Then '承認
                        '承認日取得
                        drCSV("部長承認日") = Date.Parse(drOverTime("approval_department_date")).ToString("yyyy/M/d")
                        '承認氏名取得
                        ApprovalDepartmentUser = drOverTime("approval_department_user")
                        Dim drlistDepartmentUser As DataRow() = dtUser.Select("user_name = '" + ApprovalDepartmentUser + "'")
                        For Each drDepartmentUser As DataRow In drlistDepartmentUser
                            drCSV("部長承認氏名") = drDepartmentUser("full_name")
                        Next
                    Else    '不要
                        drCSV("部長承認日") = "不要"
                        drCSV("部長承認氏名") = "不要"
                    End If
                    '本部長承認ユーザー検索
                    If drOverTime("approval_bureau_kbn") = 1 And drOverTime("approval_bureau_user") IsNot DBNull.Value Then '承認
                        '承認日取得
                        drCSV("本部長承認日") = Date.Parse(drOverTime("approval_bureau_date")).ToString("yyyy/M/d")
                        '承認氏名取得
                        ApprovalBureauUser = drOverTime("approval_bureau_user")
                        Dim drlistBureauUser As DataRow() = dtUser.Select("user_name = '" + ApprovalBureauUser + "'")
                        For Each drBureauUser As DataRow In drlistBureauUser
                            drCSV("本部長承認氏名") = drBureauUser("full_name")
                        Next
                    Else    '不要
                        drCSV("本部長承認日") = "不要"
                        drCSV("本部長承認氏名") = "不要"
                    End If
                    '管理本部長承認ユーザー検索
                    If drOverTime("approval_manager_kbn") = 1 And drOverTime("approval_manager_user") IsNot DBNull.Value Then '承認
                        '承認日取得
                        drCSV("管理本部長承認日") = Date.Parse(drOverTime("approval_manager_date")).ToString("yyyy/M/d")
                        '承認氏名取得
                        ApprovalManagerUser = drOverTime("approval_manager_user")
                        Dim drlistManagerUser As DataRow() = dtUser.Select("user_name = '" + ApprovalManagerUser + "'")
                        For Each drManagerUser As DataRow In drlistManagerUser
                            drCSV("管理本部長承認氏名") = drManagerUser("full_name")
                        Next
                    Else    '不要
                        drCSV("管理本部長承認日") = "不要"
                        drCSV("管理本部長承認氏名") = "不要"
                    End If
                    '申請日
                    drCSV("申請日") = Date.Parse(drOverTime("create_date")).ToString("yyyy年M月d日（ddd）")
                    dtCSV.Rows.Add(drCSV)
                End If
            Next
        End If
        If IsExistData Then
            'CSV出力
            Dim CSVName As String = CSVPath + "\時間外勤務テーブル_" + DBUser + "_" + Date.Now.ToString("yyyyMMddHHmmss") + ".csv"
            ConvertDataTableToCsv(dtCSV, CSVName, True)
            'CSVファイル生成フォルダを開く
            Process.Start(CSVPath)
        Else
            MsgBox("選択した期間内のデータはありません。", vbOKOnly, "データなし")
        End If
        con = Nothing
    End Sub

    Private Sub Button_PrintHolidayWorking1_Click(sender As Object, e As EventArgs) Handles Button_PrintHolidayWorking1.Click
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtHoliday As New DataTable()
        Dim dtCSV As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daHoliday.Fill(dtHoliday)

        'CSV出力
        Dim CSVName As String = CSVPath + "\休日出勤テーブル_" + Date.Now.ToString("yyyyMMddHHmmss") + ".csv"
        ConvertDataTableToCsv(dtHoliday, CSVName, True)
        'CSVファイル生成フォルダを開く
        Process.Start(CSVPath)
        con = Nothing
    End Sub

    Private Sub Button_PrintHolidayWorking2_Click(sender As Object, e As EventArgs) Handles Button_PrintHolidayWorking2.Click
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLHoliday As String = "SELECT * FROM tt_kintai_holidayworking"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daHoliday As New OracleDataAdapter(SQLHoliday, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtHoliday As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daHoliday.Fill(dtHoliday)
        'CSV出力
        Dim CSVName As String = CSVPath + "\休日出勤テーブル_" + Date.Now.ToString("yyyyMMddHHmmss") + ".csv"
        ConvertDataTableToCsv(dtHoliday, CSVName, True)
        'CSVファイル生成フォルダを開く
        Process.Start(CSVPath)
        con = Nothing
    End Sub

    Private Sub Form_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker_PrintStart.Value = Date.Now - TimeSpan.FromDays(30)
        DateTimePicker_PrintEnd.Value = Date.Now
    End Sub
End Class