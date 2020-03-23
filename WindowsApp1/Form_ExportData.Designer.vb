<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ExportData
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
        Me.Label_Export1 = New System.Windows.Forms.Label()
        Me.DateTimePicker_ExportEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_ExportStart = New System.Windows.Forms.DateTimePicker()
        Me.Label_ExportPeriod = New System.Windows.Forms.Label()
        Me.Button_ExportHolidayWorking2 = New System.Windows.Forms.Button()
        Me.Button_ExportHolidayWorking1 = New System.Windows.Forms.Button()
        Me.Button_ExportOverTime = New System.Windows.Forms.Button()
        Me.Button_ExportEnd = New System.Windows.Forms.Button()
        Me.Label_ExportTitle = New System.Windows.Forms.Label()
        Me.Button_ExportRecentFile = New System.Windows.Forms.Button()
        Me.Button_ExportHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Export1
        '
        Me.Label_Export1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Export1.AutoSize = True
        Me.Label_Export1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Export1.Location = New System.Drawing.Point(198, 114)
        Me.Label_Export1.Name = "Label_Export1"
        Me.Label_Export1.Size = New System.Drawing.Size(25, 16)
        Me.Label_Export1.TabIndex = 20
        Me.Label_Export1.Text = "～"
        '
        'DateTimePicker_ExportEnd
        '
        Me.DateTimePicker_ExportEnd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker_ExportEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExportEnd.Location = New System.Drawing.Point(229, 108)
        Me.DateTimePicker_ExportEnd.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_ExportEnd.Name = "DateTimePicker_ExportEnd"
        Me.DateTimePicker_ExportEnd.Size = New System.Drawing.Size(175, 23)
        Me.DateTimePicker_ExportEnd.TabIndex = 19
        '
        'DateTimePicker_ExportStart
        '
        Me.DateTimePicker_ExportStart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker_ExportStart.CalendarFont = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExportStart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_ExportStart.Location = New System.Drawing.Point(12, 109)
        Me.DateTimePicker_ExportStart.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_ExportStart.Name = "DateTimePicker_ExportStart"
        Me.DateTimePicker_ExportStart.Size = New System.Drawing.Size(180, 23)
        Me.DateTimePicker_ExportStart.TabIndex = 18
        '
        'Label_ExportPeriod
        '
        Me.Label_ExportPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_ExportPeriod.AutoSize = True
        Me.Label_ExportPeriod.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ExportPeriod.Location = New System.Drawing.Point(12, 77)
        Me.Label_ExportPeriod.Name = "Label_ExportPeriod"
        Me.Label_ExportPeriod.Size = New System.Drawing.Size(76, 16)
        Me.Label_ExportPeriod.TabIndex = 17
        Me.Label_ExportPeriod.Text = "出力期間"
        '
        'Button_ExportHolidayWorking2
        '
        Me.Button_ExportHolidayWorking2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_ExportHolidayWorking2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportHolidayWorking2.Location = New System.Drawing.Point(12, 305)
        Me.Button_ExportHolidayWorking2.Name = "Button_ExportHolidayWorking2"
        Me.Button_ExportHolidayWorking2.Size = New System.Drawing.Size(392, 36)
        Me.Button_ExportHolidayWorking2.TabIndex = 16
        Me.Button_ExportHolidayWorking2.Text = "休日勤務及び振替休日管理表"
        Me.Button_ExportHolidayWorking2.UseVisualStyleBackColor = True
        '
        'Button_ExportHolidayWorking1
        '
        Me.Button_ExportHolidayWorking1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_ExportHolidayWorking1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportHolidayWorking1.Location = New System.Drawing.Point(12, 231)
        Me.Button_ExportHolidayWorking1.Name = "Button_ExportHolidayWorking1"
        Me.Button_ExportHolidayWorking1.Size = New System.Drawing.Size(392, 36)
        Me.Button_ExportHolidayWorking1.TabIndex = 15
        Me.Button_ExportHolidayWorking1.Text = "休日勤務及び振替休日指示書"
        Me.Button_ExportHolidayWorking1.UseVisualStyleBackColor = True
        '
        'Button_ExportOverTime
        '
        Me.Button_ExportOverTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_ExportOverTime.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportOverTime.Location = New System.Drawing.Point(12, 159)
        Me.Button_ExportOverTime.Name = "Button_ExportOverTime"
        Me.Button_ExportOverTime.Size = New System.Drawing.Size(392, 36)
        Me.Button_ExportOverTime.TabIndex = 14
        Me.Button_ExportOverTime.Text = "時間外・休日勤務指示書"
        Me.Button_ExportOverTime.UseVisualStyleBackColor = True
        '
        'Button_ExportEnd
        '
        Me.Button_ExportEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ExportEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportEnd.Location = New System.Drawing.Point(292, 547)
        Me.Button_ExportEnd.Name = "Button_ExportEnd"
        Me.Button_ExportEnd.Size = New System.Drawing.Size(112, 36)
        Me.Button_ExportEnd.TabIndex = 13
        Me.Button_ExportEnd.Text = "閉じる"
        Me.Button_ExportEnd.UseVisualStyleBackColor = True
        '
        'Label_ExportTitle
        '
        Me.Label_ExportTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_ExportTitle.AutoSize = True
        Me.Label_ExportTitle.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ExportTitle.Location = New System.Drawing.Point(102, 27)
        Me.Label_ExportTitle.Name = "Label_ExportTitle"
        Me.Label_ExportTitle.Size = New System.Drawing.Size(202, 22)
        Me.Label_ExportTitle.TabIndex = 12
        Me.Label_ExportTitle.Text = "勤怠データ一括出力"
        '
        'Button_ExportRecentFile
        '
        Me.Button_ExportRecentFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_ExportRecentFile.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportRecentFile.Location = New System.Drawing.Point(12, 378)
        Me.Button_ExportRecentFile.Name = "Button_ExportRecentFile"
        Me.Button_ExportRecentFile.Size = New System.Drawing.Size(392, 36)
        Me.Button_ExportRecentFile.TabIndex = 21
        Me.Button_ExportRecentFile.Text = "ファイルアクセス履歴"
        Me.Button_ExportRecentFile.UseVisualStyleBackColor = True
        '
        'Button_ExportHistory
        '
        Me.Button_ExportHistory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_ExportHistory.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_ExportHistory.Location = New System.Drawing.Point(12, 451)
        Me.Button_ExportHistory.Name = "Button_ExportHistory"
        Me.Button_ExportHistory.Size = New System.Drawing.Size(392, 36)
        Me.Button_ExportHistory.TabIndex = 22
        Me.Button_ExportHistory.Text = "ブラウザ閲覧履歴"
        Me.Button_ExportHistory.UseVisualStyleBackColor = True
        '
        'Form_ExportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(416, 595)
        Me.Controls.Add(Me.Button_ExportHistory)
        Me.Controls.Add(Me.Button_ExportRecentFile)
        Me.Controls.Add(Me.Label_Export1)
        Me.Controls.Add(Me.DateTimePicker_ExportEnd)
        Me.Controls.Add(Me.DateTimePicker_ExportStart)
        Me.Controls.Add(Me.Label_ExportPeriod)
        Me.Controls.Add(Me.Button_ExportHolidayWorking2)
        Me.Controls.Add(Me.Button_ExportHolidayWorking1)
        Me.Controls.Add(Me.Button_ExportOverTime)
        Me.Controls.Add(Me.Button_ExportEnd)
        Me.Controls.Add(Me.Label_ExportTitle)
        Me.Name = "Form_ExportData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_ExportData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Export1 As Label
    Friend WithEvents DateTimePicker_ExportEnd As DateTimePicker
    Friend WithEvents DateTimePicker_ExportStart As DateTimePicker
    Friend WithEvents Label_ExportPeriod As Label
    Friend WithEvents Button_ExportHolidayWorking2 As Button
    Friend WithEvents Button_ExportHolidayWorking1 As Button
    Friend WithEvents Button_ExportOverTime As Button
    Friend WithEvents Button_ExportEnd As Button
    Friend WithEvents Label_ExportTitle As Label
    Friend WithEvents Button_ExportRecentFile As Button
    Friend WithEvents Button_ExportHistory As Button
End Class
