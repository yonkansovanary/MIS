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
        Me.SuspendLayout()
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirstName.Location = New System.Drawing.Point(76, 122)
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
        Me.LabelLastName.Location = New System.Drawing.Point(76, 186)
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
        Me.LabelUsername.Location = New System.Drawing.Point(76, 252)
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
        Me.LabelPassword.Location = New System.Drawing.Point(76, 318)
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
        Me.LabelDOB.Location = New System.Drawing.Point(527, 122)
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
        Me.LabelEmail.Location = New System.Drawing.Point(527, 186)
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
        Me.LabelPhone.Location = New System.Drawing.Point(527, 252)
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
        Me.LabelAddUserTitle.Location = New System.Drawing.Point(16, 41)
        Me.LabelAddUserTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddUserTitle.Name = "LabelAddUserTitle"
        Me.LabelAddUserTitle.Size = New System.Drawing.Size(121, 29)
        Me.LabelAddUserTitle.TabIndex = 7
        Me.LabelAddUserTitle.Text = "Add User"
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(200, 122)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(267, 30)
        Me.txtFirstname.TabIndex = 9
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(200, 182)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(267, 30)
        Me.txtLastname.TabIndex = 10
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(200, 245)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(267, 30)
        Me.txtUsername.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(200, 310)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(267, 30)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(671, 182)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 30)
        Me.txtEmail.TabIndex = 14
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(671, 245)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(267, 30)
        Me.txtPhone.TabIndex = 15
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(527, 318)
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
        Me.ComboBoxGender.Location = New System.Drawing.Point(671, 308)
        Me.ComboBoxGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxGender.TabIndex = 17
        '
        'DOB
        '
        Me.DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(672, 122)
        Me.DOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(265, 24)
        Me.DOB.TabIndex = 18
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(819, 41)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 52)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'CheckBoxLock
        '
        Me.CheckBoxLock.AutoSize = True
        Me.CheckBoxLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxLock.Location = New System.Drawing.Point(81, 382)
        Me.CheckBoxLock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxLock.Name = "CheckBoxLock"
        Me.CheckBoxLock.Size = New System.Drawing.Size(76, 29)
        Me.CheckBoxLock.TabIndex = 22
        Me.CheckBoxLock.Text = "Lock"
        Me.CheckBoxLock.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(672, 382)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(267, 30)
        Me.txtAddress.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 389)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Address"
        '
        'AddUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 468)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
End Class
