Imports Oracle.ManagedDataAccess.Client
Public Class Main
    Dim DBName As String = SystemInformation.UserName
    Dim DBFullName As String = Nothing
    Dim DBDate As String = Date.Now.ToString("yyyy/MM/dd")
    Dim MouseX As Integer = Cursor.Position.X
    Dim MouseY As Integer = Cursor.Position.Y
    Dim DBStartTime As String = Date.Now
    Dim DBEndTime As String = Date.Now
    Dim IsBreak As Boolean = False
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
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'フルネームを取得
        Dim XLApp As Object
        XLApp = CreateObject("Excel.Application")
        Dim objADSystemInfo As Object = CreateObject("ADSystemInfo")
        Dim objUser As Object = GetObject("LDAP://" & objADSystemInfo.username)
        DBFullName = objUser.DisplayName.ToString   '表示名
        Label_Title.Text = "勤怠ログ管理ツール：" + DBFullName
        '最小化して起動
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            'フォームを非表示にする
            Visible = False
            'バルーンTIPを表示
            NotifyIcon_Main.ShowBalloonTip(0)
        End If
    End Sub

    Private Sub NotifyIcon_Main_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon_Main.MouseDoubleClick
        'フォームを表示する
        Visible = True
        If Me.WindowState = FormWindowState.Minimized Then
            'ノーマルウィンドウに戻す
            WindowState = FormWindowState.Normal
        End If
        'アクティブにする
        Activate()
    End Sub

    Private Sub ToolStripMenuItem_End_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_End.Click
        Close()
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
        ElseIf Not IsBreak Then
            IsBreak = True
            WriteLog()
        End If
    End Sub

    Private Sub WriteLog()
        'OracleConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQL As String = "SELECT * FROM tt_kintai_log"
        'DataAdapterオブジェクトを生成
        Dim daLog As New OracleDataAdapter(SQL, Con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daLog)
        'DataTableオブジェクトを生成
        Dim dtLog As New DataTable()
        'DataTableとデータベースに同期させる
        daLog.Fill(dtLog)
        'データ件数取得
        Dim drLogAll As Integer = dtLog.Rows.Count
        Dim row As DataRow = dtLog.NewRow '追加行を宣言
        '値をセット
        row("id_no") = drLogAll + 1
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
        dtLog.Rows.Add(row)
        daLog.Update(dtLog)
        Con = Nothing
    End Sub

    Private Sub ExportRecentFile()
        'SqlConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLRecent As String = "SELECT * FROM tt_kintai_logrecent"
        'DataAdapterオブジェクトを生成
        Dim daRecent As New OracleDataAdapter(SQLRecent, Con)
        'SqlCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daRecent)
        'DataTableオブジェクトを生成
        Dim dtRecent As New DataTable()
        'DataTableとデータベースに同期させる
        daRecent.Fill(dtRecent)
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
                    Dim drlistRecent As DataRow() = dtRecent.Select("user_fullname = '" + DBFullName + "' AND file_name = '" + FileName + "' AND access_date = '" + AccessTime + "'")
                    '新規データであれば、追加処理
                    If drlistRecent.Length = 0 Then
                        Dim row As DataRow = dtRecent.NewRow '追加行を宣言
                        '値をセット
                        row("id_no") = dtRecent.Rows.Count + 1
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
                        dtRecent.Rows.Add(row)
                        daRecent.Update(dtRecent)
                    End If
                End If
            Next
        End If
        Con = Nothing
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        DBEndTime = Date.Now
        Timer_MouseCheck.Enabled = False
        Timer_Recent.Enabled = False
        If Not IsBreak Then
            WriteLog()
        End If
        Try
            ExportRecentFile()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer_Recent_Tick(sender As Object, e As EventArgs) Handles Timer_Recent.Tick
        Try
            ExportRecentFile()
        Catch ex As Exception

        End Try
    End Sub
End Class
