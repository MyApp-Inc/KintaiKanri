Imports Oracle.ManagedDataAccess.Client
Public Class Form_PublicHoliday
    'CSVファイルのあるフォルダ
    Dim csvDir As String = Environment.CurrentDirectory
    'CSVファイルの名前
    Dim csvFileName As String = "syukujitsu.csv"
    Dim DBName As String = SystemInformation.UserName
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
    Dim conString As String = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=" + csvDir + ";Extensions=asc,csv,tab,txt;"

    Private Sub Button_PublicHolidayClose_Click(sender As Object, e As EventArgs) Handles Button_PublicHolidayClose.Click
        Me.Close()
    End Sub

    Private Sub Button_PublicHolidayImportCSV_Click(sender As Object, e As EventArgs) Handles Button_PublicHolidayImportCSV.Click
        'OracleConnectionオブジェクトを生成
        Dim conCSV As New Odbc.OdbcConnection(conString)
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim commText As String = "SELECT * FROM [" + csvFileName + "]"
        Dim SQLPublic As String = "SELECT * FROM tm_kintai_publicholiday"
        'DataAdapterオブジェクトを生成
        Dim daCSV As New Odbc.OdbcDataAdapter(commText, conCSV)
        Dim daPublic As New OracleDataAdapter(SQLPublic, con)
        'OracleCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daPublic)
        'DataTableに格納する
        Dim dtCSV As New DataTable
        Dim dtPublic As New DataTable()
        'DataTableとデータベースに同期させる
        daCSV.Fill(dtCSV)
        daPublic.Fill(dtPublic)
        'フィルタリングする
        Dim drlistCSV As DataRow() = dtCSV.Select("国民の祝日・休日月日 >= '2019/01/01'")
        If drlistCSV.Length > 0 Then
            For Each drCSV As DataRow In drlistCSV
                Dim TargetDay As String = drCSV("国民の祝日・休日月日").ToString
                Dim TargetName As String = drCSV("国民の祝日・休日名称")
                'フィルタリングする
                Dim drlistPublic As DataRow() = dtPublic.Select("holiday = '" + TargetDay + "'")
                If drlistPublic.Length = 0 Then
                    '追加
                    Dim row As DataRow = dtPublic.NewRow '追加行を宣言
                    row("id_no") = dtPublic.Rows.Count + 1
                    row("holiday") = TargetDay
                    row("holiday_name") = TargetName
                    row("create_date") = Date.Now
                    row("update_date") = Date.Now
                    row("create_program") = "KINTAI_KANRI_SYSTEM"
                    row("update_program") = "KINTAI_KANRI_SYSTEM"
                    row("create_user") = DBName
                    row("update_user") = DBName
                    'テーブルの末尾に追加
                    dtPublic.Rows.Add(row)
                    daPublic.Update(dtPublic)
                Else
                    '変更
                    For Each dr As DataRow In drlistPublic
                        dr("holiday_name") = TargetName
                        dr("update_date") = Date.Now
                        dr("update_program") = "KINTAI_KANRI_SYSTEM"
                        dr("update_user") = DBName
                        daPublic.Update(dtPublic)
                    Next
                End If
            Next
            MsgBox("処理が完了しました。", vbOKOnly, "完了")
        Else
            MsgBox("syukujitsu.csvファイルが見つかりません。処理を終了します。", vbOKOnly, "エラー")
        End If
        conCSV = Nothing
        con = Nothing
    End Sub
End Class