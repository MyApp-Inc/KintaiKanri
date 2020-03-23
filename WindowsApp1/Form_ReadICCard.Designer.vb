<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ReadICCard
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCardID = New System.Windows.Forms.Button()
        Me.Button_PrintEnd = New System.Windows.Forms.Button()
        Me.RichTextBox_ReadICCard = New System.Windows.Forms.RichTextBox()
        Me.Timer_ReadICCard = New System.Windows.Forms.Timer(Me.components)
        Me.Label_ReadICCardStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCardID
        '
        Me.btnCardID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCardID.Location = New System.Drawing.Point(699, 34)
        Me.btnCardID.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCardID.Name = "btnCardID"
        Me.btnCardID.Size = New System.Drawing.Size(15, 16)
        Me.btnCardID.TabIndex = 0
        Me.btnCardID.UseVisualStyleBackColor = True
        '
        'Button_PrintEnd
        '
        Me.Button_PrintEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_PrintEnd.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_PrintEnd.Location = New System.Drawing.Point(602, 394)
        Me.Button_PrintEnd.Name = "Button_PrintEnd"
        Me.Button_PrintEnd.Size = New System.Drawing.Size(112, 36)
        Me.Button_PrintEnd.TabIndex = 5
        Me.Button_PrintEnd.Text = "閉じる"
        Me.Button_PrintEnd.UseVisualStyleBackColor = True
        '
        'RichTextBox_ReadICCard
        '
        Me.RichTextBox_ReadICCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox_ReadICCard.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RichTextBox_ReadICCard.Location = New System.Drawing.Point(-1, 77)
        Me.RichTextBox_ReadICCard.Name = "RichTextBox_ReadICCard"
        Me.RichTextBox_ReadICCard.ReadOnly = True
        Me.RichTextBox_ReadICCard.Size = New System.Drawing.Size(724, 311)
        Me.RichTextBox_ReadICCard.TabIndex = 6
        Me.RichTextBox_ReadICCard.TabStop = False
        Me.RichTextBox_ReadICCard.Text = ""
        '
        'Timer_ReadICCard
        '
        Me.Timer_ReadICCard.Enabled = True
        Me.Timer_ReadICCard.Interval = 1050
        '
        'Label_ReadICCardStatus
        '
        Me.Label_ReadICCardStatus.AutoSize = True
        Me.Label_ReadICCardStatus.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ReadICCardStatus.ForeColor = System.Drawing.Color.Blue
        Me.Label_ReadICCardStatus.Location = New System.Drawing.Point(12, 23)
        Me.Label_ReadICCardStatus.Name = "Label_ReadICCardStatus"
        Me.Label_ReadICCardStatus.Size = New System.Drawing.Size(414, 27)
        Me.Label_ReadICCardStatus.TabIndex = 7
        Me.Label_ReadICCardStatus.Text = "ＩＣカードをリーダーにタッチしてください"
        '
        'Form_ReadICCard
        '
        Me.AcceptButton = Me.btnCardID
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(726, 442)
        Me.Controls.Add(Me.Label_ReadICCardStatus)
        Me.Controls.Add(Me.RichTextBox_ReadICCard)
        Me.Controls.Add(Me.Button_PrintEnd)
        Me.Controls.Add(Me.btnCardID)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(442, 178)
        Me.Name = "Form_ReadICCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ICカード登録・変更"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCardID As System.Windows.Forms.Button
    Friend WithEvents Button_PrintEnd As Button
    Friend WithEvents RichTextBox_ReadICCard As RichTextBox
    Friend WithEvents Timer_ReadICCard As Timer
    Friend WithEvents Label_ReadICCardStatus As Label
End Class
