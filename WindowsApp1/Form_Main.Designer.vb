<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.Button_End = New System.Windows.Forms.Button()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_UserName = New System.Windows.Forms.Label()
        Me.Label_Start = New System.Windows.Forms.Label()
        Me.Label_Today = New System.Windows.Forms.Label()
        Me.Label_StartTime = New System.Windows.Forms.Label()
        Me.Label_Now = New System.Windows.Forms.Label()
        Me.Label_NowTime = New System.Windows.Forms.Label()
        Me.Timer_NowTime = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Menu = New System.Windows.Forms.Button()
        Me.Button_TestT = New System.Windows.Forms.Button()
        Me.Button_TestH = New System.Windows.Forms.Button()
        Me.Button_ShibataS = New System.Windows.Forms.Button()
        Me.DataGridView_Status = New System.Windows.Forms.DataGridView()
        Me.Column_FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Sttatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_MainMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Update = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer_ReloadStatus = New System.Windows.Forms.Timer(Me.components)
        Me.Label_StatusReloadTime = New System.Windows.Forms.Label()
        Me.Button_ReloadStatus = New System.Windows.Forms.Button()
        Me.TextBox_MainMessage = New System.Windows.Forms.TextBox()
        Me.Button_MainMessage = New System.Windows.Forms.Button()
        Me.Label_MainMessage = New System.Windows.Forms.Label()
        Me.Label_StatusNow = New System.Windows.Forms.Label()
        Me.RadioButton_Shimbashi = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Minatomirai = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Satellite = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Exit = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Meeting = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Other = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Break = New System.Windows.Forms.RadioButton()
        Me.Timer_MouseCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Notification = New System.Windows.Forms.Label()
        Me.NotifyIcon_Main = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Settings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_End = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox_TaskTray = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_End
        '
        Me.Button_End.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_End.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_End.Location = New System.Drawing.Point(1087, 588)
        Me.Button_End.Name = "Button_End"
        Me.Button_End.Size = New System.Drawing.Size(112, 36)
        Me.Button_End.TabIndex = 11
        Me.Button_End.Text = "終了（退勤）"
        Me.Button_End.UseVisualStyleBackColor = True
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(22, 21)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(176, 22)
        Me.Label_Title.TabIndex = 13
        Me.Label_Title.Text = "勤怠管理システム"
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(237, 24)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(97, 19)
        Me.Label_Name.TabIndex = 14
        Me.Label_Name.Text = "氏名ラベル"
        '
        'Label_UserName
        '
        Me.Label_UserName.AutoSize = True
        Me.Label_UserName.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_UserName.ForeColor = System.Drawing.Color.Black
        Me.Label_UserName.Location = New System.Drawing.Point(237, 66)
        Me.Label_UserName.Name = "Label_UserName"
        Me.Label_UserName.Size = New System.Drawing.Size(64, 19)
        Me.Label_UserName.TabIndex = 16
        Me.Label_UserName.Text = "UserN"
        '
        'Label_Start
        '
        Me.Label_Start.AutoSize = True
        Me.Label_Start.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Start.Location = New System.Drawing.Point(22, 124)
        Me.Label_Start.Name = "Label_Start"
        Me.Label_Start.Size = New System.Drawing.Size(129, 19)
        Me.Label_Start.TabIndex = 17
        Me.Label_Start.Text = "勤務開始時刻"
        '
        'Label_Today
        '
        Me.Label_Today.AutoSize = True
        Me.Label_Today.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Today.Location = New System.Drawing.Point(23, 66)
        Me.Label_Today.Name = "Label_Today"
        Me.Label_Today.Size = New System.Drawing.Size(90, 16)
        Me.Label_Today.TabIndex = 15
        Me.Label_Today.Text = "今日の日付"
        '
        'Label_StartTime
        '
        Me.Label_StartTime.AutoSize = True
        Me.Label_StartTime.BackColor = System.Drawing.Color.Black
        Me.Label_StartTime.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_StartTime.ForeColor = System.Drawing.Color.Lime
        Me.Label_StartTime.Location = New System.Drawing.Point(26, 163)
        Me.Label_StartTime.Name = "Label_StartTime"
        Me.Label_StartTime.Size = New System.Drawing.Size(87, 32)
        Me.Label_StartTime.TabIndex = 19
        Me.Label_StartTime.Text = "12:34"
        '
        'Label_Now
        '
        Me.Label_Now.AutoSize = True
        Me.Label_Now.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Now.Location = New System.Drawing.Point(237, 124)
        Me.Label_Now.Name = "Label_Now"
        Me.Label_Now.Size = New System.Drawing.Size(89, 19)
        Me.Label_Now.TabIndex = 18
        Me.Label_Now.Text = "現在時刻"
        '
        'Label_NowTime
        '
        Me.Label_NowTime.AutoSize = True
        Me.Label_NowTime.BackColor = System.Drawing.Color.Black
        Me.Label_NowTime.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NowTime.ForeColor = System.Drawing.Color.Cyan
        Me.Label_NowTime.Location = New System.Drawing.Point(239, 163)
        Me.Label_NowTime.Name = "Label_NowTime"
        Me.Label_NowTime.Size = New System.Drawing.Size(87, 32)
        Me.Label_NowTime.TabIndex = 20
        Me.Label_NowTime.Text = "12:34"
        '
        'Timer_NowTime
        '
        Me.Timer_NowTime.Enabled = True
        Me.Timer_NowTime.Interval = 1000
        '
        'Button_Menu
        '
        Me.Button_Menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Menu.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Menu.Location = New System.Drawing.Point(956, 588)
        Me.Button_Menu.Name = "Button_Menu"
        Me.Button_Menu.Size = New System.Drawing.Size(112, 36)
        Me.Button_Menu.TabIndex = 10
        Me.Button_Menu.Text = "各種機能"
        Me.Button_Menu.UseVisualStyleBackColor = True
        '
        'Button_TestT
        '
        Me.Button_TestT.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_TestT.Location = New System.Drawing.Point(289, 58)
        Me.Button_TestT.Name = "Button_TestT"
        Me.Button_TestT.Size = New System.Drawing.Size(112, 36)
        Me.Button_TestT.TabIndex = 25
        Me.Button_TestT.Text = "テスト太郎"
        Me.Button_TestT.UseVisualStyleBackColor = True
        Me.Button_TestT.Visible = False
        '
        'Button_TestH
        '
        Me.Button_TestH.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_TestH.Location = New System.Drawing.Point(289, 100)
        Me.Button_TestH.Name = "Button_TestH"
        Me.Button_TestH.Size = New System.Drawing.Size(112, 36)
        Me.Button_TestH.TabIndex = 26
        Me.Button_TestH.Text = "テスト機能"
        Me.Button_TestH.UseVisualStyleBackColor = True
        Me.Button_TestH.Visible = False
        '
        'Button_ShibataS
        '
        Me.Button_ShibataS.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ShibataS.Location = New System.Drawing.Point(289, 16)
        Me.Button_ShibataS.Name = "Button_ShibataS"
        Me.Button_ShibataS.Size = New System.Drawing.Size(112, 36)
        Me.Button_ShibataS.TabIndex = 24
        Me.Button_ShibataS.Text = "Oracle"
        Me.Button_ShibataS.UseVisualStyleBackColor = True
        Me.Button_ShibataS.Visible = False
        '
        'DataGridView_Status
        '
        Me.DataGridView_Status.AllowUserToAddRows = False
        Me.DataGridView_Status.AllowUserToDeleteRows = False
        Me.DataGridView_Status.AllowUserToResizeColumns = False
        Me.DataGridView_Status.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_Status.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView_Status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Status.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Status.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView_Status.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_Status.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridView_Status.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Status.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Status.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_FullName, Me.Column_Sttatus, Me.Column_MainMessage, Me.Column_Update})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Status.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView_Status.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridView_Status.Location = New System.Drawing.Point(422, 58)
        Me.DataGridView_Status.MultiSelect = False
        Me.DataGridView_Status.Name = "DataGridView_Status"
        Me.DataGridView_Status.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Status.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView_Status.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_Status.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView_Status.RowTemplate.Height = 21
        Me.DataGridView_Status.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Status.Size = New System.Drawing.Size(777, 502)
        Me.DataGridView_Status.TabIndex = 12
        '
        'Column_FullName
        '
        Me.Column_FullName.FillWeight = 60.0!
        Me.Column_FullName.HeaderText = "氏名"
        Me.Column_FullName.MaxInputLength = 20
        Me.Column_FullName.Name = "Column_FullName"
        Me.Column_FullName.ReadOnly = True
        Me.Column_FullName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Sttatus
        '
        Me.Column_Sttatus.FillWeight = 70.0!
        Me.Column_Sttatus.HeaderText = "現在の状況"
        Me.Column_Sttatus.MaxInputLength = 20
        Me.Column_Sttatus.Name = "Column_Sttatus"
        Me.Column_Sttatus.ReadOnly = True
        Me.Column_Sttatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Sttatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_MainMessage
        '
        Me.Column_MainMessage.FillWeight = 120.0!
        Me.Column_MainMessage.HeaderText = "メッセージ"
        Me.Column_MainMessage.MaxInputLength = 30
        Me.Column_MainMessage.Name = "Column_MainMessage"
        Me.Column_MainMessage.ReadOnly = True
        Me.Column_MainMessage.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_MainMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Update
        '
        Me.Column_Update.FillWeight = 70.0!
        Me.Column_Update.HeaderText = "最終更新日時"
        Me.Column_Update.MaxInputLength = 50
        Me.Column_Update.Name = "Column_Update"
        Me.Column_Update.ReadOnly = True
        Me.Column_Update.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Timer_ReloadStatus
        '
        Me.Timer_ReloadStatus.Interval = 60000
        '
        'Label_StatusReloadTime
        '
        Me.Label_StatusReloadTime.AutoSize = True
        Me.Label_StatusReloadTime.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_StatusReloadTime.Location = New System.Drawing.Point(419, 27)
        Me.Label_StatusReloadTime.Name = "Label_StatusReloadTime"
        Me.Label_StatusReloadTime.Size = New System.Drawing.Size(162, 16)
        Me.Label_StatusReloadTime.TabIndex = 23
        Me.Label_StatusReloadTime.Text = "HH:mm:ss現在の状況"
        '
        'Button_ReloadStatus
        '
        Me.Button_ReloadStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ReloadStatus.Enabled = False
        Me.Button_ReloadStatus.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ReloadStatus.Location = New System.Drawing.Point(1087, 12)
        Me.Button_ReloadStatus.Name = "Button_ReloadStatus"
        Me.Button_ReloadStatus.Size = New System.Drawing.Size(112, 36)
        Me.Button_ReloadStatus.TabIndex = 9
        Me.Button_ReloadStatus.Text = "更新"
        Me.Button_ReloadStatus.UseVisualStyleBackColor = True
        '
        'TextBox_MainMessage
        '
        Me.TextBox_MainMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_MainMessage.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_MainMessage.Location = New System.Drawing.Point(26, 588)
        Me.TextBox_MainMessage.MaxLength = 20
        Me.TextBox_MainMessage.Name = "TextBox_MainMessage"
        Me.TextBox_MainMessage.Size = New System.Drawing.Size(250, 23)
        Me.TextBox_MainMessage.TabIndex = 7
        '
        'Button_MainMessage
        '
        Me.Button_MainMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_MainMessage.Enabled = False
        Me.Button_MainMessage.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MainMessage.Location = New System.Drawing.Point(289, 581)
        Me.Button_MainMessage.Name = "Button_MainMessage"
        Me.Button_MainMessage.Size = New System.Drawing.Size(112, 36)
        Me.Button_MainMessage.TabIndex = 8
        Me.Button_MainMessage.Text = "送信"
        Me.Button_MainMessage.UseVisualStyleBackColor = True
        '
        'Label_MainMessage
        '
        Me.Label_MainMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_MainMessage.AutoSize = True
        Me.Label_MainMessage.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_MainMessage.Location = New System.Drawing.Point(28, 556)
        Me.Label_MainMessage.Name = "Label_MainMessage"
        Me.Label_MainMessage.Size = New System.Drawing.Size(210, 19)
        Me.Label_MainMessage.TabIndex = 22
        Me.Label_MainMessage.Text = "メッセージ（20文字以内）"
        '
        'Label_StatusNow
        '
        Me.Label_StatusNow.AutoSize = True
        Me.Label_StatusNow.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_StatusNow.Location = New System.Drawing.Point(23, 215)
        Me.Label_StatusNow.Name = "Label_StatusNow"
        Me.Label_StatusNow.Size = New System.Drawing.Size(106, 19)
        Me.Label_StatusNow.TabIndex = 21
        Me.Label_StatusNow.Text = "現在の状況"
        '
        'RadioButton_Shimbashi
        '
        Me.RadioButton_Shimbashi.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Shimbashi.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton_Shimbashi.Location = New System.Drawing.Point(26, 246)
        Me.RadioButton_Shimbashi.Name = "RadioButton_Shimbashi"
        Me.RadioButton_Shimbashi.Size = New System.Drawing.Size(168, 36)
        Me.RadioButton_Shimbashi.TabIndex = 0
        Me.RadioButton_Shimbashi.Text = "出勤（新橋）"
        Me.RadioButton_Shimbashi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Shimbashi.UseVisualStyleBackColor = True
        '
        'RadioButton_Minatomirai
        '
        Me.RadioButton_Minatomirai.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Minatomirai.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton_Minatomirai.Location = New System.Drawing.Point(233, 246)
        Me.RadioButton_Minatomirai.Name = "RadioButton_Minatomirai"
        Me.RadioButton_Minatomirai.Size = New System.Drawing.Size(168, 36)
        Me.RadioButton_Minatomirai.TabIndex = 1
        Me.RadioButton_Minatomirai.Text = "出勤（みなとみらい）"
        Me.RadioButton_Minatomirai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Minatomirai.UseVisualStyleBackColor = True
        '
        'RadioButton_Satellite
        '
        Me.RadioButton_Satellite.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Satellite.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton_Satellite.Location = New System.Drawing.Point(26, 302)
        Me.RadioButton_Satellite.Name = "RadioButton_Satellite"
        Me.RadioButton_Satellite.Size = New System.Drawing.Size(168, 36)
        Me.RadioButton_Satellite.TabIndex = 2
        Me.RadioButton_Satellite.Text = "出勤（サテライト）"
        Me.RadioButton_Satellite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Satellite.UseVisualStyleBackColor = True
        '
        'RadioButton_Exit
        '
        Me.RadioButton_Exit.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Exit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton_Exit.Location = New System.Drawing.Point(233, 362)
        Me.RadioButton_Exit.Name = "RadioButton_Exit"
        Me.RadioButton_Exit.Size = New System.Drawing.Size(168, 36)
        Me.RadioButton_Exit.TabIndex = 5
        Me.RadioButton_Exit.Text = "外出・出張"
        Me.RadioButton_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Exit.UseVisualStyleBackColor = True
        '
        'RadioButton_Meeting
        '
        Me.RadioButton_Meeting.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Meeting.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton_Meeting.Location = New System.Drawing.Point(26, 362)
        Me.RadioButton_Meeting.Name = "RadioButton_Meeting"
        Me.RadioButton_Meeting.Size = New System.Drawing.Size(168, 36)
        Me.RadioButton_Meeting.TabIndex = 4
        Me.RadioButton_Meeting.Text = "会議・打合せ"
        Me.RadioButton_Meeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Meeting.UseVisualStyleBackColor = True
        '
        'RadioButton_Other
        '
        Me.RadioButton_Other.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Other.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton_Other.Location = New System.Drawing.Point(233, 302)
        Me.RadioButton_Other.Name = "RadioButton_Other"
        Me.RadioButton_Other.Size = New System.Drawing.Size(168, 36)
        Me.RadioButton_Other.TabIndex = 3
        Me.RadioButton_Other.Text = "出勤（その他）"
        Me.RadioButton_Other.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Other.UseVisualStyleBackColor = True
        '
        'RadioButton_Break
        '
        Me.RadioButton_Break.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton_Break.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RadioButton_Break.Location = New System.Drawing.Point(26, 422)
        Me.RadioButton_Break.Name = "RadioButton_Break"
        Me.RadioButton_Break.Size = New System.Drawing.Size(168, 36)
        Me.RadioButton_Break.TabIndex = 6
        Me.RadioButton_Break.Text = "食事・休憩"
        Me.RadioButton_Break.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton_Break.UseVisualStyleBackColor = True
        '
        'Timer_MouseCheck
        '
        Me.Timer_MouseCheck.Enabled = True
        Me.Timer_MouseCheck.Interval = 60000
        '
        'Label_Notification
        '
        Me.Label_Notification.AutoSize = True
        Me.Label_Notification.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Notification.ForeColor = System.Drawing.Color.Red
        Me.Label_Notification.Location = New System.Drawing.Point(617, 25)
        Me.Label_Notification.Name = "Label_Notification"
        Me.Label_Notification.Size = New System.Drawing.Size(141, 16)
        Me.Label_Notification.TabIndex = 27
        Me.Label_Notification.Text = "承認待ち申請：n件"
        Me.Label_Notification.Visible = False
        '
        'NotifyIcon_Main
        '
        Me.NotifyIcon_Main.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon_Main.BalloonTipText = "勤怠管理システムがタスクトレイに格納されました。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "もう一度表示するには、このアイコンをダブルクリックしてください。"
        Me.NotifyIcon_Main.BalloonTipTitle = "勤怠管理システム最小化"
        Me.NotifyIcon_Main.ContextMenuStrip = Me.ContextMenuStrip_Settings
        Me.NotifyIcon_Main.Icon = CType(resources.GetObject("NotifyIcon_Main.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Main.Text = "勤怠管理システム"
        Me.NotifyIcon_Main.Visible = True
        '
        'ContextMenuStrip_Settings
        '
        Me.ContextMenuStrip_Settings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_End})
        Me.ContextMenuStrip_Settings.Name = "ContextMenuStrip_Settings"
        Me.ContextMenuStrip_Settings.Size = New System.Drawing.Size(149, 26)
        Me.ContextMenuStrip_Settings.Text = "機能"
        '
        'ToolStripMenuItem_End
        '
        Me.ToolStripMenuItem_End.Name = "ToolStripMenuItem_End"
        Me.ToolStripMenuItem_End.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripMenuItem_End.Text = "終了（退勤）"
        Me.ToolStripMenuItem_End.ToolTipText = "勤怠管理システムを終了し、退勤時刻を打刻します。"
        '
        'CheckBox_TaskTray
        '
        Me.CheckBox_TaskTray.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox_TaskTray.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_TaskTray.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_TaskTray.Location = New System.Drawing.Point(864, 12)
        Me.CheckBox_TaskTray.Name = "CheckBox_TaskTray"
        Me.CheckBox_TaskTray.Size = New System.Drawing.Size(204, 36)
        Me.CheckBox_TaskTray.TabIndex = 28
        Me.CheckBox_TaskTray.Text = "最小化でタスクトレイ常駐"
        Me.CheckBox_TaskTray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_TaskTray.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1211, 629)
        Me.Controls.Add(Me.CheckBox_TaskTray)
        Me.Controls.Add(Me.Label_Notification)
        Me.Controls.Add(Me.Label_MainMessage)
        Me.Controls.Add(Me.Button_MainMessage)
        Me.Controls.Add(Me.TextBox_MainMessage)
        Me.Controls.Add(Me.Button_ReloadStatus)
        Me.Controls.Add(Me.Label_StatusReloadTime)
        Me.Controls.Add(Me.RadioButton_Break)
        Me.Controls.Add(Me.DataGridView_Status)
        Me.Controls.Add(Me.RadioButton_Other)
        Me.Controls.Add(Me.RadioButton_Meeting)
        Me.Controls.Add(Me.RadioButton_Exit)
        Me.Controls.Add(Me.RadioButton_Satellite)
        Me.Controls.Add(Me.RadioButton_Minatomirai)
        Me.Controls.Add(Me.RadioButton_Shimbashi)
        Me.Controls.Add(Me.Label_StatusNow)
        Me.Controls.Add(Me.Button_ShibataS)
        Me.Controls.Add(Me.Button_TestH)
        Me.Controls.Add(Me.Button_TestT)
        Me.Controls.Add(Me.Button_Menu)
        Me.Controls.Add(Me.Label_NowTime)
        Me.Controls.Add(Me.Label_Now)
        Me.Controls.Add(Me.Label_StartTime)
        Me.Controls.Add(Me.Label_Today)
        Me.Controls.Add(Me.Label_Start)
        Me.Controls.Add(Me.Label_UserName)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Button_End)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "勤怠管理システム"
        CType(Me.DataGridView_Status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Settings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_End As Button
    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_UserName As Label
    Friend WithEvents Label_Start As Label
    Friend WithEvents Label_Today As Label
    Friend WithEvents Label_StartTime As Label
    Friend WithEvents Label_Now As Label
    Friend WithEvents Label_NowTime As Label
    Friend WithEvents Timer_NowTime As Timer
    Friend WithEvents Button_Menu As Button
    Friend WithEvents Button_TestT As Button
    Friend WithEvents Button_TestH As Button
    Friend WithEvents Button_ShibataS As Button
    Friend WithEvents DataGridView_Status As DataGridView
    Friend WithEvents Timer_ReloadStatus As Timer
    Friend WithEvents Label_StatusReloadTime As Label
    Friend WithEvents Button_ReloadStatus As Button
    Friend WithEvents TextBox_MainMessage As TextBox
    Friend WithEvents Button_MainMessage As Button
    Friend WithEvents Label_MainMessage As Label
    Friend WithEvents Label_StatusNow As Label
    Friend WithEvents RadioButton_Shimbashi As RadioButton
    Friend WithEvents RadioButton_Minatomirai As RadioButton
    Friend WithEvents RadioButton_Satellite As RadioButton
    Friend WithEvents RadioButton_Exit As RadioButton
    Friend WithEvents RadioButton_Meeting As RadioButton
    Friend WithEvents RadioButton_Other As RadioButton
    Friend WithEvents RadioButton_Break As RadioButton
    Friend WithEvents Timer_MouseCheck As Timer
    Friend WithEvents Label_Notification As Label
    Friend WithEvents Column_FullName As DataGridViewTextBoxColumn
    Friend WithEvents Column_Sttatus As DataGridViewTextBoxColumn
    Friend WithEvents Column_MainMessage As DataGridViewTextBoxColumn
    Friend WithEvents Column_Update As DataGridViewTextBoxColumn
    Friend WithEvents NotifyIcon_Main As NotifyIcon
    Friend WithEvents ContextMenuStrip_Settings As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_End As ToolStripMenuItem
    Friend WithEvents CheckBox_TaskTray As CheckBox
End Class
