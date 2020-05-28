<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Timer_MouseCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Recent = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_LogFile = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(12, 44)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(146, 22)
        Me.Label_Title.TabIndex = 14
        Me.Label_Title.Text = "ログ管理ツール"
        '
        'Timer_MouseCheck
        '
        Me.Timer_MouseCheck.Enabled = True
        Me.Timer_MouseCheck.Interval = 60000
        '
        'Timer_Recent
        '
        Me.Timer_Recent.Enabled = True
        Me.Timer_Recent.Interval = 300000
        '
        'Timer_LogFile
        '
        Me.Timer_LogFile.Enabled = True
        Me.Timer_LogFile.Interval = 60000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 109)
        Me.Controls.Add(Me.Label_Title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "ログ管理ツール"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Timer_MouseCheck As Timer
    Friend WithEvents Timer_Recent As Timer
    Friend WithEvents Timer_LogFile As Timer
End Class
