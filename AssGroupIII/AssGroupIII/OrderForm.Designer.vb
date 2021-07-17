<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateCreated = New System.Windows.Forms.DateTimePicker()
        Me.LabelAddOrderTitle = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.ComboBoxProName = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtUnitprice = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.LabelUnitprice = New System.Windows.Forms.Label()
        Me.LabelTotalPrice = New System.Windows.Forms.Label()
        Me.ComboBoxCustomerName = New System.Windows.Forms.ComboBox()
        Me.LabelCustomerName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(741, 15)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 52)
        Me.btnCancel.TabIndex = 71
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(881, 15)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 70
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateCreated
        '
        Me.DateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreated.Location = New System.Drawing.Point(735, 150)
        Me.DateCreated.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.Size = New System.Drawing.Size(265, 24)
        Me.DateCreated.TabIndex = 69
        '
        'LabelAddOrderTitle
        '
        Me.LabelAddOrderTitle.AutoSize = True
        Me.LabelAddOrderTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddOrderTitle.Location = New System.Drawing.Point(16, 11)
        Me.LabelAddOrderTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddOrderTitle.Name = "LabelAddOrderTitle"
        Me.LabelAddOrderTitle.Size = New System.Drawing.Size(134, 29)
        Me.LabelAddOrderTitle.TabIndex = 64
        Me.LabelAddOrderTitle.Text = "Add Order"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(557, 150)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(53, 25)
        Me.LabelDate.TabIndex = 62
        Me.LabelDate.Text = "Date"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(76, 92)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(136, 25)
        Me.LabelProductName.TabIndex = 58
        Me.LabelProductName.Text = "Product Name"
        '
        'ComboBoxProName
        '
        Me.ComboBoxProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProName.FormattingEnabled = True
        Me.ComboBoxProName.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxProName.Location = New System.Drawing.Point(253, 90)
        Me.ComboBoxProName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxProName.Name = "ComboBoxProName"
        Me.ComboBoxProName.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxProName.TabIndex = 73
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(253, 203)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 30)
        Me.TextBox1.TabIndex = 79
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'txtUnitprice
        '
        Me.txtUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitprice.Location = New System.Drawing.Point(253, 143)
        Me.txtUnitprice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnitprice.Name = "txtUnitprice"
        Me.txtUnitprice.Size = New System.Drawing.Size(267, 30)
        Me.txtUnitprice.TabIndex = 78
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(733, 203)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(267, 30)
        Me.txtTotalPrice.TabIndex = 77
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(76, 207)
        Me.LabelQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(85, 25)
        Me.LabelQty.TabIndex = 76
        Me.LabelQty.Text = "Quantity"
        '
        'LabelUnitprice
        '
        Me.LabelUnitprice.AutoSize = True
        Me.LabelUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitprice.Location = New System.Drawing.Point(76, 150)
        Me.LabelUnitprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUnitprice.Name = "LabelUnitprice"
        Me.LabelUnitprice.Size = New System.Drawing.Size(95, 25)
        Me.LabelUnitprice.TabIndex = 75
        Me.LabelUnitprice.Text = "Unit Price"
        '
        'LabelTotalPrice
        '
        Me.LabelTotalPrice.AutoSize = True
        Me.LabelTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPrice.Location = New System.Drawing.Point(556, 207)
        Me.LabelTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalPrice.Name = "LabelTotalPrice"
        Me.LabelTotalPrice.Size = New System.Drawing.Size(105, 25)
        Me.LabelTotalPrice.TabIndex = 74
        Me.LabelTotalPrice.Text = "Total Price"
        '
        'ComboBoxCustomerName
        '
        Me.ComboBoxCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCustomerName.FormattingEnabled = True
        Me.ComboBoxCustomerName.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxCustomerName.Location = New System.Drawing.Point(735, 89)
        Me.ComboBoxCustomerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxCustomerName.Name = "ComboBoxCustomerName"
        Me.ComboBoxCustomerName.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxCustomerName.TabIndex = 81
        '
        'LabelCustomerName
        '
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerName.Location = New System.Drawing.Point(557, 91)
        Me.LabelCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCustomerName.Name = "LabelCustomerName"
        Me.LabelCustomerName.Size = New System.Drawing.Size(154, 25)
        Me.LabelCustomerName.TabIndex = 80
        Me.LabelCustomerName.Text = "Customer Name"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 336)
        Me.Controls.Add(Me.ComboBoxCustomerName)
        Me.Controls.Add(Me.LabelCustomerName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtUnitprice)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.LabelQty)
        Me.Controls.Add(Me.LabelUnitprice)
        Me.Controls.Add(Me.LabelTotalPrice)
        Me.Controls.Add(Me.ComboBoxProName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DateCreated)
        Me.Controls.Add(Me.LabelAddOrderTitle)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelProductName)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DateCreated As DateTimePicker
    Friend WithEvents LabelAddOrderTitle As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelProductName As Label
    Friend WithEvents ComboBoxProName As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtUnitprice As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents LabelQty As Label
    Friend WithEvents LabelUnitprice As Label
    Friend WithEvents LabelTotalPrice As Label
    Friend WithEvents ComboBoxCustomerName As ComboBox
    Friend WithEvents LabelCustomerName As Label
End Class
