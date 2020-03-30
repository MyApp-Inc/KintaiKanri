<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Menu))
        Me.Button_MenuEnd = New System.Windows.Forms.Button()
        Me.Label_MenuTitle = New System.Windows.Forms.Label()
        Me.Button_Menu1 = New System.Windows.Forms.Button()
        Me.Button_MenuVerify = New System.Windows.Forms.Button()
        Me.Button_MenuExportData = New System.Windows.Forms.Button()
        Me.Button_MenuEditUser = New System.Windows.Forms.Button()
        Me.Button_MenuEditGroup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_MenuHolidayManager = New System.Windows.Forms.Button()
        Me.Button_MenuPublicHoliday = New System.Windows.Forms.Button()
        Me.Button_MenuPrint = New System.Windows.Forms.Button()
        Me.Button_MenuReadICCard = New System.Windows.Forms.Button()
        Me.Button_DocApproval = New System.Windows.Forms.Button()
        Me.Button_DocApprovalList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_MenuEnd
        '
        Me.Button_MenuEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_MenuEnd.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuEnd.Location = New System.Drawing.Point(766, 530)
        Me.Button_MenuEnd.Name = "Button_MenuEnd"
        Me.Button_MenuEnd.Size = New System.Drawing.Size(112, 36)
        Me.Button_MenuEnd.TabIndex = 9
        Me.Button_MenuEnd.Text = "閉じる"
        Me.Button_MenuEnd.UseVisualStyleBackColor = True
        '
        'Label_MenuTitle
        '
        Me.Label_MenuTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_MenuTitle.AutoSize = True
        Me.Label_MenuTitle.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_MenuTitle.Location = New System.Drawing.Point(399, 33)
        Me.Label_MenuTitle.Name = "Label_MenuTitle"
        Me.Label_MenuTitle.Size = New System.Drawing.Size(102, 22)
        Me.Label_MenuTitle.TabIndex = 10
        Me.Label_MenuTitle.Text = "各種機能"
        '
        'Button_Menu1
        '
        Me.Button_Menu1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_Menu1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_Menu1.Location = New System.Drawing.Point(16, 135)
        Me.Button_Menu1.Name = "Button_Menu1"
        Me.Button_Menu1.Size = New System.Drawing.Size(266, 36)
        Me.Button_Menu1.TabIndex = 0
        Me.Button_Menu1.Text = "勤務開始・終了時刻一覧表示"
        Me.Button_Menu1.UseVisualStyleBackColor = True
        '
        'Button_MenuVerify
        '
        Me.Button_MenuVerify.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuVerify.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuVerify.Location = New System.Drawing.Point(16, 251)
        Me.Button_MenuVerify.Name = "Button_MenuVerify"
        Me.Button_MenuVerify.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuVerify.TabIndex = 1
        Me.Button_MenuVerify.Text = "勤怠承認"
        Me.Button_MenuVerify.UseVisualStyleBackColor = True
        '
        'Button_MenuExportData
        '
        Me.Button_MenuExportData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuExportData.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuExportData.Location = New System.Drawing.Point(612, 432)
        Me.Button_MenuExportData.Name = "Button_MenuExportData"
        Me.Button_MenuExportData.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuExportData.TabIndex = 5
        Me.Button_MenuExportData.Text = "勤怠データ出力"
        Me.Button_MenuExportData.UseVisualStyleBackColor = True
        '
        'Button_MenuEditUser
        '
        Me.Button_MenuEditUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuEditUser.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuEditUser.Location = New System.Drawing.Point(16, 432)
        Me.Button_MenuEditUser.Name = "Button_MenuEditUser"
        Me.Button_MenuEditUser.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuEditUser.TabIndex = 7
        Me.Button_MenuEditUser.Text = "社員データ管理"
        Me.Button_MenuEditUser.UseVisualStyleBackColor = True
        '
        'Button_MenuEditGroup
        '
        Me.Button_MenuEditGroup.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuEditGroup.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuEditGroup.Location = New System.Drawing.Point(314, 432)
        Me.Button_MenuEditGroup.Name = "Button_MenuEditGroup"
        Me.Button_MenuEditGroup.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuEditGroup.TabIndex = 8
        Me.Button_MenuEditGroup.Text = "所属データ管理"
        Me.Button_MenuEditGroup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "一般機能"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "管理機能"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "人事機能"
        '
        'Button_MenuHolidayManager
        '
        Me.Button_MenuHolidayManager.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuHolidayManager.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuHolidayManager.Location = New System.Drawing.Point(16, 367)
        Me.Button_MenuHolidayManager.Name = "Button_MenuHolidayManager"
        Me.Button_MenuHolidayManager.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuHolidayManager.TabIndex = 4
        Me.Button_MenuHolidayManager.Text = "休日勤務及び振替休日管理"
        Me.Button_MenuHolidayManager.UseVisualStyleBackColor = True
        '
        'Button_MenuPublicHoliday
        '
        Me.Button_MenuPublicHoliday.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuPublicHoliday.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuPublicHoliday.Location = New System.Drawing.Point(314, 367)
        Me.Button_MenuPublicHoliday.Name = "Button_MenuPublicHoliday"
        Me.Button_MenuPublicHoliday.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuPublicHoliday.TabIndex = 6
        Me.Button_MenuPublicHoliday.Text = "祝日・法定休日管理"
        Me.Button_MenuPublicHoliday.UseVisualStyleBackColor = True
        '
        'Button_MenuPrint
        '
        Me.Button_MenuPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuPrint.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuPrint.Location = New System.Drawing.Point(612, 367)
        Me.Button_MenuPrint.Name = "Button_MenuPrint"
        Me.Button_MenuPrint.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuPrint.TabIndex = 2
        Me.Button_MenuPrint.Text = "人事関連様式出力"
        Me.Button_MenuPrint.UseVisualStyleBackColor = True
        '
        'Button_MenuReadICCard
        '
        Me.Button_MenuReadICCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_MenuReadICCard.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_MenuReadICCard.Location = New System.Drawing.Point(314, 135)
        Me.Button_MenuReadICCard.Name = "Button_MenuReadICCard"
        Me.Button_MenuReadICCard.Size = New System.Drawing.Size(266, 36)
        Me.Button_MenuReadICCard.TabIndex = 3
        Me.Button_MenuReadICCard.Text = "ＩＣカード勤怠管理"
        Me.Button_MenuReadICCard.UseVisualStyleBackColor = True
        '
        'Button_DocApproval
        '
        Me.Button_DocApproval.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_DocApproval.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_DocApproval.Location = New System.Drawing.Point(612, 135)
        Me.Button_DocApproval.Name = "Button_DocApproval"
        Me.Button_DocApproval.Size = New System.Drawing.Size(266, 36)
        Me.Button_DocApproval.TabIndex = 14
        Me.Button_DocApproval.Text = "電子承認申請"
        Me.Button_DocApproval.UseVisualStyleBackColor = True
        '
        'Button_DocApprovalList
        '
        Me.Button_DocApprovalList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_DocApprovalList.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button_DocApprovalList.Location = New System.Drawing.Point(314, 251)
        Me.Button_DocApprovalList.Name = "Button_DocApprovalList"
        Me.Button_DocApprovalList.Size = New System.Drawing.Size(266, 36)
        Me.Button_DocApprovalList.TabIndex = 15
        Me.Button_DocApprovalList.Text = "電子承認申請の承認"
        Me.Button_DocApprovalList.UseVisualStyleBackColor = True
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(888, 578)
        Me.Controls.Add(Me.Button_DocApprovalList)
        Me.Controls.Add(Me.Button_DocApproval)
        Me.Controls.Add(Me.Button_MenuReadICCard)
        Me.Controls.Add(Me.Button_MenuPrint)
        Me.Controls.Add(Me.Button_MenuPublicHoliday)
        Me.Controls.Add(Me.Button_MenuHolidayManager)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_MenuEditGroup)
        Me.Controls.Add(Me.Button_MenuEditUser)
        Me.Controls.Add(Me.Button_MenuExportData)
        Me.Controls.Add(Me.Button_MenuVerify)
        Me.Controls.Add(Me.Button_Menu1)
        Me.Controls.Add(Me.Label_MenuTitle)
        Me.Controls.Add(Me.Button_MenuEnd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "各種機能"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_MenuEnd As Button
    Friend WithEvents Label_MenuTitle As Label
    Friend WithEvents Button_Menu1 As Button
    Friend WithEvents Button_MenuVerify As Button
    Friend WithEvents Button_MenuExportData As Button
    Friend WithEvents Button_MenuEditUser As Button
    Friend WithEvents Button_MenuEditGroup As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_MenuHolidayManager As Button
    Friend WithEvents Button_MenuPublicHoliday As Button
    Friend WithEvents Button_MenuPrint As Button
    Friend WithEvents Button_MenuReadICCard As Button
    Friend WithEvents Button_DocApproval As Button
    Friend WithEvents Button_DocApprovalList As Button
End Class
