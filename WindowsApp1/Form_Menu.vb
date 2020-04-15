Imports Oracle.ManagedDataAccess.Client

Public Class Form_Menu
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
    Private Sub Button_MenuEnd_Click(sender As Object, e As EventArgs) Handles Button_MenuEnd.Click
        Me.Close()
    End Sub

    Private Sub Button_Menu1_Click(sender As Object, e As EventArgs) Handles Button_Menu1.Click
        'フォームのインスタンスを生成する
        Dim cForm_TimeCard As New Form_TimeCard
        'モーダルでフォームを表示する
        cForm_TimeCard.ShowInTaskbar = False
        cForm_TimeCard.ShowDialog(Me)
    End Sub

    Private Sub Button_Menu2_Click(sender As Object, e As EventArgs) Handles Button_MenuVerify.Click
        'フォームのインスタンスを生成する
        Dim cForm_VerifiedList As New Form_VerifiedList
        'モーダルでフォームを表示する
        cForm_VerifiedList.ShowInTaskbar = False
        cForm_VerifiedList.ShowDialog(Me)
    End Sub

    Private Sub Form_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SqlConnectionオブジェクトを生成
        Dim con As New OracleConnection(constr)
        'SQL文を作成
        Dim SQLUser As String = "SELECT * FROM tm_kintai_user"
        'DataAdapterオブジェクトを生成
        Dim daUser As New OracleDataAdapter(SQLUser, con)
        'DataTableオブジェクトを生成
        Dim dtUser As New DataTable()
        'DataTableとデータベースに同期させる
        daUser.Fill(dtUser)
        'フィルタリングする
        Dim drlistMe As DataRow() = dtUser.Select("user_name = '" + SystemInformation.UserName + "'")
        '検索結果により分岐（UserTableテーブルにデータがあれば、Roleを取得）
        If drlistMe.Length > 0 Then
            For Each drUser As DataRow In drlistMe
                Dim Role As Integer = drUser("role_kbn")
                'Role:0（課員）なら勤怠承認ボタン非活性
                If Role = 0 Then
                    Button_MenuVerify.Enabled = False
                End If
                Dim Admin As Integer = drUser("admin_kbn")
                'Adminの値に応じてボタン非活性
                Select Case Admin
                    Case 0
                        Button_MenuHolidayManager.Enabled = False
                        Button_MenuExportData.Enabled = False
                        Button_MenuEditUser.Enabled = False
                        Button_MenuEditGroup.Enabled = False
                        Button_MenuPublicHoliday.Enabled = False
                    Case 1
                        Button_MenuEditUser.Enabled = False
                        Button_MenuEditGroup.Enabled = False
                    Case 9
                        Button_MenuHolidayManager.Enabled = False
                        Button_MenuExportData.Enabled = False
                End Select
            Next
        End If
        con = Nothing
    End Sub

    Private Sub Button_MenuHolidayManager_Click(sender As Object, e As EventArgs) Handles Button_MenuHolidayManager.Click
        'フォームのインスタンスを生成する
        Dim cForm_HolidayManager As New Form_HolidayManager
        'モーダルでフォームを表示する
        cForm_HolidayManager.ShowInTaskbar = False
        cForm_HolidayManager.ShowDialog(Me)
    End Sub

    Private Sub Button_menu5_Click(sender As Object, e As EventArgs) Handles Button_MenuEditGroup.Click
        'フォームのインスタンスを生成する
        Dim cForm_EditGroup As New Form_EditGroup
        'モーダルでフォームを表示する
        cForm_EditGroup.ShowInTaskbar = False
        cForm_EditGroup.ShowDialog(Me)
    End Sub

    Private Sub Button_menu4_Click(sender As Object, e As EventArgs) Handles Button_MenuEditUser.Click
        'フォームのインスタンスを生成する
        Dim cForm_EditUser As New Form_EditUser
        'モーダルでフォームを表示する
        cForm_EditUser.ShowInTaskbar = False
        cForm_EditUser.ShowDialog(Me)
    End Sub

    Private Sub Button_MenuPublicHoliday_Click(sender As Object, e As EventArgs) Handles Button_MenuPublicHoliday.Click
        'フォームのインスタンスを生成する
        Dim cForm_PublicHoliday As New Form_PublicHoliday
        'モーダルでフォームを表示する
        cForm_PublicHoliday.ShowInTaskbar = False
        cForm_PublicHoliday.ShowDialog(Me)
    End Sub

    Private Sub Button_MenuPrint_Click(sender As Object, e As EventArgs) Handles Button_MenuPrint.Click
        'フォームのインスタンスを生成する
        Dim cForm_Print As New Form_Print
        'モーダルでフォームを表示する
        cForm_Print.ShowInTaskbar = False
        cForm_Print.ShowDialog(Me)
    End Sub

    Private Sub Button_MenuReadICCard_Click(sender As Object, e As EventArgs) Handles Button_MenuReadICCard.Click
        'フォームのインスタンスを生成する
        Dim cForm_ReadICCard As New Form_ReadICCard
        'モーダルでフォームを表示する
        cForm_ReadICCard.ShowInTaskbar = False
        cForm_ReadICCard.ShowDialog(Me)
    End Sub

    Private Sub Button_MenuExportData_Click(sender As Object, e As EventArgs) Handles Button_MenuExportData.Click
        'フォームのインスタンスを生成する
        Dim cForm_ExportData As New Form_ExportData
        'モーダルでフォームを表示する
        cForm_ExportData.ShowInTaskbar = False
        cForm_ExportData.ShowDialog(Me)
    End Sub

    Private Sub Button_DocApproval_Click(sender As Object, e As EventArgs) Handles Button_DocApproval.Click
        'フォームのインスタンスを生成する
        Dim cForm_DocApproval As New Form_DocApproval
        'モーダルでフォームを表示する
        cForm_DocApproval.ShowInTaskbar = False
        cForm_DocApproval.ShowDialog(Me)
    End Sub

    Private Sub Button_DocApprovalList_Click(sender As Object, e As EventArgs) Handles Button_DocApprovalList.Click
        'フォームのインスタンスを生成する
        Dim cForm_DocApprovalList As New Form_DocApprovalList
        'モーダルでフォームを表示する
        cForm_DocApprovalList.ShowInTaskbar = False
        cForm_DocApprovalList.ShowDialog(Me)
    End Sub

    Private Sub Button_MenuCheckTimeCard_Click(sender As Object, e As EventArgs) Handles Button_MenuCheckTimeCard.Click
        'フォームのインスタンスを生成する
        Dim cForm_CheckTimeCard As New Form_CheckTimeCard
        'モーダルでフォームを表示する
        cForm_CheckTimeCard.ShowInTaskbar = False
        cForm_CheckTimeCard.ShowDialog(Me)
    End Sub
End Class