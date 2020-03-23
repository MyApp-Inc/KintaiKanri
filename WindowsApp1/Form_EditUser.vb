Imports Oracle.ManagedDataAccess.Client

Public Class Form_EditUser
    Dim IdBureau As Integer = 0
    Dim IdDepartment As Integer = 0
    Dim IdDivision As Integer = 0
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
    Private Sub Button_EditUserEnd_Click(sender As Object, e As EventArgs) Handles Button_EditUserEnd.Click
        Me.Close()
    End Sub

    Private Sub Form_EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListView初期化
        ListView_EditUser.Items.Clear()
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        Dim daDivision As New OracleDataAdapter(SQLDivision, con)
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
        'UserTableフィルタリング
        Dim drlistUser As DataRow() = dtUser.Select("user_name IS NOT NULL")
        '社員一覧をListViewに表示して、最後に（新規追加）を表示
        If drlistUser.Length > 0 Then
            For Each dr As DataRow In drlistUser
                Dim ListItem1 As New ListViewItem
                ListItem1.Text = dr("full_name")
                ListView_EditUser.Items.Add(ListItem1)
            Next
        End If
        Dim ListItem2 As New ListViewItem
        ListItem2.Text = "（新規追加）"
        ListView_EditUser.Items.Add(ListItem2)
        'BureauTableフィルタリング
        Dim drlistBureau As DataRow() = dtBureau.Select("is_dummy_flg IS NOT NULL")
        '本部一覧をListView_Bureauに表示
        If drlistBureau.Length > 0 Then
            For Each dr As DataRow In drlistBureau
                Dim BureauName As String = dr("bureau_name")
                ComboBox_EditBureau.Items.Add(BureauName)
            Next
        End If
        con = Nothing
    End Sub

    Private Sub ListView_EditUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_EditUser.SelectedIndexChanged
        If ListView_EditUser.SelectedItems.Count > 0 Then
            'OracleConnectionオブジェクトを生成
            Dim con As New OracleConnection(Constr)
            'SQL文を作成
            Dim SQLUser As String = "Select * FROM tm_kintai_user"
            Dim SQLBureau As String = "Select * FROM tm_kintai_bureau"
            Dim SQLDepartment As String = "Select * FROM tm_kintai_department"
            Dim SQLDivision As String = "Select * FROM tm_kintai_division"
            'DataAdapterオブジェクトを生成
            Dim daUser As New OracleDataAdapter(SQLUser, con)
            Dim daBureau As New OracleDataAdapter(SQLBureau, con)
            Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
            Dim daDivision As New OracleDataAdapter(SQLDivision, con)
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
            '画面右側の表示
            If ListView_EditUser.SelectedItems(0).Text = "（新規追加）" Then
                '社員新規追加
                Button_EditUserAddOrEdit.Text = "追加"
                TextBox_EditUserName.Text = Nothing
                TextBox_EditLastName.Text = Nothing
                TextBox_EditFirstName.Text = Nothing
                TextBox_EditEmployeeNumber.Text = Nothing
                ComboBox_EditRole.SelectedIndex = -1
                ComboBox_EditAdmin.SelectedIndex = -1
                ComboBox_EditBureau.SelectedIndex = -1
                ComboBox_EditDepartment.SelectedIndex = -1
                ComboBox_EditDivision.SelectedIndex = -1
                DateTimePicker_EditStartTime.Value = Date.Parse("2019/01/01 9:00:00")
                DateTimePicker_EditEndTime.Value = Date.Parse("2019/01/01 17:00:00")
                Label_EditICCardStatus.Text = "未登録"
                Button_EditICCard.Text = "ＩＣカード登録"
                IdBureau = 0
                IdDepartment = 0
                IdDivision = 0
            Else
                '社員編集
                Button_EditUserAddOrEdit.Text = "編集"
                'UserTableフィルタリング
                Dim drlistUser As DataRow() = dtUser.Select("full_name = '" + ListView_EditUser.SelectedItems(0).Text + "'")
                If drlistUser.Length > 0 Then
                    For Each dr As DataRow In drlistUser
                        TextBox_EditUserName.Text = dr("user_name")
                        TextBox_EditLastName.Text = dr("full_name").ToString.Substring(0, dr("full_name").ToString.IndexOf("　"))
                        TextBox_EditFirstName.Text = dr("full_name").ToString.Substring(dr("full_name").ToString.IndexOf("　") + 1)
                        TextBox_EditEmployeeNumber.Text = dr("employee_no")
                        ComboBox_EditRole.SelectedIndex = dr("role_kbn")
                        If dr("admin_kbn") = 9 Then
                            ComboBox_EditAdmin.SelectedIndex = 2
                        Else
                            ComboBox_EditAdmin.SelectedIndex = dr("admin_kbn")
                        End If
                        If dr("bureau_no") = 0 Then
                            ComboBox_EditBureau.SelectedItem = "（本部無所属）"
                            IdBureau = 0
                        Else
                            'BureauTableフィルタリング
                            Dim drlistBureau As DataRow() = dtBureau.Select("id_no = '" + dr("bureau_no").ToString + "'")
                            For Each drBureau As DataRow In drlistBureau
                                ComboBox_EditBureau.SelectedItem = drBureau("bureau_name")
                            Next
                        End If
                        If dr("department_no") = 0 Then
                            ComboBox_EditDepartment.SelectedIndex = -1
                            IdDepartment = 0
                        Else
                            'DepartmentTableフィルタリング
                            Dim drlistDepartment As DataRow() = dtDepartment.Select("id_no = '" + dr("department_no").ToString + "'")
                            For Each drDepartment As DataRow In drlistDepartment
                                ComboBox_EditDepartment.SelectedItem = drDepartment("department_name")
                            Next
                        End If
                        If dr("division_no") = 0 Then
                            ComboBox_EditDivision.SelectedIndex = -1
                            IdDivision = 0
                        Else
                            'DivisionTableフィルタリング
                            Dim drlistDivision As DataRow() = dtDivision.Select("id_no = '" + dr("division_no").ToString + "'")
                            For Each drDivision As DataRow In drlistDivision
                                ComboBox_EditDivision.SelectedItem = drDivision("division_name")
                            Next
                        End If
                        DateTimePicker_EditStartTime.Value = dr("start_time")
                        DateTimePicker_EditEndTime.Value = dr("end_time")
                        If dr("iccard_cd") = "0" Then
                            Label_EditICCardStatus.Text = "未登録"
                            Button_EditICCard.Text = "ＩＣカード登録"
                        Else
                            Label_EditICCardStatus.Text = dr("iccard_cd")
                            Button_EditICCard.Text = "ＩＣカード変更"
                        End If
                    Next
                End If
            End If
            con = Nothing
        End If
    End Sub

    Private Sub ComboBox_EditBureau_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_EditBureau.SelectedIndexChanged
        ComboBox_EditDepartment.Items.Clear()
        ComboBox_EditDivision.Items.Clear()
        IdBureau = 0
        If ComboBox_EditBureau.SelectedIndex > -1 Then
            'OracleConnectionオブジェクトを生成
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
            Dim drlistBureau As DataRow() = dtBureau.Select("bureau_name = '" + ComboBox_EditBureau.SelectedItem.ToString + "'")
            For Each drBureau As DataRow In drlistBureau
                'DepartmentTableフィルタリング
                IdBureau = drBureau("id_no")
                Dim drlistDepartment As DataRow() = dtDepartment.Select("upper_group_no = '" + IdBureau.ToString + "'")
                For Each drDepartment As DataRow In drlistDepartment
                    ComboBox_EditDepartment.Items.Add(drDepartment("department_name"))
                Next
            Next
            con = Nothing
        End If
    End Sub

    Private Sub ComboBox_EditDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_EditDepartment.SelectedIndexChanged
        ComboBox_EditDivision.Items.Clear()
        IdDepartment = 0
        If ComboBox_EditDepartment.SelectedIndex > -1 Then
            'OracleConnectionオブジェクトを生成
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
            Dim drlistDepartment As DataRow() = dtDepartment.Select("department_name = '" + ComboBox_EditDepartment.SelectedItem.ToString + "'")
            For Each drDepartment As DataRow In drlistDepartment
                'DivisionTableフィルタリング
                IdDepartment = drDepartment("id_no")
                Dim drlistDivision As DataRow() = dtDivision.Select("upper_group_no = '" + IdDepartment.ToString + "'")
                For Each drDivision As DataRow In drlistDivision
                    ComboBox_EditDivision.Items.Add(drDivision("division_name"))
                Next
            Next
            con = Nothing
        End If
    End Sub

    Private Sub ComboBox_EditDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_EditDivision.SelectedIndexChanged
        IdDivision = 0
        If ComboBox_EditDivision.SelectedIndex > -1 Then
            'OracleConnectionオブジェクトを生成
            Dim con As New OracleConnection(Constr)
            'SQL文を作成
            Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
            Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
            Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
            Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
            'DataAdapterオブジェクトを生成
            Dim daUser As New OracleDataAdapter(SQLUser, con)
            Dim daBureau As New OracleDataAdapter(SQLBureau, con)
            Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
            Dim daDivision As New OracleDataAdapter(SQLDivision, con)
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
            'DepartmentTableフィルタリング
            Dim drlistDivision As DataRow() = dtDivision.Select("division_name = '" + ComboBox_EditDivision.SelectedItem.ToString + "'")
            For Each drDivision As DataRow In drlistDivision
                'DivisionTableフィルタリング
                IdDivision = drDivision("id_no")
            Next
            con = Nothing
        End If
    End Sub

    Private Sub Button_EditUserAddOrEdit_Click(sender As Object, e As EventArgs) Handles Button_EditUserAddOrEdit.Click
        'OracleConnectionオブジェクトを生成
        Dim con As New OracleConnection(Constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        Dim SQLBureau As String = "SELECT * FROM tm_kintai_bureau"
        Dim SQLDepartment As String = "SELECT * FROM tm_kintai_department"
        Dim SQLDivision As String = "SELECT * FROM tm_kintai_division"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        Dim daBureau As New OracleDataAdapter(SQLBureau, con)
        Dim daDepartment As New OracleDataAdapter(SQLDepartment, con)
        Dim daDivision As New OracleDataAdapter(SQLDivision, con)
        'SqlCommandBuilderオブジェクトを生成
        Dim cmdbuilder As New OracleCommandBuilder(daUser)
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
        '所属IDを変数に格納
        If ComboBox_EditBureau.SelectedIndex > -1 Then
            Dim drlist As DataRow() = dtBureau.Select("bureau_name = '" + ComboBox_EditBureau.SelectedItem.ToString + "'")
            For Each dr As DataRow In drlist
                IdBureau = dr("id_no")
            Next
        Else
            IdBureau = 0
        End If
        If ComboBox_EditDepartment.SelectedIndex > -1 Then
            Dim drlist As DataRow() = dtDepartment.Select("department_name = '" + ComboBox_EditDepartment.SelectedItem.ToString + "'")
            For Each dr As DataRow In drlist
                IdDepartment = dr("id_no")
            Next
        Else
            IdDepartment = 0
        End If
        If ComboBox_EditDivision.SelectedIndex > -1 Then
            Dim drlist As DataRow() = dtDivision.Select("division_name = '" + ComboBox_EditDivision.SelectedItem.ToString + "'")
            For Each dr As DataRow In drlist
                IdDivision = dr("id_no")
            Next
        Else
            IdDivision = 0
        End If
        'UserTableデータ処理
        If Button_EditUserAddOrEdit.Text = "追加" Then
            'ユーザー追加処理
            Dim row As DataRow = dtUser.NewRow '追加行を宣言
            row("id_no") = dtUser.Rows.Count + 1
            row("user_name") = TextBox_EditUserName.Text
            row("full_name") = TextBox_EditLastName.Text + "　" + TextBox_EditFirstName.Text
            row("role_kbn") = ComboBox_EditRole.SelectedIndex
            If ComboBox_EditAdmin.SelectedIndex = 2 Then
                row("admin_kbn") = 9
            Else
                row("admin_kbn") = ComboBox_EditAdmin.SelectedIndex
            End If
            row("bureau_no") = IdBureau
            row("department_no") = IdDepartment
            row("division_no") = IdDivision
            row("start_time") = DateTimePicker_EditStartTime.Value
            row("end_time") = DateTimePicker_EditEndTime.Value
            If Label_EditICCardStatus.Text = "未登録" Then
                row("iccard_cd") = "0"
            Else
                row("iccard_cd") = Label_EditICCardStatus.Text
            End If
            row("create_date") = Date.Now
            row("update_date") = Date.Now
            row("create_program") = "KINTAI_KANRI_SYSTEM"
            row("update_program") = "KINTAI_KANRI_SYSTEM"
            row("create_user") = DBName
            row("update_user") = DBName
            row("status_kbn") = 0
            row("employee_no") = TextBox_EditEmployeeNumber.Text
            dtUser.Rows.Add(row)
            daUser.Update(dtUser)
        Else
            'ユーザー編集処理
            Dim drlist As DataRow() = dtUser.Select("full_name = '" + ListView_EditUser.SelectedItems(0).Text + "'")
            For Each dr As DataRow In drlist
                dr("user_name") = TextBox_EditUserName.Text
                dr("full_name") = TextBox_EditLastName.Text + "　" + TextBox_EditFirstName.Text
                dr("role_kbn") = ComboBox_EditRole.SelectedIndex
                If ComboBox_EditAdmin.SelectedIndex = 2 Then
                    dr("admin_kbn") = 9
                Else
                    dr("admin_kbn") = ComboBox_EditAdmin.SelectedIndex
                End If
                dr("bureau_no") = IdBureau
                dr("department_no") = IdDepartment
                dr("division_no") = IdDivision
                dr("start_time") = DateTimePicker_EditStartTime.Value
                dr("end_time") = DateTimePicker_EditEndTime.Value
                If Label_EditICCardStatus.Text = "未登録" Then
                    dr("iccard_cd") = "0"
                Else
                    dr("iccard_cd") = Label_EditICCardStatus.Text
                End If
                dr("update_date") = Date.Now
                dr("update_program") = "KINTAI_KANRI_SYSTEM"
                dr("update_user") = DBName
                dr("employee_no") = TextBox_EditEmployeeNumber.Text
                daUser.Update(dtUser)
            Next
        End If
        'ListView初期化
        ListView_EditUser.Items.Clear()
        'UserTableフィルタリング
        Dim drlistUser As DataRow() = dtUser.Select("user_name IS NOT NULL")
        '社員一覧をListViewに表示して、最後に（新規追加）を表示
        If drlistUser.Length > 0 Then
            For Each dr As DataRow In drlistUser
                Dim ListItem1 As New ListViewItem
                ListItem1.Text = dr("full_name")
                ListView_EditUser.Items.Add(ListItem1)
            Next
        End If
        Dim ListItem2 As New ListViewItem
        ListItem2.Text = "（新規追加）"
        ListView_EditUser.Items.Add(ListItem2)
        Button_EditUserAddOrEdit.Text = "追加"
        TextBox_EditUserName.Text = Nothing
        TextBox_EditLastName.Text = Nothing
        TextBox_EditFirstName.Text = Nothing
        TextBox_EditEmployeeNumber.Text = Nothing
        ComboBox_EditRole.SelectedIndex = -1
        ComboBox_EditAdmin.SelectedIndex = -1
        ComboBox_EditBureau.SelectedIndex = -1
        ComboBox_EditDepartment.SelectedIndex = -1
        ComboBox_EditDivision.SelectedIndex = -1
        DateTimePicker_EditStartTime.Value = Date.Parse("2019/01/01 9:00:00")
        DateTimePicker_EditEndTime.Value = Date.Parse("2019/01/01 17:00:00")
        Label_EditICCardStatus.Text = "未登録"
        Button_EditICCard.Text = "ＩＣカード登録"
        con = Nothing
    End Sub

    Private Sub Button_EditICCard_Click(sender As Object, e As EventArgs) Handles Button_EditICCard.Click
        '----------
        ' 変数定義
        '----------
        Dim pcsc As New clsWinSCard

        '----------------
        ' ボタンを無効化
        '----------------
        Button_EditICCard.Enabled = False

        '------------------------------
        ' タイムアウトする時間(ミリ秒)
        '------------------------------
        pcsc.Timeout_MilliSecond = 1000

        '------------------------------------
        ' FelicaのIDm,PMM、MifareのUIDを取得
        '------------------------------------
        If pcsc.getCardID() Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
            If pcsc.IsFelica Then
                Label_EditICCardStatus.Text = pcsc.IDm
            ElseIf pcsc.IsMifare Then
                Label_EditICCardStatus.Text = pcsc.UID
            End If
        End If

        '----------------
        ' ボタンを有効化
        '----------------
        Button_EditICCard.Enabled = True
    End Sub
End Class