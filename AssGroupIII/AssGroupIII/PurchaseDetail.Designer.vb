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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewPurchase = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxPurStatus = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPurchaseCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelAddPurchaseTitle = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxPurchaseEm = New System.Windows.Forms.ComboBox()
        Me.LabelProName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.PurchaseDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewPurchaseDetail = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PurchaseDeProId = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxShipping = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxPurchaseDeId = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPurchaseQty = New System.Windows.Forms.TextBox()
        Me.LabelTotalPrice = New System.Windows.Forms.Label()
        Me.LabelUnitprice = New System.Windows.Forms.Label()
        Me.txtPurchaseUnitprice = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxUom = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewPurchaseDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel3.Controls.Add(Me.DataGridViewPurchase)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(-4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(688, 972)
        Me.Panel3.TabIndex = 64
        '
        'DataGridViewPurchase
        '
        Me.DataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchase.Location = New System.Drawing.Point(7, 424)
        Me.DataGridViewPurchase.Name = "DataGridViewPurchase"
        Me.DataGridViewPurchase.RowTemplate.Height = 24
        Me.DataGridViewPurchase.Size = New System.Drawing.Size(670, 539)
        Me.DataGridViewPurchase.TabIndex = 65
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ComboBoxPurStatus)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.txtPurchaseCode)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.LabelAddPurchaseTitle)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtTotalAmount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBoxPurchaseEm)
        Me.Panel1.Controls.Add(Me.LabelProName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelDate)
        Me.Panel1.Controls.Add(Me.PurchaseDate)
        Me.Panel1.Location = New System.Drawing.Point(7, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 402)
        Me.Panel1.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 242)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 25)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Status"
        '
        'ComboBoxPurStatus
        '
        Me.ComboBoxPurStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPurStatus.FormattingEnabled = True
        Me.ComboBoxPurStatus.Items.AddRange(New Object() {"Pending", "Completed"})
        Me.ComboBoxPurStatus.Location = New System.Drawing.Point(177, 238)
        Me.ComboBoxPurStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPurStatus.Name = "ComboBoxPurStatus"
        Me.ComboBoxPurStatus.Size = New System.Drawing.Size(250, 33)
        Me.ComboBoxPurStatus.TabIndex = 69
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(203, 20)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 52)
        Me.btnDelete.TabIndex = 68
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtPurchaseCode
        '
        Me.txtPurchaseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseCode.Location = New System.Drawing.Point(177, 119)
        Me.txtPurchaseCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPurchaseCode.Name = "txtPurchaseCode"
        Me.txtPurchaseCode.Size = New System.Drawing.Size(250, 30)
        Me.txtPurchaseCode.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(331, 20)
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
        Me.LabelAddPurchaseTitle.Size = New System.Drawing.Size(122, 29)
        Me.LabelAddPurchaseTitle.TabIndex = 47
        Me.LabelAddPurchaseTitle.Text = "Purchase"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(471, 20)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 52)
        Me.Button2.TabIndex = 64
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(177, 350)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(250, 30)
        Me.txtTotalAmount.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 354)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Total Amount"
        '
        'ComboBoxPurchaseEm
        '
        Me.ComboBoxPurchaseEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPurchaseEm.FormattingEnabled = True
        Me.ComboBoxPurchaseEm.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxPurchaseEm.Location = New System.Drawing.Point(178, 169)
        Me.ComboBoxPurchaseEm.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPurchaseEm.Name = "ComboBoxPurchaseEm"
        Me.ComboBoxPurchaseEm.Size = New System.Drawing.Size(249, 33)
        Me.ComboBoxPurchaseEm.TabIndex = 59
        '
        'LabelProName
        '
        Me.LabelProName.AutoSize = True
        Me.LabelProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProName.Location = New System.Drawing.Point(9, 119)
        Me.LabelProName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProName.Name = "LabelProName"
        Me.LabelProName.Size = New System.Drawing.Size(148, 25)
        Me.LabelProName.TabIndex = 42
        Me.LabelProName.Text = "Purchase Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 173)
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
        Me.LabelDate.Location = New System.Drawing.Point(9, 304)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(53, 25)
        Me.LabelDate.TabIndex = 45
        Me.LabelDate.Text = "Date"
        '
        'PurchaseDate
        '
        Me.PurchaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseDate.Location = New System.Drawing.Point(177, 304)
        Me.PurchaseDate.Margin = New System.Windows.Forms.Padding(4)
        Me.PurchaseDate.Name = "PurchaseDate"
        Me.PurchaseDate.Size = New System.Drawing.Size(247, 24)
        Me.PurchaseDate.TabIndex = 54
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.Controls.Add(Me.DataGridViewPurchaseDetail)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Location = New System.Drawing.Point(690, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1233, 972)
        Me.Panel4.TabIndex = 68
        '
        'DataGridViewPurchaseDetail
        '
        Me.DataGridViewPurchaseDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchaseDetail.Location = New System.Drawing.Point(7, 429)
        Me.DataGridViewPurchaseDetail.Name = "DataGridViewPurchaseDetail"
        Me.DataGridViewPurchaseDetail.RowTemplate.Height = 24
        Me.DataGridViewPurchaseDetail.Size = New System.Drawing.Size(1215, 534)
        Me.DataGridViewPurchaseDetail.TabIndex = 66
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ComboBoxUom)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.PurchaseDeProId)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ComboBoxStatus)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ComboBoxShipping)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ComboBoxSupplier)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ComboBoxPurchaseDeId)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtPurchaseQty)
        Me.Panel2.Controls.Add(Me.LabelTotalPrice)
        Me.Panel2.Controls.Add(Me.LabelUnitprice)
        Me.Panel2.Controls.Add(Me.txtPurchaseUnitprice)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.LabelQty)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.txtTotalPrice)
        Me.Panel2.Location = New System.Drawing.Point(7, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1215, 402)
        Me.Panel2.TabIndex = 65
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(773, 21)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 52)
        Me.Button3.TabIndex = 69
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PurchaseDeProId
        '
        Me.PurchaseDeProId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseDeProId.FormattingEnabled = True
        Me.PurchaseDeProId.Location = New System.Drawing.Point(198, 168)
        Me.PurchaseDeProId.Margin = New System.Windows.Forms.Padding(4)
        Me.PurchaseDeProId.Name = "PurchaseDeProId"
        Me.PurchaseDeProId.Size = New System.Drawing.Size(267, 33)
        Me.PurchaseDeProId.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 169)
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
        Me.ComboBoxStatus.Location = New System.Drawing.Point(774, 160)
        Me.ComboBoxStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(298, 33)
        Me.ComboBoxStatus.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(609, 168)
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
        Me.Label7.Size = New System.Drawing.Size(210, 29)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Purchase Details"
        '
        'ComboBoxShipping
        '
        Me.ComboBoxShipping.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxShipping.FormattingEnabled = True
        Me.ComboBoxShipping.Location = New System.Drawing.Point(774, 113)
        Me.ComboBoxShipping.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxShipping.Name = "ComboBoxShipping"
        Me.ComboBoxShipping.Size = New System.Drawing.Size(298, 33)
        Me.ComboBoxShipping.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(609, 113)
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
        Me.ComboBoxSupplier.Location = New System.Drawing.Point(774, 216)
        Me.ComboBoxSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxSupplier.Name = "ComboBoxSupplier"
        Me.ComboBoxSupplier.Size = New System.Drawing.Size(298, 33)
        Me.ComboBoxSupplier.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(609, 216)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 25)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Supplier ID"
        '
        'ComboBoxPurchaseDeId
        '
        Me.ComboBoxPurchaseDeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPurchaseDeId.FormattingEnabled = True
        Me.ComboBoxPurchaseDeId.Location = New System.Drawing.Point(198, 113)
        Me.ComboBoxPurchaseDeId.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPurchaseDeId.Name = "ComboBoxPurchaseDeId"
        Me.ComboBoxPurchaseDeId.Size = New System.Drawing.Size(267, 33)
        Me.ComboBoxPurchaseDeId.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Purchase ID"
        '
        'txtPurchaseQty
        '
        Me.txtPurchaseQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseQty.Location = New System.Drawing.Point(198, 260)
        Me.txtPurchaseQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPurchaseQty.Name = "txtPurchaseQty"
        Me.txtPurchaseQty.Size = New System.Drawing.Size(267, 30)
        Me.txtPurchaseQty.TabIndex = 50
        '
        'LabelTotalPrice
        '
        Me.LabelTotalPrice.AutoSize = True
        Me.LabelTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPrice.Location = New System.Drawing.Point(609, 280)
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
        Me.LabelUnitprice.Location = New System.Drawing.Point(22, 318)
        Me.LabelUnitprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUnitprice.Name = "LabelUnitprice"
        Me.LabelUnitprice.Size = New System.Drawing.Size(95, 25)
        Me.LabelUnitprice.TabIndex = 43
        Me.LabelUnitprice.Text = "Unit Price"
        '
        'txtPurchaseUnitprice
        '
        Me.txtPurchaseUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseUnitprice.Location = New System.Drawing.Point(198, 313)
        Me.txtPurchaseUnitprice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPurchaseUnitprice.Name = "txtPurchaseUnitprice"
        Me.txtPurchaseUnitprice.Size = New System.Drawing.Size(267, 30)
        Me.txtPurchaseUnitprice.TabIndex = 49
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(913, 21)
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
        Me.LabelQty.Location = New System.Drawing.Point(22, 264)
        Me.LabelQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(85, 25)
        Me.LabelQty.TabIndex = 44
        Me.LabelQty.Text = "Quantity"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(1053, 21)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 55
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(774, 280)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(298, 30)
        Me.txtTotalPrice.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 221)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 25)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Unit of Measure"
        '
        'ComboBoxUom
        '
        Me.ComboBoxUom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxUom.FormattingEnabled = True
        Me.ComboBoxUom.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBoxUom.Location = New System.Drawing.Point(198, 217)
        Me.ComboBoxUom.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxUom.Name = "ComboBoxUom"
        Me.ComboBoxUom.Size = New System.Drawing.Size(266, 33)
        Me.ComboBoxUom.TabIndex = 70
        '
        'PurchaseDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 976)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PurchaseDetail"
        Me.Text = "PurchaseDetail"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridViewPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridViewPurchaseDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridViewPurchase As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPurchaseCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelAddPurchaseTitle As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxPurchaseEm As ComboBox
    Friend WithEvents LabelProName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents PurchaseDate As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewPurchaseDetail As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxShipping As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxSupplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxPurchaseDeId As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPurchaseQty As TextBox
    Friend WithEvents LabelTotalPrice As Label
    Friend WithEvents LabelUnitprice As Label
    Friend WithEvents txtPurchaseUnitprice As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents LabelQty As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents PurchaseDeProId As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxPurStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxUom As ComboBox
End Class
