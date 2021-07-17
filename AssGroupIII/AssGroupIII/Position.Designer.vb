<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Position
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Position))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.LabelAddBrandTitle = New System.Windows.Forms.Label()
        Me.Labeldescription = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.DataGridViewPosition = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(581, 74)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 52)
        Me.btnCancel.TabIndex = 68
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(721, 74)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 52)
        Me.btnSave.TabIndex = 67
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(267, 200)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(267, 96)
        Me.txtDescription.TabIndex = 66
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(267, 161)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(267, 30)
        Me.txtName.TabIndex = 65
        Me.txtName.UseSystemPasswordChar = True
        '
        'LabelAddBrandTitle
        '
        Me.LabelAddBrandTitle.AutoSize = True
        Me.LabelAddBrandTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddBrandTitle.Location = New System.Drawing.Point(124, 39)
        Me.LabelAddBrandTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAddBrandTitle.Name = "LabelAddBrandTitle"
        Me.LabelAddBrandTitle.Size = New System.Drawing.Size(108, 29)
        Me.LabelAddBrandTitle.TabIndex = 64
        Me.LabelAddBrandTitle.Text = "Position"
        '
        'Labeldescription
        '
        Me.Labeldescription.AutoSize = True
        Me.Labeldescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldescription.Location = New System.Drawing.Point(123, 204)
        Me.Labeldescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labeldescription.Name = "Labeldescription"
        Me.Labeldescription.Size = New System.Drawing.Size(109, 25)
        Me.Labeldescription.TabIndex = 63
        Me.Labeldescription.Text = "Description"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(120, 168)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(64, 25)
        Me.LabelName.TabIndex = 62
        Me.LabelName.Text = "Name"
        '
        'DataGridViewPosition
        '
        Me.DataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPosition.Location = New System.Drawing.Point(128, 337)
        Me.DataGridViewPosition.Name = "DataGridViewPosition"
        Me.DataGridViewPosition.RowTemplate.Height = 24
        Me.DataGridViewPosition.Size = New System.Drawing.Size(713, 371)
        Me.DataGridViewPosition.TabIndex = 69
        '
        'Position
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 754)
        Me.Controls.Add(Me.DataGridViewPosition)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.LabelAddBrandTitle)
        Me.Controls.Add(Me.Labeldescription)
        Me.Controls.Add(Me.LabelName)
        Me.Name = "Position"
        Me.Text = "Position"
        CType(Me.DataGridViewPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents LabelAddBrandTitle As Label
    Friend WithEvents Labeldescription As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents DataGridViewPosition As DataGridView
End Class
