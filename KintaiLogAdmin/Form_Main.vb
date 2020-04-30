Imports Oracle.ManagedDataAccess.Client
Public Class Form_Main
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
    Private Sub Button_ExportEnd_Click(sender As Object, e As EventArgs) Handles Button_ExportEnd.Click
        Close()
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker_ExportStart.Value = Date.Now - TimeSpan.FromDays(30)
        DateTimePicker_ExportEnd.Value = Date.Now
    End Sub

    Private Sub Button_ExportTimeLog_Click(sender As Object, e As EventArgs) Handles Button_ExportTimeLog.Click
        'OracleConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQL As String = "SELECT * FROM tt_kintai_log"
        'DataAdapterオブジェクトを生成
        Dim daLog As New OracleDataAdapter(SQL, Con)
        'DataTableオブジェクトを生成
        Dim dtLog As New DataTable()
        Dim dtCSV As New DataTable()
        'DataTableとデータベースに同期させる
        daLog.Fill(dtLog)
        'CSV出力用DataTableオブジェクトに列を追加
        dtCSV.Columns.Add("ID", Type.GetType("System.Int32"))
        dtCSV.Columns.Add("氏名", Type.GetType("System.String"))
        dtCSV.Columns.Add("勤務日", Type.GetType("System.String"))
        dtCSV.Columns.Add("作業開始時刻", Type.GetType("System.String"))
        dtCSV.Columns.Add("作業終了時刻", Type.GetType("System.String"))
        '勤怠ログテーブルフィルタリング（指定期間内のデータ）
        Dim drlistLog As DataRow() = dtLog.Select("workingday >= '" + DateTimePicker_ExportStart.Value + "' AND workingday <= '" + DateTimePicker_ExportEnd.Value + "'")
        If drlistLog.Length > 0 Then
            For Each drLog As DataRow In drlistLog
                Dim drCSV As DataRow = dtCSV.NewRow '追加行を宣言
                drCSV("ID") = drLog("id_no")
                drCSV("氏名") = drLog("user_fullname")
                drCSV("勤務日") = Date.Parse(drLog("workingday")).ToString("yyyy/MM/dd")
                drCSV("作業開始時刻") = Date.Parse(drLog("start_time")).ToString("HH:mm")
                drCSV("作業終了時刻") = Date.Parse(drLog("end_time")).ToString("HH:mm")
                dtCSV.Rows.Add(drCSV)
            Next
            'CSV出力
            Dim CSVName As String = CSVPath + "\作業時間ログ_" + Date.Now.ToString("yyyyMMddHHmmss") + ".csv"
            ConvertDataTableToCsv(dtCSV, CSVName, True)
            'CSVファイル生成フォルダを開く
            Process.Start(CSVPath)
        Else
            MsgBox("選択した期間内のデータはありません。", vbOKOnly, "データなし")
        End If
    End Sub

    Private Sub Button_ExportFileAccessLog_Click(sender As Object, e As EventArgs) Handles Button_ExportFileAccessLog.Click
        'OracleConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQL As String = "SELECT * FROM tt_kintai_logrecent"
        'DataAdapterオブジェクトを生成
        Dim daRecent As New OracleDataAdapter(SQL, Con)
        'DataTableオブジェクトを生成
        Dim dtRecent As New DataTable()
        Dim dtCSV As New DataTable()
        'DataTableとデータベースに同期させる
        daRecent.Fill(dtRecent)
        'CSV出力用DataTableオブジェクトに列を追加
        dtCSV.Columns.Add("ID", Type.GetType("System.Int32"))
        dtCSV.Columns.Add("氏名", Type.GetType("System.String"))
        dtCSV.Columns.Add("ファイル名", Type.GetType("System.String"))
        dtCSV.Columns.Add("アクセス日時", Type.GetType("System.String"))
        '勤怠ログテーブルフィルタリング（指定期間内のデータ）
        Dim drlistRecent As DataRow() = dtRecent.Select("access_date >= '" + DateTimePicker_ExportStart.Value + "' AND access_date <= '" + DateTimePicker_ExportEnd.Value + "'")
        If drlistRecent.Length > 0 Then
            For Each drRecent As DataRow In drlistRecent
                Dim drCSV As DataRow = dtCSV.NewRow '追加行を宣言
                drCSV("ID") = drRecent("id_no")
                drCSV("氏名") = drRecent("user_fullname")
                drCSV("ファイル名") = drRecent("file_name")
                drCSV("アクセス日時") = drRecent("access_date")
                dtCSV.Rows.Add(drCSV)
            Next
            'CSV出力
            Dim CSVName As String = CSVPath + "\ファイルアクセスログ_" + Date.Now.ToString("yyyyMMddHHmmss") + ".csv"
            ConvertDataTableToCsv(dtCSV, CSVName, True)
            'CSVファイル生成フォルダを開く
            Process.Start(CSVPath)
        Else
            MsgBox("選択した期間内のデータはありません。", vbOKOnly, "データなし")
        End If
    End Sub
End Class
