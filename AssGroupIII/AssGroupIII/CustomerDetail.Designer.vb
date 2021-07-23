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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(709, 11)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 52)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(849, 11)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 55
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateCreated
        '
        Me.DateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreated.Location = New System.Drawing.Point(703, 98)
        Me.DateCreated.Margin = New System.Windows.Forms.Padding(4)
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.Size = New System.Drawing.Size(265, 24)
        Me.DateCreated.TabIndex = 54
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(701, 150)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(267, 144)
        Me.txtAddress.TabIndex = 51
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(253, 263)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(267, 30)
        Me.txtQty.TabIndex = 50
        Me.txtQty.UseSystemPasswordChar = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(253, 210)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 30)
        Me.txtEmail.TabIndex = 49
        '
        'LabelAddCustomerTitle
        '
        Me.LabelAddCustomerTitle.AutoSize = True
        Me.LabelAddCustomerTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddCustomerTitle.Location = New System.Drawing.Point(16, 11)
        Me.LabelAddCustomerTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddCustomerTitle.Name = "LabelAddCustomerTitle"
        Me.LabelAddCustomerTitle.Size = New System.Drawing.Size(178, 29)
        Me.LabelAddCustomerTitle.TabIndex = 47
        Me.LabelAddCustomerTitle.Text = "Add Customer"
        '
        'Labeldescription
        '
        Me.Labeldescription.AutoSize = True
        Me.Labeldescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldescription.Location = New System.Drawing.Point(557, 154)
        Me.Labeldescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labeldescription.Name = "Labeldescription"
        Me.Labeldescription.Size = New System.Drawing.Size(85, 25)
        Me.Labeldescription.TabIndex = 46
        Me.Labeldescription.Text = "Address"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(557, 98)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(53, 25)
        Me.LabelDate.TabIndex = 45
        Me.LabelDate.Text = "Date"
        '
        'LabelComapnyName
        '
        Me.LabelComapnyName.AutoSize = True
        Me.LabelComapnyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelComapnyName.Location = New System.Drawing.Point(76, 271)
        Me.LabelComapnyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelComapnyName.Name = "LabelComapnyName"
        Me.LabelComapnyName.Size = New System.Drawing.Size(154, 25)
        Me.LabelComapnyName.TabIndex = 44
        Me.LabelComapnyName.Text = "Company Name"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(76, 218)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(60, 25)
        Me.LabelEmail.TabIndex = 43
        Me.LabelEmail.Text = "Email"
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPhone.Location = New System.Drawing.Point(76, 156)
        Me.LabelPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(69, 25)
        Me.LabelPhone.TabIndex = 42
        Me.LabelPhone.Text = "Phone"
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.Location = New System.Drawing.Point(76, 92)
        Me.LabelCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(64, 25)
        Me.LabelCustomerName.TabIndex = 41
        Me.LabelCustomerName.Text = "Name"
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPhone.Location = New System.Drawing.Point(253, 150)
        Me.TextBoxPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(267, 30)
        Me.TextBoxPhone.TabIndex = 57
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(81, 331)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1022, 568)
        Me.DataGridView1.TabIndex = 58
        '
        'CustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 902)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerDetail"
        Me.Text = "CustomerDetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
End Class
