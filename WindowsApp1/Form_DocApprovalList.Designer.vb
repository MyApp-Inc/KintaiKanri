<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DocApprovalList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DocApprovalList))
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label_MenuTitle = New System.Windows.Forms.Label()
        Me.Button_Reload = New System.Windows.Forms.Button()
        Me.DataGridView_DocApproval = New System.Windows.Forms.DataGridView()
        Me.Column_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_File = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_BreakTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Verify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_Reject = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView_DocApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(1196, 562)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(112, 36)
        Me.Button_Close.TabIndex = 11
        Me.Button_Close.Text = "閉じる"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Label_MenuTitle
        '
        Me.Label_MenuTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_MenuTitle.AutoSize = True
        Me.Label_MenuTitle.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_MenuTitle.Location = New System.Drawing.Point(554, 23)
        Me.Label_MenuTitle.Name = "Label_MenuTitle"
        Me.Label_MenuTitle.Size = New System.Drawing.Size(213, 22)
        Me.Label_MenuTitle.TabIndex = 12
        Me.Label_MenuTitle.Text = "電子承認申請の承認"
        '
        'Button_Reload
        '
        Me.Button_Reload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Reload.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Reload.Location = New System.Drawing.Point(12, 562)
        Me.Button_Reload.Name = "Button_Reload"
        Me.Button_Reload.Size = New System.Drawing.Size(112, 36)
        Me.Button_Reload.TabIndex = 14
        Me.Button_Reload.Text = "更新"
        Me.Button_Reload.UseVisualStyleBackColor = True
        '
        'DataGridView_DocApproval
        '
        Me.DataGridView_DocApproval.AllowUserToAddRows = False
        Me.DataGridView_DocApproval.AllowUserToDeleteRows = False
        Me.DataGridView_DocApproval.AllowUserToOrderColumns = True
        Me.DataGridView_DocApproval.AllowUserToResizeColumns = False
        Me.DataGridView_DocApproval.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_DocApproval.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_DocApproval.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_DocApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_DocApproval.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView_DocApproval.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_DocApproval.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DocApproval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_DocApproval.ColumnHeadersHeight = 28
        Me.DataGridView_DocApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_DocApproval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Id, Me.Column_File, Me.Column_Group, Me.Column_FullName, Me.Column_Date, Me.Column_BreakTime, Me.Column_Verify, Me.Column_Reject})
        Me.DataGridView_DocApproval.Location = New System.Drawing.Point(12, 63)
        Me.DataGridView_DocApproval.MultiSelect = False
        Me.DataGridView_DocApproval.Name = "DataGridView_DocApproval"
        Me.DataGridView_DocApproval.ReadOnly = True
        Me.DataGridView_DocApproval.RowHeadersVisible = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_DocApproval.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView_DocApproval.RowTemplate.Height = 40
        Me.DataGridView_DocApproval.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DocApproval.Size = New System.Drawing.Size(1296, 493)
        Me.DataGridView_DocApproval.TabIndex = 15
        '
        'Column_Id
        '
        Me.Column_Id.FillWeight = 75.0!
        Me.Column_Id.HeaderText = "ID"
        Me.Column_Id.MaxInputLength = 5
        Me.Column_Id.Name = "Column_Id"
        Me.Column_Id.ReadOnly = True
        Me.Column_Id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_File
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_File.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column_File.HeaderText = "申請ファイル"
        Me.Column_File.Name = "Column_File"
        Me.Column_File.ReadOnly = True
        Me.Column_File.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_File.Text = "ファイル表示"
        Me.Column_File.UseColumnTextForButtonValue = True
        '
        'Column_Group
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_Group.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column_Group.FillWeight = 200.0!
        Me.Column_Group.HeaderText = "所属"
        Me.Column_Group.MaxInputLength = 100
        Me.Column_Group.Name = "Column_Group"
        Me.Column_Group.ReadOnly = True
        Me.Column_Group.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_FullName
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_FullName.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column_FullName.FillWeight = 130.0!
        Me.Column_FullName.HeaderText = "氏名"
        Me.Column_FullName.MaxInputLength = 100
        Me.Column_FullName.Name = "Column_FullName"
        Me.Column_FullName.ReadOnly = True
        Me.Column_FullName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'Column_BreakTime
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_BreakTime.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column_BreakTime.FillWeight = 300.0!
        Me.Column_BreakTime.HeaderText = "件名"
        Me.Column_BreakTime.MaxInputLength = 100
        Me.Column_BreakTime.Name = "Column_BreakTime"
        Me.Column_BreakTime.ReadOnly = True
        Me.Column_BreakTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_BreakTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'Form_DocApprovalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 610)
        Me.Controls.Add(Me.DataGridView_DocApproval)
        Me.Controls.Add(Me.Button_Reload)
        Me.Controls.Add(Me.Label_MenuTitle)
        Me.Controls.Add(Me.Button_Close)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_DocApprovalList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "電子承認申請の承認"
        CType(Me.DataGridView_DocApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Close As Button
    Friend WithEvents Label_MenuTitle As Label
    Friend WithEvents Button_Reload As Button
    Friend WithEvents DataGridView_DocApproval As DataGridView
    Friend WithEvents Column_Id As DataGridViewTextBoxColumn
    Friend WithEvents Column_File As DataGridViewButtonColumn
    Friend WithEvents Column_Group As DataGridViewTextBoxColumn
    Friend WithEvents Column_FullName As DataGridViewTextBoxColumn
    Friend WithEvents Column_Date As DataGridViewTextBoxColumn
    Friend WithEvents Column_BreakTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_Verify As DataGridViewButtonColumn
    Friend WithEvents Column_Reject As DataGridViewButtonColumn
End Class
