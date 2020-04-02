Imports Oracle.ManagedDataAccess.Client
Public Class Form_DocApprovalList
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
    Dim DBName As String = SystemInformation.UserName
    Dim Role As Integer = 0
    Dim ImportDir As String = "\\atgmsfs1\it\COMMON\勤怠管理システム【テスト版】\exportfiles"
    Dim targetDirectory As String = "C:\kintaiKanriSystem"
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Close()
    End Sub

    Private Sub Form_DocApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_Reload.PerformClick()
    End Sub

    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        'DataGridViewの行を数えて、全行のデータを削除
        If DataGridView_DocApproval.Rows.Count > 0 Then
            For i = 0 To DataGridView_DocApproval.Rows.Count - 1 Step 1
                DataGridView_DocApproval.Rows.RemoveAt(0)
            Next
        End If
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLDoc As String = "SELECT * FROM tt_kintai_docapproval"
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
        'DataAdapterオブジェクトを生成
        Dim daDoc As New OracleDataAdapter(SQLDoc, con)
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        Dim daDivision As New OracleDataAdapter(SQLDivision, con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daDoc)
        'DataTableオブジェクトを生成
        Dim dtDoc As New DataTable()
        Dim dtUser As New DataTable()
        Dim dtBureau As New DataTable()
        Dim dtDepartment As New DataTable()
        Dim dtDivision As New DataTable()
        'DataTableとデータベースに同期させる
        daDoc.Fill(dtDoc)
        daUser.Fill(dtUser)
        daBureau.Fill(dtBureau)
        daDepartment.Fill(dtDepartment)
        daDivision.Fill(dtDivision)
        'フィルタリングする
        Dim drlistMe As DataRow() = dtUser.Select("user_name = '" + DBName + "'")
        '検索結果により分岐（UserTableテーブルにデータがあれば、Roleを取得）
        If drlistMe.Length > 0 Then
            Dim drMe As DataRow = drlistMe(0)
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
            '対象ユーザーが存在すれば、そのユーザーの申請データを取得
            If drlistUser.Length > 0 Then
                Dim drlistDoc As DataRow()
                Dim TargetName As String
                Dim Idx As Integer = 0
                '対象ユーザー1人1人について、申請データがあるかどうかチェック
                For Each drUser As DataRow In drlistUser
                    TargetName = drUser("user_name")
                    Select Case Role
                        Case 1
                            drlistDoc = dtDoc.Select("user_id = '" + TargetName + "' AND approval_division_kbn = '0'")
                        Case 2
                            drlistDoc = dtDoc.Select("user_id = '" + TargetName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                                        approval_department_kbn = '0'")
                        Case 3
                            drlistDoc = dtDoc.Select("user_id = '" + TargetName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                                           (approval_department_kbn = '1' OR approval_department_kbn = '9') AND
                                                                                                            approval_bureau_kbn = '0'")
                        Case Else
                            drlistDoc = dtDoc.Select("user_id = '" + TargetName + "' AND (approval_division_kbn = '1' OR approval_division_kbn = '9') AND
                                                                                                           (approval_department_kbn = '1' OR approval_department_kbn = '9') AND
                                                                                                           (approval_bureau_kbn = '1' OR approval_bureau_kbn = '9') AND
                                                                                                            approval_manager1_kbn = '0'")
                    End Select
                    If drlistDoc.Length > 0 Then
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
                        '申請データをDataGridViewに表示
                        For Each drDoc As DataRow In drlistDoc
                            DataGridView_DocApproval.Rows.Add()
                            DataGridView_DocApproval(0, Idx).Value = drDoc("id_no")
                            DataGridView_DocApproval(2, Idx).Value = TargetBureau + Environment.NewLine + TargetDepartment + Environment.NewLine + TargetDivision
                            DataGridView_DocApproval(3, Idx).Value = drUser("full_name")
                            DataGridView_DocApproval(4, Idx).Value = Date.Parse(drDoc("create_date")).ToString("yyyy年MM月dd日（ddd）")
                            DataGridView_DocApproval(5, Idx).Value = drDoc("subject")
                            Idx = Idx + 1
                        Next
                        DataGridView_DocApproval.ClearSelection()
                    End If
                Next
            End If
        End If
        con = Nothing
    End Sub

    Private Sub DataGridView_DocApproval_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_DocApproval.CellContentClick
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLDoc As String = "SELECT * FROM tt_kintai_docapproval"
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daDoc As New OracleDataAdapter(SQLDoc, con)
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daDoc)
        'DataTableオブジェクトを生成
        Dim dtDoc As New DataTable()
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daDoc.Fill(dtDoc)
        daUser.Fill(dtUser)

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim TargetRow As Integer = e.RowIndex
        Dim TargetId As String = DataGridView_DocApproval(0, TargetRow).Value
        Dim TargetFullName As String = DataGridView_DocApproval(3, e.RowIndex).Value
        Dim TargetUser As String = Nothing
        If dgv.Columns(e.ColumnIndex).Name = "Column_File" Then
            'ファイル表示ボタンがクリックされた時の処理
            'Userテーブルを参照し、FullNameからUserNameを取得
            Dim drlistUser As DataRow() = dtUser.Select("full_name = '" + TargetFullName + "'")
            If drlistUser.Length > 0 Then
                For Each drUser As DataRow In drlistUser
                    TargetUser = drUser("user_name")
                Next
            End If
            'フィルタリングする
            Dim drlistDoc As DataRow() = dtDoc.Select("id_no = '" + TargetId + "'")
            If drlistDoc.Length > 0 Then
                Dim drDoc As DataRow = drlistDoc(0)
                '対象のzipファイル名を取得（.zipを付与）
                Dim TargetFileName As String = drDoc("file_name") + ".zip"
                '対象ファイルのCreateDateを取得
                Dim TargetDate As String = Date.Parse(drDoc("create_date")).ToString("yyyyMMddHHmmss")

                '展開するZIP書庫のパス 
                Dim zipFileName As String = ImportDir + "\" + TargetFileName
                '展開したファイルを保存するフォルダ（存在しないと作成される） 
                'Dim targetDirectory As String = "C:\kintaiKanriSystem"
                '展開するファイルのフィルタ 
                Dim fileFilter As String = ""

                'FastZipオブジェクトの作成 
                Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip()
                '属性を復元するか。デフォルトはfalse 
                fastZip.RestoreAttributesOnExtract = True
                'ファイル日時を復元するか。デフォルトはfalse 
                fastZip.RestoreDateTimeOnExtract = True
                '空のフォルダも作成するか。デフォルトはfalse 
                fastZip.CreateEmptyDirectories = True

                '★☆★最重要機密事項★☆★パスワード生成
                Dim src As Long = Long.Parse(TargetDate)
                Dim Temp1 As Integer = src Mod 83
                Dim Temp2 As Integer = src Mod 89
                Dim Temp3 As Integer = src Mod 97
                Dim Passwd As String = TargetUser.Substring(0, 1) + Temp1.ToString + Temp2.ToString + Temp3.ToString + TargetUser.Substring(1, 1)

                'パスワードが設定されているとき 
                'パスワードが設定されている書庫をパスワードを指定せずに展開しようとすると、 
                '　例外ZipExceptionがスローされる 
                fastZip.Password = Passwd

                'ZIP書庫を展開する 
                fastZip.ExtractZip(zipFileName, targetDirectory, fileFilter)
                '展開したフォルダを表示
                Process.Start(targetDirectory)
            End If
        ElseIf dgv.Columns(e.ColumnIndex).Name = "Column_Verify" Then
            '承認ボタンがクリックされた時の処理
            Dim drlistDoc As DataRow() = dtDoc.Select("id_no = '" + TargetId + "'")
            If drlistDoc.Length > 0 Then
                Dim drDoc As DataRow = drlistDoc(0)
                Select Case Role
                    Case 1
                        drDoc("approval_division_kbn") = 1
                        drDoc("approval_division_date") = Date.Now
                        drDoc("approval_division_user") = DBName
                    Case 2
                        drDoc("approval_department_kbn") = 1
                        drDoc("approval_department_date") = Date.Now
                        drDoc("approval_department_user") = DBName
                    Case 3
                        drDoc("approval_bureau_kbn") = 1
                        drDoc("approval_bureau_date") = Date.Now
                        drDoc("approval_bureau_user") = DBName
                    Case Else
                        drDoc("approval_manager1_kbn") = 1
                        drDoc("approval_manager1_date") = Date.Now
                        drDoc("approval_manager1_user") = DBName
                End Select
                drDoc("update_date") = Date.Now
                drDoc("update_program") = "KINTAI_KANRI_SYSTEM"
                drDoc("update_user") = DBName
                daDoc.Update(dtDoc)
                DataGridView_DocApproval.Rows.RemoveAt(TargetRow)
            End If
        ElseIf dgv.Columns(e.ColumnIndex).Name = "Column_Reject" Then
            '却下ボタンがクリックされた時の処理
            Dim drlistDoc As DataRow() = dtDoc.Select("id_no = '" + TargetId + "'")
            If drlistDoc.Length > 0 Then
                Dim drDoc As DataRow = drlistDoc(0)
                Select Case Role
                    Case 1
                        drDoc("approval_division_kbn") = 2
                    Case 2
                        drDoc("approval_department_kbn") = 2
                    Case 3
                        drDoc("approval_bureau_kbn") = 2
                    Case Else
                        drDoc("approval_manager1_kbn") = 2
                End Select
                drDoc("update_date") = Date.Now
                drDoc("update_program") = "KINTAI_KANRI_SYSTEM"
                drDoc("update_user") = DBName
                daDoc.Update(dtDoc)
                DataGridView_DocApproval.Rows.RemoveAt(TargetRow)
            End If
        End If
        con = Nothing
    End Sub

    Private Sub Form_DocApprovalList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IO.Directory.Exists(targetDirectory) Then
            IO.Directory.Delete(targetDirectory, True)
        End If
    End Sub
End Class