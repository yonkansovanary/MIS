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
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(845, 41)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 38
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateCreated
        '
        Me.DateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreated.Location = New System.Drawing.Point(699, 217)
        Me.DateCreated.Margin = New System.Windows.Forms.Padding(4)
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.Size = New System.Drawing.Size(265, 24)
        Me.DateCreated.TabIndex = 37
        '
        'ComboBoxBrand
        '
        Me.ComboBoxBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBrand.FormattingEnabled = True
        Me.ComboBoxBrand.Items.AddRange(New Object() {""})
        Me.ComboBoxBrand.Location = New System.Drawing.Point(211, 293)
        Me.ComboBoxBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxBrand.Name = "ComboBoxBrand"
        Me.ComboBoxBrand.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxBrand.TabIndex = 36
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(75, 296)
        Me.LabelGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(64, 25)
        Me.LabelGender.TabIndex = 35
        Me.LabelGender.Text = "Brand"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(697, 156)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(267, 30)
        Me.txtQty.TabIndex = 32
        '
        'txtUnitprice
        '
        Me.txtUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitprice.Location = New System.Drawing.Point(211, 357)
        Me.txtUnitprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitprice.Name = "txtUnitprice"
        Me.txtUnitprice.Size = New System.Drawing.Size(267, 30)
        Me.txtUnitprice.TabIndex = 31
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(211, 166)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(267, 30)
        Me.txtProductName.TabIndex = 29
        '
        'LabelAddProductTitle
        '
        Me.LabelAddProductTitle.AutoSize = True
        Me.LabelAddProductTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddProductTitle.Location = New System.Drawing.Point(75, 21)
        Me.LabelAddProductTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddProductTitle.Name = "LabelAddProductTitle"
        Me.LabelAddProductTitle.Size = New System.Drawing.Size(198, 29)
        Me.LabelAddProductTitle.TabIndex = 28
        Me.LabelAddProductTitle.Text = "ADD PRODUCT"
        '
        'Labeldescription
        '
        Me.Labeldescription.AutoSize = True
        Me.Labeldescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldescription.Location = New System.Drawing.Point(553, 285)
        Me.Labeldescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labeldescription.Name = "Labeldescription"
        Me.Labeldescription.Size = New System.Drawing.Size(109, 25)
        Me.Labeldescription.TabIndex = 26
        Me.Labeldescription.Text = "Description"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(553, 217)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(53, 25)
        Me.LabelDate.TabIndex = 25
        Me.LabelDate.Text = "Date"
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(551, 163)
        Me.LabelQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(85, 25)
        Me.LabelQty.TabIndex = 24
        Me.LabelQty.Text = "Quantity"
        '
        'LabelUnitprice
        '
        Me.LabelUnitprice.AutoSize = True
        Me.LabelUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitprice.Location = New System.Drawing.Point(75, 364)
        Me.LabelUnitprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUnitprice.Name = "LabelUnitprice"
        Me.LabelUnitprice.Size = New System.Drawing.Size(95, 25)
        Me.LabelUnitprice.TabIndex = 23
        Me.LabelUnitprice.Text = "Unit Price"
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategory.Location = New System.Drawing.Point(75, 230)
        Me.LabelCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(92, 25)
        Me.LabelCategory.TabIndex = 22
        Me.LabelCategory.Text = "Category"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(75, 166)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(64, 25)
        Me.LabelProductName.TabIndex = 21
        Me.LabelProductName.Text = "Name"
        '
        'ComboBoxcategory
        '
        Me.ComboBoxcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxcategory.FormattingEnabled = True
        Me.ComboBoxcategory.Location = New System.Drawing.Point(211, 222)
        Me.ComboBoxcategory.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxcategory.Name = "ComboBoxcategory"
        Me.ComboBoxcategory.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxcategory.TabIndex = 40
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(697, 281)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(267, 96)
        Me.txtDescription.TabIndex = 33
        '
        'txtProductCode
        '
        Me.txtProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.Location = New System.Drawing.Point(211, 116)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(267, 30)
        Me.txtProductCode.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Code"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(578, 41)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 52)
        Me.btnDelete.TabIndex = 44
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(717, 41)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 52)
        Me.Button1.TabIndex = 43
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(845, 41)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 52)
        Me.btnUpdate.TabIndex = 45
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'AddProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 468)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxcategory)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddProductForm"
        Me.Text = "AddProductForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUpdate As Button
End Class
