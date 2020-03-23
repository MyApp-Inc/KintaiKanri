Imports Oracle.ManagedDataAccess.Client

Public Class Form_EditGroup
    Dim IdBureau As Integer = 0
    Dim IdDepartment As Integer = 0
    Dim IdDivision As Integer = 0
    Dim IsDummyBureau As Integer = 0
    Dim IsDummyDepartment As Integer = 0
    Dim Flag As Integer = 0
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
    Private Sub Button_EditGroupEnd_Click(sender As Object, e As EventArgs) Handles Button_EditGroupEnd.Click
        Me.Close()
    End Sub

    Private Sub Form_EditGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListView初期化
        ListView_Bureau.Items.Clear()
        ListView_Department.Items.Clear()
        ListView_Division.Items.Clear()
        'SqlConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        'DataAdapterオブジェクトを生成
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        'DataTableオブジェクトを生成
        Dim dtBureau As New DataTable()
        Dim dtDepartment As New DataTable()
        'DataTableとデータベースに同期させる
        daBureau.Fill(dtBureau)
        daDepartment.Fill(dtDepartment)
        'フィルタリング
        Dim drlistBureau As DataRow() = dtBureau.Select("is_dummy_flg >= 0")
        '本部一覧をListView_Bureauに表示して、最後に（新規追加）を表示
        If drlistBureau.Length > 0 Then
            For Each dr As DataRow In drlistBureau
                Dim ListItem1 As New ListViewItem
                ListItem1.Text = dr("bureau_name")
                ListView_Bureau.Items.Add(ListItem1)
            Next
        End If
        Dim ListItem2 As New ListViewItem
        ListItem2.Text = "（新規追加）"
        ListView_Bureau.Items.Add(ListItem2)
        con = Nothing
    End Sub

    Private Sub ListView_Bureau_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Bureau.SelectedIndexChanged
        If ListView_Bureau.SelectedItems.Count > 0 Then
            'ListView初期化
            ListView_Department.Items.Clear()
            ListView_Division.Items.Clear()
            Dim TargetItem As ListViewItem = ListView_Bureau.SelectedItems(0)
            Dim ListItem As New ListViewItem
            If TargetItem.Text = "（新規追加）" Then
                Label_AddOrEdit.Text = "本部を新規追加する"
                TextBox_AddOrEdit.Text = Nothing
                Button_AddOrEdit.Text = "追加"
                IdBureau = 0
                Flag = 11
                Button_Delete.Visible = False
            Else
                Label_AddOrEdit.Text = TargetItem.Text + "の名称を変更する"
                TextBox_AddOrEdit.Text = TargetItem.Text
                Button_AddOrEdit.Text = "変更"
                Flag = 12
                Button_Delete.Visible = true
            End If
            TextBox_AddOrEdit.Visible = True
            Button_AddOrEdit.Visible = True
            'SqlConnectionオブジェクトを生成
            Dim con As New OracleConnection(Constr)
            'SQL文を作成
            Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
            Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
            'DataAdapterオブジェクトを生成
            Dim daBureau As New OracleDataAdapter(SQLBureau, con)
            Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
            'DataTableオブジェクトを生成
            Dim dtBureau As New DataTable()
            Dim dtDepartment As New DataTable()
            'DataTableとデータベースに同期させる
            daBureau.Fill(dtBureau)
            daDepartment.Fill(dtDepartment)
            'BureauTableフィルタリング
            Dim drlistBureau As DataRow() = dtBureau.Select("bureau_name = '" + TargetItem.Text + "'")
            '選択されている本部のIdとダミーフラグを取得
            For Each drBureau As DataRow In drlistBureau
                IdBureau = drBureau("id_no")
                IsDummyBureau = drBureau("is_dummy_flg")
            Next
            'DepartmentTableフィルタリング
            Dim drlistDepartment As DataRow() = dtDepartment.Select("upper_group_no = '" + IdBureau.ToString + "'")
            '部一覧をListView_Departmentに表示して、最後に（新規追加）を表示
            If drlistDepartment.Length > 0 Then
                For Each drDepartment As DataRow In drlistDepartment
                    Dim ListItem1 As New ListViewItem
                    ListItem1.Text = drDepartment("department_name")
                    ListView_Department.Items.Add(ListItem1)
                Next
            End If
            ListItem.Text = "（新規追加）"
            ListView_Department.Items.Add(ListItem)
            con = Nothing
        End If
    End Sub

    Private Sub ListView_Department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Department.SelectedIndexChanged
        If ListView_Department.SelectedItems.Count > 0 Then
            'ListView_Division初期化
            ListView_Division.Items.Clear()
            Dim ListItem As New ListViewItem
            Dim TargetItem As ListViewItem = ListView_Department.SelectedItems(0)
            TextBox_AddOrEdit.Visible = True
            Button_AddOrEdit.Visible = True
            If TargetItem.Text = "（新規追加）" Then
                If IsDummyBureau = 1 Then
                    Label_AddOrEdit.Text = "本部無所属の部を新規追加する"
                Else
                    Label_AddOrEdit.Text = ListView_Bureau.SelectedItems(0).Text + "に所属する部を新規追加する"
                End If
                TextBox_AddOrEdit.Text = Nothing
                Button_AddOrEdit.Text = "追加"
                IdDepartment = 0
                Flag = 21
                Button_Delete.Visible = False
            Else
                Label_AddOrEdit.Text = TargetItem.Text + "の名称を変更する"
                TextBox_AddOrEdit.Text = TargetItem.Text
                Button_AddOrEdit.Text = "変更"
                Flag = 22
                Button_Delete.Visible = True
                'SqlConnectionオブジェクトを生成
                Dim con As New OracleConnection(Constr)
                'SQL文を作成
                Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
                Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
                'DataAdapterオブジェクトを生成
                Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
                Dim daDivision As New OracleDataAdapter(SQLDivision, con)
                'DataTableオブジェクトを生成
                Dim dtDepartment As New DataTable()
                Dim dtDivision As New DataTable()
                'DataTableとデータベースに同期させる
                daDepartment.Fill(dtDepartment)
                daDivision.Fill(dtDivision)
                'DepartmentTableフィルタリング
                Dim drlistDepartment As DataRow() = dtDepartment.Select("department_name = '" + TargetItem.Text + "'")
                '選択されている部のIdとダミーフラグを取得
                For Each drDepartment As DataRow In drlistDepartment
                    IdDepartment = drDepartment("id_no")
                    IsDummyDepartment = drDepartment("is_dummy_flg")
                Next
                'DivisionTableフィルタリング
                Dim drlistDivision As DataRow() = dtDivision.Select("upper_group_no = '" + IdDepartment.ToString + "'")
                '課一覧をListView_Divisionに表示して、最後に（新規追加）を表示
                If drlistDivision.Length > 0 Then
                    For Each drDivision As DataRow In drlistDivision
                        Dim ListItem1 As New ListViewItem
                        ListItem1.Text = drDivision("division_name")
                        ListView_Division.Items.Add(ListItem1)
                    Next
                End If
                ListItem.Text = "（新規追加）"
                ListView_Division.Items.Add(ListItem)
                con = Nothing
            End If
        End If
    End Sub

    Private Sub ListView_Division_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Division.SelectedIndexChanged
        If ListView_Division.SelectedItems.Count > 0 Then
            Dim TargetItem As ListViewItem = ListView_Division.SelectedItems(0)
            TextBox_AddOrEdit.Visible = True
            Button_AddOrEdit.Visible = True
            If TargetItem.Text = "（新規追加）" Then
                If IsDummyDepartment = 1 Then
                    Label_AddOrEdit.Text = ListView_Bureau.SelectedItems(0).Text + "直属の課を新規追加する"
                Else
                    Label_AddOrEdit.Text = ListView_Department.SelectedItems(0).Text + "に所属する課を新規追加する"

                End If
                TextBox_AddOrEdit.Text = Nothing
                Button_AddOrEdit.Text = "追加"
                IdDivision = 0
                Flag = 31
                Button_Delete.Visible = False
            Else
                Label_AddOrEdit.Text = TargetItem.Text + "の名称を変更する"
                TextBox_AddOrEdit.Text = TargetItem.Text
                Button_AddOrEdit.Text = "変更"
                Flag = 32
                Button_Delete.Visible = True
                'SqlConnectionオブジェクトを生成
                Dim con As New OracleConnection(Constr)
                'SQL文を作成
                Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
                'DataAdapterオブジェクトを生成
                Dim daDivision As New OracleDataAdapter(SQLDivision, con)
                'DataTableオブジェクトを生成
                Dim dtDivision As New DataTable()
                'DataTableとデータベースに同期させる
                daDivision.Fill(dtDivision)
                'DivisionTableフィルタリング
                Dim drlistDivision As DataRow() = dtDivision.Select("division_name = '" + TargetItem.Text + "'")
                '選択されている部のIdを取得
                For Each drDivision As DataRow In drlistDivision
                    IdDivision = drDivision("id_no")
                Next
                con = Nothing
            End If
        End If
    End Sub

    Private Sub Button_AddOrEdit_Click(sender As Object, e As EventArgs) Handles Button_AddOrEdit.Click
        'SqlConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
        'DataAdapterオブジェクトを生成
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        Dim daDivision As New OracleDataAdapter(SQLDivision, con)
        'SqlCommandBuilderオブジェクトを生成
        Dim cmdbuilder1 As New OracleCommandBuilder(daBureau)
        Dim cmdbuilder2 As New OracleCommandBuilder(daDepartment)
        Dim cmdbuilder3 As New OracleCommandBuilder(daDivision)
        'DataTableオブジェクトを生成
        Dim dtBureau As New DataTable()
        Dim dtDepartment As New DataTable()
        Dim dtDivision As New DataTable()
        'DataTableとデータベースに同期させる
        daBureau.Fill(dtBureau)
        daDepartment.Fill(dtDepartment)
        daDivision.Fill(dtDivision)
        Select Case Flag
            Case 11
                Dim row As DataRow = dtBureau.NewRow '追加行を宣言
                'IDを採番
                Dim Id As Integer = dtBureau.Rows.Count
                Do
                    Id += 1
                    Dim drlistId As DataRow() = dtBureau.Select("id_no = '" + Id.ToString + "'")
                    If drlistId.Count = 0 Then
                        Exit Do
                    End If
                Loop
                '値をセット
                row("id_no") = Id
                row("bureau_name") = TextBox_AddOrEdit.Text
                If TextBox_AddOrEdit.Text.Substring(0, 1) = "※" Then
                    row("is_dummy_flg") = 1
                Else
                    row("is_dummy_flg") = 0
                End If
                row("create_date") = Date.Now
                row("update_date") = Date.Now
                row("create_program") = "KINTAI_KANRI_SYSTEM"
                row("update_program") = "KINTAI_KANRI_SYSTEM"
                row("create_user") = DBName
                row("update_user") = DBName
                'テーブルの末尾に追加
                dtBureau.Rows.Add(row)
                daBureau.Update(dtBureau)
            Case 21
                Dim row As DataRow = dtDepartment.NewRow '追加行を宣言
                'IDを採番
                Dim Id As Integer = dtDepartment.Rows.Count
                Do
                    Id += 1
                    Dim drlistId As DataRow() = dtDepartment.Select("id_no = '" + Id.ToString + "'")
                    If drlistId.Count = 0 Then
                        Exit Do
                    End If
                Loop
                '値をセット
                row("id_no") = Id
                row("department_name") = TextBox_AddOrEdit.Text
                row("upper_group_no") = IdBureau
                If TextBox_AddOrEdit.Text.Substring(0, 1) = "※" Then
                    row("is_dummy_flg") = 1
                Else
                    row("is_dummy_flg") = 0
                End If
                row("create_date") = Date.Now
                row("update_date") = Date.Now
                row("create_program") = "KINTAI_KANRI_SYSTEM"
                row("update_program") = "KINTAI_KANRI_SYSTEM"
                row("create_user") = DBName
                row("update_user") = DBName
                'テーブルの末尾に追加
                dtDepartment.Rows.Add(row)
                daDepartment.Update(dtDepartment)
            Case 31
                Dim row As DataRow = dtDivision.NewRow '追加行を宣言
                'IDを採番
                Dim Id As Integer = dtDivision.Rows.Count
                Do
                    Id += 1
                    Dim drlistId As DataRow() = dtDivision.Select("id_no = '" + Id.ToString + "'")
                    If drlistId.Count = 0 Then
                        Exit Do
                    End If
                Loop
                '値をセット
                row("id_no") = Id
                row("division_name") = TextBox_AddOrEdit.Text
                row("upper_group_no") = IdDepartment
                row("create_date") = Date.Now
                row("update_date") = Date.Now
                row("create_program") = "KINTAI_KANRI_SYSTEM"
                row("update_program") = "KINTAI_KANRI_SYSTEM"
                row("create_user") = DBName
                row("update_user") = DBName
                'テーブルの末尾に追加
                dtDivision.Rows.Add(row)
                daDivision.Update(dtDivision)
            Case 12
                Dim drlist As DataRow() = dtBureau.Select("id_no = '" + IdBureau.ToString + "'")
                For Each dr As DataRow In drlist
                    If TextBox_AddOrEdit.Text.Substring(0, 1) = "※" Then
                        dr("is_dummy_flg") = 1
                    Else
                        dr("is_dummy_flg") = 0
                    End If
                    dr("bureau_name") = TextBox_AddOrEdit.Text
                    dr("update_date") = Date.Now
                    dr("update_program") = "KINTAI_KANRI_SYSTEM"
                    dr("update_user") = DBName
                    daBureau.Update(dtBureau)
                Next
            Case 22
                Dim drlist As DataRow() = dtDepartment.Select("id_no = '" + IdDepartment.ToString + "'")
                For Each dr As DataRow In drlist
                    If TextBox_AddOrEdit.Text.Substring(0, 1) = "※" Then
                        dr("is_dummy_flg") = 1
                    Else
                        dr("is_dummy_flg") = 0
                    End If
                    dr("department_name") = TextBox_AddOrEdit.Text
                    dr("update_date") = Date.Now
                    dr("update_program") = "KINTAI_KANRI_SYSTEM"
                    dr("update_user") = DBName
                    daDepartment.Update(dtDepartment)
                Next
            Case 32
                Dim drlist As DataRow() = dtDivision.Select("id_no = '" + IdDivision.ToString + "'")
                For Each dr As DataRow In drlist
                    dr("division_name") = TextBox_AddOrEdit.Text
                    dr("update_date") = Date.Now
                    dr("update_program") = "KINTAI_KANRI_SYSTEM"
                    dr("update_user") = DBName
                    daDivision.Update(dtDivision)
                Next
            Case Else
        End Select
        TextBox_AddOrEdit.Text = Nothing
        Label_AddOrEdit.Text = "処理が完了しました"
        'ListView初期化
        ListView_Bureau.Items.Clear()
        ListView_Department.Items.Clear()
        ListView_Division.Items.Clear()
        TextBox_AddOrEdit.Visible = False
        Button_AddOrEdit.Visible = False
        Button_Delete.Visible = False
        'フィルタリング
        Dim drlistBureau As DataRow() = dtBureau.Select("is_dummy_flg >= 0")
        '本部一覧をListView_Bureauに表示して、最後に（新規追加）を表示
        If drlistBureau.Length > 0 Then
            For Each dr As DataRow In drlistBureau
                Dim ListItem1 As New ListViewItem
                ListItem1.Text = dr("bureau_name")
                ListView_Bureau.Items.Add(ListItem1)
            Next
        End If
        Dim ListItem2 As New ListViewItem
        ListItem2.Text = "（新規追加）"
        ListView_Bureau.Items.Add(ListItem2)
        con = Nothing
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        'SqlConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
        'DataAdapterオブジェクトを生成
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        Dim daDivision As New OracleDataAdapter(SQLDivision, con)
        'SqlCommandBuilderオブジェクトを生成
        Dim cmdbuilder1 As New OracleCommandBuilder(daBureau)
        Dim cmdbuilder2 As New OracleCommandBuilder(daDepartment)
        Dim cmdbuilder3 As New OracleCommandBuilder(daDivision)
        'DataTableオブジェクトを生成
        Dim dtBureau As New DataTable()
        Dim dtDepartment As New DataTable()
        Dim dtDivision As New DataTable()
        'DataTableとデータベースに同期させる
        daBureau.Fill(dtBureau)
        daDepartment.Fill(dtDepartment)
        daDivision.Fill(dtDivision)
        Select Case Flag
            Case 12
                Dim drlist As DataRow() = dtBureau.Select("id_no = '" + IdBureau.ToString + "'")
                For Each dr As DataRow In drlist
                    dr.Delete()
                    daBureau.Update(dtBureau)
                Next
            Case 22
                Dim drlist As DataRow() = dtDepartment.Select("id_no = '" + IdDepartment.ToString + "'")
                For Each dr As DataRow In drlist
                    dr.Delete()
                    daDepartment.Update(dtDepartment)
                Next
            Case 32
                Dim drlist As DataRow() = dtDivision.Select("id_no = '" + IdDivision.ToString + "'")
                For Each dr As DataRow In drlist
                    dr.Delete()
                    daDivision.Update(dtDivision)
                Next
        End Select
        TextBox_AddOrEdit.Text = Nothing
        Label_AddOrEdit.Text = "処理が完了しました"
        'ListView初期化
        ListView_Bureau.Items.Clear()
        ListView_Department.Items.Clear()
        ListView_Division.Items.Clear()
        TextBox_AddOrEdit.Visible = False
        Button_AddOrEdit.Visible = False
        Button_Delete.Visible = False
        'フィルタリング
        Dim drlistBureau As DataRow() = dtBureau.Select("is_dummy_flg >= 0")
        '本部一覧をListView_Bureauに表示して、最後に（新規追加）を表示
        If drlistBureau.Length > 0 Then
            For Each dr As DataRow In drlistBureau
                Dim ListItem1 As New ListViewItem
                ListItem1.Text = dr("bureau_name")
                ListView_Bureau.Items.Add(ListItem1)
            Next
        End If
        Dim ListItem2 As New ListViewItem
        ListItem2.Text = "（新規追加）"
        ListView_Bureau.Items.Add(ListItem2)
        con = Nothing
    End Sub
End Class