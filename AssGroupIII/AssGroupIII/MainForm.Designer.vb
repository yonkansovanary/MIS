<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.PanelAdminBtn = New System.Windows.Forms.Panel()
        Me.Adminbtn = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelProjectTitle = New System.Windows.Forms.Label()
        Me.LabelUserAdminName = New System.Windows.Forms.Label()
        Me.PanelHeaderB = New System.Windows.Forms.Panel()
        Me.PanelHeaderS = New System.Windows.Forms.Panel()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.ListUserPanel = New System.Windows.Forms.Panel()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.DataGridView_sec_user = New System.Windows.Forms.DataGridView()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.PanelSidebar.SuspendLayout()
        Me.PanelAdminBtn.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderB.SuspendLayout()
        Me.ListUserPanel.SuspendLayout()
        CType(Me.DataGridView_sec_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.Location = New System.Drawing.Point(726, 344)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(91, 24)
        Me.LabelWelcome.TabIndex = 0
        Me.LabelWelcome.Text = "Welcome"
        '
        'PanelSidebar
        '
        Me.PanelSidebar.BackColor = System.Drawing.Color.Navy
        Me.PanelSidebar.Controls.Add(Me.PanelAdminBtn)
        Me.PanelSidebar.Controls.Add(Me.PictureBox2)
        Me.PanelSidebar.Controls.Add(Me.PictureBox1)
        Me.PanelSidebar.Controls.Add(Me.LabelProjectTitle)
        Me.PanelSidebar.Controls.Add(Me.LabelUserAdminName)
        Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSidebar.Name = "PanelSidebar"
        Me.PanelSidebar.Size = New System.Drawing.Size(200, 703)
        Me.PanelSidebar.TabIndex = 1
        '
        'PanelAdminBtn
        '
        Me.PanelAdminBtn.Controls.Add(Me.Adminbtn)
        Me.PanelAdminBtn.Controls.Add(Me.PictureBox8)
        Me.PanelAdminBtn.Location = New System.Drawing.Point(0, 228)
        Me.PanelAdminBtn.Name = "PanelAdminBtn"
        Me.PanelAdminBtn.Size = New System.Drawing.Size(196, 43)
        Me.PanelAdminBtn.TabIndex = 6
        '
        'Adminbtn
        '
        Me.Adminbtn.AutoSize = True
        Me.Adminbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adminbtn.ForeColor = System.Drawing.Color.White
        Me.Adminbtn.Location = New System.Drawing.Point(46, 12)
        Me.Adminbtn.Name = "Adminbtn"
        Me.Adminbtn.Size = New System.Drawing.Size(124, 20)
        Me.Adminbtn.TabIndex = 13
        Me.Adminbtn.Text = "Administration"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(14, 7)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(25, 29)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 9
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(39, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LabelProjectTitle
        '
        Me.LabelProjectTitle.AutoSize = True
        Me.LabelProjectTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProjectTitle.ForeColor = System.Drawing.Color.White
        Me.LabelProjectTitle.Location = New System.Drawing.Point(12, 22)
        Me.LabelProjectTitle.Name = "LabelProjectTitle"
        Me.LabelProjectTitle.Size = New System.Drawing.Size(168, 24)
        Me.LabelProjectTitle.TabIndex = 4
        Me.LabelProjectTitle.Text = "Inventory System"
        '
        'LabelUserAdminName
        '
        Me.LabelUserAdminName.AutoSize = True
        Me.LabelUserAdminName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserAdminName.ForeColor = System.Drawing.Color.White
        Me.LabelUserAdminName.Location = New System.Drawing.Point(74, 183)
        Me.LabelUserAdminName.Name = "LabelUserAdminName"
        Me.LabelUserAdminName.Size = New System.Drawing.Size(86, 20)
        Me.LabelUserAdminName.TabIndex = 7
        Me.LabelUserAdminName.Text = "Lisa Khim"
        '
        'PanelHeaderB
        '
        Me.PanelHeaderB.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PanelHeaderB.Controls.Add(Me.PanelHeaderS)
        Me.PanelHeaderB.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderB.Location = New System.Drawing.Point(200, 0)
        Me.PanelHeaderB.Name = "PanelHeaderB"
        Me.PanelHeaderB.Size = New System.Drawing.Size(1170, 47)
        Me.PanelHeaderB.TabIndex = 2
        '
        'PanelHeaderS
        '
        Me.PanelHeaderS.BackColor = System.Drawing.SystemColors.Control
        Me.PanelHeaderS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderS.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderS.Name = "PanelHeaderS"
        Me.PanelHeaderS.Size = New System.Drawing.Size(1170, 46)
        Me.PanelHeaderS.TabIndex = 3
        '
        'PanelFooter
        '
        Me.PanelFooter.BackColor = System.Drawing.Color.Navy
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(200, 657)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(1170, 46)
        Me.PanelFooter.TabIndex = 3
        '
        'ListUserPanel
        '
        Me.ListUserPanel.Controls.Add(Me.btnAddUser)
        Me.ListUserPanel.Controls.Add(Me.DataGridView_sec_user)
        Me.ListUserPanel.Location = New System.Drawing.Point(200, 94)
        Me.ListUserPanel.Name = "ListUserPanel"
        Me.ListUserPanel.Size = New System.Drawing.Size(1170, 557)
        Me.ListUserPanel.TabIndex = 7
        Me.ListUserPanel.Visible = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.Blue
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.Location = New System.Drawing.Point(1083, 3)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(75, 42)
        Me.btnAddUser.TabIndex = 2
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'DataGridView_sec_user
        '
        Me.DataGridView_sec_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_sec_user.Location = New System.Drawing.Point(10, 51)
        Me.DataGridView_sec_user.Name = "DataGridView_sec_user"
        Me.DataGridView_sec_user.Size = New System.Drawing.Size(1148, 497)
        Me.DataGridView_sec_user.TabIndex = 0
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.ForeColor = System.Drawing.Color.Black
        Me.AdminLabel.Location = New System.Drawing.Point(206, 71)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(124, 20)
        Me.AdminLabel.TabIndex = 14
        Me.AdminLabel.Text = "Administration"
        Me.AdminLabel.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 703)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.PanelHeaderB)
        Me.Controls.Add(Me.ListUserPanel)
        Me.Controls.Add(Me.PanelSidebar)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.PanelSidebar.ResumeLayout(False)
        Me.PanelSidebar.PerformLayout()
        Me.PanelAdminBtn.ResumeLayout(False)
        Me.PanelAdminBtn.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderB.ResumeLayout(False)
        Me.ListUserPanel.ResumeLayout(False)
        CType(Me.DataGridView_sec_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelWelcome As Label
    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents PanelHeaderB As Panel
    Friend WithEvents PanelHeaderS As Panel
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListUserPanel As Panel
    Friend WithEvents DataGridView_sec_user As DataGridView
    Friend WithEvents AdminLabel As Label
    Friend WithEvents PanelAdminBtn As Panel
    Friend WithEvents Adminbtn As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents LabelProjectTitle As Label
    Friend WithEvents LabelUserAdminName As Label
    Friend WithEvents btnAddUser As Button
End Class
