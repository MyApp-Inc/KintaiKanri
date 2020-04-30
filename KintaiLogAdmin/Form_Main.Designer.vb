<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.DateTimePicker_ExportEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_ExportStart = New System.Windows.Forms.DateTimePicker()
        Me.Label_ExportPeriod = New System.Windows.Forms.Label()
        Me.Button_ExportFileAccessLog = New System.Windows.Forms.Button()
        Me.Button_ExportTimeLog = New System.Windows.Forms.Button()
        Me.Label_Export1 = New System.Windows.Forms.Label()
        Me.Button_ExportEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(73, 42)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(308, 22)
        Me.Label_Title.TabIndex = 15
        Me.Label_Title.Text = "勤怠ログ管理ツール（管理者用）"
        '
        'DateTimePicker_ExportEnd
        '
        Me.DateTimePicker_ExportEnd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker_ExportEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExportEnd.Location = New System.Drawing.Point(248, 128)
        Me.DateTimePicker_ExportEnd.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_ExportEnd.Name = "DateTimePicker_ExportEnd"
        Me.DateTimePicker_ExportEnd.Size = New System.Drawing.Size(175, 23)
        Me.DateTimePicker_ExportEnd.TabIndex = 24
        '
        'DateTimePicker_ExportStart
        '
        Me.DateTimePicker_ExportStart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker_ExportStart.CalendarFont = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExportStart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExportStart.Location = New System.Drawing.Point(31, 129)
        Me.DateTimePicker_ExportStart.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_ExportStart.Name = "DateTimePicker_ExportStart"
        Me.DateTimePicker_ExportStart.Size = New System.Drawing.Size(180, 23)
        Me.DateTimePicker_ExportStart.TabIndex = 23
        '
        'Label_ExportPeriod
        '
        Me.Label_ExportPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_ExportPeriod.AutoSize = True
        Me.Label_ExportPeriod.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ExportPeriod.Location = New System.Drawing.Point(31, 97)
        Me.Label_ExportPeriod.Name = "Label_ExportPeriod"
        Me.Label_ExportPeriod.Size = New System.Drawing.Size(76, 16)
        Me.Label_ExportPeriod.TabIndex = 22
        Me.Label_ExportPeriod.Text = "出力期間"
        '
        'Button_ExportFileAccessLog
        '
        Me.Button_ExportFileAccessLog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_ExportFileAccessLog.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportFileAccessLog.Location = New System.Drawing.Point(31, 251)
        Me.Button_ExportFileAccessLog.Name = "Button_ExportFileAccessLog"
        Me.Button_ExportFileAccessLog.Size = New System.Drawing.Size(392, 36)
        Me.Button_ExportFileAccessLog.TabIndex = 21
        Me.Button_ExportFileAccessLog.Text = "ファイルアクセスログ出力"
        Me.Button_ExportFileAccessLog.UseVisualStyleBackColor = True
        '
        'Button_ExportTimeLog
        '
        Me.Button_ExportTimeLog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_ExportTimeLog.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportTimeLog.Location = New System.Drawing.Point(31, 179)
        Me.Button_ExportTimeLog.Name = "Button_ExportTimeLog"
        Me.Button_ExportTimeLog.Size = New System.Drawing.Size(392, 36)
        Me.Button_ExportTimeLog.TabIndex = 20
        Me.Button_ExportTimeLog.Text = "作業時間ログ出力"
        Me.Button_ExportTimeLog.UseVisualStyleBackColor = True
        '
        'Label_Export1
        '
        Me.Label_Export1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Export1.AutoSize = True
        Me.Label_Export1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Export1.Location = New System.Drawing.Point(217, 133)
        Me.Label_Export1.Name = "Label_Export1"
        Me.Label_Export1.Size = New System.Drawing.Size(25, 16)
        Me.Label_Export1.TabIndex = 25
        Me.Label_Export1.Text = "～"
        '
        'Button_ExportEnd
        '
        Me.Button_ExportEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ExportEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportEnd.Location = New System.Drawing.Point(311, 364)
        Me.Button_ExportEnd.Name = "Button_ExportEnd"
        Me.Button_ExportEnd.Size = New System.Drawing.Size(112, 36)
        Me.Button_ExportEnd.TabIndex = 26
        Me.Button_ExportEnd.Text = "終了"
        Me.Button_ExportEnd.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 412)
        Me.Controls.Add(Me.Button_ExportEnd)
        Me.Controls.Add(Me.Label_Export1)
        Me.Controls.Add(Me.DateTimePicker_ExportEnd)
        Me.Controls.Add(Me.DateTimePicker_ExportStart)
        Me.Controls.Add(Me.Label_ExportPeriod)
        Me.Controls.Add(Me.Button_ExportFileAccessLog)
        Me.Controls.Add(Me.Button_ExportTimeLog)
        Me.Controls.Add(Me.Label_Title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Main"
        Me.Text = "勤怠ログ管理ツール（管理者用）"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents DateTimePicker_ExportEnd As DateTimePicker
    Friend WithEvents DateTimePicker_ExportStart As DateTimePicker
    Friend WithEvents Label_ExportPeriod As Label
    Friend WithEvents Button_ExportFileAccessLog As Button
    Friend WithEvents Button_ExportTimeLog As Button
    Friend WithEvents Label_Export1 As Label
    Friend WithEvents Button_ExportEnd As Button
End Class
