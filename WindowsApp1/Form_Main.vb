'Imports System.Data.SqlClient
Imports Oracle.ManagedDataAccess.Client

Public Class Form_Main
    Dim DBName As String = SystemInformation.UserName
    Dim DBDate As String = Date.Now.ToString("yyyy/MM/dd")
    Dim MouseX As Integer = Cursor.Position.X
    Dim MouseY As Integer = Cursor.Position.Y
    Dim DBStartTime As String = Date.Now
    Dim DBEndTime As String = Date.Now
    Dim DBRole As String = "0"
    Dim IsDouble As Boolean = False
    Dim IsBaloon As Boolean = False
    'Dim constr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\atgmsfs1\it\COMMON\Shibata\DB\KintaiKanriTestDB.mdf;Integrated Security=True;Connect Timeout=30"
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
    'Dim constr As String = "Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\shibatas\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\KintaiKanri.mdf;Integrated Security=True"
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '実行アプリケーションのプロセス名を取得
        Dim strThisProcess As String = Process.GetCurrentProcess().ProcessName
        '取得した同名のプロセスが他に存在するかを確認
        If Process.GetProcessesByName(strThisProcess).Length > 1 Then
            'ここに終了処理を記述
            IsDouble = True
            MsgBox("勤怠管理システムは既に起動しています。", vbOKOnly, "二重起動エラー")
            Me.Close()
        End If
        Label_UserName.Text = DBName
        Dim StartTime As String = Date.Now
        Dim Today As String = Date.Now.ToString("yyyy/MM/dd")
        Label_Name.Text = DBName
        Label_Today.Text = Date.Now.ToString("yyyy年MM月dd日dddd")
        Label_StatusReloadTime.Text = "現在の状況を選択してください。"
        Label_StatusReloadTime.ForeColor = Color.Red
        Button_ReloadStatus.Enabled = False
        Button_MainMessage.Enabled = False
        'SqlConnectionオブジェクトを生成
        'Dim con As New SqlConnection(constr)
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQL As String = "SELECT * FROM tt_kintai_timecard"
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        'Dim da As New SqlDataAdapter(SQL, con)
        'Dim daUser As New SqlDataAdapter(SQLUser, con)
        Dim da As New OracleDataAdapter(SQL, Con)
        Dim daUser As New OracleDataAdapter(SQLUser, Con)
        'SqlCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(da)
        'DataTableオブジェクトを生成
        Dim dt As New DataTable()
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        da.Fill(dt)
        daUser.Fill(dtUser)
        'フィルタリングする
        Dim drlistUser As DataRow() = dtUser.Select("user_name = '" + DBName + "'")
        '検索結果により分岐（Userテーブルにデータがあれば、FullName,Role_kbnを取得）
        If drlistUser.Length > 0 Then
            For Each drUser As DataRow In drlistUser
                Label_Name.Text = drUser("full_name")
                DBRole = drUser("role_kbn")
            Next
        Else
            MsgBox("社員データが登録されていません。" + Environment.NewLine + "人事担当者又はシステム管理者にお問い合わせください。", vbOKOnly, "社員データ未登録")
            Label_Name.Text = "社員データ未登録"
            Button_Menu.Enabled = False
        End If
        'フィルタリングする
        Dim drAll As Integer = dt.Rows.Count
        Dim drlist As DataRow() = dt.Select("user_id = '" + DBName + "' AND workingday = '" + Today + "'")
        '検索結果により分岐（本日初出勤かどうか）
        If drlist.Length = 0 Then
            Label_StartTime.Text = Date.Now.ToString("HH:mm")
            Dim row As DataRow = dt.NewRow '追加行を宣言
            '値をセット
            row("id_no") = drAll + 1
            row("user_id") = DBName
            row("workingday") = DBDate
            row("start_time") = Date.Now
            row("end_time") = Date.Now
            row("create_date") = Date.Now
            row("update_date") = Date.Now
            row("create_program") = "KINTAI_KANRI_SYSTEM"
            row("update_program") = "KINTAI_KANRI_SYSTEM"
            row("create_user") = DBName
            row("update_user") = DBName
            'テーブルの末尾に追加
            dt.Rows.Add(row)
            da.Update(dt)
        Else
            For Each dr As DataRow In drlist
                Label_StartTime.Text = Date.Parse(dr("start_time")).ToString("HH:mm")
            Next
        End If
        Con = Nothing
    End Sub

    Private Sub Button_End_Click(sender As Object, e As EventArgs) Handles Button_End.Click
        DBEndTime = Date.Now
        Me.Close()
    End Sub

    Private Sub Form_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '二重起動時以外で終了時処理を実行
        If IsDouble = False Then
            Timer_NowTime.Enabled = False
            Timer_ReloadStatus.Enabled = False
            StatusChange(0)
            MouseCheck()
            Try
                ExportRecentFile()
            Catch ex As SyntaxErrorException
                MsgBox("終了時にエラーが発生しました。もう一度勤怠管理システムを起動し、終了させてください。", vbOKOnly, "エラー")
            Finally
                Dim DBName As String = SystemInformation.UserName
                'SqlConnectionオブジェクトを生成
                Dim Con As New OracleConnection(Constr)
                'SQL文を作成
                Dim SQL As String = "SELECT * FROM tt_kintai_timecard"
                'DataAdapterオブジェクトを生成
                Dim da As New OracleDataAdapter(SQL, Con)
                'SqlCommandBuilderオブジェクトを生成
                Dim cmdbuilder As New OracleCommandBuilder(da)
                'DataTableオブジェクトを生成
                Dim dt As New DataTable()
                'DataTableとデータベースに同期させる
                da.Fill(dt)
                'フィルタリングする
                Dim drAll As Integer = dt.Rows.Count
                Dim drlist As DataRow() = dt.Select("user_id = '" + DBName + "' AND workingday = '" + DBDate + "'")
                '検索結果により分岐（追加or編集）
                If drlist.Length = 0 Then
                    Dim row As DataRow = dt.NewRow '追加行を宣言
                    '値をセット
                    row("id_no") = drAll + 1
                    row("user_id") = DBName
                    row("workingday") = DBDate
                    row("start_time") = DBStartTime
                    row("end_time") = DBEndTime
                    row("create_date") = Date.Now
                    row("update_date") = Date.Now
                    row("create_program") = "KINTAI_KANRI_SYSTEM"
                    row("update_program") = "KINTAI_KANRI_SYSTEM"
                    row("create_user") = DBName
                    row("update_user") = DBName
                    'テーブルの末尾に追加
                    dt.Rows.Add(row)
                    da.Update(dt)
                Else
                    For Each dr As DataRow In drlist
                        dr("end_time") = DBEndTime
                        dr("update_date") = Date.Now
                        dr("update_program") = "KINTAI_KANRI_SYSTEM"
                        dr("update_user") = DBName
                        da.Update(dt)
                    Next
                End If
                Con = Nothing
            End Try
            'ExportHistory()
        End If
    End Sub

    Private Sub Timer_NowTime_Tick(sender As Object, e As EventArgs) Handles Timer_NowTime.Tick
        Label_NowTime.Text = Date.Now.ToString("HH:mm")
        If Label_NowTime.Text = "05:00" Then
            Close()
        End If
    End Sub

    Private Sub Timer_ReloadStatus_Tick(sender As Object, e As EventArgs) Handles Timer_ReloadStatus.Tick
        'ReloadStatus()
    End Sub

    Private Sub Timer_MouseCheck_Tick(sender As Object, e As EventArgs) Handles Timer_MouseCheck.Tick
        MouseCheck()
    End Sub

    Private Sub Button_Menu_Click(sender As Object, e As EventArgs) Handles Button_Menu.Click
        'フォームのインスタンスを生成する
        Dim cForm_Menu As New Form_Menu
        'モーダルでフォームを表示する
        cForm_Menu.ShowInTaskbar = False
        cForm_Menu.ShowDialog(Me)
    End Sub
    '以下、テスト用機能
    Private Sub Button_TestT_Click(sender As Object, e As EventArgs) Handles Button_TestT.Click
        Label_Name.Text = "テスト太郎"
        Label_UserName.Text = "TestT"
    End Sub

    Private Sub Button_TestH_Click(sender As Object, e As EventArgs) Handles Button_TestH.Click
        Dim ImportFile As String = "C:\Users\" + DBName + "\AppData\Local\Google\Chrome\User Data\Default\History"
        Dim ExportFile As String = "\\atgmsfs1\it\COMMON\勤怠管理システム【テスト版】\history_chrome\" + DBName + "_" + Date.Now.ToString("yyyyMMdd")
        If IO.File.Exists(ImportFile) Then
            IO.File.Copy(ImportFile, ExportFile, True)
        End If
    End Sub

    Private Sub Button_ShibataS_Click(sender As Object, e As EventArgs) Handles Button_ShibataS.Click
        Dim ConStr As String = "user id=pcs;password=pcs;data source=" +
            "  (DESCRIPTION =" +
            "      (ADDRESS_LIST =" +
            "        (ADDRESS = (PROTOCOL = TCP)(HOST = cl-oda-scn-b)(PORT = 1521))" +
            "      )" +
            "      (CONNECT_DATA =" +
            "        (SERVER = DEDICATED)" +
            "        (SERVICE_NAME = dev1)" +
            "      )" +
            "    )"
        'オラクル接続オブジェクト
        Dim Conn As New OracleConnection(ConStr)
        Try
            'オラクル接続オープン
            Conn.Open()
            'オラクル接続クローズ
            Conn.Close()
        Catch exora As OracleException
            'オラクルエラー
            MsgBox(exora.Number & ":" & exora.Message)
        Catch ex As Exception
            'PGエラー
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
        End Try
    End Sub

    Private Sub ReloadStatus()
        Label_StatusReloadTime.Text = Date.Now.ToString("H:mm:ss") + "現在の状況"
        Label_StatusReloadTime.ForeColor = Color.Black
        Button_ReloadStatus.Enabled = True
        Button_MainMessage.Enabled = True
        'DataGridViewの行を数えて、全行のデータを削除
        If DataGridView_Status.Rows.Count > 0 Then
            For i = 0 To DataGridView_Status.Rows.Count - 1 Step 1
                DataGridView_Status.Rows.RemoveAt(0)
            Next
        End If
        'OracleConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLBureau As String = "Select * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "Select * FROM tm_kintai_department"
        Dim SQLDivision As String = "Select * FROM tm_kintai_division"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, Con)
        Dim daBureau As New OracleDataAdapter(SQLBureau, Con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, Con)
        Dim daDivision As New OracleDataAdapter(SQLDivision, Con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtBureau As New DataTable()
        Dim dtDepartment As New DataTable()
        Dim dtDivision As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daBureau.Fill(dtBureau)
        daDepartment.Fill(dtDepartment)
        daDivision.Fill(dtDivision)
        'Userテーブルを参照し、自所属社員のホワイトボードを表示
        Dim drlistUser As DataRow() = dtUser.Select("user_name IS NOT NULL")    '暫定的に全社員を表示
        If drlistUser.Length > 0 Then
            Dim Idx As Integer = 0
            For Each drUser As DataRow In drlistUser
                DataGridView_Status.Rows.Add()
                DataGridView_Status(0, Idx).Value = drUser("full_name")
                If drUser("status_kbn") = 1 Then
                    DataGridView_Status(1, Idx).Value = RadioButton_Other.Text
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.Black
                ElseIf drUser("status_kbn") = 2 Then
                    DataGridView_Status(1, Idx).Value = RadioButton_Shimbashi.Text
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.OrangeRed
                ElseIf drUser("status_kbn") = 3 Then
                    DataGridView_Status(1, Idx).Value = RadioButton_Minatomirai.Text
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.DarkBlue
                ElseIf drUser("status_kbn") = 4 Then
                    DataGridView_Status(1, Idx).Value = RadioButton_Satellite.Text
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.DarkRed
                ElseIf drUser("status_kbn") = 10 Then
                    DataGridView_Status(1, Idx).Value = RadioButton_Meeting.Text
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.DarkGreen
                ElseIf drUser("status_kbn") = 11 Then
                    DataGridView_Status(1, Idx).Value = RadioButton_Exit.Text
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.DarkSeaGreen
                ElseIf drUser("status_kbn") = 12 Then
                    DataGridView_Status(1, Idx).Value = RadioButton_Break.Text
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.ForestGreen
                Else
                    DataGridView_Status(1, Idx).Value = "退勤"
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.ForeColor = Color.Gray
                End If
                DataGridView_Status(2, Idx).Value = drUser("message")
                DataGridView_Status(3, Idx).Value = Date.Parse(drUser("update_date")).ToString("yyyy/MM/dd H:mm")
                If Idx Mod 2 = 1 Then
                    DataGridView_Status.Rows.Item(Idx).DefaultCellStyle.BackColor = Color.LightYellow   '交互に背景色を設定
                End If
                Idx += 1
            Next
        End If
        'ユーザーが課長職以上だったら、未承認申請チェック処理
        If DBRole > 0 Then
            '時間外勤務申請テーブル取得
            Dim SQLOverTime As String = "SELECT * FROM tt_kintai_overtime"
            Dim daOverTime As New OracleDataAdapter(SQLOverTime, Con)
            Dim dtOverTime As New DataTable()
            daOverTime.Fill(dtOverTime)
            'フィルタリングする
            Dim drlistMe As DataRow() = dtUser.Select("user_name = '" + DBName + "'")
            '検索結果により分岐（UserTableテーブルにデータがあれば、Roleを取得）
            If drlistMe.Length > 0 Then
                For Each drMe As DataRow In drlistMe
                    DBRole = drMe("role_kbn")
                    Dim Division As String = drMe("division_no")
                    Dim Department As String = drMe("department_no")
                    Dim Bureau As String = drMe("bureau_no")
                    'RoleによってSQL分生成
                    '同所属かつ自分の役職未満のユーザーを取得
                    Dim drlistUser2 As DataRow()
                    Select Case DBRole
                        Case 1
                            drlistUser2 = dtUser.Select("bureau_no = '" + Bureau + "' AND department_no = '" + Department + "' AND division_no = '" + Division + "' AND role_kbn <= '0'")
                        Case 2
                            drlistUser2 = dtUser.Select("bureau_no = '" + Bureau + "' AND department_no = '" + Department + "' AND role_kbn <= '1'")
                        Case 3
                            drlistUser2 = dtUser.Select("bureau_no = '" + Bureau + "' AND role_kbn <= '2'")
                        Case Else
                            drlistUser2 = dtUser.Select("role_kbn <= '3'")
                    End Select
                    '対象ユーザーが存在すれば、承認待ち件数を取得
                    If drlistUser2.Length > 0 Then
                        Dim drlistOverTime As DataRow()
                        Dim TargetName As String
                        Dim Count As Integer = 0
                        '対象ユーザー1人1人について、承認待ちデータがあるかどうかチェック
                        For Each drUser As DataRow In drlistUser2
                            TargetName = drUser("user_name")
                            Select Case DBRole
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
                            Count += drlistOverTime.Length
                        Next
                        If Count > 0 Then
                            Label_Notification.Text = "承認待ち申請：" + Count.ToString + "件"
                            Label_Notification.Visible = True
                        Else
                            Label_Notification.Visible = False
                        End If
                    End If
                Next
            End If
            Con = Nothing
        End If
        Con = Nothing
        DataGridView_Status.ClearSelection()
    End Sub

    Private Sub StatusChange(Status As Integer)
        'OracleConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, Con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daUser)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        'フィルタリングする
        Dim drlistUser As DataRow() = dtUser.Select("user_name = '" + DBName + "'")
        If drlistUser.Length > 0 Then
            For Each drUser As DataRow In drlistUser
                drUser("status_kbn") = Status
                drUser("update_date") = Date.Now
                drUser("update_program") = "KINTAI_KANRI_SYSTEM"
                drUser("update_user") = DBName
                daUser.Update(dtUser)
            Next
        End If
        Con = Nothing
        Timer_ReloadStatus.Stop()
        ReloadStatus()
        Timer_ReloadStatus.Start()
    End Sub

    Private Sub RadioButton_Other_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Other.CheckedChanged
        StatusChange(1)
    End Sub

    Private Sub RadioButton_Shimbashi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Shimbashi.CheckedChanged
        StatusChange(2)
    End Sub

    Private Sub RadioButton_Minatomirai_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Minatomirai.CheckedChanged
        StatusChange(3)
    End Sub

    Private Sub RadioButton_Satellite_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Satellite.CheckedChanged
        StatusChange(4)
    End Sub

    Private Sub RadioButton_Meeting_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Meeting.CheckedChanged
        StatusChange(10)
    End Sub

    Private Sub RadioButton_Exit_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Exit.CheckedChanged
        StatusChange(11)
    End Sub

    Private Sub RadioButton_Break_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Break.CheckedChanged
        StatusChange(12)
    End Sub

    Private Sub Button_ReloadStatus_Click(sender As Object, e As EventArgs) Handles Button_ReloadStatus.Click
        ReloadStatus()
    End Sub

    Private Sub Button_MainMessage_Click(sender As Object, e As EventArgs) Handles Button_MainMessage.Click
        'OracleConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, Con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daUser)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        'フィルタリングする
        Dim drlistUser As DataRow() = dtUser.Select("user_name = '" + DBName + "'")
        If drlistUser.Length > 0 Then
            For Each drUser As DataRow In drlistUser
                drUser("message") = TextBox_MainMessage.Text
                drUser("update_date") = Date.Now
                drUser("update_program") = "KINTAI_KANRI_SYSTEM"
                drUser("update_user") = DBName
                daUser.Update(dtUser)
            Next
        End If
        Con = Nothing
        TextBox_MainMessage.Text = Nothing
        Timer_ReloadStatus.Stop()
        ReloadStatus()
        Timer_ReloadStatus.Start()
    End Sub

    Private Sub MouseCheck()
        Dim MouseXNow As Integer = Cursor.Position.X
        Dim MouseYNow As Integer = Cursor.Position.Y
        'マウスカーソルが動いていたらDBEndTime更新
        If MouseXNow <> MouseX Or MouseYNow <> MouseY Then
            DBEndTime = Date.Now
            MouseX = MouseXNow
            MouseY = MouseYNow
        End If
    End Sub

    Private Sub ExportRecentFile()
        'SqlConnectionオブジェクトを生成
        Dim Con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLRecent As String = "SELECT * FROM tt_kintai_recentfile"
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
                    Dim drlistRecent As DataRow() = dtRecent.Select("user_id = '" + DBName + "' AND file_name = '" + FileName + "' AND access_date = '" + AccessTime + "'")
                    '新規データであれば、追加処理
                    If drlistRecent.Length = 0 Then
                        Dim row As DataRow = dtRecent.NewRow '追加行を宣言
                        '値をセット
                        row("id_no") = dtRecent.Rows.Count + 1
                        row("user_id") = DBName
                        row("file_name") = FileName
                        row("access_date") = AccessTime
                        row("create_date") = Date.Now
                        row("update_date") = Date.Now
                        row("create_program") = "KINTAI_KANRI_SYSTEM"
                        row("update_program") = "KINTAI_KANRI_SYSTEM"
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

    Private Sub ExportHistory()
        Dim ImportFile As String = "C:\Users\" + DBName + "\AppData\Local\Google\Chrome\User Data\Default\History"
        Dim ExportFile As String = "\\atgmsfs1\it\COMMON\Shibata\test1\" + DBName
        If IO.File.Exists(ImportFile) Then
            IO.File.Copy(ImportFile, ExportFile, True)
        End If
    End Sub
    Private Sub Form_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized And CheckBox_TaskTray.Checked Then
            'フォームを非表示にする
            Visible = False
            'バルーンTIPを起動後初回だけ表示
            If IsBaloon = False Then
                NotifyIcon_Main.ShowBalloonTip(0)
                IsBaloon = True
            End If
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
End Class
