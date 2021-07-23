<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUserForm))
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelDOB = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPhone = New System.Windows.Forms.Label()
        Me.LabelAddUserTitle = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.CheckBoxLock = New System.Windows.Forms.CheckBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnUserDelete = New System.Windows.Forms.Button()
        Me.ComboBoxRole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPosition = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(72, 180)
        Me.LabelFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(106, 25)
        Me.LabelFirstName.TabIndex = 0
        Me.LabelFirstName.Text = "First Name"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(72, 244)
        Me.LabelLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(106, 25)
        Me.LabelLastName.TabIndex = 1
        Me.LabelLastName.Text = "Last Name"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(72, 310)
        Me.LabelUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(102, 25)
        Me.LabelUsername.TabIndex = 2
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(72, 376)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(98, 25)
        Me.LabelPassword.TabIndex = 3
        Me.LabelPassword.Text = "Password"
        '
        'LabelDOB
        '
        Me.LabelDOB.AutoSize = True
        Me.LabelDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDOB.Location = New System.Drawing.Point(597, 122)
        Me.LabelDOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDOB.Name = "LabelDOB"
        Me.LabelDOB.Size = New System.Drawing.Size(123, 25)
        Me.LabelDOB.TabIndex = 4
        Me.LabelDOB.Text = "Date Of Birth"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(597, 186)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(60, 25)
        Me.LabelEmail.TabIndex = 5
        Me.LabelEmail.Text = "Email"
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhone.Location = New System.Drawing.Point(597, 252)
        Me.LabelPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(69, 25)
        Me.LabelPhone.TabIndex = 6
        Me.LabelPhone.Text = "Phone"
        '
        'LabelAddUserTitle
        '
        Me.LabelAddUserTitle.AutoSize = True
        Me.LabelAddUserTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddUserTitle.Location = New System.Drawing.Point(72, 41)
        Me.LabelAddUserTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddUserTitle.Name = "LabelAddUserTitle"
        Me.LabelAddUserTitle.Size = New System.Drawing.Size(142, 29)
        Me.LabelAddUserTitle.TabIndex = 7
        Me.LabelAddUserTitle.Text = "ADD USER"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(270, 180)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(267, 30)
        Me.txtFirstname.TabIndex = 9
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(270, 240)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(267, 30)
        Me.txtLastname.TabIndex = 10
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(270, 303)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(267, 30)
        Me.txtUsername.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(270, 368)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(267, 30)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(735, 182)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 30)
        Me.txtEmail.TabIndex = 14
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(735, 245)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(267, 30)
        Me.txtPhone.TabIndex = 15
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(597, 318)
        Me.LabelGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(77, 25)
        Me.LabelGender.TabIndex = 16
        Me.LabelGender.Text = "Gender"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(735, 308)
        Me.ComboBoxGender.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxGender.TabIndex = 17
        '
        'DOB
        '
        Me.DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(735, 122)
        Me.DOB.Margin = New System.Windows.Forms.Padding(4)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(265, 24)
        Me.DOB.TabIndex = 18
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(819, 41)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 19
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(679, 41)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 52)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'CheckBoxLock
        '
        Me.CheckBoxLock.AutoSize = True
        Me.CheckBoxLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLock.Location = New System.Drawing.Point(735, 507)
        Me.CheckBoxLock.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxLock.Name = "CheckBoxLock"
        Me.CheckBoxLock.Size = New System.Drawing.Size(76, 29)
        Me.CheckBoxLock.TabIndex = 22
        Me.CheckBoxLock.Text = "Lock"
        Me.CheckBoxLock.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(735, 382)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(267, 30)
        Me.txtAddress.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(597, 389)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Address"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(270, 124)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(267, 30)
        Me.txtCode.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Code"
        '
        'txtConPassword
        '
        Me.txtConPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPassword.Location = New System.Drawing.Point(270, 430)
        Me.txtConPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConPassword.Name = "txtConPassword"
        Me.txtConPassword.Size = New System.Drawing.Size(267, 30)
        Me.txtConPassword.TabIndex = 28
        Me.txtConPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 432)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Confirm Password"
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(820, 40)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 52)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnUserDelete
        '
        Me.btnUserDelete.BackColor = System.Drawing.Color.White
        Me.btnUserDelete.Image = CType(resources.GetObject("btnUserDelete.Image"), System.Drawing.Image)
        Me.btnUserDelete.Location = New System.Drawing.Point(540, 41)
        Me.btnUserDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUserDelete.Name = "btnUserDelete"
        Me.btnUserDelete.Size = New System.Drawing.Size(120, 52)
        Me.btnUserDelete.TabIndex = 30
        Me.btnUserDelete.UseVisualStyleBackColor = False
        '
        'ComboBoxRole
        '
        Me.ComboBoxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRole.FormattingEnabled = True
        Me.ComboBoxRole.Items.AddRange(New Object() {""})
        Me.ComboBoxRole.Location = New System.Drawing.Point(270, 488)
        Me.ComboBoxRole.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxRole.Name = "ComboBoxRole"
        Me.ComboBoxRole.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxRole.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 493)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(597, 448)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Position"
        '
        'ComboBoxPosition
        '
        Me.ComboBoxPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPosition.FormattingEnabled = True
        Me.ComboBoxPosition.Items.AddRange(New Object() {""})
        Me.ComboBoxPosition.Location = New System.Drawing.Point(735, 443)
        Me.ComboBoxPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPosition.Name = "ComboBoxPosition"
        Me.ComboBoxPosition.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxPosition.TabIndex = 33
        '
        'AddUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 566)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxPosition)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxRole)
        Me.Controls.Add(Me.btnUserDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtConPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxLock)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.LabelAddUserTitle)
        Me.Controls.Add(Me.LabelPhone)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelDOB)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddUserForm"
        Me.Text = "AddUserForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelFirstName As Label
    Friend WithEvents LabelLastName As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelDOB As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelAddUserTitle As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents LabelGender As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents CheckBoxLock As CheckBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnUserDelete As Button
    Friend WithEvents ComboBoxRole As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxPosition As ComboBox
End Class
