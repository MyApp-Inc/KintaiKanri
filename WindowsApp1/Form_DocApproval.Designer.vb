<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_DocApproval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DocApproval))
        Me.Button_DocApprovalClose = New System.Windows.Forms.Button()
        Me.Label_MenuTitle = New System.Windows.Forms.Label()
        Me.Label_ApprovalFile = New System.Windows.Forms.Label()
        Me.TextBox_ApprovalFile = New System.Windows.Forms.TextBox()
        Me.Button_History = New System.Windows.Forms.Button()
        Me.Button_OpenFile = New System.Windows.Forms.Button()
        Me.Label_ApprovalPerson = New System.Windows.Forms.Label()
        Me.CheckBox_Division = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Department = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Bureau = New System.Windows.Forms.CheckBox()
        Me.CheckBox_COO = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Manager1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_CFO = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Boss2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Boss1 = New System.Windows.Forms.CheckBox()
        Me.TextBox_ApprovalSubject = New System.Windows.Forms.TextBox()
        Me.Label_ApprovalSubject = New System.Windows.Forms.Label()
        Me.Button_Execute = New System.Windows.Forms.Button()
        Me.CheckBox_Manager2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Manager3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Manager4 = New System.Windows.Forms.CheckBox()
        Me.Label_ApprovalFileDesc = New System.Windows.Forms.Label()
        Me.Label_SubjectAlart = New System.Windows.Forms.Label()
        Me.Label_FileAlart = New System.Windows.Forms.Label()
        Me.Label_PersonAlart = New System.Windows.Forms.Label()
        Me.GroupBox_Person = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Person.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_DocApprovalClose
        '
        Me.Button_DocApprovalClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_DocApprovalClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_DocApprovalClose.Location = New System.Drawing.Point(911, 627)
        Me.Button_DocApprovalClose.Name = "Button_DocApprovalClose"
        Me.Button_DocApprovalClose.Size = New System.Drawing.Size(112, 36)
        Me.Button_DocApprovalClose.TabIndex = 10
        Me.Button_DocApprovalClose.Text = "閉じる"
        Me.Button_DocApprovalClose.UseVisualStyleBackColor = True
        '
        'Label_MenuTitle
        '
        Me.Label_MenuTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_MenuTitle.AutoSize = True
        Me.Label_MenuTitle.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_MenuTitle.Location = New System.Drawing.Point(443, 38)
        Me.Label_MenuTitle.Name = "Label_MenuTitle"
        Me.Label_MenuTitle.Size = New System.Drawing.Size(148, 22)
        Me.Label_MenuTitle.TabIndex = 11
        Me.Label_MenuTitle.Text = "電子承認申請"
        '
        'Label_ApprovalFile
        '
        Me.Label_ApprovalFile.AutoSize = True
        Me.Label_ApprovalFile.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ApprovalFile.Location = New System.Drawing.Point(12, 158)
        Me.Label_ApprovalFile.Name = "Label_ApprovalFile"
        Me.Label_ApprovalFile.Size = New System.Drawing.Size(100, 16)
        Me.Label_ApprovalFile.TabIndex = 12
        Me.Label_ApprovalFile.Text = "申請ファイル："
        '
        'TextBox_ApprovalFile
        '
        Me.TextBox_ApprovalFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ApprovalFile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox_ApprovalFile.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_ApprovalFile.Location = New System.Drawing.Point(15, 211)
        Me.TextBox_ApprovalFile.Multiline = True
        Me.TextBox_ApprovalFile.Name = "TextBox_ApprovalFile"
        Me.TextBox_ApprovalFile.ReadOnly = True
        Me.TextBox_ApprovalFile.Size = New System.Drawing.Size(1007, 94)
        Me.TextBox_ApprovalFile.TabIndex = 13
        '
        'Button_History
        '
        Me.Button_History.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_History.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_History.Location = New System.Drawing.Point(15, 627)
        Me.Button_History.Name = "Button_History"
        Me.Button_History.Size = New System.Drawing.Size(173, 36)
        Me.Button_History.TabIndex = 14
        Me.Button_History.Text = "承認申請履歴"
        Me.Button_History.UseVisualStyleBackColor = True
        '
        'Button_OpenFile
        '
        Me.Button_OpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_OpenFile.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_OpenFile.Location = New System.Drawing.Point(910, 311)
        Me.Button_OpenFile.Name = "Button_OpenFile"
        Me.Button_OpenFile.Size = New System.Drawing.Size(112, 36)
        Me.Button_OpenFile.TabIndex = 15
        Me.Button_OpenFile.Text = "参照"
        Me.Button_OpenFile.UseVisualStyleBackColor = True
        '
        'Label_ApprovalPerson
        '
        Me.Label_ApprovalPerson.AutoSize = True
        Me.Label_ApprovalPerson.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ApprovalPerson.Location = New System.Drawing.Point(12, 360)
        Me.Label_ApprovalPerson.Name = "Label_ApprovalPerson"
        Me.Label_ApprovalPerson.Size = New System.Drawing.Size(188, 16)
        Me.Label_ApprovalPerson.TabIndex = 16
        Me.Label_ApprovalPerson.Text = "申請対象者（決裁権者）："
        '
        'CheckBox_Division
        '
        Me.CheckBox_Division.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Division.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Division.Location = New System.Drawing.Point(858, 57)
        Me.CheckBox_Division.Name = "CheckBox_Division"
        Me.CheckBox_Division.Size = New System.Drawing.Size(163, 36)
        Me.CheckBox_Division.TabIndex = 17
        Me.CheckBox_Division.Text = "上長"
        Me.CheckBox_Division.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Division.UseVisualStyleBackColor = True
        '
        'CheckBox_Department
        '
        Me.CheckBox_Department.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Department.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Department.Location = New System.Drawing.Point(689, 57)
        Me.CheckBox_Department.Name = "CheckBox_Department"
        Me.CheckBox_Department.Size = New System.Drawing.Size(163, 36)
        Me.CheckBox_Department.TabIndex = 18
        Me.CheckBox_Department.Text = "部長／次長"
        Me.CheckBox_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Department.UseVisualStyleBackColor = True
        '
        'CheckBox_Bureau
        '
        Me.CheckBox_Bureau.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Bureau.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Bureau.Location = New System.Drawing.Point(520, 57)
        Me.CheckBox_Bureau.Name = "CheckBox_Bureau"
        Me.CheckBox_Bureau.Size = New System.Drawing.Size(163, 36)
        Me.CheckBox_Bureau.TabIndex = 19
        Me.CheckBox_Bureau.Text = "本部長（該当部署）"
        Me.CheckBox_Bureau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Bureau.UseVisualStyleBackColor = True
        '
        'CheckBox_COO
        '
        Me.CheckBox_COO.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_COO.Enabled = False
        Me.CheckBox_COO.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_COO.Location = New System.Drawing.Point(351, 57)
        Me.CheckBox_COO.Name = "CheckBox_COO"
        Me.CheckBox_COO.Size = New System.Drawing.Size(163, 36)
        Me.CheckBox_COO.TabIndex = 20
        Me.CheckBox_COO.Text = "COO"
        Me.CheckBox_COO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_COO.UseVisualStyleBackColor = True
        '
        'CheckBox_Manager1
        '
        Me.CheckBox_Manager1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Manager1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Manager1.Location = New System.Drawing.Point(182, 57)
        Me.CheckBox_Manager1.Name = "CheckBox_Manager1"
        Me.CheckBox_Manager1.Size = New System.Drawing.Size(163, 36)
        Me.CheckBox_Manager1.TabIndex = 21
        Me.CheckBox_Manager1.Text = "管理本部長"
        Me.CheckBox_Manager1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Manager1.UseVisualStyleBackColor = True
        '
        'CheckBox_CFO
        '
        Me.CheckBox_CFO.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_CFO.Enabled = False
        Me.CheckBox_CFO.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_CFO.Location = New System.Drawing.Point(13, 59)
        Me.CheckBox_CFO.Name = "CheckBox_CFO"
        Me.CheckBox_CFO.Size = New System.Drawing.Size(163, 36)
        Me.CheckBox_CFO.TabIndex = 22
        Me.CheckBox_CFO.Text = "CFO"
        Me.CheckBox_CFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_CFO.UseVisualStyleBackColor = True
        '
        'CheckBox_Boss2
        '
        Me.CheckBox_Boss2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Boss2.Enabled = False
        Me.CheckBox_Boss2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Boss2.Location = New System.Drawing.Point(520, 6)
        Me.CheckBox_Boss2.Name = "CheckBox_Boss2"
        Me.CheckBox_Boss2.Size = New System.Drawing.Size(501, 36)
        Me.CheckBox_Boss2.TabIndex = 23
        Me.CheckBox_Boss2.Text = "副社長"
        Me.CheckBox_Boss2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Boss2.UseVisualStyleBackColor = True
        '
        'CheckBox_Boss1
        '
        Me.CheckBox_Boss1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Boss1.Enabled = False
        Me.CheckBox_Boss1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Boss1.Location = New System.Drawing.Point(13, 6)
        Me.CheckBox_Boss1.Name = "CheckBox_Boss1"
        Me.CheckBox_Boss1.Size = New System.Drawing.Size(501, 36)
        Me.CheckBox_Boss1.TabIndex = 24
        Me.CheckBox_Boss1.Text = "社長"
        Me.CheckBox_Boss1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Boss1.UseVisualStyleBackColor = True
        '
        'TextBox_ApprovalSubject
        '
        Me.TextBox_ApprovalSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ApprovalSubject.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox_ApprovalSubject.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox_ApprovalSubject.Location = New System.Drawing.Point(15, 110)
        Me.TextBox_ApprovalSubject.MaxLength = 100
        Me.TextBox_ApprovalSubject.Name = "TextBox_ApprovalSubject"
        Me.TextBox_ApprovalSubject.Size = New System.Drawing.Size(1007, 23)
        Me.TextBox_ApprovalSubject.TabIndex = 26
        '
        'Label_ApprovalSubject
        '
        Me.Label_ApprovalSubject.AutoSize = True
        Me.Label_ApprovalSubject.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ApprovalSubject.Location = New System.Drawing.Point(12, 79)
        Me.Label_ApprovalSubject.Name = "Label_ApprovalSubject"
        Me.Label_ApprovalSubject.Size = New System.Drawing.Size(51, 16)
        Me.Label_ApprovalSubject.TabIndex = 25
        Me.Label_ApprovalSubject.Text = "件名："
        '
        'Button_Execute
        '
        Me.Button_Execute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Execute.Enabled = False
        Me.Button_Execute.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Execute.Location = New System.Drawing.Point(692, 571)
        Me.Button_Execute.Name = "Button_Execute"
        Me.Button_Execute.Size = New System.Drawing.Size(331, 36)
        Me.Button_Execute.TabIndex = 27
        Me.Button_Execute.Text = "承認申請実行"
        Me.Button_Execute.UseVisualStyleBackColor = True
        '
        'CheckBox_Manager2
        '
        Me.CheckBox_Manager2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Manager2.Enabled = False
        Me.CheckBox_Manager2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Manager2.Location = New System.Drawing.Point(13, 112)
        Me.CheckBox_Manager2.Name = "CheckBox_Manager2"
        Me.CheckBox_Manager2.Size = New System.Drawing.Size(332, 36)
        Me.CheckBox_Manager2.TabIndex = 28
        Me.CheckBox_Manager2.Text = "関係本部長（営業本部）"
        Me.CheckBox_Manager2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Manager2.UseVisualStyleBackColor = True
        '
        'CheckBox_Manager3
        '
        Me.CheckBox_Manager3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Manager3.Enabled = False
        Me.CheckBox_Manager3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Manager3.Location = New System.Drawing.Point(351, 112)
        Me.CheckBox_Manager3.Name = "CheckBox_Manager3"
        Me.CheckBox_Manager3.Size = New System.Drawing.Size(332, 36)
        Me.CheckBox_Manager3.TabIndex = 29
        Me.CheckBox_Manager3.Text = "関係本部長（マーケティング本部）"
        Me.CheckBox_Manager3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Manager3.UseVisualStyleBackColor = True
        '
        'CheckBox_Manager4
        '
        Me.CheckBox_Manager4.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Manager4.Enabled = False
        Me.CheckBox_Manager4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox_Manager4.Location = New System.Drawing.Point(690, 112)
        Me.CheckBox_Manager4.Name = "CheckBox_Manager4"
        Me.CheckBox_Manager4.Size = New System.Drawing.Size(332, 36)
        Me.CheckBox_Manager4.TabIndex = 30
        Me.CheckBox_Manager4.Text = "関係本部長（生産本部）"
        Me.CheckBox_Manager4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Manager4.UseVisualStyleBackColor = True
        '
        'Label_ApprovalFileDesc
        '
        Me.Label_ApprovalFileDesc.AutoSize = True
        Me.Label_ApprovalFileDesc.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_ApprovalFileDesc.Location = New System.Drawing.Point(12, 185)
        Me.Label_ApprovalFileDesc.Name = "Label_ApprovalFileDesc"
        Me.Label_ApprovalFileDesc.Size = New System.Drawing.Size(629, 15)
        Me.Label_ApprovalFileDesc.TabIndex = 31
        Me.Label_ApprovalFileDesc.Text = "「参照」ボタンを押して申請ファイルを選択するか、申請ファイルをこのフォームにドラッグ＆ドロップしてください。"
        '
        'Label_SubjectAlart
        '
        Me.Label_SubjectAlart.AutoSize = True
        Me.Label_SubjectAlart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_SubjectAlart.ForeColor = System.Drawing.Color.Red
        Me.Label_SubjectAlart.Location = New System.Drawing.Point(69, 79)
        Me.Label_SubjectAlart.Name = "Label_SubjectAlart"
        Me.Label_SubjectAlart.Size = New System.Drawing.Size(59, 16)
        Me.Label_SubjectAlart.TabIndex = 32
        Me.Label_SubjectAlart.Text = "未入力"
        '
        'Label_FileAlart
        '
        Me.Label_FileAlart.AutoSize = True
        Me.Label_FileAlart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_FileAlart.ForeColor = System.Drawing.Color.Red
        Me.Label_FileAlart.Location = New System.Drawing.Point(118, 158)
        Me.Label_FileAlart.Name = "Label_FileAlart"
        Me.Label_FileAlart.Size = New System.Drawing.Size(59, 16)
        Me.Label_FileAlart.TabIndex = 33
        Me.Label_FileAlart.Text = "未選択"
        '
        'Label_PersonAlart
        '
        Me.Label_PersonAlart.AutoSize = True
        Me.Label_PersonAlart.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_PersonAlart.ForeColor = System.Drawing.Color.Red
        Me.Label_PersonAlart.Location = New System.Drawing.Point(206, 360)
        Me.Label_PersonAlart.Name = "Label_PersonAlart"
        Me.Label_PersonAlart.Size = New System.Drawing.Size(59, 16)
        Me.Label_PersonAlart.TabIndex = 34
        Me.Label_PersonAlart.Text = "未選択"
        '
        'GroupBox_Person
        '
        Me.GroupBox_Person.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Manager4)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Manager3)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Manager2)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Boss1)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Boss2)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_CFO)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Manager1)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_COO)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Bureau)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Department)
        Me.GroupBox_Person.Controls.Add(Me.CheckBox_Division)
        Me.GroupBox_Person.Location = New System.Drawing.Point(2, 387)
        Me.GroupBox_Person.Name = "GroupBox_Person"
        Me.GroupBox_Person.Size = New System.Drawing.Size(1033, 158)
        Me.GroupBox_Person.TabIndex = 35
        Me.GroupBox_Person.TabStop = False
        '
        'Form_DocApproval
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 675)
        Me.Controls.Add(Me.GroupBox_Person)
        Me.Controls.Add(Me.Label_PersonAlart)
        Me.Controls.Add(Me.Label_FileAlart)
        Me.Controls.Add(Me.Label_SubjectAlart)
        Me.Controls.Add(Me.Label_ApprovalFileDesc)
        Me.Controls.Add(Me.Button_Execute)
        Me.Controls.Add(Me.TextBox_ApprovalSubject)
        Me.Controls.Add(Me.Label_ApprovalSubject)
        Me.Controls.Add(Me.Label_ApprovalPerson)
        Me.Controls.Add(Me.Button_OpenFile)
        Me.Controls.Add(Me.Button_History)
        Me.Controls.Add(Me.TextBox_ApprovalFile)
        Me.Controls.Add(Me.Label_ApprovalFile)
        Me.Controls.Add(Me.Label_MenuTitle)
        Me.Controls.Add(Me.Button_DocApprovalClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_DocApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "電子承認申請"
        Me.GroupBox_Person.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_DocApprovalClose As Button
    Friend WithEvents Label_MenuTitle As Label
    Friend WithEvents Label_ApprovalFile As Label
    Friend WithEvents TextBox_ApprovalFile As TextBox
    Friend WithEvents Button_History As Button
    Friend WithEvents Button_OpenFile As Button
    Friend WithEvents Label_ApprovalPerson As Label
    Friend WithEvents CheckBox_Division As CheckBox
    Friend WithEvents CheckBox_Department As CheckBox
    Friend WithEvents CheckBox_Bureau As CheckBox
    Friend WithEvents CheckBox_COO As CheckBox
    Friend WithEvents CheckBox_Manager1 As CheckBox
    Friend WithEvents CheckBox_CFO As CheckBox
    Friend WithEvents CheckBox_Boss2 As CheckBox
    Friend WithEvents CheckBox_Boss1 As CheckBox
    Friend WithEvents TextBox_ApprovalSubject As TextBox
    Friend WithEvents Label_ApprovalSubject As Label
    Friend WithEvents Button_Execute As Button
    Friend WithEvents CheckBox_Manager2 As CheckBox
    Friend WithEvents CheckBox_Manager3 As CheckBox
    Friend WithEvents CheckBox_Manager4 As CheckBox
    Friend WithEvents Label_ApprovalFileDesc As Label
    Friend WithEvents Label_SubjectAlart As Label
    Friend WithEvents Label_FileAlart As Label
    Friend WithEvents Label_PersonAlart As Label
    Friend WithEvents GroupBox_Person As GroupBox
End Class
