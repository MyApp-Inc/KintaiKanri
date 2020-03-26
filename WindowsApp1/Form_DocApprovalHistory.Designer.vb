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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DocApprovalHistory))
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label_MenuTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(1120, 561)
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
        Me.Label_MenuTitle.Location = New System.Drawing.Point(525, 36)
        Me.Label_MenuTitle.Name = "Label_MenuTitle"
        Me.Label_MenuTitle.Size = New System.Drawing.Size(194, 22)
        Me.Label_MenuTitle.TabIndex = 12
        Me.Label_MenuTitle.Text = "電子承認申請履歴"
        '
        'Form_DocApprovalHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 609)
        Me.Controls.Add(Me.Label_MenuTitle)
        Me.Controls.Add(Me.Button_Close)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_DocApprovalHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "電子承認申請履歴"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Close As Button
    Friend WithEvents Label_MenuTitle As Label
End Class
