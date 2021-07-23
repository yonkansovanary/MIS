<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleManagment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleManagment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxUOM = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaleDeProId = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxShipping = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxSaleDeId = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaleQty = New System.Windows.Forms.TextBox()
        Me.LabelTotalPrice = New System.Windows.Forms.Label()
        Me.LabelUnitprice = New System.Windows.Forms.Label()
        Me.txtProUnitprice = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxSaleStatus = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSaleCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelAddPurchaseTitle = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxSaleEm = New System.Windows.Forms.ComboBox()
        Me.LabelProName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.SaleDate = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewSale = New System.Windows.Forms.DataGridView()
        Me.DataGridViewSaleDetail = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewSaleDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.ComboBoxUOM)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.SaleDeProId)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ComboBoxStatus)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ComboBoxShipping)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ComboBoxSupplier)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ComboBoxSaleDeId)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtSaleQty)
        Me.Panel2.Controls.Add(Me.LabelTotalPrice)
        Me.Panel2.Controls.Add(Me.LabelUnitprice)
        Me.Panel2.Controls.Add(Me.txtProUnitprice)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.LabelQty)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.txtTotalPrice)
        Me.Panel2.Location = New System.Drawing.Point(679, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 402)
        Me.Panel2.TabIndex = 66
        '
        'ComboBoxUOM
        '
        Me.ComboBoxUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUOM.FormattingEnabled = True
        Me.ComboBoxUOM.Location = New System.Drawing.Point(155, 221)
        Me.ComboBoxUOM.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxUOM.Name = "ComboBoxUOM"
        Me.ComboBoxUOM.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxUOM.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 25)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "UOM"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(701, 28)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 52)
        Me.Button3.TabIndex = 69
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SaleDeProId
        '
        Me.SaleDeProId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaleDeProId.FormattingEnabled = True
        Me.SaleDeProId.Location = New System.Drawing.Point(155, 162)
        Me.SaleDeProId.Margin = New System.Windows.Forms.Padding(4)
        Me.SaleDeProId.Name = "SaleDeProId"
        Me.SaleDeProId.Size = New System.Drawing.Size(267, 33)
        Me.SaleDeProId.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 163)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 25)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Product ID"
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Pending ", "Completed ", "Canceled", "Sending "})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(803, 160)
        Me.ComboBoxStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(298, 33)
        Me.ComboBoxStatus.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(638, 168)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 29)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Sale Details"
        '
        'ComboBoxShipping
        '
        Me.ComboBoxShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxShipping.FormattingEnabled = True
        Me.ComboBoxShipping.Location = New System.Drawing.Point(803, 113)
        Me.ComboBoxShipping.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxShipping.Name = "ComboBoxShipping"
        Me.ComboBoxShipping.Size = New System.Drawing.Size(298, 33)
        Me.ComboBoxShipping.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(638, 113)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 25)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Shipping ID"
        '
        'ComboBoxSupplier
        '
        Me.ComboBoxSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSupplier.FormattingEnabled = True
        Me.ComboBoxSupplier.Location = New System.Drawing.Point(803, 216)
        Me.ComboBoxSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSupplier.Name = "ComboBoxSupplier"
        Me.ComboBoxSupplier.Size = New System.Drawing.Size(298, 33)
        Me.ComboBoxSupplier.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(638, 216)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Customer ID"
        '
        'ComboBoxSaleDeId
        '
        Me.ComboBoxSaleDeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSaleDeId.FormattingEnabled = True
        Me.ComboBoxSaleDeId.Location = New System.Drawing.Point(155, 107)
        Me.ComboBoxSaleDeId.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSaleDeId.Name = "ComboBoxSaleDeId"
        Me.ComboBoxSaleDeId.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxSaleDeId.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Sale Code"
        '
        'txtSaleQty
        '
        Me.txtSaleQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleQty.Location = New System.Drawing.Point(155, 269)
        Me.txtSaleQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaleQty.Name = "txtSaleQty"
        Me.txtSaleQty.Size = New System.Drawing.Size(267, 30)
        Me.txtSaleQty.TabIndex = 50
        '
        'LabelTotalPrice
        '
        Me.LabelTotalPrice.AutoSize = True
        Me.LabelTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPrice.Location = New System.Drawing.Point(638, 280)
        Me.LabelTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalPrice.Name = "LabelTotalPrice"
        Me.LabelTotalPrice.Size = New System.Drawing.Size(105, 25)
        Me.LabelTotalPrice.TabIndex = 41
        Me.LabelTotalPrice.Text = "Total Price"
        '
        'LabelUnitprice
        '
        Me.LabelUnitprice.AutoSize = True
        Me.LabelUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitprice.Location = New System.Drawing.Point(25, 331)
        Me.LabelUnitprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUnitprice.Name = "LabelUnitprice"
        Me.LabelUnitprice.Size = New System.Drawing.Size(95, 25)
        Me.LabelUnitprice.TabIndex = 43
        Me.LabelUnitprice.Text = "Unit Price"
        '
        'txtProUnitprice
        '
        Me.txtProUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProUnitprice.Location = New System.Drawing.Point(155, 326)
        Me.txtProUnitprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProUnitprice.Name = "txtProUnitprice"
        Me.txtProUnitprice.Size = New System.Drawing.Size(267, 30)
        Me.txtProUnitprice.TabIndex = 49
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(841, 28)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 52)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(25, 273)
        Me.LabelQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(85, 25)
        Me.LabelQty.TabIndex = 44
        Me.LabelQty.Text = "Quantity"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(981, 28)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 55
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(803, 280)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(298, 30)
        Me.txtTotalPrice.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ComboBoxSaleStatus)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.txtSaleCode)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.LabelAddPurchaseTitle)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtTotalAmount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBoxSaleEm)
        Me.Panel1.Controls.Add(Me.LabelProName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelDate)
        Me.Panel1.Controls.Add(Me.SaleDate)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 402)
        Me.Panel1.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 328)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 25)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Status"
        '
        'ComboBoxSaleStatus
        '
        Me.ComboBoxSaleStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSaleStatus.FormattingEnabled = True
        Me.ComboBoxSaleStatus.Items.AddRange(New Object() {"Pending", "Completed"})
        Me.ComboBoxSaleStatus.Location = New System.Drawing.Point(178, 326)
        Me.ComboBoxSaleStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSaleStatus.Name = "ComboBoxSaleStatus"
        Me.ComboBoxSaleStatus.Size = New System.Drawing.Size(320, 33)
        Me.ComboBoxSaleStatus.TabIndex = 69
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(242, 28)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 52)
        Me.btnDelete.TabIndex = 68
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtSaleCode
        '
        Me.txtSaleCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleCode.Location = New System.Drawing.Point(178, 119)
        Me.txtSaleCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaleCode.Name = "txtSaleCode"
        Me.txtSaleCode.Size = New System.Drawing.Size(320, 30)
        Me.txtSaleCode.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(370, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 52)
        Me.Button1.TabIndex = 65
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelAddPurchaseTitle
        '
        Me.LabelAddPurchaseTitle.AutoSize = True
        Me.LabelAddPurchaseTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddPurchaseTitle.Location = New System.Drawing.Point(14, 21)
        Me.LabelAddPurchaseTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddPurchaseTitle.Name = "LabelAddPurchaseTitle"
        Me.LabelAddPurchaseTitle.Size = New System.Drawing.Size(203, 29)
        Me.LabelAddPurchaseTitle.TabIndex = 47
        Me.LabelAddPurchaseTitle.Text = "Sale Information"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(510, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 52)
        Me.Button2.TabIndex = 64
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(178, 278)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(320, 30)
        Me.txtTotalAmount.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 280)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Total Amount"
        '
        'ComboBoxSaleEm
        '
        Me.ComboBoxSaleEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSaleEm.FormattingEnabled = True
        Me.ComboBoxSaleEm.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxSaleEm.Location = New System.Drawing.Point(178, 169)
        Me.ComboBoxSaleEm.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSaleEm.Name = "ComboBoxSaleEm"
        Me.ComboBoxSaleEm.Size = New System.Drawing.Size(320, 33)
        Me.ComboBoxSaleEm.TabIndex = 59
        '
        'LabelProName
        '
        Me.LabelProName.AutoSize = True
        Me.LabelProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProName.Location = New System.Drawing.Point(13, 119)
        Me.LabelProName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProName.Name = "LabelProName"
        Me.LabelProName.Size = New System.Drawing.Size(105, 25)
        Me.LabelProName.TabIndex = 42
        Me.LabelProName.Text = "Sale Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 173)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Employee Name"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(13, 230)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(53, 25)
        Me.LabelDate.TabIndex = 45
        Me.LabelDate.Text = "Date"
        '
        'SaleDate
        '
        Me.SaleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaleDate.Location = New System.Drawing.Point(178, 232)
        Me.SaleDate.Margin = New System.Windows.Forms.Padding(4)
        Me.SaleDate.Name = "SaleDate"
        Me.SaleDate.Size = New System.Drawing.Size(318, 24)
        Me.SaleDate.TabIndex = 54
        '
        'DataGridViewSale
        '
        Me.DataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSale.Location = New System.Drawing.Point(12, 452)
        Me.DataGridViewSale.Name = "DataGridViewSale"
        Me.DataGridViewSale.RowTemplate.Height = 24
        Me.DataGridViewSale.Size = New System.Drawing.Size(640, 487)
        Me.DataGridViewSale.TabIndex = 68
        '
        'DataGridViewSaleDetail
        '
        Me.DataGridViewSaleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSaleDetail.Location = New System.Drawing.Point(679, 452)
        Me.DataGridViewSaleDetail.Name = "DataGridViewSaleDetail"
        Me.DataGridViewSaleDetail.RowTemplate.Height = 24
        Me.DataGridViewSaleDetail.Size = New System.Drawing.Size(1191, 487)
        Me.DataGridViewSaleDetail.TabIndex = 69
        '
        'SaleManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 976)
        Me.Controls.Add(Me.DataGridViewSaleDetail)
        Me.Controls.Add(Me.DataGridViewSale)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "SaleManagment"
        Me.Text = "SaleManagment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewSale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewSaleDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents SaleDeProId As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxShipping As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxSupplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxSaleDeId As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaleQty As TextBox
    Friend WithEvents LabelTotalPrice As Label
    Friend WithEvents LabelUnitprice As Label
    Friend WithEvents txtProUnitprice As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents LabelQty As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxSaleStatus As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSaleCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelAddPurchaseTitle As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxSaleEm As ComboBox
    Friend WithEvents LabelProName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents SaleDate As DateTimePicker
    Friend WithEvents DataGridViewSale As DataGridView
    Friend WithEvents DataGridViewSaleDetail As DataGridView
    Friend WithEvents ComboBoxUOM As ComboBox
    Friend WithEvents Label6 As Label
End Class
