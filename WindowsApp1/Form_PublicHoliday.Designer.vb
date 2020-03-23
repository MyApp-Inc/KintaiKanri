<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PublicHoliday
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
        Me.Label_EditUserTitle = New System.Windows.Forms.Label()
        Me.Button_PublicHolidayClose = New System.Windows.Forms.Button()
        Me.Button_PublicHolidayImportCSV = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_EditUserTitle
        '
        Me.Label_EditUserTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_EditUserTitle.AutoSize = True
        Me.Label_EditUserTitle.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_EditUserTitle.Location = New System.Drawing.Point(53, 35)
        Me.Label_EditUserTitle.Name = "Label_EditUserTitle"
        Me.Label_EditUserTitle.Size = New System.Drawing.Size(180, 19)
        Me.Label_EditUserTitle.TabIndex = 10
        Me.Label_EditUserTitle.Text = "祝日・法定休日管理"
        '
        'Button_PublicHolidayClose
        '
        Me.Button_PublicHolidayClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_PublicHolidayClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_PublicHolidayClose.Location = New System.Drawing.Point(148, 341)
        Me.Button_PublicHolidayClose.Name = "Button_PublicHolidayClose"
        Me.Button_PublicHolidayClose.Size = New System.Drawing.Size(112, 36)
        Me.Button_PublicHolidayClose.TabIndex = 16
        Me.Button_PublicHolidayClose.Text = "閉じる"
        Me.Button_PublicHolidayClose.UseVisualStyleBackColor = True
        '
        'Button_PublicHolidayImportCSV
        '
        Me.Button_PublicHolidayImportCSV.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_PublicHolidayImportCSV.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_PublicHolidayImportCSV.Location = New System.Drawing.Point(30, 91)
        Me.Button_PublicHolidayImportCSV.Name = "Button_PublicHolidayImportCSV"
        Me.Button_PublicHolidayImportCSV.Size = New System.Drawing.Size(230, 36)
        Me.Button_PublicHolidayImportCSV.TabIndex = 17
        Me.Button_PublicHolidayImportCSV.Text = "CSVファイル読込"
        Me.Button_PublicHolidayImportCSV.UseVisualStyleBackColor = True
        '
        'Form_PublicHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(287, 389)
        Me.Controls.Add(Me.Button_PublicHolidayImportCSV)
        Me.Controls.Add(Me.Button_PublicHolidayClose)
        Me.Controls.Add(Me.Label_EditUserTitle)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form_PublicHoliday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "祝日・法定休日管理"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_EditUserTitle As Label
    Friend WithEvents Button_PublicHolidayClose As Button
    Friend WithEvents Button_PublicHolidayImportCSV As Button
End Class
