<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DocApprovalHistory
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DocApprovalHistory))
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.DataGridView_DocHistory = New System.Windows.Forms.DataGridView()
        Me.Column_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_File = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_BreakTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_VerifyStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Print = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView_DocHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(1200, 561)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(112, 36)
        Me.Button_Close.TabIndex = 11
        Me.Button_Close.Text = "閉じる"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Label_Title
        '
        Me.Label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(565, 24)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(194, 22)
        Me.Label_Title.TabIndex = 12
        Me.Label_Title.Text = "電子承認申請履歴"
        '
        'DataGridView_DocHistory
        '
        Me.DataGridView_DocHistory.AllowUserToAddRows = False
        Me.DataGridView_DocHistory.AllowUserToDeleteRows = False
        Me.DataGridView_DocHistory.AllowUserToResizeColumns = False
        Me.DataGridView_DocHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_DocHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_DocHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_DocHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_DocHistory.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView_DocHistory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DocHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_DocHistory.ColumnHeadersHeight = 28
        Me.DataGridView_DocHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_DocHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Id, Me.Column_File, Me.Column_Date, Me.Column_BreakTime, Me.Column_VerifyStatus, Me.Column_Print})
        Me.DataGridView_DocHistory.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView_DocHistory.MultiSelect = False
        Me.DataGridView_DocHistory.Name = "DataGridView_DocHistory"
        Me.DataGridView_DocHistory.ReadOnly = True
        Me.DataGridView_DocHistory.RowHeadersVisible = False
        Me.DataGridView_DocHistory.RowHeadersWidth = 60
        DataGridViewCellStyle8.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DataGridView_DocHistory.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView_DocHistory.RowTemplate.Height = 40
        Me.DataGridView_DocHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_DocHistory.Size = New System.Drawing.Size(1300, 493)
        Me.DataGridView_DocHistory.TabIndex = 16
        '
        'Column_Id
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column_Id.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column_Id.FillWeight = 50.0!
        Me.Column_Id.HeaderText = "ID"
        Me.Column_Id.MaxInputLength = 5
        Me.Column_Id.Name = "Column_Id"
        Me.Column_Id.ReadOnly = True
        Me.Column_Id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_File
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_File.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column_File.HeaderText = "申請ファイル"
        Me.Column_File.Name = "Column_File"
        Me.Column_File.ReadOnly = True
        Me.Column_File.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_File.Text = "ファイル表示"
        Me.Column_File.UseColumnTextForButtonValue = True
        '
        'Column_Date
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column_Date.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column_Date.FillWeight = 150.0!
        Me.Column_Date.HeaderText = "日付"
        Me.Column_Date.MaxInputLength = 100
        Me.Column_Date.Name = "Column_Date"
        Me.Column_Date.ReadOnly = True
        Me.Column_Date.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column_BreakTime
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_BreakTime.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column_BreakTime.FillWeight = 300.0!
        Me.Column_BreakTime.HeaderText = "件名"
        Me.Column_BreakTime.MaxInputLength = 100
        Me.Column_BreakTime.Name = "Column_BreakTime"
        Me.Column_BreakTime.ReadOnly = True
        Me.Column_BreakTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_BreakTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_VerifyStatus
        '
        Me.Column_VerifyStatus.FillWeight = 200.0!
        Me.Column_VerifyStatus.HeaderText = "承認状況"
        Me.Column_VerifyStatus.MaxInputLength = 100
        Me.Column_VerifyStatus.Name = "Column_VerifyStatus"
        Me.Column_VerifyStatus.ReadOnly = True
        Me.Column_VerifyStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_VerifyStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column_Print
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column_Print.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column_Print.HeaderText = "承認印出力"
        Me.Column_Print.Name = "Column_Print"
        Me.Column_Print.ReadOnly = True
        Me.Column_Print.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Print.Text = "出力"
        Me.Column_Print.UseColumnTextForButtonValue = True
        '
        'Form_DocApprovalHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 609)
        Me.Controls.Add(Me.DataGridView_DocHistory)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Button_Close)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_DocApprovalHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "電子承認申請履歴"
        CType(Me.DataGridView_DocHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Close As Button
    Friend WithEvents Label_Title As Label
    Friend WithEvents DataGridView_DocHistory As DataGridView
    Friend WithEvents Column_Id As DataGridViewTextBoxColumn
    Friend WithEvents Column_File As DataGridViewButtonColumn
    Friend WithEvents Column_Date As DataGridViewTextBoxColumn
    Friend WithEvents Column_BreakTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_VerifyStatus As DataGridViewTextBoxColumn
    Friend WithEvents Column_Print As DataGridViewButtonColumn
End Class
