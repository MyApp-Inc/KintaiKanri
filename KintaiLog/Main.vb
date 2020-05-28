'Imports Oracle.ManagedDataAccess.Client
Imports Microsoft.Win32

Public Class Main
    Dim DBName As String = SystemInformation.UserName
    Dim DBFullName As String = SystemInformation.UserName
    Dim DBDate As String = Date.Now.ToString("yyyy/MM/dd")
    Dim DBStart As String = Date.Now.ToString("yyyyMMddHHmmss")
    Dim MouseX As Integer = Cursor.Position.X
    Dim MouseY As Integer = Cursor.Position.Y
    Dim DBStartTime As String = Date.Now
    Dim DBEndTime As String = Date.Now
    Dim IsBreak As Boolean = False
    Dim CSVPath As String = Environment.CurrentDirectory + "\Log"
    Dim ExportLogPath As String = "\\atgmsfs1\Attendance_Management$\Log"
    Dim DBUser As String = SystemInformation.UserName
    Dim dtCSVLog As New DataTable()
    Dim dtCSVRecent As New DataTable()
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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'フルネームを取得
            Dim XLApp As Object
            XLApp = CreateObject("Excel.Application")
            Dim objADSystemInfo As Object = CreateObject("ADSystemInfo")
            Dim objUser As Object = GetObject("LDAP://" & objADSystemInfo.username)
            DBFullName = objUser.DisplayName.ToString   '表示名
        Catch ex As Exception

        End Try

        'ログフォルダがなければ、フォルダを作成
        If Not IO.Directory.Exists(CSVPath) Then
            IO.Directory.CreateDirectory(CSVPath)
        End If

        'CSV出力用DataTableオブジェクトに列を追加
        dtCSVLog.Columns.Add("user_fullname", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("workingday", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("start_time", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("end_time", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("create_date", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("update_date", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("create_program", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("update_program", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("create_user", Type.GetType("System.String"))
        dtCSVLog.Columns.Add("update_user", Type.GetType("System.String"))

        dtCSVRecent.Columns.Add("user_fullname", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("file_name", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("access_date", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("create_date", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("update_date", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("create_program", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("update_program", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("create_user", Type.GetType("System.String"))
        dtCSVRecent.Columns.Add("update_user", Type.GetType("System.String"))
        '最小化して起動
        Opacity = 0
        Visible = False
        ShowInTaskbar = False
        WindowState = FormWindowState.Minimized
        'イベントをイベントハンドラに関連付ける
        'フォームコンストラクタなどの適当な位置に記述してもよい
        AddHandler SystemEvents.SessionEnding, AddressOf SystemEvents_SessionEnding
    End Sub

    Private Sub Timer_MouseCheck_Tick(sender As Object, e As EventArgs) Handles Timer_MouseCheck.Tick
        Dim MouseXNow As Integer = Cursor.Position.X
        Dim MouseYNow As Integer = Cursor.Position.Y
        'マウスカーソルが動いていたらDBEndTime更新、動いていなければKintai_Logに作業時間を記録
        If MouseXNow <> MouseX Or MouseYNow <> MouseY Then
            If IsBreak Then
                DBStartTime = Date.Now
                IsBreak = False
            End If
            DBEndTime = Date.Now
            MouseX = MouseXNow
            MouseY = MouseYNow
            Try
                WriteLog()
            Catch ex As Exception

            End Try
        ElseIf Not IsBreak Then
            IsBreak = True
            Try
                WriteLog()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub WriteLog()
        Try
            'フルネームを取得
            Dim XLApp As Object
            XLApp = CreateObject("Excel.Application")
            Dim objADSystemInfo As Object = CreateObject("ADSystemInfo")
            Dim objUser As Object = GetObject("LDAP://" & objADSystemInfo.username)
            DBFullName = objUser.DisplayName.ToString   '表示名
        Catch ex As Exception

        End Try
        'ログテーブルフィルタリング（同じデータがあるかどうか）
        Dim drlistLog As DataRow() = dtCSVLog.Select("user_fullname = '" + DBFullName + "' AND workingday = '" + DBDate + "' AND start_time = '" + DBStartTime + "'")
        If drlistLog.Length = 0 Then
            'データ件数取得
            'Dim drLogAll As Integer = dtLog.Rows.Count
            'Dim row As DataRow = dtLog.NewRow '追加行を宣言
            Dim row As DataRow = dtCSVLog.NewRow '追加行を宣言
            '値をセット
            'row("id_no") = drLogAll + 1
            row("user_fullname") = DBFullName
            row("workingday") = DBDate
            row("start_time") = DBStartTime
            row("end_time") = DBEndTime
            row("create_date") = Date.Now
            row("update_date") = Date.Now
            row("create_program") = "KINTAI_LOG_TOOL"
            row("update_program") = "KINTAI_LOG_TOOL"
            row("create_user") = DBName
            row("update_user") = DBName
            'テーブルの末尾に追加
            dtCSVLog.Rows.Add(row)
            'daLog.Update(dtLog)
        Else
            For Each dr As DataRow In drlistLog
                dr("end_time") = DBEndTime
                dr("update_date") = Date.Now
                dr("update_program") = "KINTAI_LOG_TOOL"
                dr("update_user") = DBName
                'daLog.Update(dtLog)
            Next
        End If
        'Con = Nothing
    End Sub

    Private Sub ExportRecentFile()
        'SqlConnectionオブジェクトを生成
        'Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        'Dim SQLRecent As String = "SELECT * FROM tt_kintai_logrecent"
        'DataAdapterオブジェクトを生成
        'Dim daRecent As New OracleDataAdapter(SQLRecent, Con)
        'SqlCommandBuilderオブジェクトを生成
        'Dim cmdbuilder As New OracleCommandBuilder(daRecent)
        'DataTableオブジェクトを生成
        'Dim dtRecent As New DataTable()
        'DataTableとデータベースに同期させる
        'daRecent.Fill(dtRecent)
        '最近使った項目を開く
        'Process.Start("EXPLORER.EXE", "shell:Recent")
        '最近使った項目以下のファイルをすべて取得する
        'ワイルドカード"*"は、すべてのファイルを意味する
        Dim Dir As String = "C:\Users\" + DBName + "\AppData\Roaming\Microsoft\Windows\Recent"
        'Dim files As IEnumerable(Of String) = IO.Directory.EnumerateFiles(Dir, "*", IO.SearchOption.AllDirectories)
        Dim files As IEnumerable(Of String) = IO.Directory.EnumerateFiles(Dir, "*")
        '最近使った項目があれば、データベース追加処理
        If files.Count > 0 Then
            For Each f As String In files
                'アクセス日時の取得
                Dim FileName As String = f.Substring(Dir.Length + 1, f.Length - Dir.Length - 5)
                Dim AccessTime As Date = IO.File.GetLastAccessTime(f)
                '当日のファイルアクセスデータのみ処理
                If AccessTime.Date = Date.Today.Date Then
                    'ListBox1.Items.Add(filename + "：" + AccessTime.ToString)
                    'ファイルアクセス履歴テーブルフィルタリング（同じデータがあるかどうか）
                    Dim drlistRecent As DataRow() = dtCSVRecent.Select("user_fullname = '" + DBFullName + "' AND file_name = '" + FileName + "' AND access_date = '" + AccessTime + "'")
                    '新規データであれば、追加処理
                    If drlistRecent.Length = 0 Then
                        Dim row As DataRow = dtCSVRecent.NewRow '追加行を宣言
                        '値をセット
                        'row("id_no") = dtCSVRecent.Rows.Count + 1
                        row("user_fullname") = DBFullName
                        row("file_name") = FileName
                        row("access_date") = AccessTime
                        row("create_date") = Date.Now
                        row("update_date") = Date.Now
                        row("create_program") = "KINTAI_LOG_TOOL"
                        row("update_program") = "KINTAI_LOG_TOOL"
                        row("create_user") = DBName
                        row("update_user") = DBName
                        'テーブルの末尾に追加
                        dtCSVRecent.Rows.Add(row)
                        'daRecent.Update(dtRecent)
                    End If
                End If
            Next
        End If
        'Con = Nothing
    End Sub

    Private Sub Timer_Recent_Tick(sender As Object, e As EventArgs) Handles Timer_Recent.Tick
        Try
            ExportRecentFile()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'イベントを解放する
        'フォームDisposeメソッド内の基本クラスのDisposeメソッド呼び出しの前に
        '記述してもよい
        RemoveHandler SystemEvents.SessionEnding, AddressOf SystemEvents_SessionEnding
    End Sub

    'ログオフ、シャットダウンしようとしているとき
    Private Sub SystemEvents_SessionEnding(ByVal sender As Object, ByVal e As SessionEndingEventArgs)
        'CSV出力
        Dim CSVNameLog As String = CSVPath + "\Log_" + DBUser + "_" + Date.Now.ToString("yyyyMMddHHmmss") + ".csv"
        Dim CSVNameRecent As String = CSVPath + "\Recent_" + DBUser + "_" + Date.Now.ToString("yyyyMMddHHmmss") + ".csv"
        ConvertDataTableToCsv(dtCSVLog, CSVNameLog, True)
        ConvertDataTableToCsv(dtCSVRecent, CSVNameRecent, True)
    End Sub

    Private Sub Timer_LogFile_Tick(sender As Object, e As EventArgs) Handles Timer_LogFile.Tick
        'ログファイルがあるかチェック
        Dim files As IEnumerable(Of String) = IO.Directory.EnumerateFiles(CSVPath, "*")
        If files.Count > 0 Then
            '転送先フォルダにアクセスできる状態であれば、ファイル転送
            If IO.Directory.Exists(ExportLogPath) Then
                For Each f As String In files
                    '転送元ファイル名を取得
                    Dim FileName As String = f.Substring(CSVPath.Length + 1, f.Length - CSVPath.Length - 5)
                    'ファイルコピー
                    IO.File.Copy(f, ExportLogPath + "\" + FileName + ".csv")
                    'ファイルを削除
                    IO.File.Delete(f)
                Next
                Enabled = False
            Else
                'MsgBox("フォルダなし")
            End If
        Else
            Enabled = False
        End If
    End Sub
End Class
