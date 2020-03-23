<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TimeCard
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TimeCard))
        Me.Label_TimeCardName = New System.Windows.Forms.Label()
        Me.Button_TimeCardEnd = New System.Windows.Forms.Button()
        Me.Button_TimeCardDisplay = New System.Windows.Forms.Button()
        Me.DataGridView_TimeCard = New System.Windows.Forms.DataGridView()
        Me.Column_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_ExtraWorking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Holiday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Verified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label_TimeCardEdit = New System.Windows.Forms.Label()
        Me.Label_TimeCardEditDate = New System.Windows.Forms.Label()
        Me.Label_TimeCardEditStartTime = New System.Windows.Forms.Label()
        Me.Label_TimeCardEditEndTime = New System.Windows.Forms.Label()
        Me.DateTimePicker_StartTime = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_EndTime = New System.Windows.Forms.DateTimePicker()
        Me.Button_TimeCardEdit = New System.Windows.Forms.Button()
        Me.Label_TimeCardEditBreakTime = New System.Windows.Forms.Label()
        Me.Label_TimeCardEditReason = New System.Windows.Forms.Label()
        Me.TextBox_ReasonOfWorking = New System.Windows.Forms.TextBox()
        Me.Label_TimeCardEditHoliday = New System.Windows.Forms.Label()
        Me.DateTimePicker_Holiday = New System.Windows.Forms.DateTimePicker()
        Me.Label_ReportHoliday = New System.Windows.Forms.Label()
        Me.Label_ExecutedHoliday = New System.Windows.Forms.Label()
        Me.DateTimePicker_ExecutedHoliday = New System.Windows.Forms.DateTimePicker()
        Me.Button_ReportHoliday = New System.Windows.Forms.Button()
        Me.DateTimePicker_TimeCard = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_BreakTime = New System.Windows.Forms.DateTimePicker()
        Me.Label_TimeCardEditOverTime = New System.Windows.Forms.Label()
        Me.Label_OverTimeSum = New System.Windows.Forms.Label()
        Me.Label_Tomorrow = New System.Windows.Forms.Label()
        Me.Label_TimeCardReasonAlart = New System.Windows.Forms.Label()
        Me.Button_TimeCardCancel = New System.Windows.Forms.Button()
        CType(Me.DataGridView_TimeCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_TimeCardName
        '
        Me.Label_TimeCardName.AutoSize = True
        Me.Label_TimeCardName.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardName.Location = New System.Drawing.Point(23, 26)
        Me.Label_TimeCardName.Name = "Label_TimeCardName"
        Me.Label_TimeCardName.Size = New System.Drawing.Size(76, 15)
        Me.Label_TimeCardName.TabIndex = 13
        Me.Label_TimeCardName.Text = "氏名ラベル"
        '
        'Button_TimeCardEnd
        '
        Me.Button_TimeCardEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_TimeCardEnd.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_TimeCardEnd.Location = New System.Drawing.Point(1231, 558)
        Me.Button_TimeCardEnd.Name = "Button_TimeCardEnd"
        Me.Button_TimeCardEnd.Size = New System.Drawing.Size(90, 30)
        Me.Button_TimeCardEnd.TabIndex = 11
        Me.Button_TimeCardEnd.Text = "閉じる"
        Me.Button_TimeCardEnd.UseVisualStyleBackColor = True
        '
        'Button_TimeCardDisplay
        '
        Me.Button_TimeCardDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_TimeCardDisplay.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_TimeCardDisplay.Location = New System.Drawing.Point(923, 19)
        Me.Button_TimeCardDisplay.Name = "Button_TimeCardDisplay"
        Me.Button_TimeCardDisplay.Size = New System.Drawing.Size(90, 30)
        Me.Button_TimeCardDisplay.TabIndex = 1
        Me.Button_TimeCardDisplay.Text = "表示"
        Me.Button_TimeCardDisplay.UseVisualStyleBackColor = True
        '
        'DataGridView_TimeCard
        '
        Me.DataGridView_TimeCard.AllowUserToAddRows = False
        Me.DataGridView_TimeCard.AllowUserToDeleteRows = False
        Me.DataGridView_TimeCard.AllowUserToResizeColumns = False
        Me.DataGridView_TimeCard.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_TimeCard.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_TimeCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_TimeCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_TimeCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView_TimeCard.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_TimeCard.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_TimeCard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_TimeCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_TimeCard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Date, Me.Column_StartTime, Me.Column_EndTime, Me.Column_ExtraWorking, Me.Column_Holiday, Me.Column_Verified})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_TimeCard.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView_TimeCard.Location = New System.Drawing.Point(26, 67)
        Me.DataGridView_TimeCard.MultiSelect = False
        Me.DataGridView_TimeCard.Name = "DataGridView_TimeCard"
        Me.DataGridView_TimeCard.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_TimeCard.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView_TimeCard.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_TimeCard.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView_TimeCard.RowTemplate.Height = 26
        Me.DataGridView_TimeCard.Size = New System.Drawing.Size(987, 518)
        Me.DataGridView_TimeCard.TabIndex = 12
        '
        'Column_Date
        '
        Me.Column_Date.HeaderText = "日付"
        Me.Column_Date.MaxInputLength = 100
        Me.Column_Date.Name = "Column_Date"
        Me.Column_Date.ReadOnly = True
        Me.Column_Date.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_StartTime
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_StartTime.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column_StartTime.HeaderText = "勤務開始"
        Me.Column_StartTime.MaxInputLength = 100
        Me.Column_StartTime.Name = "Column_StartTime"
        Me.Column_StartTime.ReadOnly = True
        Me.Column_StartTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_EndTime
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_EndTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column_EndTime.HeaderText = "勤務終了"
        Me.Column_EndTime.MaxInputLength = 100
        Me.Column_EndTime.Name = "Column_EndTime"
        Me.Column_EndTime.ReadOnly = True
        Me.Column_EndTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_EndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_ExtraWorking
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_ExtraWorking.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column_ExtraWorking.FillWeight = 250.0!
        Me.Column_ExtraWorking.HeaderText = "時間外勤務申請内容"
        Me.Column_ExtraWorking.MaxInputLength = 150
        Me.Column_ExtraWorking.Name = "Column_ExtraWorking"
        Me.Column_ExtraWorking.ReadOnly = True
        Me.Column_ExtraWorking.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_ExtraWorking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Holiday
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_Holiday.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column_Holiday.FillWeight = 250.0!
        Me.Column_Holiday.HeaderText = "休日勤務・振替休日申請内容"
        Me.Column_Holiday.MaxInputLength = 100
        Me.Column_Holiday.Name = "Column_Holiday"
        Me.Column_Holiday.ReadOnly = True
        Me.Column_Holiday.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Holiday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Verified
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_Verified.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column_Verified.FillWeight = 150.0!
        Me.Column_Verified.HeaderText = "承認状況"
        Me.Column_Verified.MaxInputLength = 100
        Me.Column_Verified.Name = "Column_Verified"
        Me.Column_Verified.ReadOnly = True
        Me.Column_Verified.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Verified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label_TimeCardEdit
        '
        Me.Label_TimeCardEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEdit.AutoSize = True
        Me.Label_TimeCardEdit.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEdit.Location = New System.Drawing.Point(1019, 20)
        Me.Label_TimeCardEdit.Name = "Label_TimeCardEdit"
        Me.Label_TimeCardEdit.Size = New System.Drawing.Size(160, 15)
        Me.Label_TimeCardEdit.TabIndex = 15
        Me.Label_TimeCardEdit.Text = "時間外・休日勤務申請"
        '
        'Label_TimeCardEditDate
        '
        Me.Label_TimeCardEditDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEditDate.AutoSize = True
        Me.Label_TimeCardEditDate.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEditDate.Location = New System.Drawing.Point(1019, 54)
        Me.Label_TimeCardEditDate.Name = "Label_TimeCardEditDate"
        Me.Label_TimeCardEditDate.Size = New System.Drawing.Size(197, 15)
        Me.Label_TimeCardEditDate.TabIndex = 16
        Me.Label_TimeCardEditDate.Text = "申請する日付を左表から選択"
        '
        'Label_TimeCardEditStartTime
        '
        Me.Label_TimeCardEditStartTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEditStartTime.AutoSize = True
        Me.Label_TimeCardEditStartTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEditStartTime.Location = New System.Drawing.Point(1020, 89)
        Me.Label_TimeCardEditStartTime.Name = "Label_TimeCardEditStartTime"
        Me.Label_TimeCardEditStartTime.Size = New System.Drawing.Size(153, 15)
        Me.Label_TimeCardEditStartTime.TabIndex = 17
        Me.Label_TimeCardEditStartTime.Text = "勤務開始（予定）時刻"
        Me.Label_TimeCardEditStartTime.Visible = False
        '
        'Label_TimeCardEditEndTime
        '
        Me.Label_TimeCardEditEndTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEditEndTime.AutoSize = True
        Me.Label_TimeCardEditEndTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEditEndTime.Location = New System.Drawing.Point(1020, 121)
        Me.Label_TimeCardEditEndTime.Name = "Label_TimeCardEditEndTime"
        Me.Label_TimeCardEditEndTime.Size = New System.Drawing.Size(153, 15)
        Me.Label_TimeCardEditEndTime.TabIndex = 18
        Me.Label_TimeCardEditEndTime.Text = "勤務終了（予定）時刻"
        Me.Label_TimeCardEditEndTime.Visible = False
        '
        'DateTimePicker_StartTime
        '
        Me.DateTimePicker_StartTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_StartTime.CalendarFont = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_StartTime.CustomFormat = " H 時 mm 分"
        Me.DateTimePicker_StartTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_StartTime.Location = New System.Drawing.Point(1200, 83)
        Me.DateTimePicker_StartTime.Name = "DateTimePicker_StartTime"
        Me.DateTimePicker_StartTime.ShowUpDown = True
        Me.DateTimePicker_StartTime.Size = New System.Drawing.Size(121, 22)
        Me.DateTimePicker_StartTime.TabIndex = 2
        Me.DateTimePicker_StartTime.Value = New Date(2019, 10, 24, 0, 0, 0, 0)
        Me.DateTimePicker_StartTime.Visible = False
        '
        'DateTimePicker_EndTime
        '
        Me.DateTimePicker_EndTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_EndTime.CalendarFont = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_EndTime.CustomFormat = " H 時 mm 分"
        Me.DateTimePicker_EndTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_EndTime.Location = New System.Drawing.Point(1200, 115)
        Me.DateTimePicker_EndTime.Name = "DateTimePicker_EndTime"
        Me.DateTimePicker_EndTime.ShowUpDown = True
        Me.DateTimePicker_EndTime.Size = New System.Drawing.Size(121, 22)
        Me.DateTimePicker_EndTime.TabIndex = 3
        Me.DateTimePicker_EndTime.Value = New Date(2019, 10, 24, 0, 0, 0, 0)
        Me.DateTimePicker_EndTime.Visible = False
        '
        'Button_TimeCardEdit
        '
        Me.Button_TimeCardEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_TimeCardEdit.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_TimeCardEdit.Location = New System.Drawing.Point(1230, 354)
        Me.Button_TimeCardEdit.Name = "Button_TimeCardEdit"
        Me.Button_TimeCardEdit.Size = New System.Drawing.Size(90, 30)
        Me.Button_TimeCardEdit.TabIndex = 8
        Me.Button_TimeCardEdit.Text = "申請"
        Me.Button_TimeCardEdit.UseVisualStyleBackColor = True
        Me.Button_TimeCardEdit.Visible = False
        '
        'Label_TimeCardEditBreakTime
        '
        Me.Label_TimeCardEditBreakTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEditBreakTime.AutoSize = True
        Me.Label_TimeCardEditBreakTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEditBreakTime.Location = New System.Drawing.Point(1019, 156)
        Me.Label_TimeCardEditBreakTime.Name = "Label_TimeCardEditBreakTime"
        Me.Label_TimeCardEditBreakTime.Size = New System.Drawing.Size(71, 15)
        Me.Label_TimeCardEditBreakTime.TabIndex = 19
        Me.Label_TimeCardEditBreakTime.Text = "休憩時間"
        Me.Label_TimeCardEditBreakTime.Visible = False
        '
        'Label_TimeCardEditReason
        '
        Me.Label_TimeCardEditReason.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEditReason.AutoSize = True
        Me.Label_TimeCardEditReason.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEditReason.Location = New System.Drawing.Point(1019, 190)
        Me.Label_TimeCardEditReason.Name = "Label_TimeCardEditReason"
        Me.Label_TimeCardEditReason.Size = New System.Drawing.Size(182, 15)
        Me.Label_TimeCardEditReason.TabIndex = 20
        Me.Label_TimeCardEditReason.Text = "業務内容及び理由（必須）"
        Me.Label_TimeCardEditReason.Visible = False
        '
        'TextBox_ReasonOfWorking
        '
        Me.TextBox_ReasonOfWorking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ReasonOfWorking.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_ReasonOfWorking.Location = New System.Drawing.Point(1021, 219)
        Me.TextBox_ReasonOfWorking.MaxLength = 200
        Me.TextBox_ReasonOfWorking.Multiline = True
        Me.TextBox_ReasonOfWorking.Name = "TextBox_ReasonOfWorking"
        Me.TextBox_ReasonOfWorking.Size = New System.Drawing.Size(299, 77)
        Me.TextBox_ReasonOfWorking.TabIndex = 6
        Me.TextBox_ReasonOfWorking.Visible = False
        '
        'Label_TimeCardEditHoliday
        '
        Me.Label_TimeCardEditHoliday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEditHoliday.AutoSize = True
        Me.Label_TimeCardEditHoliday.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEditHoliday.Location = New System.Drawing.Point(1019, 322)
        Me.Label_TimeCardEditHoliday.Name = "Label_TimeCardEditHoliday"
        Me.Label_TimeCardEditHoliday.Size = New System.Drawing.Size(119, 15)
        Me.Label_TimeCardEditHoliday.TabIndex = 21
        Me.Label_TimeCardEditHoliday.Text = "振替休日指示日"
        Me.Label_TimeCardEditHoliday.Visible = False
        '
        'DateTimePicker_Holiday
        '
        Me.DateTimePicker_Holiday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_Holiday.CalendarFont = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_Holiday.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_Holiday.Location = New System.Drawing.Point(1160, 316)
        Me.DateTimePicker_Holiday.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_Holiday.Name = "DateTimePicker_Holiday"
        Me.DateTimePicker_Holiday.Size = New System.Drawing.Size(160, 22)
        Me.DateTimePicker_Holiday.TabIndex = 7
        Me.DateTimePicker_Holiday.Visible = False
        '
        'Label_ReportHoliday
        '
        Me.Label_ReportHoliday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ReportHoliday.AutoSize = True
        Me.Label_ReportHoliday.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ReportHoliday.Location = New System.Drawing.Point(1020, 420)
        Me.Label_ReportHoliday.Name = "Label_ReportHoliday"
        Me.Label_ReportHoliday.Size = New System.Drawing.Size(135, 15)
        Me.Label_ReportHoliday.TabIndex = 23
        Me.Label_ReportHoliday.Text = "振替休日実施報告"
        Me.Label_ReportHoliday.Visible = False
        '
        'Label_ExecutedHoliday
        '
        Me.Label_ExecutedHoliday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ExecutedHoliday.AutoSize = True
        Me.Label_ExecutedHoliday.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ExecutedHoliday.Location = New System.Drawing.Point(1020, 451)
        Me.Label_ExecutedHoliday.Name = "Label_ExecutedHoliday"
        Me.Label_ExecutedHoliday.Size = New System.Drawing.Size(103, 15)
        Me.Label_ExecutedHoliday.TabIndex = 24
        Me.Label_ExecutedHoliday.Text = "実振替休日日"
        Me.Label_ExecutedHoliday.Visible = False
        '
        'DateTimePicker_ExecutedHoliday
        '
        Me.DateTimePicker_ExecutedHoliday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_ExecutedHoliday.CalendarFont = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExecutedHoliday.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExecutedHoliday.Location = New System.Drawing.Point(1161, 445)
        Me.DateTimePicker_ExecutedHoliday.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_ExecutedHoliday.Name = "DateTimePicker_ExecutedHoliday"
        Me.DateTimePicker_ExecutedHoliday.Size = New System.Drawing.Size(160, 22)
        Me.DateTimePicker_ExecutedHoliday.TabIndex = 9
        Me.DateTimePicker_ExecutedHoliday.Visible = False
        '
        'Button_ReportHoliday
        '
        Me.Button_ReportHoliday.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ReportHoliday.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ReportHoliday.Location = New System.Drawing.Point(1231, 483)
        Me.Button_ReportHoliday.Name = "Button_ReportHoliday"
        Me.Button_ReportHoliday.Size = New System.Drawing.Size(90, 30)
        Me.Button_ReportHoliday.TabIndex = 10
        Me.Button_ReportHoliday.Text = "実施報告"
        Me.Button_ReportHoliday.UseVisualStyleBackColor = True
        Me.Button_ReportHoliday.Visible = False
        '
        'DateTimePicker_TimeCard
        '
        Me.DateTimePicker_TimeCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_TimeCard.CalendarFont = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_TimeCard.CustomFormat = " yyyy 年 M 月"
        Me.DateTimePicker_TimeCard.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_TimeCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_TimeCard.Location = New System.Drawing.Point(765, 21)
        Me.DateTimePicker_TimeCard.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_TimeCard.Name = "DateTimePicker_TimeCard"
        Me.DateTimePicker_TimeCard.ShowUpDown = True
        Me.DateTimePicker_TimeCard.Size = New System.Drawing.Size(142, 22)
        Me.DateTimePicker_TimeCard.TabIndex = 0
        '
        'DateTimePicker_BreakTime
        '
        Me.DateTimePicker_BreakTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_BreakTime.CalendarFont = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_BreakTime.CustomFormat = " H 時間 mm 分"
        Me.DateTimePicker_BreakTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_BreakTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_BreakTime.Location = New System.Drawing.Point(1183, 149)
        Me.DateTimePicker_BreakTime.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_BreakTime.Name = "DateTimePicker_BreakTime"
        Me.DateTimePicker_BreakTime.ShowUpDown = True
        Me.DateTimePicker_BreakTime.Size = New System.Drawing.Size(137, 22)
        Me.DateTimePicker_BreakTime.TabIndex = 5
        Me.DateTimePicker_BreakTime.Value = New Date(2019, 1, 1, 1, 0, 0, 0)
        Me.DateTimePicker_BreakTime.Visible = False
        '
        'Label_TimeCardEditOverTime
        '
        Me.Label_TimeCardEditOverTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardEditOverTime.AutoSize = True
        Me.Label_TimeCardEditOverTime.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardEditOverTime.ForeColor = System.Drawing.Color.Blue
        Me.Label_TimeCardEditOverTime.Location = New System.Drawing.Point(1020, 354)
        Me.Label_TimeCardEditOverTime.Name = "Label_TimeCardEditOverTime"
        Me.Label_TimeCardEditOverTime.Size = New System.Drawing.Size(167, 15)
        Me.Label_TimeCardEditOverTime.TabIndex = 22
        Me.Label_TimeCardEditOverTime.Text = "残業時間 ： 0時間00分"
        Me.Label_TimeCardEditOverTime.Visible = False
        '
        'Label_OverTimeSum
        '
        Me.Label_OverTimeSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_OverTimeSum.AutoSize = True
        Me.Label_OverTimeSum.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_OverTimeSum.Location = New System.Drawing.Point(504, 26)
        Me.Label_OverTimeSum.Name = "Label_OverTimeSum"
        Me.Label_OverTimeSum.Size = New System.Drawing.Size(232, 15)
        Me.Label_OverTimeSum.TabIndex = 14
        Me.Label_OverTimeSum.Text = "当月の残業時間合計：0時間00分"
        '
        'Label_Tomorrow
        '
        Me.Label_Tomorrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Tomorrow.AutoSize = True
        Me.Label_Tomorrow.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Tomorrow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Tomorrow.Location = New System.Drawing.Point(1179, 121)
        Me.Label_Tomorrow.Name = "Label_Tomorrow"
        Me.Label_Tomorrow.Size = New System.Drawing.Size(23, 15)
        Me.Label_Tomorrow.TabIndex = 25
        Me.Label_Tomorrow.Text = "翌"
        Me.Label_Tomorrow.Visible = False
        '
        'Label_TimeCardReasonAlart
        '
        Me.Label_TimeCardReasonAlart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_TimeCardReasonAlart.AutoSize = True
        Me.Label_TimeCardReasonAlart.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_TimeCardReasonAlart.ForeColor = System.Drawing.Color.Blue
        Me.Label_TimeCardReasonAlart.Location = New System.Drawing.Point(1020, 381)
        Me.Label_TimeCardReasonAlart.Name = "Label_TimeCardReasonAlart"
        Me.Label_TimeCardReasonAlart.Size = New System.Drawing.Size(180, 15)
        Me.Label_TimeCardReasonAlart.TabIndex = 26
        Me.Label_TimeCardReasonAlart.Text = "業務内容及び理由入力済"
        Me.Label_TimeCardReasonAlart.Visible = False
        '
        'Button_TimeCardCancel
        '
        Me.Button_TimeCardCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_TimeCardCancel.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_TimeCardCancel.Location = New System.Drawing.Point(1231, 19)
        Me.Button_TimeCardCancel.Name = "Button_TimeCardCancel"
        Me.Button_TimeCardCancel.Size = New System.Drawing.Size(90, 30)
        Me.Button_TimeCardCancel.TabIndex = 27
        Me.Button_TimeCardCancel.Text = "申請取下げ"
        Me.Button_TimeCardCancel.UseVisualStyleBackColor = True
        Me.Button_TimeCardCancel.Visible = False
        '
        'Form_TimeCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1337, 600)
        Me.Controls.Add(Me.Button_TimeCardCancel)
        Me.Controls.Add(Me.Label_TimeCardReasonAlart)
        Me.Controls.Add(Me.Label_Tomorrow)
        Me.Controls.Add(Me.Label_OverTimeSum)
        Me.Controls.Add(Me.Label_TimeCardEditOverTime)
        Me.Controls.Add(Me.DateTimePicker_BreakTime)
        Me.Controls.Add(Me.DateTimePicker_TimeCard)
        Me.Controls.Add(Me.Button_ReportHoliday)
        Me.Controls.Add(Me.DateTimePicker_ExecutedHoliday)
        Me.Controls.Add(Me.Label_ExecutedHoliday)
        Me.Controls.Add(Me.Label_ReportHoliday)
        Me.Controls.Add(Me.DateTimePicker_Holiday)
        Me.Controls.Add(Me.Label_TimeCardEditHoliday)
        Me.Controls.Add(Me.TextBox_ReasonOfWorking)
        Me.Controls.Add(Me.Label_TimeCardEditReason)
        Me.Controls.Add(Me.Label_TimeCardEditBreakTime)
        Me.Controls.Add(Me.Button_TimeCardEdit)
        Me.Controls.Add(Me.DateTimePicker_EndTime)
        Me.Controls.Add(Me.DateTimePicker_StartTime)
        Me.Controls.Add(Me.Label_TimeCardEditEndTime)
        Me.Controls.Add(Me.Label_TimeCardEditStartTime)
        Me.Controls.Add(Me.Label_TimeCardEditDate)
        Me.Controls.Add(Me.Label_TimeCardEdit)
        Me.Controls.Add(Me.DataGridView_TimeCard)
        Me.Controls.Add(Me.Button_TimeCardDisplay)
        Me.Controls.Add(Me.Button_TimeCardEnd)
        Me.Controls.Add(Me.Label_TimeCardName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_TimeCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出勤・退勤時刻一覧"
        CType(Me.DataGridView_TimeCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_TimeCardName As Label
    Friend WithEvents Button_TimeCardEnd As Button
    Friend WithEvents Button_TimeCardDisplay As Button
    Friend WithEvents DataGridView_TimeCard As DataGridView
    Friend WithEvents Label_TimeCardEdit As Label
    Friend WithEvents Label_TimeCardEditDate As Label
    Friend WithEvents Label_TimeCardEditStartTime As Label
    Friend WithEvents Label_TimeCardEditEndTime As Label
    Friend WithEvents DateTimePicker_StartTime As DateTimePicker
    Friend WithEvents DateTimePicker_EndTime As DateTimePicker
    Friend WithEvents Button_TimeCardEdit As Button
    Friend WithEvents Label_TimeCardEditBreakTime As Label
    Friend WithEvents Label_TimeCardEditReason As Label
    Friend WithEvents TextBox_ReasonOfWorking As TextBox
    Friend WithEvents Label_TimeCardEditHoliday As Label
    Friend WithEvents DateTimePicker_Holiday As DateTimePicker
    Friend WithEvents Label_ReportHoliday As Label
    Friend WithEvents Label_ExecutedHoliday As Label
    Friend WithEvents DateTimePicker_ExecutedHoliday As DateTimePicker
    Friend WithEvents Button_ReportHoliday As Button
    Friend WithEvents DateTimePicker_TimeCard As DateTimePicker
    Friend WithEvents DateTimePicker_BreakTime As DateTimePicker
    Friend WithEvents Label_TimeCardEditOverTime As Label
    Friend WithEvents Label_OverTimeSum As Label
    Friend WithEvents Label_Tomorrow As Label
    Friend WithEvents Label_TimeCardReasonAlart As Label
    Friend WithEvents Button_TimeCardCancel As Button
    Friend WithEvents Column_Date As DataGridViewTextBoxColumn
    Friend WithEvents Column_StartTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_EndTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_ExtraWorking As DataGridViewTextBoxColumn
    Friend WithEvents Column_Holiday As DataGridViewTextBoxColumn
    Friend WithEvents Column_Verified As DataGridViewTextBoxColumn
End Class
