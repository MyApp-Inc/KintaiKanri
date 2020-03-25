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
        Dim ExportFile As String = FileServerDir + "\" + TextBox_ApprovalFile.Text
        If IO.File.Exists(ImportFile) Then
            'ファイルを一時フォルダにコピー
            IO.File.Copy(ImportFile, ExportFile, True)
            'ZIP書庫を作成
            'IO.Compression.ZipFile.CreateFromDirectory(FileServerDir, ExportDir + "\" + DBName + "_" + Date.Now.ToString("yyMMddHHmmss") + ".zip")
            'ファイルを一時フォルダから削除
            'IO.File.Delete(ExportFile)
        End If
        MsgBox("電子承認申請が完了しました。", vbOKOnly, "電子承認申請完了")
    End Sub
End Class