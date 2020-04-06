Imports Oracle.ManagedDataAccess.Client
Public Class Form_DocApprovalHistory
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
    Dim ImportDir As String = "\\atgmsfs1\it\COMMON\勤怠管理システム【テスト版】\exportfiles"
    Dim targetDirectory As String = "C:\kintaiKanriSystem"
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Close()
    End Sub

    Private Sub Form_DocApprovalHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'テスト用機能
        If Form_Main.Label_UserName.Text = "TestT" Then
            DBName = "TestT"
        End If
        'DataGridViewの行を数えて、全行のデータを削除
        If DataGridView_DocHistory.Rows.Count > 0 Then
            For i = 0 To DataGridView_DocHistory.Rows.Count - 1 Step 1
                DataGridView_DocHistory.Rows.RemoveAt(0)
            Next
        End If
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLDoc As String = "SELECT * FROM tt_kintai_docapproval"
        'DataAdapterオブジェクトを生成
        Dim daDoc As New OracleDataAdapter(SQLDoc, con)
        'DataTableオブジェクトを生成
        Dim dtDoc As New DataTable()
        'DataTableとデータベースに同期させる
        daDoc.Fill(dtDoc)
        '自分の申請データをフィルタリング
        Dim drlistDoc As DataRow() = dtDoc.Select("user_id = '" + DBName + "'")
        If drlistDoc.Length > 0 Then
            '申請データを表示
            Dim Idx As Integer = 0
            For Each drDoc As DataRow In drlistDoc
                DataGridView_DocHistory.Rows.Add()
                DataGridView_DocHistory(0, Idx).Value = drDoc("id_no")
                DataGridView_DocHistory(2, Idx).Value = Date.Parse(drDoc("create_date")).ToString("yyyy年MM月dd日（ddd）")
                DataGridView_DocHistory(3, Idx).Value = drDoc("subject")
                '承認状況
                If drDoc("approval_division_kbn") = 2 Or drDoc("approval_department_kbn") = 2 Or drDoc("approval_bureau_kbn") = 2 Or drDoc("approval_manager1_kbn") = 2 Then
                    DataGridView_DocHistory(4, Idx).Value = "却下"
                    DataGridView_DocHistory(4, Idx).Style.ForeColor = Color.Red
                    DataGridView_DocHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightPink
                ElseIf drDoc("approval_division_kbn") = 0 Then
                    DataGridView_DocHistory(4, Idx).Value = "上長申請中"
                    DataGridView_DocHistory(4, Idx).Style.ForeColor = Color.Black
                    DataGridView_DocHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                ElseIf drDoc("approval_department_kbn") = 0 Then
                    DataGridView_DocHistory(4, Idx).Value = "部長／次長申請中"
                    DataGridView_DocHistory(4, Idx).Style.ForeColor = Color.Black
                    DataGridView_DocHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                ElseIf drDoc("approval_bureau_kbn") = 0 Then
                    DataGridView_DocHistory(4, Idx).Value = "本部長（該当部署）申請中"
                    DataGridView_DocHistory(4, Idx).Style.ForeColor = Color.Black
                    DataGridView_DocHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                ElseIf drDoc("approval_manager1_kbn") = 0 Then
                    DataGridView_DocHistory(4, Idx).Value = "管理本部長申請中"
                    DataGridView_DocHistory(4, Idx).Style.ForeColor = Color.Black
                    DataGridView_DocHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightYellow
                Else
                    DataGridView_DocHistory(4, Idx).Value = "承認"
                    DataGridView_DocHistory(4, Idx).Style.ForeColor = Color.Blue
                    DataGridView_DocHistory.Rows(Idx).DefaultCellStyle.BackColor = Color.LightCyan
                End If
                If DataGridView_DocHistory(4, Idx).Value = "承認" Then
                    DataGridView_DocHistory(5, Idx).Value = "出力"
                    DataGridView_DocHistory(5, Idx).Style.BackColor = Color.LightGray
                Else
                    DataGridView_DocHistory(5, Idx).Value = "取下げ"
                    DataGridView_DocHistory(5, Idx).Style.BackColor = Color.LightPink
                End If
                Idx = Idx + 1
            Next
            DataGridView_DocHistory.ClearSelection()
        End If
        con = Nothing
    End Sub

    Private Sub DataGridView_DocHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_DocHistory.CellContentClick
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

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim TargetRow As Integer = e.RowIndex
        Dim TargetId As String = DataGridView_DocHistory(0, TargetRow).Value
        If dgv.Columns(e.ColumnIndex).Name = "Column_File" Then
            'ファイル表示ボタンがクリックされた時の処理
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
                'Dim targetDirectory As String = "C:\temp\kintai"
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
                Dim Passwd As String = DBName.Substring(0, 1) + Temp1.ToString + Temp2.ToString + Temp3.ToString + DBName.Substring(1, 1)

                'パスワードが設定されているとき 
                'パスワードが設定されている書庫をパスワードを指定せずに展開しようとすると、 
                '　例外ZipExceptionがスローされる 
                fastZip.Password = Passwd

                'ZIP書庫を展開する 
                fastZip.ExtractZip(zipFileName, targetDirectory, fileFilter)
                '展開したフォルダを表示
                Process.Start(targetDirectory)
            End If
        ElseIf dgv.Columns(e.ColumnIndex).Name = "Column_Print" Then
            'フィルタリングする
            Dim drlistDoc As DataRow() = dtDoc.Select("id_no = '" + TargetId + "'")
            If DataGridView_DocHistory(e.ColumnIndex, e.RowIndex).Value = "出力" Then
                '出力ボタンがクリックされた時の処理
                If drlistDoc.Length > 0 Then
                    Dim drDoc As DataRow = drlistDoc(0)
                    '対象のzipファイル名を取得（.zipを付与）
                    Dim TargetFileName As String = drDoc("file_name") + ".zip"

                    '開くZIP書庫 
                    Dim zipPath As String = ImportDir + "\" + TargetFileName

                    'ZipFileオブジェクトの作成 
                    Dim zf As New ICSharpCode.SharpZipLib.Zip.ZipFile(zipPath)

                    'ZIP内のエントリを列挙
                    Dim ze As ICSharpCode.SharpZipLib.Zip.ZipEntry
                    For Each ze In zf
                        '情報を表示する
                        MsgBox("出力")
                        If ze.IsFile Then
                            'ファイルのとき 
                            Console.WriteLine("名前 : {0}", ze.Name)
                        ElseIf ze.IsDirectory Then
                            'ディレクトリのとき 
                            Console.WriteLine("ディレクトリ名 : {0}", ze.Name)
                        End If
                    Next
                    '変数宣言
                    Dim ex As New Microsoft.Office.Interop.Excel.Application
                    Dim sh As Microsoft.Office.Interop.Excel.Worksheet
                    Dim wb As Microsoft.Office.Interop.Excel.Workbook

                End If
            ElseIf DataGridView_DocHistory(e.ColumnIndex, e.RowIndex).Value = "取下げ" Then
                '取下げボタンがクリックされた時の処理
                If drlistDoc.Length > 0 Then
                    Dim drDoc As DataRow = drlistDoc(0)
                    drDoc.Delete()
                    daDoc.Update(dtDoc)
                    DataGridView_DocHistory.Rows.RemoveAt(TargetRow)
                End If
            End If
        End If
        DataGridView_DocHistory.ClearSelection()
        con = Nothing
    End Sub

    Private Sub Form_DocApprovalHistory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IO.Directory.Exists(targetDirectory) Then
            IO.Directory.Delete(targetDirectory, True)
        End If
    End Sub
End Class