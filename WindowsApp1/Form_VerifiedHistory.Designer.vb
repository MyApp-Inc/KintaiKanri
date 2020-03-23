<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_VerifiedHistory
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_VerifiedHistory))
        Me.DateTimePicker_VerifiedHistory = New System.Windows.Forms.DateTimePicker()
        Me.Button_VerifiedHistoryDisplay = New System.Windows.Forms.Button()
        Me.Button_VerifiedHistoryClose = New System.Windows.Forms.Button()
        Me.Label_VerifiedListTitle = New System.Windows.Forms.Label()
        Me.ListView_VerifiedHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader_FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataGridView_VerifiedHistory = New System.Windows.Forms.DataGridView()
        Me.Column_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_WorkingTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_OverTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_BreakTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_holiday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_ApprovalStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView_VerifiedHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker_VerifiedHistory
        '
        Me.DateTimePicker_VerifiedHistory.CalendarFont = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_VerifiedHistory.CustomFormat = " yyyy 年 M 月"
        Me.DateTimePicker_VerifiedHistory.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_VerifiedHistory.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_VerifiedHistory.Location = New System.Drawing.Point(14, 28)
        Me.DateTimePicker_VerifiedHistory.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_VerifiedHistory.Name = "DateTimePicker_VerifiedHistory"
        Me.DateTimePicker_VerifiedHistory.ShowUpDown = True
        Me.DateTimePicker_VerifiedHistory.Size = New System.Drawing.Size(167, 22)
        Me.DateTimePicker_VerifiedHistory.TabIndex = 0
        '
        'Button_VerifiedHistoryDisplay
        '
        Me.Button_VerifiedHistoryDisplay.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_VerifiedHistoryDisplay.Location = New System.Drawing.Point(187, 26)
        Me.Button_VerifiedHistoryDisplay.Name = "Button_VerifiedHistoryDisplay"
        Me.Button_VerifiedHistoryDisplay.Size = New System.Drawing.Size(97, 28)
        Me.Button_VerifiedHistoryDisplay.TabIndex = 1
        Me.Button_VerifiedHistoryDisplay.Text = "表示"
        Me.Button_VerifiedHistoryDisplay.UseVisualStyleBackColor = True
        '
        'Button_VerifiedHistoryClose
        '
        Me.Button_VerifiedHistoryClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_VerifiedHistoryClose.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_VerifiedHistoryClose.Location = New System.Drawing.Point(1194, 431)
        Me.Button_VerifiedHistoryClose.Name = "Button_VerifiedHistoryClose"
        Me.Button_VerifiedHistoryClose.Size = New System.Drawing.Size(126, 36)
        Me.Button_VerifiedHistoryClose.TabIndex = 2
        Me.Button_VerifiedHistoryClose.Text = "閉じる"
        Me.Button_VerifiedHistoryClose.UseVisualStyleBackColor = True
        '
        'Label_VerifiedListTitle
        '
        Me.Label_VerifiedListTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_VerifiedListTitle.AutoSize = True
        Me.Label_VerifiedListTitle.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_VerifiedListTitle.Location = New System.Drawing.Point(595, 26)
        Me.Label_VerifiedListTitle.Name = "Label_VerifiedListTitle"
        Me.Label_VerifiedListTitle.Size = New System.Drawing.Size(275, 22)
        Me.Label_VerifiedListTitle.TabIndex = 5
        Me.Label_VerifiedListTitle.Text = "時間外・休日勤務履歴一覧"
        '
        'ListView_VerifiedHistory
        '
        Me.ListView_VerifiedHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_VerifiedHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_FullName, Me.ColumnHeader_Number})
        Me.ListView_VerifiedHistory.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListView_VerifiedHistory.FullRowSelect = True
        Me.ListView_VerifiedHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_VerifiedHistory.HideSelection = False
        Me.ListView_VerifiedHistory.Location = New System.Drawing.Point(14, 73)
        Me.ListView_VerifiedHistory.MultiSelect = False
        Me.ListView_VerifiedHistory.Name = "ListView_VerifiedHistory"
        Me.ListView_VerifiedHistory.ShowGroups = False
        Me.ListView_VerifiedHistory.Size = New System.Drawing.Size(167, 352)
        Me.ListView_VerifiedHistory.TabIndex = 3
        Me.ListView_VerifiedHistory.TabStop = False
        Me.ListView_VerifiedHistory.UseCompatibleStateImageBehavior = False
        Me.ListView_VerifiedHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_FullName
        '
        Me.ColumnHeader_FullName.Text = "氏名"
        Me.ColumnHeader_FullName.Width = 90
        '
        'ColumnHeader_Number
        '
        Me.ColumnHeader_Number.Text = "時間"
        Me.ColumnHeader_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView_VerifiedHistory
        '
        Me.DataGridView_VerifiedHistory.AllowUserToAddRows = False
        Me.DataGridView_VerifiedHistory.AllowUserToDeleteRows = False
        Me.DataGridView_VerifiedHistory.AllowUserToOrderColumns = True
        Me.DataGridView_VerifiedHistory.AllowUserToResizeColumns = False
        Me.DataGridView_VerifiedHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_VerifiedHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_VerifiedHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_VerifiedHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_VerifiedHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView_VerifiedHistory.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_VerifiedHistory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_VerifiedHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_VerifiedHistory.ColumnHeadersHeight = 28
        Me.DataGridView_VerifiedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_VerifiedHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Date, Me.Column_WorkingTime, Me.Column_OverTime, Me.Column_BreakTime, Me.Column_Reason, Me.Column_holiday, Me.Column_ApprovalStatus})
        Me.DataGridView_VerifiedHistory.Location = New System.Drawing.Point(187, 73)
        Me.DataGridView_VerifiedHistory.MultiSelect = False
        Me.DataGridView_VerifiedHistory.Name = "DataGridView_VerifiedHistory"
        Me.DataGridView_VerifiedHistory.ReadOnly = True
        Me.DataGridView_VerifiedHistory.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_VerifiedHistory.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView_VerifiedHistory.RowTemplate.Height = 40
        Me.DataGridView_VerifiedHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_VerifiedHistory.Size = New System.Drawing.Size(1133, 352)
        Me.DataGridView_VerifiedHistory.TabIndex = 4
        '
        'Column_Date
        '
        Me.Column_Date.FillWeight = 175.0!
        Me.Column_Date.HeaderText = "日付"
        Me.Column_Date.MaxInputLength = 100
        Me.Column_Date.Name = "Column_Date"
        Me.Column_Date.ReadOnly = True
        Me.Column_Date.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column_WorkingTime
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_WorkingTime.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column_WorkingTime.FillWeight = 130.0!
        Me.Column_WorkingTime.HeaderText = "勤務時間"
        Me.Column_WorkingTime.MaxInputLength = 100
        Me.Column_WorkingTime.Name = "Column_WorkingTime"
        Me.Column_WorkingTime.ReadOnly = True
        Me.Column_WorkingTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_WorkingTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_OverTime
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_OverTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column_OverTime.FillWeight = 130.0!
        Me.Column_OverTime.HeaderText = "残業時間"
        Me.Column_OverTime.MaxInputLength = 100
        Me.Column_OverTime.Name = "Column_OverTime"
        Me.Column_OverTime.ReadOnly = True
        Me.Column_OverTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_OverTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_BreakTime
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_BreakTime.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column_BreakTime.HeaderText = "休憩時間"
        Me.Column_BreakTime.MaxInputLength = 100
        Me.Column_BreakTime.Name = "Column_BreakTime"
        Me.Column_BreakTime.ReadOnly = True
        Me.Column_BreakTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_BreakTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Reason
        '
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_Reason.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column_Reason.FillWeight = 200.0!
        Me.Column_Reason.HeaderText = "業務内容及び理由"
        Me.Column_Reason.MaxInputLength = 400
        Me.Column_Reason.Name = "Column_Reason"
        Me.Column_Reason.ReadOnly = True
        Me.Column_Reason.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_holiday
        '
        Me.Column_holiday.FillWeight = 160.0!
        Me.Column_holiday.HeaderText = "振替休日取得状況"
        Me.Column_holiday.MaxInputLength = 200
        Me.Column_holiday.Name = "Column_holiday"
        Me.Column_holiday.ReadOnly = True
        Me.Column_holiday.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_holiday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_ApprovalStatus
        '
        Me.Column_ApprovalStatus.FillWeight = 150.0!
        Me.Column_ApprovalStatus.HeaderText = "承認状況"
        Me.Column_ApprovalStatus.MaxInputLength = 50
        Me.Column_ApprovalStatus.Name = "Column_ApprovalStatus"
        Me.Column_ApprovalStatus.ReadOnly = True
        Me.Column_ApprovalStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_ApprovalStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Form_VerifiedHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1332, 479)
        Me.Controls.Add(Me.DataGridView_VerifiedHistory)
        Me.Controls.Add(Me.ListView_VerifiedHistory)
        Me.Controls.Add(Me.Label_VerifiedListTitle)
        Me.Controls.Add(Me.Button_VerifiedHistoryClose)
        Me.Controls.Add(Me.Button_VerifiedHistoryDisplay)
        Me.Controls.Add(Me.DateTimePicker_VerifiedHistory)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_VerifiedHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "時間外・休日勤務履歴一覧"
        CType(Me.DataGridView_VerifiedHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker_VerifiedHistory As DateTimePicker
    Friend WithEvents Button_VerifiedHistoryDisplay As Button
    Friend WithEvents Button_VerifiedHistoryClose As Button
    Friend WithEvents Label_VerifiedListTitle As Label
    Friend WithEvents ListView_VerifiedHistory As ListView
    Friend WithEvents ColumnHeader_FullName As ColumnHeader
    Friend WithEvents ColumnHeader_Number As ColumnHeader
    Friend WithEvents DataGridView_VerifiedHistory As DataGridView
    Friend WithEvents Column_Date As DataGridViewTextBoxColumn
    Friend WithEvents Column_WorkingTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_OverTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_BreakTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_Reason As DataGridViewTextBoxColumn
    Friend WithEvents Column_holiday As DataGridViewTextBoxColumn
    Friend WithEvents Column_ApprovalStatus As DataGridViewTextBoxColumn
End Class
