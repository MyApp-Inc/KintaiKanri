<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CheckTimeCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CheckTimeCard))
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.DataGridView_TimeCard = New System.Windows.Forms.DataGridView()
        Me.Column_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_ExtraWorking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Holiday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Verified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListView_User = New System.Windows.Forms.ListView()
        Me.ColumnHeader_FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_WorkinkTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label_OverTimeSum = New System.Windows.Forms.Label()
        Me.DateTimePicker_TimeCard = New System.Windows.Forms.DateTimePicker()
        Me.Button_TimeCardDisplay = New System.Windows.Forms.Button()
        CType(Me.DataGridView_TimeCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(1235, 558)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(90, 30)
        Me.Button_Close.TabIndex = 12
        Me.Button_Close.Text = "閉じる"
        Me.Button_Close.UseVisualStyleBackColor = True
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
        Me.DataGridView_TimeCard.Location = New System.Drawing.Point(338, 46)
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
        Me.DataGridView_TimeCard.Size = New System.Drawing.Size(987, 506)
        Me.DataGridView_TimeCard.TabIndex = 13
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
        'ListView_User
        '
        Me.ListView_User.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_User.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_FullName, Me.ColumnHeader_WorkinkTime})
        Me.ListView_User.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListView_User.FullRowSelect = True
        Me.ListView_User.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_User.HideSelection = False
        Me.ListView_User.Location = New System.Drawing.Point(12, 46)
        Me.ListView_User.MultiSelect = False
        Me.ListView_User.Name = "ListView_User"
        Me.ListView_User.ShowGroups = False
        Me.ListView_User.Size = New System.Drawing.Size(320, 506)
        Me.ListView_User.TabIndex = 14
        Me.ListView_User.TabStop = False
        Me.ListView_User.UseCompatibleStateImageBehavior = False
        Me.ListView_User.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_FullName
        '
        Me.ColumnHeader_FullName.Text = "氏名"
        Me.ColumnHeader_FullName.Width = 140
        '
        'ColumnHeader_WorkinkTime
        '
        Me.ColumnHeader_WorkinkTime.Text = "直近の勤務時間"
        Me.ColumnHeader_WorkinkTime.Width = 150
        '
        'Label_OverTimeSum
        '
        Me.Label_OverTimeSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_OverTimeSum.AutoSize = True
        Me.Label_OverTimeSum.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_OverTimeSum.Location = New System.Drawing.Point(816, 17)
        Me.Label_OverTimeSum.Name = "Label_OverTimeSum"
        Me.Label_OverTimeSum.Size = New System.Drawing.Size(232, 15)
        Me.Label_OverTimeSum.TabIndex = 17
        Me.Label_OverTimeSum.Text = "当月の残業時間合計：0時間00分"
        Me.Label_OverTimeSum.Visible = False
        '
        'DateTimePicker_TimeCard
        '
        Me.DateTimePicker_TimeCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_TimeCard.CalendarFont = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_TimeCard.CustomFormat = " yyyy 年 M 月"
        Me.DateTimePicker_TimeCard.Enabled = False
        Me.DateTimePicker_TimeCard.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_TimeCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_TimeCard.Location = New System.Drawing.Point(1077, 12)
        Me.DateTimePicker_TimeCard.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_TimeCard.Name = "DateTimePicker_TimeCard"
        Me.DateTimePicker_TimeCard.ShowUpDown = True
        Me.DateTimePicker_TimeCard.Size = New System.Drawing.Size(142, 22)
        Me.DateTimePicker_TimeCard.TabIndex = 15
        '
        'Button_TimeCardDisplay
        '
        Me.Button_TimeCardDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_TimeCardDisplay.Enabled = False
        Me.Button_TimeCardDisplay.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_TimeCardDisplay.Location = New System.Drawing.Point(1235, 10)
        Me.Button_TimeCardDisplay.Name = "Button_TimeCardDisplay"
        Me.Button_TimeCardDisplay.Size = New System.Drawing.Size(90, 30)
        Me.Button_TimeCardDisplay.TabIndex = 16
        Me.Button_TimeCardDisplay.Text = "表示"
        Me.Button_TimeCardDisplay.UseVisualStyleBackColor = True
        '
        'Form_CheckTimeCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 600)
        Me.Controls.Add(Me.Label_OverTimeSum)
        Me.Controls.Add(Me.DateTimePicker_TimeCard)
        Me.Controls.Add(Me.Button_TimeCardDisplay)
        Me.Controls.Add(Me.ListView_User)
        Me.Controls.Add(Me.DataGridView_TimeCard)
        Me.Controls.Add(Me.Button_Close)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_CheckTimeCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "勤務時間確認"
        CType(Me.DataGridView_TimeCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Close As Button
    Friend WithEvents DataGridView_TimeCard As DataGridView
    Friend WithEvents Column_Date As DataGridViewTextBoxColumn
    Friend WithEvents Column_StartTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_EndTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_ExtraWorking As DataGridViewTextBoxColumn
    Friend WithEvents Column_Holiday As DataGridViewTextBoxColumn
    Friend WithEvents Column_Verified As DataGridViewTextBoxColumn
    Friend WithEvents ListView_User As ListView
    Friend WithEvents ColumnHeader_FullName As ColumnHeader
    Friend WithEvents ColumnHeader_WorkinkTime As ColumnHeader
    Friend WithEvents Label_OverTimeSum As Label
    Friend WithEvents DateTimePicker_TimeCard As DateTimePicker
    Friend WithEvents Button_TimeCardDisplay As Button
End Class
