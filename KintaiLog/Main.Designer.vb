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
        Me.NotifyIcon_Main = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_End = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_MouseCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Recent = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(12, 44)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(192, 22)
        Me.Label_Title.TabIndex = 14
        Me.Label_Title.Text = "勤怠ログ管理ツール"
        '
        'NotifyIcon_Main
        '
        Me.NotifyIcon_Main.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon_Main.BalloonTipText = "勤怠ログ管理ツールが起動しました"
        Me.NotifyIcon_Main.BalloonTipTitle = "勤怠ログ管理ツール"
        Me.NotifyIcon_Main.ContextMenuStrip = Me.ContextMenuStrip_Main
        Me.NotifyIcon_Main.Icon = CType(resources.GetObject("NotifyIcon_Main.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Main.Text = "勤怠ログ管理ツール"
        Me.NotifyIcon_Main.Visible = True
        '
        'ContextMenuStrip_Main
        '
        Me.ContextMenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_End})
        Me.ContextMenuStrip_Main.Name = "ContextMenuStrip_Main"
        Me.ContextMenuStrip_Main.Size = New System.Drawing.Size(101, 26)
        Me.ContextMenuStrip_Main.Text = "機能"
        '
        'ToolStripMenuItem_End
        '
        Me.ToolStripMenuItem_End.Name = "ToolStripMenuItem_End"
        Me.ToolStripMenuItem_End.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem_End.Text = "終了"
        '
        'Timer_MouseCheck
        '
        Me.Timer_MouseCheck.Enabled = True
        Me.Timer_MouseCheck.Interval = 60000
        '
        'Timer_Recent
        '
        Me.Timer_Recent.Enabled = True
        Me.Timer_Recent.Interval = 3600000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 109)
        Me.Controls.Add(Me.Label_Title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "勤怠ログ管理ツール"
        Me.ContextMenuStrip_Main.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents NotifyIcon_Main As NotifyIcon
    Friend WithEvents ContextMenuStrip_Main As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_End As ToolStripMenuItem
    Friend WithEvents Timer_MouseCheck As Timer
    Friend WithEvents Timer_Recent As Timer
End Class
