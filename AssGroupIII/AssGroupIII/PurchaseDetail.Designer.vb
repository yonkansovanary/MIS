<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseDetail))
        Me.ComboBoxProName = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateCreated = New System.Windows.Forms.DateTimePicker()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtUnitprice = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.LabelAddPurchaseTitle = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.LabelUnitprice = New System.Windows.Forms.Label()
        Me.LabelProName = New System.Windows.Forms.Label()
        Me.LabelTotalPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxProName
        '
        Me.ComboBoxProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProName.FormattingEnabled = True
        Me.ComboBoxProName.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxProName.Location = New System.Drawing.Point(191, 101)
        Me.ComboBoxProName.Name = "ComboBoxProName"
        Me.ComboBoxProName.Size = New System.Drawing.Size(201, 28)
        Me.ComboBoxProName.TabIndex = 57
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(197, 34)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 42)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(302, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 42)
        Me.btnSave.TabIndex = 55
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DateCreated
        '
        Me.DateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreated.Location = New System.Drawing.Point(191, 293)
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.Size = New System.Drawing.Size(200, 21)
        Me.DateCreated.TabIndex = 54
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(191, 197)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(201, 26)
        Me.txtQty.TabIndex = 50
        Me.txtQty.UseSystemPasswordChar = True
        '
        'txtUnitprice
        '
        Me.txtUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitprice.Location = New System.Drawing.Point(191, 148)
        Me.txtUnitprice.Name = "txtUnitprice"
        Me.txtUnitprice.Size = New System.Drawing.Size(201, 26)
        Me.txtUnitprice.TabIndex = 49
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(191, 244)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(201, 26)
        Me.txtTotalPrice.TabIndex = 48
        '
        'LabelAddPurchaseTitle
        '
        Me.LabelAddPurchaseTitle.AutoSize = True
        Me.LabelAddPurchaseTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddPurchaseTitle.Location = New System.Drawing.Point(12, 9)
        Me.LabelAddPurchaseTitle.Name = "LabelAddPurchaseTitle"
        Me.LabelAddPurchaseTitle.Size = New System.Drawing.Size(142, 24)
        Me.LabelAddPurchaseTitle.TabIndex = 47
        Me.LabelAddPurchaseTitle.Text = "Add Purchase"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(63, 293)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(44, 20)
        Me.LabelDate.TabIndex = 45
        Me.LabelDate.Text = "Date"
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(63, 200)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(68, 20)
        Me.LabelQty.TabIndex = 44
        Me.LabelQty.Text = "Quantity"
        '
        'LabelUnitprice
        '
        Me.LabelUnitprice.AutoSize = True
        Me.LabelUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitprice.Location = New System.Drawing.Point(63, 154)
        Me.LabelUnitprice.Name = "LabelUnitprice"
        Me.LabelUnitprice.Size = New System.Drawing.Size(77, 20)
        Me.LabelUnitprice.TabIndex = 43
        Me.LabelUnitprice.Text = "Unit Price"
        '
        'LabelProName
        '
        Me.LabelProName.AutoSize = True
        Me.LabelProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProName.Location = New System.Drawing.Point(63, 104)
        Me.LabelProName.Name = "LabelProName"
        Me.LabelProName.Size = New System.Drawing.Size(110, 20)
        Me.LabelProName.TabIndex = 42
        Me.LabelProName.Text = "Product Name"
        '
        'LabelTotalPrice
        '
        Me.LabelTotalPrice.AutoSize = True
        Me.LabelTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPrice.Location = New System.Drawing.Point(63, 244)
        Me.LabelTotalPrice.Name = "LabelTotalPrice"
        Me.LabelTotalPrice.Size = New System.Drawing.Size(83, 20)
        Me.LabelTotalPrice.TabIndex = 41
        Me.LabelTotalPrice.Text = "Total Price"
        '
        'PurchaseDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 420)
        Me.Controls.Add(Me.ComboBoxProName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DateCreated)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtUnitprice)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.LabelAddPurchaseTitle)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelQty)
        Me.Controls.Add(Me.LabelUnitprice)
        Me.Controls.Add(Me.LabelProName)
        Me.Controls.Add(Me.LabelTotalPrice)
        Me.Name = "PurchaseDetail"
        Me.Text = "PurchaseDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxProName As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DateCreated As DateTimePicker
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtUnitprice As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents LabelAddPurchaseTitle As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelQty As Label
    Friend WithEvents LabelUnitprice As Label
    Friend WithEvents LabelProName As Label
    Friend WithEvents LabelTotalPrice As Label
End Class
