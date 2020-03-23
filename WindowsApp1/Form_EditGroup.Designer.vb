<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EditGroup
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("（新規追加）")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_EditGroup))
        Me.Button_EditGroupEnd = New System.Windows.Forms.Button()
        Me.Label_Bureau = New System.Windows.Forms.Label()
        Me.Label_Department = New System.Windows.Forms.Label()
        Me.Label_Division = New System.Windows.Forms.Label()
        Me.ListView_Bureau = New System.Windows.Forms.ListView()
        Me.ListView_Department = New System.Windows.Forms.ListView()
        Me.ListView_Division = New System.Windows.Forms.ListView()
        Me.TextBox_AddOrEdit = New System.Windows.Forms.TextBox()
        Me.Label_AddOrEdit = New System.Windows.Forms.Label()
        Me.Button_AddOrEdit = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_EditGroupEnd
        '
        Me.Button_EditGroupEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_EditGroupEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_EditGroupEnd.Location = New System.Drawing.Point(968, 523)
        Me.Button_EditGroupEnd.Name = "Button_EditGroupEnd"
        Me.Button_EditGroupEnd.Size = New System.Drawing.Size(112, 36)
        Me.Button_EditGroupEnd.TabIndex = 3
        Me.Button_EditGroupEnd.Text = "閉じる"
        Me.Button_EditGroupEnd.UseVisualStyleBackColor = True
        '
        'Label_Bureau
        '
        Me.Label_Bureau.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Bureau.AutoSize = True
        Me.Label_Bureau.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Bureau.Location = New System.Drawing.Point(54, 27)
        Me.Label_Bureau.Name = "Label_Bureau"
        Me.Label_Bureau.Size = New System.Drawing.Size(89, 19)
        Me.Label_Bureau.TabIndex = 7
        Me.Label_Bureau.Text = "本部一覧"
        '
        'Label_Department
        '
        Me.Label_Department.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Department.AutoSize = True
        Me.Label_Department.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Department.Location = New System.Drawing.Point(413, 27)
        Me.Label_Department.Name = "Label_Department"
        Me.Label_Department.Size = New System.Drawing.Size(69, 19)
        Me.Label_Department.TabIndex = 8
        Me.Label_Department.Text = "部一覧"
        '
        'Label_Division
        '
        Me.Label_Division.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Division.AutoSize = True
        Me.Label_Division.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_Division.Location = New System.Drawing.Point(778, 27)
        Me.Label_Division.Name = "Label_Division"
        Me.Label_Division.Size = New System.Drawing.Size(69, 19)
        Me.Label_Division.TabIndex = 9
        Me.Label_Division.Text = "課一覧"
        '
        'ListView_Bureau
        '
        Me.ListView_Bureau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListView_Bureau.FullRowSelect = True
        Me.ListView_Bureau.HideSelection = False
        Me.ListView_Bureau.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView_Bureau.Location = New System.Drawing.Point(58, 69)
        Me.ListView_Bureau.MultiSelect = False
        Me.ListView_Bureau.Name = "ListView_Bureau"
        Me.ListView_Bureau.Size = New System.Drawing.Size(298, 396)
        Me.ListView_Bureau.TabIndex = 4
        Me.ListView_Bureau.UseCompatibleStateImageBehavior = False
        Me.ListView_Bureau.View = System.Windows.Forms.View.List
        '
        'ListView_Department
        '
        Me.ListView_Department.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListView_Department.FullRowSelect = True
        Me.ListView_Department.HideSelection = False
        Me.ListView_Department.Location = New System.Drawing.Point(417, 69)
        Me.ListView_Department.MultiSelect = False
        Me.ListView_Department.Name = "ListView_Department"
        Me.ListView_Department.Size = New System.Drawing.Size(298, 396)
        Me.ListView_Department.TabIndex = 5
        Me.ListView_Department.UseCompatibleStateImageBehavior = False
        Me.ListView_Department.View = System.Windows.Forms.View.List
        '
        'ListView_Division
        '
        Me.ListView_Division.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListView_Division.FullRowSelect = True
        Me.ListView_Division.HideSelection = False
        Me.ListView_Division.Location = New System.Drawing.Point(782, 69)
        Me.ListView_Division.MultiSelect = False
        Me.ListView_Division.Name = "ListView_Division"
        Me.ListView_Division.Size = New System.Drawing.Size(298, 396)
        Me.ListView_Division.TabIndex = 6
        Me.ListView_Division.UseCompatibleStateImageBehavior = False
        Me.ListView_Division.View = System.Windows.Forms.View.List
        '
        'TextBox_AddOrEdit
        '
        Me.TextBox_AddOrEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_AddOrEdit.Location = New System.Drawing.Point(58, 523)
        Me.TextBox_AddOrEdit.MaxLength = 50
        Me.TextBox_AddOrEdit.Name = "TextBox_AddOrEdit"
        Me.TextBox_AddOrEdit.Size = New System.Drawing.Size(298, 26)
        Me.TextBox_AddOrEdit.TabIndex = 0
        Me.TextBox_AddOrEdit.Visible = False
        '
        'Label_AddOrEdit
        '
        Me.Label_AddOrEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_AddOrEdit.AutoSize = True
        Me.Label_AddOrEdit.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_AddOrEdit.Location = New System.Drawing.Point(54, 492)
        Me.Label_AddOrEdit.Name = "Label_AddOrEdit"
        Me.Label_AddOrEdit.Size = New System.Drawing.Size(316, 19)
        Me.Label_AddOrEdit.TabIndex = 10
        Me.Label_AddOrEdit.Text = "追加・編集する所属を選択してください"
        '
        'Button_AddOrEdit
        '
        Me.Button_AddOrEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_AddOrEdit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_AddOrEdit.Location = New System.Drawing.Point(362, 523)
        Me.Button_AddOrEdit.Name = "Button_AddOrEdit"
        Me.Button_AddOrEdit.Size = New System.Drawing.Size(112, 36)
        Me.Button_AddOrEdit.TabIndex = 1
        Me.Button_AddOrEdit.Text = "追加"
        Me.Button_AddOrEdit.UseVisualStyleBackColor = True
        Me.Button_AddOrEdit.Visible = False
        '
        'Button_Delete
        '
        Me.Button_Delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Delete.Enabled = False
        Me.Button_Delete.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(480, 523)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(112, 36)
        Me.Button_Delete.TabIndex = 2
        Me.Button_Delete.Text = "削除"
        Me.Button_Delete.UseVisualStyleBackColor = True
        Me.Button_Delete.Visible = False
        '
        'Form_EditGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1121, 571)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_AddOrEdit)
        Me.Controls.Add(Me.Label_AddOrEdit)
        Me.Controls.Add(Me.TextBox_AddOrEdit)
        Me.Controls.Add(Me.ListView_Division)
        Me.Controls.Add(Me.ListView_Department)
        Me.Controls.Add(Me.ListView_Bureau)
        Me.Controls.Add(Me.Label_Division)
        Me.Controls.Add(Me.Label_Department)
        Me.Controls.Add(Me.Label_Bureau)
        Me.Controls.Add(Me.Button_EditGroupEnd)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form_EditGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_EditGroupEnd As Button
    Friend WithEvents Label_Bureau As Label
    Friend WithEvents Label_Department As Label
    Friend WithEvents Label_Division As Label
    Friend WithEvents ListView_Bureau As ListView
    Friend WithEvents ListView_Department As ListView
    Friend WithEvents ListView_Division As ListView
    Friend WithEvents TextBox_AddOrEdit As TextBox
    Friend WithEvents Label_AddOrEdit As Label
    Friend WithEvents Button_AddOrEdit As Button
    Friend WithEvents Button_Delete As Button
End Class
