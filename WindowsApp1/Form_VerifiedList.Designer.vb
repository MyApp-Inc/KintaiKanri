<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_VerifiedList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_VerifiedList))
        Me.Button_VerifiedListClose = New System.Windows.Forms.Button()
        Me.Label_VerifiedListTitle = New System.Windows.Forms.Label()
        Me.Label_DammyName = New System.Windows.Forms.Label()
        Me.DataGridView_TimeCardVerify = New System.Windows.Forms.DataGridView()
        Me.Column_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_WorkingTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_OverTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_BreakTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Verify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_Reject = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button_VerifiedListPast = New System.Windows.Forms.Button()
        Me.ListView_Verified = New System.Windows.Forms.ListView()
        Me.ColumnHeader_FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button_VerifiedListReload = New System.Windows.Forms.Button()
        CType(Me.DataGridView_TimeCardVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_VerifiedListClose
        '
        Me.Button_VerifiedListClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_VerifiedListClose.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_VerifiedListClose.Location = New System.Drawing.Point(1204, 537)
        Me.Button_VerifiedListClose.Name = "Button_VerifiedListClose"
        Me.Button_VerifiedListClose.Size = New System.Drawing.Size(112, 36)
        Me.Button_VerifiedListClose.TabIndex = 2
        Me.Button_VerifiedListClose.Text = "閉じる"
        Me.Button_VerifiedListClose.UseVisualStyleBackColor = True
        '
        'Label_VerifiedListTitle
        '
        Me.Label_VerifiedListTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_VerifiedListTitle.AutoSize = True
        Me.Label_VerifiedListTitle.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_VerifiedListTitle.Location = New System.Drawing.Point(537, 31)
        Me.Label_VerifiedListTitle.Name = "Label_VerifiedListTitle"
        Me.Label_VerifiedListTitle.Size = New System.Drawing.Size(275, 22)
        Me.Label_VerifiedListTitle.TabIndex = 5
        Me.Label_VerifiedListTitle.Text = "時間外・休日勤務申請一覧"
        '
        'Label_DammyName
        '
        Me.Label_DammyName.AutoSize = True
        Me.Label_DammyName.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_DammyName.Location = New System.Drawing.Point(12, 435)
        Me.Label_DammyName.Name = "Label_DammyName"
        Me.Label_DammyName.Size = New System.Drawing.Size(0, 22)
        Me.Label_DammyName.TabIndex = 6
        '
        'DataGridView_TimeCardVerify
        '
        Me.DataGridView_TimeCardVerify.AllowUserToAddRows = False
        Me.DataGridView_TimeCardVerify.AllowUserToDeleteRows = False
        Me.DataGridView_TimeCardVerify.AllowUserToOrderColumns = True
        Me.DataGridView_TimeCardVerify.AllowUserToResizeColumns = False
        Me.DataGridView_TimeCardVerify.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_TimeCardVerify.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_TimeCardVerify.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_TimeCardVerify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_TimeCardVerify.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView_TimeCardVerify.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_TimeCardVerify.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_TimeCardVerify.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_TimeCardVerify.ColumnHeadersHeight = 28
        Me.DataGridView_TimeCardVerify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_TimeCardVerify.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Date, Me.Column_WorkingTime, Me.Column_OverTime, Me.Column_BreakTime, Me.Column_Reason, Me.Column_Verify, Me.Column_Reject})
        Me.DataGridView_TimeCardVerify.Location = New System.Drawing.Point(233, 85)
        Me.DataGridView_TimeCardVerify.MultiSelect = False
        Me.DataGridView_TimeCardVerify.Name = "DataGridView_TimeCardVerify"
        Me.DataGridView_TimeCardVerify.ReadOnly = True
        Me.DataGridView_TimeCardVerify.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_TimeCardVerify.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView_TimeCardVerify.RowTemplate.Height = 40
        Me.DataGridView_TimeCardVerify.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_TimeCardVerify.Size = New System.Drawing.Size(1083, 442)
        Me.DataGridView_TimeCardVerify.TabIndex = 4
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
        Me.Column_BreakTime.FillWeight = 125.0!
        Me.Column_BreakTime.HeaderText = "休憩取得時間"
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
        Me.Column_Reason.FillWeight = 290.0!
        Me.Column_Reason.HeaderText = "業務内容及び理由"
        Me.Column_Reason.MaxInputLength = 400
        Me.Column_Reason.Name = "Column_Reason"
        Me.Column_Reason.ReadOnly = True
        Me.Column_Reason.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Verify
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Column_Verify.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column_Verify.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column_Verify.HeaderText = ""
        Me.Column_Verify.Name = "Column_Verify"
        Me.Column_Verify.ReadOnly = True
        Me.Column_Verify.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Verify.Text = "承認"
        Me.Column_Verify.UseColumnTextForButtonValue = True
        '
        'Column_Reject
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Column_Reject.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column_Reject.HeaderText = ""
        Me.Column_Reject.Name = "Column_Reject"
        Me.Column_Reject.ReadOnly = True
        Me.Column_Reject.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Reject.Text = "却下"
        Me.Column_Reject.UseColumnTextForButtonValue = True
        '
        'Button_VerifiedListPast
        '
        Me.Button_VerifiedListPast.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_VerifiedListPast.Location = New System.Drawing.Point(12, 28)
        Me.Button_VerifiedListPast.Name = "Button_VerifiedListPast"
        Me.Button_VerifiedListPast.Size = New System.Drawing.Size(184, 30)
        Me.Button_VerifiedListPast.TabIndex = 0
        Me.Button_VerifiedListPast.Text = "履歴一覧表示"
        Me.Button_VerifiedListPast.UseVisualStyleBackColor = True
        '
        'ListView_Verified
        '
        Me.ListView_Verified.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_Verified.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_FullName, Me.ColumnHeader_Number})
        Me.ListView_Verified.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListView_Verified.FullRowSelect = True
        Me.ListView_Verified.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_Verified.HideSelection = False
        Me.ListView_Verified.Location = New System.Drawing.Point(12, 85)
        Me.ListView_Verified.MultiSelect = False
        Me.ListView_Verified.Name = "ListView_Verified"
        Me.ListView_Verified.ShowGroups = False
        Me.ListView_Verified.Size = New System.Drawing.Size(204, 442)
        Me.ListView_Verified.TabIndex = 3
        Me.ListView_Verified.TabStop = False
        Me.ListView_Verified.UseCompatibleStateImageBehavior = False
        Me.ListView_Verified.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_FullName
        '
        Me.ColumnHeader_FullName.Text = "氏名"
        Me.ColumnHeader_FullName.Width = 140
        '
        'ColumnHeader_Number
        '
        Me.ColumnHeader_Number.Text = "件数"
        Me.ColumnHeader_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader_Number.Width = 50
        '
        'Button_VerifiedListReload
        '
        Me.Button_VerifiedListReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_VerifiedListReload.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_VerifiedListReload.Location = New System.Drawing.Point(12, 537)
        Me.Button_VerifiedListReload.Name = "Button_VerifiedListReload"
        Me.Button_VerifiedListReload.Size = New System.Drawing.Size(112, 36)
        Me.Button_VerifiedListReload.TabIndex = 1
        Me.Button_VerifiedListReload.Text = "更新"
        Me.Button_VerifiedListReload.UseVisualStyleBackColor = True
        '
        'Form_VerifiedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1332, 587)
        Me.Controls.Add(Me.Button_VerifiedListReload)
        Me.Controls.Add(Me.ListView_Verified)
        Me.Controls.Add(Me.Button_VerifiedListPast)
        Me.Controls.Add(Me.DataGridView_TimeCardVerify)
        Me.Controls.Add(Me.Label_DammyName)
        Me.Controls.Add(Me.Label_VerifiedListTitle)
        Me.Controls.Add(Me.Button_VerifiedListClose)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_VerifiedList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "時間外・休日勤務申請一覧"
        CType(Me.DataGridView_TimeCardVerify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_VerifiedListClose As Button
    Friend WithEvents Label_VerifiedListTitle As Label
    Friend WithEvents Label_DammyName As Label
    Friend WithEvents DataGridView_TimeCardVerify As DataGridView
    Friend WithEvents Button_VerifiedListPast As Button
    Friend WithEvents ListView_Verified As ListView
    Friend WithEvents ColumnHeader_Number As ColumnHeader
    Friend WithEvents Button_VerifiedListReload As Button
    Friend WithEvents Column_Date As DataGridViewTextBoxColumn
    Friend WithEvents Column_WorkingTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_OverTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_BreakTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_Reason As DataGridViewTextBoxColumn
    Friend WithEvents Column_Verify As DataGridViewButtonColumn
    Friend WithEvents Column_Reject As DataGridViewButtonColumn
    Friend WithEvents ColumnHeader_FullName As ColumnHeader
End Class
