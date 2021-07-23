<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.txtUnitprice = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.LabelAddProductTitle = New System.Windows.Forms.Label()
        Me.LabelUnitprice = New System.Windows.Forms.Label()
        Me.LabelCategory = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewSupplier = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(827, 43)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 52)
        Me.btnUpdate.TabIndex = 66
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(560, 43)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 52)
        Me.btnDelete.TabIndex = 65
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(699, 43)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 52)
        Me.Button1.TabIndex = 64
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtProductCode
        '
        Me.txtProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.Location = New System.Drawing.Point(228, 139)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(267, 30)
        Me.txtProductCode.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Code"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(827, 43)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 60
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(57, 319)
        Me.LabelGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(60, 25)
        Me.LabelGender.TabIndex = 57
        Me.LabelGender.Text = "Email"
        '
        'txtUnitprice
        '
        Me.txtUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitprice.Location = New System.Drawing.Point(726, 144)
        Me.txtUnitprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitprice.Name = "txtUnitprice"
        Me.txtUnitprice.Size = New System.Drawing.Size(267, 30)
        Me.txtUnitprice.TabIndex = 54
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(228, 189)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(267, 30)
        Me.txtProductName.TabIndex = 53
        '
        'LabelAddProductTitle
        '
        Me.LabelAddProductTitle.AutoSize = True
        Me.LabelAddProductTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddProductTitle.Location = New System.Drawing.Point(57, 23)
        Me.LabelAddProductTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddProductTitle.Name = "LabelAddProductTitle"
        Me.LabelAddProductTitle.Size = New System.Drawing.Size(197, 29)
        Me.LabelAddProductTitle.TabIndex = 52
        Me.LabelAddProductTitle.Text = "ADD SUPPLIER"
        '
        'LabelUnitprice
        '
        Me.LabelUnitprice.AutoSize = True
        Me.LabelUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitprice.Location = New System.Drawing.Point(540, 147)
        Me.LabelUnitprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUnitprice.Name = "LabelUnitprice"
        Me.LabelUnitprice.Size = New System.Drawing.Size(86, 25)
        Me.LabelUnitprice.TabIndex = 48
        Me.LabelUnitprice.Text = "Location"
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategory.Location = New System.Drawing.Point(57, 253)
        Me.LabelCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(69, 25)
        Me.LabelCategory.TabIndex = 47
        Me.LabelCategory.Text = "Phone"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(57, 189)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(64, 25)
        Me.LabelProductName.TabIndex = 46
        Me.LabelProductName.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(228, 319)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 30)
        Me.TextBox1.TabIndex = 67
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(228, 250)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(267, 30)
        Me.TextBox2.TabIndex = 68
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(726, 283)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(267, 30)
        Me.TextBox3.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 286)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 25)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Company Location"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(726, 210)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(267, 30)
        Me.TextBox4.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(540, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Company Name"
        '
        'DataGridViewSupplier
        '
        Me.DataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplier.Location = New System.Drawing.Point(25, 371)
        Me.DataGridViewSupplier.Name = "DataGridViewSupplier"
        Me.DataGridViewSupplier.RowTemplate.Height = 24
        Me.DataGridViewSupplier.Size = New System.Drawing.Size(1125, 469)
        Me.DataGridViewSupplier.TabIndex = 73
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 870)
        Me.Controls.Add(Me.DataGridViewSupplier)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.txtUnitprice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.LabelAddProductTitle)
        Me.Controls.Add(Me.LabelUnitprice)
        Me.Controls.Add(Me.LabelCategory)
        Me.Controls.Add(Me.LabelProductName)
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        CType(Me.DataGridViewSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents LabelGender As Label
    Friend WithEvents txtUnitprice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents LabelAddProductTitle As Label
    Friend WithEvents LabelUnitprice As Label
    Friend WithEvents LabelCategory As Label
    Friend WithEvents LabelProductName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewSupplier As DataGridView
End Class
