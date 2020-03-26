Imports Oracle.ManagedDataAccess.Client
Public Class Form_DocApproval
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
    Dim PersonCount As Integer = 0
    Dim DBName As String = SystemInformation.UserName
    Dim ImportFile As String = ""
    Dim FileServerDir As String = "\\atgmsfs1\it\COMMON\勤怠管理システム【テスト版】\files"
    Dim ExportDir As String = "\\atgmsfs1\it\COMMON\勤怠管理システム【テスト版】\exportfiles"
    Private Sub Button_DocApprovalClose_Click(sender As Object, e As EventArgs) Handles Button_DocApprovalClose.Click
        Close()
    End Sub

    Private Sub Button_OpenFile_Click(sender As Object, e As EventArgs) Handles Button_OpenFile.Click
        'OpenFileDialogクラスのインスタンスを作成
        Dim OpenFile As New OpenFileDialog()
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        OpenFile.InitialDirectory = "%userprofile%\Documents"
        'タイトルを設定する
        OpenFile.Title = "電子承認申請対象ファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        OpenFile.RestoreDirectory = True
        'ダイアログを表示する
        If OpenFile.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            ImportFile = OpenFile.FileName
            TextBox_ApprovalFile.Text = IO.Path.GetFileName(ImportFile)
        End If
    End Sub

    Private Sub Form_DocApproval_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        'コントロール内にドラッグされたとき実行される
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
            e.Effect = DragDropEffects.Copy
        Else
            'ファイル以外は受け付けない
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Form_DocApproval_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        'コントロール内にドロップされたとき実行される
        'ドロップされたファイル名を取得する
        Dim FileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        'ファイルかどうかをチェック
        If IO.Path.GetExtension(FileName(0)) = Nothing Then
            MsgBox("それはファイルではありません。", vbOKOnly, "ファイル選択エラー")
        Else
            'TextBoxに表示する
            ImportFile = FileName(0)
            TextBox_ApprovalFile.Text = IO.Path.GetFileName(ImportFile)
        End If
    End Sub

    Private Sub DocApprovalValidation()
        'バリデーション（件名・申請ファイル・承認権者が条件を満たせば申請実行ボタン有効化）
        If TextBox_ApprovalSubject.Text = Nothing Or TextBox_ApprovalFile.Text = Nothing Or PersonCount = 0 Then
            Button_Execute.Enabled = False
        Else
            Button_Execute.Enabled = True
        End If
    End Sub

    Private Sub PersonValidation()
        '承認権者が選択されているかどうかをチェックする処理
        PersonCount = GroupBox_Person.Controls.OfType(Of CheckBox)().Where(Function(c) c.Checked = True).Count()
        If PersonCount = 0 Then
            Label_PersonAlart.Text = "未選択"
            Label_PersonAlart.ForeColor = Color.Red
        Else
            Label_PersonAlart.Text = "選択済"
            Label_PersonAlart.ForeColor = Color.Blue
        End If
        DocApprovalValidation()
    End Sub

    Private Sub TextBox_ApprovalSubject_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ApprovalSubject.TextChanged
        '件名が入力されているかどうかをチェックする処理
        If TextBox_ApprovalSubject.Text = Nothing Then
            Label_SubjectAlart.Text = "未入力"
            Label_SubjectAlart.ForeColor = Color.Red
        Else
            Label_SubjectAlart.Text = "入力済"
            Label_SubjectAlart.ForeColor = Color.Blue
        End If
        DocApprovalValidation()
    End Sub

    Private Sub TextBox_ApprovalFile_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ApprovalFile.TextChanged
        '申請ファイルが選択されているかどうかをチェックする処理
        If TextBox_ApprovalFile.Text = Nothing Then
            Label_FileAlart.Text = "未選択"
            Label_FileAlart.ForeColor = Color.Red
        Else
            Label_FileAlart.Text = "選択済"
            Label_FileAlart.ForeColor = Color.Blue
        End If
        DocApprovalValidation()
    End Sub

    '＊＊＊　チェックボックス変更時イベントここから　＊＊＊
    Private Sub CheckBox_Boss1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Boss1.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Boss2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Boss2.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_CFO_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_CFO.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Manager1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Manager1.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_COO_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_COO.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Bureau_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Bureau.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Department_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Department.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Division_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Division.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Manager2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Manager2.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Manager3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Manager3.CheckedChanged
        PersonValidation()
    End Sub

    Private Sub CheckBox_Manager4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Manager4.CheckedChanged
        PersonValidation()
    End Sub
    '＊＊＊　チェックボックス変更時イベントここまで　＊＊＊

    Private Sub Form_DocApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        Dim dtBureau As New DataTable()
        Dim dtDepartment As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        daBureau.Fill(dtBureau)
        daDepartment.Fill(dtDepartment)
        'フィルタリングする
        Dim drlistMe As DataRow() = dtUser.Select("user_name = '" + DBName + "'")
        '検索結果により分岐（UserTableテーブルにデータがあれば、Roleを取得）
        If drlistMe.Length > 0 Then
            Dim drMe As DataRow = drlistMe(0)
            Dim Role As Integer = drMe("role_kbn")
            Dim Division As String = drMe("division_no")
            Dim Department As String = drMe("department_no")
            Dim Bureau As String = drMe("bureau_no")
            Select Case Role
                Case 1
                    CheckBox_Division.Enabled = False
                Case 2
                    CheckBox_Division.Enabled = False
                    CheckBox_Department.Enabled = False
                Case Else
                    CheckBox_Division.Enabled = True
                    CheckBox_Department.Enabled = True
            End Select
        End If
        con = Nothing
    End Sub

    Private Sub Button_Execute_Click(sender As Object, e As EventArgs) Handles Button_Execute.Click
        Dim UserDir As String = FileServerDir + "\" + DBName
        Dim ExportFile As String = UserDir + "\" + TextBox_ApprovalFile.Text
        If IO.File.Exists(ImportFile) Then
            'フォルダ作成
            If IO.Directory.Exists(UserDir) = False Then
                IO.Directory.CreateDirectory(UserDir)
            End If
            'ファイルを一時フォルダにコピー
            IO.File.Copy(ImportFile, ExportFile, True)
            '作成日を設定
            Dim CreateDate As Date = Date.Now
            '作成するZIP書庫のパス
            'ファイルが既に存在している場合は、上書きされる
            Dim zipFileName As String = ExportDir + "\" + DBName + "_" + CreateDate.ToString("yyMMddHHmmss") + ".zip"
            '圧縮するフォルダのパス
            Dim sourceDirectory As String = UserDir
            'サブディレクトリも圧縮するかどうか
            Dim recurse As Boolean = True
            '★☆★最重要機密事項★☆★パスワード生成
            Dim src As Long = Long.Parse(CreateDate.ToString("yyyyMMddHHmmss"))
            Dim Temp1 As Integer = src Mod 83
            Dim Temp2 As Integer = src Mod 89
            Dim Temp3 As Integer = src Mod 97
            Dim Passwd As String = DBName.Substring(0, 1) + Temp1.ToString + Temp2.ToString + Temp3.ToString + DBName.Substring(1, 1)
            'MsgBox(Passwd)

            'FastZipオブジェクトの作成
            Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip()
            '空のフォルダも書庫に入れるか。デフォルトはfalse
            fastZip.CreateEmptyDirectories = True
            'ZIP64を使うか。デフォルトはDynamicで、状況に応じてZIP64を使う
            '（大きなファイルはZIP64でしか圧縮できないが、対応していないアーカイバもある）
            fastZip.UseZip64 = ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic
            'パスワードを設定するには次のようにする
            fastZip.Password = Passwd

            '圧縮してZIP書庫を作成
            fastZip.CreateZip(zipFileName, sourceDirectory, recurse, Nothing, Nothing)

            'ファイルを一時フォルダから削除
            IO.File.Delete(ExportFile)

            'OracleConnectionオブジェクトを生成
            Dim con As New OracleConnection(Constr)
            'SQL文を作成
            Dim SQLDoc As String = "SELECT * FROM tt_kintai_docapproval"
            'DataAdapterオブジェクトを生成
            Dim daDoc As New OracleDataAdapter(SQLDoc, con)
            'OracleCommandBuilderオブジェクトを生成
            Dim cmdbuilder As New OracleCommandBuilder(daDoc)
            'DataTableオブジェクトを生成
            Dim dtDoc As New DataTable()
            'DataTableとデータベースに同期させる
            daDoc.Fill(dtDoc)
            '申請情報をデータベースに格納
            Dim row As DataRow = dtDoc.NewRow '追加行を宣言
            'IDを採番
            Dim Id As Integer = dtDoc.Rows.Count
            Do
                Id += 1
                Dim drlistId As DataRow() = dtDoc.Select("id_no = '" + Id.ToString + "'")
                If drlistId.Count = 0 Then
                    Exit Do
                End If
            Loop
            row("id_no") = Id
            row("user_id") = DBName
            row("subject") = TextBox_ApprovalSubject.Text
            row("file_name") = IO.Path.GetFileNameWithoutExtension(zipFileName)
            row("approval_division_kbn") = 0
            row("approval_department_kbn") = 0
            row("approval_bureau_kbn") = 0
            row("approval_manager1_kbn") = 0
            row("approval_manager2_kbn") = ""
            row("approval_manager3_kbn") = ""
            row("approval_manager4_kbn") = ""
            row("approval_coo_kbn") = ""
            row("approval_cfo_kbn") = ""
            row("approval_boss1_kbn") = ""
            row("approval_boss2_kbn") = ""
            row("create_date") = CreateDate
            row("update_date") = CreateDate
            row("create_program") = "KINTAI_KANRI_SYSTEM"
            row("update_program") = "KINTAI_KANRI_SYSTEM"
            row("create_user") = DBName
            row("update_user") = DBName
            'テーブルの末尾に追加
            dtDoc.Rows.Add(row)
            daDoc.Update(dtDoc)
            MsgBox("電子承認申請が完了しました。", vbOKOnly, "電子承認申請完了")
            'フォーム初期化
            TextBox_ApprovalSubject.Text = Nothing
            TextBox_ApprovalFile.Text = Nothing
            For Each CheckBoxPerson As CheckBox In GroupBox_Person.Controls
                CheckBoxPerson.Checked = False
            Next
            con = Nothing
        Else
            MsgBox("申請ファイルが存在しません。", vbOKOnly, "エラー")
        End If
    End Sub
End Class