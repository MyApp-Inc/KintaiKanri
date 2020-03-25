<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EditUser
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("（新規追加）")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_EditUser))
        Me.Button_EditUserEnd = New System.Windows.Forms.Button()
        Me.ListView_EditUser = New System.Windows.Forms.ListView()
        Me.Label_EditUserName = New System.Windows.Forms.Label()
        Me.Label_EditUserTitle = New System.Windows.Forms.Label()
        Me.Label_EditFullName = New System.Windows.Forms.Label()
        Me.Label_EditRole = New System.Windows.Forms.Label()
        Me.Label_EditAdmin = New System.Windows.Forms.Label()
        Me.Label_EditBureau = New System.Windows.Forms.Label()
        Me.Label_EditDepartment = New System.Windows.Forms.Label()
        Me.Label_EditDivision = New System.Windows.Forms.Label()
        Me.Label_EditStartTime = New System.Windows.Forms.Label()
        Me.Label_EditEndTime = New System.Windows.Forms.Label()
        Me.TextBox_EditUserName = New System.Windows.Forms.TextBox()
        Me.TextBox_EditLastName = New System.Windows.Forms.TextBox()
        Me.ComboBox_EditRole = New System.Windows.Forms.ComboBox()
        Me.ComboBox_EditAdmin = New System.Windows.Forms.ComboBox()
        Me.ComboBox_EditBureau = New System.Windows.Forms.ComboBox()
        Me.ComboBox_EditDepartment = New System.Windows.Forms.ComboBox()
        Me.ComboBox_EditDivision = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_EditStartTime = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_EditEndTime = New System.Windows.Forms.DateTimePicker()
        Me.Button_EditUserAddOrEdit = New System.Windows.Forms.Button()
        Me.Label_EditICCard = New System.Windows.Forms.Label()
        Me.Label_EditICCardStatus = New System.Windows.Forms.Label()
        Me.Button_EditICCard = New System.Windows.Forms.Button()
        Me.Label_EditLastName = New System.Windows.Forms.Label()
        Me.Label_EditFirstName = New System.Windows.Forms.Label()
        Me.TextBox_EditFirstName = New System.Windows.Forms.TextBox()
        Me.Label_EditEmployeeNumber = New System.Windows.Forms.Label()
        Me.TextBox_EditEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_EditUserEnd
        '
        Me.Button_EditUserEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_EditUserEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_EditUserEnd.Location = New System.Drawing.Point(692, 591)
        Me.Button_EditUserEnd.Name = "Button_EditUserEnd"
        Me.Button_EditUserEnd.Size = New System.Drawing.Size(112, 36)
        Me.Button_EditUserEnd.TabIndex = 13
        Me.Button_EditUserEnd.Text = "閉じる"
        Me.Button_EditUserEnd.UseVisualStyleBackColor = True
        '
        'ListView_EditUser
        '
        Me.ListView_EditUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_EditUser.FullRowSelect = True
        Me.ListView_EditUser.HideSelection = False
        Me.ListView_EditUser.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView_EditUser.Location = New System.Drawing.Point(12, 49)
        Me.ListView_EditUser.MultiSelect = False
        Me.ListView_EditUser.Name = "ListView_EditUser"
        Me.ListView_EditUser.Size = New System.Drawing.Size(298, 578)
        Me.ListView_EditUser.TabIndex = 14
        Me.ListView_EditUser.UseCompatibleStateImageBehavior = False
        Me.ListView_EditUser.View = System.Windows.Forms.View.List
        '
        'Label_EditUserName
        '
        Me.Label_EditUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditUserName.AutoSize = True
        Me.Label_EditUserName.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditUserName.Location = New System.Drawing.Point(344, 49)
        Me.Label_EditUserName.Name = "Label_EditUserName"
        Me.Label_EditUserName.Size = New System.Drawing.Size(97, 19)
        Me.Label_EditUserName.TabIndex = 16
        Me.Label_EditUserName.Text = "ユーザー名"
        '
        'Label_EditUserTitle
        '
        Me.Label_EditUserTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_EditUserTitle.AutoSize = True
        Me.Label_EditUserTitle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditUserTitle.Location = New System.Drawing.Point(344, 9)
        Me.Label_EditUserTitle.Name = "Label_EditUserTitle"
        Me.Label_EditUserTitle.Size = New System.Drawing.Size(137, 19)
        Me.Label_EditUserTitle.TabIndex = 15
        Me.Label_EditUserTitle.Text = "社員データ管理"
        '
        'Label_EditFullName
        '
        Me.Label_EditFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditFullName.AutoSize = True
        Me.Label_EditFullName.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditFullName.Location = New System.Drawing.Point(344, 90)
        Me.Label_EditFullName.Name = "Label_EditFullName"
        Me.Label_EditFullName.Size = New System.Drawing.Size(49, 19)
        Me.Label_EditFullName.TabIndex = 17
        Me.Label_EditFullName.Text = "氏名"
        '
        'Label_EditRole
        '
        Me.Label_EditRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditRole.AutoSize = True
        Me.Label_EditRole.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditRole.Location = New System.Drawing.Point(344, 172)
        Me.Label_EditRole.Name = "Label_EditRole"
        Me.Label_EditRole.Size = New System.Drawing.Size(49, 19)
        Me.Label_EditRole.TabIndex = 21
        Me.Label_EditRole.Text = "役職"
        '
        'Label_EditAdmin
        '
        Me.Label_EditAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditAdmin.AutoSize = True
        Me.Label_EditAdmin.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditAdmin.Location = New System.Drawing.Point(344, 213)
        Me.Label_EditAdmin.Name = "Label_EditAdmin"
        Me.Label_EditAdmin.Size = New System.Drawing.Size(115, 19)
        Me.Label_EditAdmin.TabIndex = 22
        Me.Label_EditAdmin.Text = "システム権限"
        '
        'Label_EditBureau
        '
        Me.Label_EditBureau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditBureau.AutoSize = True
        Me.Label_EditBureau.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditBureau.Location = New System.Drawing.Point(344, 254)
        Me.Label_EditBureau.Name = "Label_EditBureau"
        Me.Label_EditBureau.Size = New System.Drawing.Size(89, 19)
        Me.Label_EditBureau.TabIndex = 23
        Me.Label_EditBureau.Text = "所属本部"
        '
        'Label_EditDepartment
        '
        Me.Label_EditDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditDepartment.AutoSize = True
        Me.Label_EditDepartment.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditDepartment.Location = New System.Drawing.Point(344, 295)
        Me.Label_EditDepartment.Name = "Label_EditDepartment"
        Me.Label_EditDepartment.Size = New System.Drawing.Size(69, 19)
        Me.Label_EditDepartment.TabIndex = 24
        Me.Label_EditDepartment.Text = "所属部"
        '
        'Label_EditDivision
        '
        Me.Label_EditDivision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditDivision.AutoSize = True
        Me.Label_EditDivision.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditDivision.Location = New System.Drawing.Point(344, 336)
        Me.Label_EditDivision.Name = "Label_EditDivision"
        Me.Label_EditDivision.Size = New System.Drawing.Size(69, 19)
        Me.Label_EditDivision.TabIndex = 25
        Me.Label_EditDivision.Text = "所属課"
        '
        'Label_EditStartTime
        '
        Me.Label_EditStartTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditStartTime.AutoSize = True
        Me.Label_EditStartTime.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditStartTime.Location = New System.Drawing.Point(344, 377)
        Me.Label_EditStartTime.Name = "Label_EditStartTime"
        Me.Label_EditStartTime.Size = New System.Drawing.Size(129, 19)
        Me.Label_EditStartTime.TabIndex = 26
        Me.Label_EditStartTime.Text = "勤務開始時刻"
        '
        'Label_EditEndTime
        '
        Me.Label_EditEndTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditEndTime.AutoSize = True
        Me.Label_EditEndTime.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditEndTime.Location = New System.Drawing.Point(344, 418)
        Me.Label_EditEndTime.Name = "Label_EditEndTime"
        Me.Label_EditEndTime.Size = New System.Drawing.Size(129, 19)
        Me.Label_EditEndTime.TabIndex = 27
        Me.Label_EditEndTime.Text = "勤務終了時刻"
        '
        'TextBox_EditUserName
        '
        Me.TextBox_EditUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_EditUserName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_EditUserName.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox_EditUserName.Location = New System.Drawing.Point(506, 48)
        Me.TextBox_EditUserName.MaxLength = 8
        Me.TextBox_EditUserName.Name = "TextBox_EditUserName"
        Me.TextBox_EditUserName.Size = New System.Drawing.Size(298, 23)
        Me.TextBox_EditUserName.TabIndex = 0
        '
        'TextBox_EditLastName
        '
        Me.TextBox_EditLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_EditLastName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_EditLastName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TextBox_EditLastName.Location = New System.Drawing.Point(537, 88)
        Me.TextBox_EditLastName.MaxLength = 50
        Me.TextBox_EditLastName.Name = "TextBox_EditLastName"
        Me.TextBox_EditLastName.Size = New System.Drawing.Size(113, 23)
        Me.TextBox_EditLastName.TabIndex = 1
        '
        'ComboBox_EditRole
        '
        Me.ComboBox_EditRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_EditRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_EditRole.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox_EditRole.FormattingEnabled = True
        Me.ComboBox_EditRole.Items.AddRange(New Object() {"課員・部員", "課長", "部長", "本部長", "管理本部長"})
        Me.ComboBox_EditRole.Location = New System.Drawing.Point(506, 167)
        Me.ComboBox_EditRole.Name = "ComboBox_EditRole"
        Me.ComboBox_EditRole.Size = New System.Drawing.Size(298, 24)
        Me.ComboBox_EditRole.TabIndex = 4
        '
        'ComboBox_EditAdmin
        '
        Me.ComboBox_EditAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_EditAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_EditAdmin.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox_EditAdmin.FormattingEnabled = True
        Me.ComboBox_EditAdmin.Items.AddRange(New Object() {"一般", "人事管理者", "システム管理者", "テストユーザー"})
        Me.ComboBox_EditAdmin.Location = New System.Drawing.Point(506, 209)
        Me.ComboBox_EditAdmin.Name = "ComboBox_EditAdmin"
        Me.ComboBox_EditAdmin.Size = New System.Drawing.Size(298, 24)
        Me.ComboBox_EditAdmin.TabIndex = 5
        '
        'ComboBox_EditBureau
        '
        Me.ComboBox_EditBureau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_EditBureau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_EditBureau.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox_EditBureau.FormattingEnabled = True
        Me.ComboBox_EditBureau.Location = New System.Drawing.Point(506, 251)
        Me.ComboBox_EditBureau.Name = "ComboBox_EditBureau"
        Me.ComboBox_EditBureau.Size = New System.Drawing.Size(298, 24)
        Me.ComboBox_EditBureau.TabIndex = 6
        '
        'ComboBox_EditDepartment
        '
        Me.ComboBox_EditDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_EditDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_EditDepartment.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox_EditDepartment.FormattingEnabled = True
        Me.ComboBox_EditDepartment.Location = New System.Drawing.Point(506, 293)
        Me.ComboBox_EditDepartment.Name = "ComboBox_EditDepartment"
        Me.ComboBox_EditDepartment.Size = New System.Drawing.Size(298, 24)
        Me.ComboBox_EditDepartment.TabIndex = 7
        '
        'ComboBox_EditDivision
        '
        Me.ComboBox_EditDivision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_EditDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_EditDivision.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox_EditDivision.FormattingEnabled = True
        Me.ComboBox_EditDivision.Location = New System.Drawing.Point(506, 335)
        Me.ComboBox_EditDivision.Name = "ComboBox_EditDivision"
        Me.ComboBox_EditDivision.Size = New System.Drawing.Size(298, 24)
        Me.ComboBox_EditDivision.TabIndex = 8
        '
        'DateTimePicker_EditStartTime
        '
        Me.DateTimePicker_EditStartTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_EditStartTime.CustomFormat = " H 時 mm 分"
        Me.DateTimePicker_EditStartTime.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_EditStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_EditStartTime.Location = New System.Drawing.Point(506, 377)
        Me.DateTimePicker_EditStartTime.Name = "DateTimePicker_EditStartTime"
        Me.DateTimePicker_EditStartTime.ShowUpDown = True
        Me.DateTimePicker_EditStartTime.Size = New System.Drawing.Size(298, 23)
        Me.DateTimePicker_EditStartTime.TabIndex = 9
        Me.DateTimePicker_EditStartTime.Value = New Date(2019, 1, 1, 9, 0, 0, 0)
        '
        'DateTimePicker_EditEndTime
        '
        Me.DateTimePicker_EditEndTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_EditEndTime.CustomFormat = " H 時 mm 分"
        Me.DateTimePicker_EditEndTime.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_EditEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_EditEndTime.Location = New System.Drawing.Point(506, 418)
        Me.DateTimePicker_EditEndTime.Name = "DateTimePicker_EditEndTime"
        Me.DateTimePicker_EditEndTime.ShowUpDown = True
        Me.DateTimePicker_EditEndTime.Size = New System.Drawing.Size(298, 23)
        Me.DateTimePicker_EditEndTime.TabIndex = 10
        Me.DateTimePicker_EditEndTime.Value = New Date(2019, 1, 1, 17, 0, 0, 0)
        '
        'Button_EditUserAddOrEdit
        '
        Me.Button_EditUserAddOrEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_EditUserAddOrEdit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_EditUserAddOrEdit.Location = New System.Drawing.Point(692, 508)
        Me.Button_EditUserAddOrEdit.Name = "Button_EditUserAddOrEdit"
        Me.Button_EditUserAddOrEdit.Size = New System.Drawing.Size(112, 36)
        Me.Button_EditUserAddOrEdit.TabIndex = 12
        Me.Button_EditUserAddOrEdit.Text = "追加"
        Me.Button_EditUserAddOrEdit.UseVisualStyleBackColor = True
        '
        'Label_EditICCard
        '
        Me.Label_EditICCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditICCard.AutoSize = True
        Me.Label_EditICCard.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditICCard.Location = New System.Drawing.Point(344, 459)
        Me.Label_EditICCard.Name = "Label_EditICCard"
        Me.Label_EditICCard.Size = New System.Drawing.Size(77, 19)
        Me.Label_EditICCard.TabIndex = 28
        Me.Label_EditICCard.Text = "ＩＣカード"
        '
        'Label_EditICCardStatus
        '
        Me.Label_EditICCardStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditICCardStatus.AutoSize = True
        Me.Label_EditICCardStatus.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditICCardStatus.Location = New System.Drawing.Point(502, 459)
        Me.Label_EditICCardStatus.Name = "Label_EditICCardStatus"
        Me.Label_EditICCardStatus.Size = New System.Drawing.Size(59, 16)
        Me.Label_EditICCardStatus.TabIndex = 29
        Me.Label_EditICCardStatus.Text = "未登録"
        '
        'Button_EditICCard
        '
        Me.Button_EditICCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_EditICCard.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_EditICCard.Location = New System.Drawing.Point(692, 451)
        Me.Button_EditICCard.Name = "Button_EditICCard"
        Me.Button_EditICCard.Size = New System.Drawing.Size(112, 36)
        Me.Button_EditICCard.TabIndex = 11
        Me.Button_EditICCard.Text = "ＩＣカード登録"
        Me.Button_EditICCard.UseVisualStyleBackColor = True
        '
        'Label_EditLastName
        '
        Me.Label_EditLastName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditLastName.AutoSize = True
        Me.Label_EditLastName.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditLastName.Location = New System.Drawing.Point(502, 89)
        Me.Label_EditLastName.Name = "Label_EditLastName"
        Me.Label_EditLastName.Size = New System.Drawing.Size(29, 19)
        Me.Label_EditLastName.TabIndex = 18
        Me.Label_EditLastName.Text = "姓"
        '
        'Label_EditFirstName
        '
        Me.Label_EditFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditFirstName.AutoSize = True
        Me.Label_EditFirstName.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditFirstName.Location = New System.Drawing.Point(656, 90)
        Me.Label_EditFirstName.Name = "Label_EditFirstName"
        Me.Label_EditFirstName.Size = New System.Drawing.Size(29, 19)
        Me.Label_EditFirstName.TabIndex = 19
        Me.Label_EditFirstName.Text = "名"
        '
        'TextBox_EditFirstName
        '
        Me.TextBox_EditFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_EditFirstName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_EditFirstName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.TextBox_EditFirstName.Location = New System.Drawing.Point(691, 88)
        Me.TextBox_EditFirstName.MaxLength = 50
        Me.TextBox_EditFirstName.Name = "TextBox_EditFirstName"
        Me.TextBox_EditFirstName.Size = New System.Drawing.Size(113, 23)
        Me.TextBox_EditFirstName.TabIndex = 2
        '
        'Label_EditEmployeeNumber
        '
        Me.Label_EditEmployeeNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_EditEmployeeNumber.AutoSize = True
        Me.Label_EditEmployeeNumber.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditEmployeeNumber.Location = New System.Drawing.Point(344, 131)
        Me.Label_EditEmployeeNumber.Name = "Label_EditEmployeeNumber"
        Me.Label_EditEmployeeNumber.Size = New System.Drawing.Size(89, 19)
        Me.Label_EditEmployeeNumber.TabIndex = 20
        Me.Label_EditEmployeeNumber.Text = "社員番号"
        '
        'TextBox_EditEmployeeNumber
        '
        Me.TextBox_EditEmployeeNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_EditEmployeeNumber.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_EditEmployeeNumber.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox_EditEmployeeNumber.Location = New System.Drawing.Point(506, 126)
        Me.TextBox_EditEmployeeNumber.MaxLength = 8
        Me.TextBox_EditEmployeeNumber.Name = "TextBox_EditEmployeeNumber"
        Me.TextBox_EditEmployeeNumber.Size = New System.Drawing.Size(298, 23)
        Me.TextBox_EditEmployeeNumber.TabIndex = 3
        '
        'Form_EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(823, 639)
        Me.Controls.Add(Me.TextBox_EditEmployeeNumber)
        Me.Controls.Add(Me.Label_EditEmployeeNumber)
        Me.Controls.Add(Me.Label_EditFirstName)
        Me.Controls.Add(Me.TextBox_EditFirstName)
        Me.Controls.Add(Me.Label_EditLastName)
        Me.Controls.Add(Me.Button_EditICCard)
        Me.Controls.Add(Me.Label_EditICCardStatus)
        Me.Controls.Add(Me.Label_EditICCard)
        Me.Controls.Add(Me.Button_EditUserAddOrEdit)
        Me.Controls.Add(Me.DateTimePicker_EditEndTime)
        Me.Controls.Add(Me.DateTimePicker_EditStartTime)
        Me.Controls.Add(Me.ComboBox_EditDivision)
        Me.Controls.Add(Me.ComboBox_EditDepartment)
        Me.Controls.Add(Me.ComboBox_EditBureau)
        Me.Controls.Add(Me.ComboBox_EditAdmin)
        Me.Controls.Add(Me.ComboBox_EditRole)
        Me.Controls.Add(Me.TextBox_EditLastName)
        Me.Controls.Add(Me.TextBox_EditUserName)
        Me.Controls.Add(Me.Label_EditEndTime)
        Me.Controls.Add(Me.Label_EditStartTime)
        Me.Controls.Add(Me.Label_EditDivision)
        Me.Controls.Add(Me.Label_EditDepartment)
        Me.Controls.Add(Me.Label_EditBureau)
        Me.Controls.Add(Me.Label_EditAdmin)
        Me.Controls.Add(Me.Label_EditRole)
        Me.Controls.Add(Me.Label_EditFullName)
        Me.Controls.Add(Me.Label_EditUserTitle)
        Me.Controls.Add(Me.Label_EditUserName)
        Me.Controls.Add(Me.ListView_EditUser)
        Me.Controls.Add(Me.Button_EditUserEnd)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form_EditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "社員データ管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_EditUserEnd As Button
    Friend WithEvents ListView_EditUser As ListView
    Friend WithEvents Label_EditUserName As Label
    Friend WithEvents Label_EditUserTitle As Label
    Friend WithEvents Label_EditFullName As Label
    Friend WithEvents Label_EditRole As Label
    Friend WithEvents Label_EditAdmin As Label
    Friend WithEvents Label_EditBureau As Label
    Friend WithEvents Label_EditDepartment As Label
    Friend WithEvents Label_EditDivision As Label
    Friend WithEvents Label_EditStartTime As Label
    Friend WithEvents Label_EditEndTime As Label
    Friend WithEvents TextBox_EditUserName As TextBox
    Friend WithEvents TextBox_EditLastName As TextBox
    Friend WithEvents ComboBox_EditRole As ComboBox
    Friend WithEvents ComboBox_EditAdmin As ComboBox
    Friend WithEvents ComboBox_EditBureau As ComboBox
    Friend WithEvents ComboBox_EditDepartment As ComboBox
    Friend WithEvents ComboBox_EditDivision As ComboBox
    Friend WithEvents DateTimePicker_EditStartTime As DateTimePicker
    Friend WithEvents DateTimePicker_EditEndTime As DateTimePicker
    Friend WithEvents Button_EditUserAddOrEdit As Button
    Friend WithEvents Label_EditICCard As Label
    Friend WithEvents Label_EditICCardStatus As Label
    Friend WithEvents Button_EditICCard As Button
    Friend WithEvents Label_EditLastName As Label
    Friend WithEvents Label_EditFirstName As Label
    Friend WithEvents TextBox_EditFirstName As TextBox
    Friend WithEvents Label_EditEmployeeNumber As Label
    Friend WithEvents TextBox_EditEmployeeNumber As TextBox
End Class
