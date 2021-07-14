<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerDetail))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateCreated = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.LabelAddCustomerTitle = New System.Windows.Forms.Label()
        Me.Labeldescription = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelComapnyName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPhone = New System.Windows.Forms.Label()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.TextBoxPhone = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(532, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 42)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(637, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 42)
        Me.btnSave.TabIndex = 55
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateCreated
        '
        Me.DateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreated.Location = New System.Drawing.Point(527, 80)
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.Size = New System.Drawing.Size(200, 21)
        Me.DateCreated.TabIndex = 54
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(526, 122)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(201, 118)
        Me.txtAddress.TabIndex = 51
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(190, 214)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(201, 26)
        Me.txtQty.TabIndex = 50
        Me.txtQty.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(190, 171)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 26)
        Me.txtEmail.TabIndex = 49
        '
        'LabelAddCustomerTitle
        '
        Me.LabelAddCustomerTitle.AutoSize = True
        Me.LabelAddCustomerTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddCustomerTitle.Location = New System.Drawing.Point(12, 9)
        Me.LabelAddCustomerTitle.Name = "LabelAddCustomerTitle"
        Me.LabelAddCustomerTitle.Size = New System.Drawing.Size(143, 24)
        Me.LabelAddCustomerTitle.TabIndex = 47
        Me.LabelAddCustomerTitle.Text = "Add Customer"
        '
        'Labeldescription
        '
        Me.Labeldescription.AutoSize = True
        Me.Labeldescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldescription.Location = New System.Drawing.Point(418, 125)
        Me.Labeldescription.Name = "Labeldescription"
        Me.Labeldescription.Size = New System.Drawing.Size(68, 20)
        Me.Labeldescription.TabIndex = 46
        Me.Labeldescription.Text = "Address"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(418, 80)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(44, 20)
        Me.LabelDate.TabIndex = 45
        Me.LabelDate.Text = "Date"
        '
        'LabelComapnyName
        '
        Me.LabelComapnyName.AutoSize = True
        Me.LabelComapnyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComapnyName.Location = New System.Drawing.Point(57, 220)
        Me.LabelComapnyName.Name = "LabelComapnyName"
        Me.LabelComapnyName.Size = New System.Drawing.Size(122, 20)
        Me.LabelComapnyName.TabIndex = 44
        Me.LabelComapnyName.Text = "Company Name"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(57, 177)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(48, 20)
        Me.LabelEmail.TabIndex = 43
        Me.LabelEmail.Text = "Email"
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhone.Location = New System.Drawing.Point(57, 127)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(55, 20)
        Me.LabelPhone.TabIndex = 42
        Me.LabelPhone.Text = "Phone"
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.Location = New System.Drawing.Point(57, 75)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(51, 20)
        Me.LabelCustomerName.TabIndex = 41
        Me.LabelCustomerName.Text = "Name"
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhone.Location = New System.Drawing.Point(190, 122)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(201, 26)
        Me.TextBoxPhone.TabIndex = 57
        '
        'CustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 287)
        Me.Controls.Add(Me.TextBoxPhone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DateCreated)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.LabelAddCustomerTitle)
        Me.Controls.Add(Me.Labeldescription)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelComapnyName)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelPhone)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Name = "CustomerDetail"
        Me.Text = "CustomerDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DateCreated As DateTimePicker
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents LabelAddCustomerTitle As Label
    Friend WithEvents Labeldescription As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelComapnyName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelCustomerName As Label
    Friend WithEvents TextBoxPhone As TextBox
End Class
