<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Print))
        Me.Label_PrintTitle = New System.Windows.Forms.Label()
        Me.Button_PrintEnd = New System.Windows.Forms.Button()
        Me.Button_PrintOverTime = New System.Windows.Forms.Button()
        Me.Button_PrintHolidayWorking1 = New System.Windows.Forms.Button()
        Me.Button_PrintHolidayWorking2 = New System.Windows.Forms.Button()
        Me.Label_PrintPeriod = New System.Windows.Forms.Label()
        Me.DateTimePicker_PrintStart = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_PrintEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label_Print1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_PrintTitle
        '
        Me.Label_PrintTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_PrintTitle.AutoSize = True
        Me.Label_PrintTitle.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_PrintTitle.Location = New System.Drawing.Point(111, 30)
        Me.Label_PrintTitle.Name = "Label_PrintTitle"
        Me.Label_PrintTitle.Size = New System.Drawing.Size(194, 22)
        Me.Label_PrintTitle.TabIndex = 3
        Me.Label_PrintTitle.Text = "人事関連様式出力"
        '
        'Button_PrintEnd
        '
        Me.Button_PrintEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_PrintEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_PrintEnd.Location = New System.Drawing.Point(292, 409)
        Me.Button_PrintEnd.Name = "Button_PrintEnd"
        Me.Button_PrintEnd.Size = New System.Drawing.Size(112, 36)
        Me.Button_PrintEnd.TabIndex = 4
        Me.Button_PrintEnd.Text = "閉じる"
        Me.Button_PrintEnd.UseVisualStyleBackColor = True
        '
        'Button_PrintOverTime
        '
        Me.Button_PrintOverTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_PrintOverTime.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_PrintOverTime.Location = New System.Drawing.Point(12, 168)
        Me.Button_PrintOverTime.Name = "Button_PrintOverTime"
        Me.Button_PrintOverTime.Size = New System.Drawing.Size(392, 36)
        Me.Button_PrintOverTime.TabIndex = 5
        Me.Button_PrintOverTime.Text = "時間外・休日勤務指示書"
        Me.Button_PrintOverTime.UseVisualStyleBackColor = True
        '
        'Button_PrintHolidayWorking1
        '
        Me.Button_PrintHolidayWorking1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_PrintHolidayWorking1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_PrintHolidayWorking1.Location = New System.Drawing.Point(12, 240)
        Me.Button_PrintHolidayWorking1.Name = "Button_PrintHolidayWorking1"
        Me.Button_PrintHolidayWorking1.Size = New System.Drawing.Size(392, 36)
        Me.Button_PrintHolidayWorking1.TabIndex = 6
        Me.Button_PrintHolidayWorking1.Text = "休日勤務及び振替休日指示書"
        Me.Button_PrintHolidayWorking1.UseVisualStyleBackColor = True
        '
        'Button_PrintHolidayWorking2
        '
        Me.Button_PrintHolidayWorking2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_PrintHolidayWorking2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_PrintHolidayWorking2.Location = New System.Drawing.Point(12, 314)
        Me.Button_PrintHolidayWorking2.Name = "Button_PrintHolidayWorking2"
        Me.Button_PrintHolidayWorking2.Size = New System.Drawing.Size(392, 36)
        Me.Button_PrintHolidayWorking2.TabIndex = 7
        Me.Button_PrintHolidayWorking2.Text = "休日勤務及び振替休日管理表"
        Me.Button_PrintHolidayWorking2.UseVisualStyleBackColor = True
        '
        'Label_PrintPeriod
        '
        Me.Label_PrintPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_PrintPeriod.AutoSize = True
        Me.Label_PrintPeriod.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_PrintPeriod.Location = New System.Drawing.Point(12, 86)
        Me.Label_PrintPeriod.Name = "Label_PrintPeriod"
        Me.Label_PrintPeriod.Size = New System.Drawing.Size(76, 16)
        Me.Label_PrintPeriod.TabIndex = 8
        Me.Label_PrintPeriod.Text = "出力期間"
        '
        'DateTimePicker_PrintStart
        '
        Me.DateTimePicker_PrintStart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker_PrintStart.CalendarFont = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_PrintStart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_PrintStart.Location = New System.Drawing.Point(12, 118)
        Me.DateTimePicker_PrintStart.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_PrintStart.Name = "DateTimePicker_PrintStart"
        Me.DateTimePicker_PrintStart.Size = New System.Drawing.Size(180, 23)
        Me.DateTimePicker_PrintStart.TabIndex = 9
        '
        'DateTimePicker_PrintEnd
        '
        Me.DateTimePicker_PrintEnd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker_PrintEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimePicker_PrintEnd.Location = New System.Drawing.Point(229, 117)
        Me.DateTimePicker_PrintEnd.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_PrintEnd.Name = "DateTimePicker_PrintEnd"
        Me.DateTimePicker_PrintEnd.Size = New System.Drawing.Size(175, 23)
        Me.DateTimePicker_PrintEnd.TabIndex = 10
        '
        'Label_Print1
        '
        Me.Label_Print1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Print1.AutoSize = True
        Me.Label_Print1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Print1.Location = New System.Drawing.Point(198, 123)
        Me.Label_Print1.Name = "Label_Print1"
        Me.Label_Print1.Size = New System.Drawing.Size(25, 16)
        Me.Label_Print1.TabIndex = 11
        Me.Label_Print1.Text = "～"
        '
        'Form_Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(416, 457)
        Me.Controls.Add(Me.Label_Print1)
        Me.Controls.Add(Me.DateTimePicker_PrintEnd)
        Me.Controls.Add(Me.DateTimePicker_PrintStart)
        Me.Controls.Add(Me.Label_PrintPeriod)
        Me.Controls.Add(Me.Button_PrintHolidayWorking2)
        Me.Controls.Add(Me.Button_PrintHolidayWorking1)
        Me.Controls.Add(Me.Button_PrintOverTime)
        Me.Controls.Add(Me.Button_PrintEnd)
        Me.Controls.Add(Me.Label_PrintTitle)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "人事関連様式出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_PrintTitle As Label
    Friend WithEvents Button_PrintEnd As Button
    Friend WithEvents Button_PrintOverTime As Button
    Friend WithEvents Button_PrintHolidayWorking1 As Button
    Friend WithEvents Button_PrintHolidayWorking2 As Button
    Friend WithEvents Label_PrintPeriod As Label
    Friend WithEvents DateTimePicker_PrintStart As DateTimePicker
    Friend WithEvents DateTimePicker_PrintEnd As DateTimePicker
    Friend WithEvents Label_Print1 As Label
End Class
