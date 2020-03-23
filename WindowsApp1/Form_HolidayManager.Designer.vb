<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_HolidayManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_HolidayManager))
        Me.DataGridView_HolidayManager = New System.Windows.Forms.DataGridView()
        Me.Column_Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_PreHoliday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_PreVerify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_Holiday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_AfterVerify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button_HolidayManagerClose = New System.Windows.Forms.Button()
        Me.Label_HolidayManagerTitle = New System.Windows.Forms.Label()
        Me.DateTimePicker_HolidayManagerTargetYear = New System.Windows.Forms.DateTimePicker()
        Me.Button_HolidayManagerDisplay = New System.Windows.Forms.Button()
        Me.ListView_HolidayManager = New System.Windows.Forms.ListView()
        Me.ColumnHeader_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Number1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Number2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.DataGridView_HolidayManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_HolidayManager
        '
        Me.DataGridView_HolidayManager.AllowUserToAddRows = False
        Me.DataGridView_HolidayManager.AllowUserToDeleteRows = False
        Me.DataGridView_HolidayManager.AllowUserToOrderColumns = True
        Me.DataGridView_HolidayManager.AllowUserToResizeColumns = False
        Me.DataGridView_HolidayManager.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_HolidayManager.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_HolidayManager.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_HolidayManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_HolidayManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView_HolidayManager.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_HolidayManager.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_HolidayManager.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_HolidayManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_HolidayManager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Group, Me.Column_FullName, Me.Column_PreHoliday, Me.Column_PreVerify, Me.Column_Holiday, Me.Column_AfterVerify})
        Me.DataGridView_HolidayManager.Location = New System.Drawing.Point(339, 62)
        Me.DataGridView_HolidayManager.MultiSelect = False
        Me.DataGridView_HolidayManager.Name = "DataGridView_HolidayManager"
        Me.DataGridView_HolidayManager.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_HolidayManager.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView_HolidayManager.RowTemplate.Height = 60
        Me.DataGridView_HolidayManager.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_HolidayManager.Size = New System.Drawing.Size(970, 400)
        Me.DataGridView_HolidayManager.TabIndex = 4
        '
        'Column_Group
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_Group.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column_Group.FillWeight = 200.0!
        Me.Column_Group.HeaderText = "所属"
        Me.Column_Group.MaxInputLength = 100
        Me.Column_Group.Name = "Column_Group"
        Me.Column_Group.ReadOnly = True
        Me.Column_Group.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column_FullName
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_FullName.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column_FullName.FillWeight = 150.0!
        Me.Column_FullName.HeaderText = "氏名"
        Me.Column_FullName.MaxInputLength = 100
        Me.Column_FullName.Name = "Column_FullName"
        Me.Column_FullName.ReadOnly = True
        Me.Column_FullName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_PreHoliday
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_PreHoliday.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column_PreHoliday.FillWeight = 200.0!
        Me.Column_PreHoliday.HeaderText = "振替休日指示日"
        Me.Column_PreHoliday.MaxInputLength = 100
        Me.Column_PreHoliday.Name = "Column_PreHoliday"
        Me.Column_PreHoliday.ReadOnly = True
        Me.Column_PreHoliday.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_PreHoliday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_PreVerify
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Column_PreVerify.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column_PreVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column_PreVerify.HeaderText = ""
        Me.Column_PreVerify.Name = "Column_PreVerify"
        Me.Column_PreVerify.ReadOnly = True
        Me.Column_PreVerify.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_PreVerify.Text = "確認"
        '
        'Column_Holiday
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_Holiday.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column_Holiday.FillWeight = 200.0!
        Me.Column_Holiday.HeaderText = "実振替休日日"
        Me.Column_Holiday.MaxInputLength = 100
        Me.Column_Holiday.Name = "Column_Holiday"
        Me.Column_Holiday.ReadOnly = True
        Me.Column_Holiday.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Holiday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_AfterVerify
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Column_AfterVerify.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column_AfterVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column_AfterVerify.HeaderText = ""
        Me.Column_AfterVerify.Name = "Column_AfterVerify"
        Me.Column_AfterVerify.ReadOnly = True
        Me.Column_AfterVerify.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_AfterVerify.Text = "確認"
        '
        'Button_HolidayManagerClose
        '
        Me.Button_HolidayManagerClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_HolidayManagerClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_HolidayManagerClose.Location = New System.Drawing.Point(1197, 486)
        Me.Button_HolidayManagerClose.Name = "Button_HolidayManagerClose"
        Me.Button_HolidayManagerClose.Size = New System.Drawing.Size(112, 36)
        Me.Button_HolidayManagerClose.TabIndex = 2
        Me.Button_HolidayManagerClose.Text = "閉じる"
        Me.Button_HolidayManagerClose.UseVisualStyleBackColor = True
        '
        'Label_HolidayManagerTitle
        '
        Me.Label_HolidayManagerTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_HolidayManagerTitle.AutoSize = True
        Me.Label_HolidayManagerTitle.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_HolidayManagerTitle.Location = New System.Drawing.Point(630, 23)
        Me.Label_HolidayManagerTitle.Name = "Label_HolidayManagerTitle"
        Me.Label_HolidayManagerTitle.Size = New System.Drawing.Size(266, 19)
        Me.Label_HolidayManagerTitle.TabIndex = 5
        Me.Label_HolidayManagerTitle.Text = "休日勤務及び振替休日管理表"
        '
        'DateTimePicker_HolidayManagerTargetYear
        '
        Me.DateTimePicker_HolidayManagerTargetYear.CalendarFont = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_HolidayManagerTargetYear.CustomFormat = " yyyy 年"
        Me.DateTimePicker_HolidayManagerTargetYear.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_HolidayManagerTargetYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_HolidayManagerTargetYear.Location = New System.Drawing.Point(75, 14)
        Me.DateTimePicker_HolidayManagerTargetYear.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_HolidayManagerTargetYear.Name = "DateTimePicker_HolidayManagerTargetYear"
        Me.DateTimePicker_HolidayManagerTargetYear.ShowUpDown = True
        Me.DateTimePicker_HolidayManagerTargetYear.Size = New System.Drawing.Size(104, 26)
        Me.DateTimePicker_HolidayManagerTargetYear.TabIndex = 0
        '
        'Button_HolidayManagerDisplay
        '
        Me.Button_HolidayManagerDisplay.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_HolidayManagerDisplay.Location = New System.Drawing.Point(194, 12)
        Me.Button_HolidayManagerDisplay.Name = "Button_HolidayManagerDisplay"
        Me.Button_HolidayManagerDisplay.Size = New System.Drawing.Size(112, 36)
        Me.Button_HolidayManagerDisplay.TabIndex = 1
        Me.Button_HolidayManagerDisplay.Text = "表示"
        Me.Button_HolidayManagerDisplay.UseVisualStyleBackColor = True
        '
        'ListView_HolidayManager
        '
        Me.ListView_HolidayManager.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_HolidayManager.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_Date, Me.ColumnHeader_Number1, Me.ColumnHeader_Number2})
        Me.ListView_HolidayManager.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListView_HolidayManager.FullRowSelect = True
        Me.ListView_HolidayManager.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_HolidayManager.HideSelection = False
        Me.ListView_HolidayManager.Location = New System.Drawing.Point(24, 62)
        Me.ListView_HolidayManager.MultiSelect = False
        Me.ListView_HolidayManager.Name = "ListView_HolidayManager"
        Me.ListView_HolidayManager.ShowGroups = False
        Me.ListView_HolidayManager.Size = New System.Drawing.Size(282, 400)
        Me.ListView_HolidayManager.TabIndex = 3
        Me.ListView_HolidayManager.TabStop = False
        Me.ListView_HolidayManager.UseCompatibleStateImageBehavior = False
        Me.ListView_HolidayManager.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_Date
        '
        Me.ColumnHeader_Date.Text = "日付"
        Me.ColumnHeader_Date.Width = 120
        '
        'ColumnHeader_Number1
        '
        Me.ColumnHeader_Number1.Text = "要確認"
        Me.ColumnHeader_Number1.Width = 70
        '
        'ColumnHeader_Number2
        '
        Me.ColumnHeader_Number2.Text = "確認済"
        Me.ColumnHeader_Number2.Width = 70
        '
        'Form_HolidayManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1330, 534)
        Me.Controls.Add(Me.ListView_HolidayManager)
        Me.Controls.Add(Me.Button_HolidayManagerDisplay)
        Me.Controls.Add(Me.DateTimePicker_HolidayManagerTargetYear)
        Me.Controls.Add(Me.Label_HolidayManagerTitle)
        Me.Controls.Add(Me.Button_HolidayManagerClose)
        Me.Controls.Add(Me.DataGridView_HolidayManager)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_HolidayManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "休日勤務及び振替休日管理"
        CType(Me.DataGridView_HolidayManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_HolidayManager As DataGridView
    Friend WithEvents Button_HolidayManagerClose As Button
    Friend WithEvents Label_HolidayManagerTitle As Label
    Friend WithEvents DateTimePicker_HolidayManagerTargetYear As DateTimePicker
    Friend WithEvents Button_HolidayManagerDisplay As Button
    Friend WithEvents ListView_HolidayManager As ListView
    Friend WithEvents ColumnHeader_Date As ColumnHeader
    Friend WithEvents ColumnHeader_Number1 As ColumnHeader
    Friend WithEvents ColumnHeader_Number2 As ColumnHeader
    Friend WithEvents Column_Group As DataGridViewTextBoxColumn
    Friend WithEvents Column_FullName As DataGridViewTextBoxColumn
    Friend WithEvents Column_PreHoliday As DataGridViewTextBoxColumn
    Friend WithEvents Column_PreVerify As DataGridViewButtonColumn
    Friend WithEvents Column_Holiday As DataGridViewTextBoxColumn
    Friend WithEvents Column_AfterVerify As DataGridViewButtonColumn
End Class
