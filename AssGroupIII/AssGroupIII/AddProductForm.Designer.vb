<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProductForm))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateCreated = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxBrand = New System.Windows.Forms.ComboBox()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtUnitprice = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.LabelAddProductTitle = New System.Windows.Forms.Label()
        Me.Labeldescription = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.LabelUnitprice = New System.Windows.Forms.Label()
        Me.LabelCategory = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.ComboBoxcategory = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(529, 33)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 42)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(634, 33)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 42)
        Me.btnSave.TabIndex = 38
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateCreated
        '
        Me.DateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreated.Location = New System.Drawing.Point(524, 149)
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.Size = New System.Drawing.Size(200, 21)
        Me.DateCreated.TabIndex = 37
        '
        'ComboBoxBrand
        '
        Me.ComboBoxBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBrand.FormattingEnabled = True
        Me.ComboBoxBrand.Items.AddRange(New Object() {""})
        Me.ComboBoxBrand.Location = New System.Drawing.Point(156, 202)
        Me.ComboBoxBrand.Name = "ComboBoxBrand"
        Me.ComboBoxBrand.Size = New System.Drawing.Size(201, 28)
        Me.ComboBoxBrand.TabIndex = 36
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(54, 205)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(52, 20)
        Me.LabelGender.TabIndex = 35
        Me.LabelGender.Text = "Brand"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(523, 99)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(201, 26)
        Me.txtQty.TabIndex = 32
        Me.txtQty.UseSystemPasswordChar = True
        '
        'txtUnitprice
        '
        Me.txtUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitprice.Location = New System.Drawing.Point(156, 254)
        Me.txtUnitprice.Name = "txtUnitprice"
        Me.txtUnitprice.Size = New System.Drawing.Size(201, 26)
        Me.txtUnitprice.TabIndex = 31
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(156, 99)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(201, 26)
        Me.txtProductName.TabIndex = 29
        '
        'LabelAddProductTitle
        '
        Me.LabelAddProductTitle.AutoSize = True
        Me.LabelAddProductTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddProductTitle.Location = New System.Drawing.Point(9, 33)
        Me.LabelAddProductTitle.Name = "LabelAddProductTitle"
        Me.LabelAddProductTitle.Size = New System.Drawing.Size(126, 24)
        Me.LabelAddProductTitle.TabIndex = 28
        Me.LabelAddProductTitle.Text = "Add Product"
        '
        'Labeldescription
        '
        Me.Labeldescription.AutoSize = True
        Me.Labeldescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldescription.Location = New System.Drawing.Point(415, 204)
        Me.Labeldescription.Name = "Labeldescription"
        Me.Labeldescription.Size = New System.Drawing.Size(89, 20)
        Me.Labeldescription.TabIndex = 26
        Me.Labeldescription.Text = "Description"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(415, 149)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(44, 20)
        Me.LabelDate.TabIndex = 25
        Me.LabelDate.Text = "Date"
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(413, 105)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(68, 20)
        Me.LabelQty.TabIndex = 24
        Me.LabelQty.Text = "Quantity"
        '
        'LabelUnitprice
        '
        Me.LabelUnitprice.AutoSize = True
        Me.LabelUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitprice.Location = New System.Drawing.Point(54, 260)
        Me.LabelUnitprice.Name = "LabelUnitprice"
        Me.LabelUnitprice.Size = New System.Drawing.Size(77, 20)
        Me.LabelUnitprice.TabIndex = 23
        Me.LabelUnitprice.Text = "Unit Price"
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategory.Location = New System.Drawing.Point(54, 151)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(73, 20)
        Me.LabelCategory.TabIndex = 22
        Me.LabelCategory.Text = "Category"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(54, 99)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(51, 20)
        Me.LabelProductName.TabIndex = 21
        Me.LabelProductName.Text = "Name"
        '
        'ComboBoxcategory
        '
        Me.ComboBoxcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxcategory.FormattingEnabled = True
        Me.ComboBoxcategory.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxcategory.Location = New System.Drawing.Point(156, 148)
        Me.ComboBoxcategory.Name = "ComboBoxcategory"
        Me.ComboBoxcategory.Size = New System.Drawing.Size(201, 28)
        Me.ComboBoxcategory.TabIndex = 40
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(523, 201)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(201, 79)
        Me.txtDescription.TabIndex = 33
        '
        'AddProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 380)
        Me.Controls.Add(Me.ComboBoxcategory)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DateCreated)
        Me.Controls.Add(Me.ComboBoxBrand)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtUnitprice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.LabelAddProductTitle)
        Me.Controls.Add(Me.Labeldescription)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelQty)
        Me.Controls.Add(Me.LabelUnitprice)
        Me.Controls.Add(Me.LabelCategory)
        Me.Controls.Add(Me.LabelProductName)
        Me.Name = "AddProductForm"
        Me.Text = "AddProductForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DateCreated As DateTimePicker
    Friend WithEvents ComboBoxBrand As ComboBox
    Friend WithEvents LabelGender As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtUnitprice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents LabelAddProductTitle As Label
    Friend WithEvents Labeldescription As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelQty As Label
    Friend WithEvents LabelUnitprice As Label
    Friend WithEvents LabelCategory As Label
    Friend WithEvents LabelProductName As Label
    Friend WithEvents ComboBoxcategory As ComboBox
    Friend WithEvents txtDescription As TextBox
End Class
