<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCostumer
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
        Me.pnlCustormerTitleContainer = New System.Windows.Forms.Panel()
        Me.pbCloseCustomerEditForm = New FontAwesome.Sharp.IconPictureBox()
        Me.pbCloseCustomerForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblCustomerEditTitle = New System.Windows.Forms.Label()
        Me.btlSaveCustomer = New System.Windows.Forms.Button()
        Me.lblEmailAdd = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.pnlCustormerTitleContainer.SuspendLayout()
        CType(Me.pbCloseCustomerEditForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustormerTitleContainer
        '
        Me.pnlCustormerTitleContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlCustormerTitleContainer.Controls.Add(Me.pbCloseCustomerEditForm)
        Me.pnlCustormerTitleContainer.Controls.Add(Me.pbCloseCustomerForm)
        Me.pnlCustormerTitleContainer.Controls.Add(Me.lblCustomerEditTitle)
        Me.pnlCustormerTitleContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCustormerTitleContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustormerTitleContainer.Name = "pnlCustormerTitleContainer"
        Me.pnlCustormerTitleContainer.Size = New System.Drawing.Size(476, 65)
        Me.pnlCustormerTitleContainer.TabIndex = 60
        '
        'pbCloseCustomerEditForm
        '
        Me.pbCloseCustomerEditForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbCloseCustomerEditForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseCustomerEditForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseCustomerEditForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseCustomerEditForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseCustomerEditForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseCustomerEditForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseCustomerEditForm.IconSize = 50
        Me.pbCloseCustomerEditForm.Location = New System.Drawing.Point(410, 9)
        Me.pbCloseCustomerEditForm.Name = "pbCloseCustomerEditForm"
        Me.pbCloseCustomerEditForm.Size = New System.Drawing.Size(50, 51)
        Me.pbCloseCustomerEditForm.TabIndex = 4
        Me.pbCloseCustomerEditForm.TabStop = False
        '
        'pbCloseCustomerForm
        '
        Me.pbCloseCustomerForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbCloseCustomerForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseCustomerForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseCustomerForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseCustomerForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseCustomerForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseCustomerForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseCustomerForm.IconSize = 50
        Me.pbCloseCustomerForm.Location = New System.Drawing.Point(656, 10)
        Me.pbCloseCustomerForm.Name = "pbCloseCustomerForm"
        Me.pbCloseCustomerForm.Size = New System.Drawing.Size(50, 51)
        Me.pbCloseCustomerForm.TabIndex = 3
        Me.pbCloseCustomerForm.TabStop = False
        '
        'lblCustomerEditTitle
        '
        Me.lblCustomerEditTitle.AutoSize = True
        Me.lblCustomerEditTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerEditTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomerEditTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblCustomerEditTitle.Name = "lblCustomerEditTitle"
        Me.lblCustomerEditTitle.Size = New System.Drawing.Size(360, 37)
        Me.lblCustomerEditTitle.TabIndex = 1
        Me.lblCustomerEditTitle.Text = "Edit Costumer Information"
        '
        'btlSaveCustomer
        '
        Me.btlSaveCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btlSaveCustomer.BackColor = System.Drawing.Color.RoyalBlue
        Me.btlSaveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btlSaveCustomer.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlSaveCustomer.ForeColor = System.Drawing.Color.Snow
        Me.btlSaveCustomer.Location = New System.Drawing.Point(58, 407)
        Me.btlSaveCustomer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btlSaveCustomer.Name = "btlSaveCustomer"
        Me.btlSaveCustomer.Size = New System.Drawing.Size(347, 34)
        Me.btlSaveCustomer.TabIndex = 86
        Me.btlSaveCustomer.Text = "Save"
        Me.btlSaveCustomer.UseVisualStyleBackColor = False
        '
        'lblEmailAdd
        '
        Me.lblEmailAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmailAdd.AutoSize = True
        Me.lblEmailAdd.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAdd.ForeColor = System.Drawing.Color.LightGray
        Me.lblEmailAdd.Location = New System.Drawing.Point(57, 332)
        Me.lblEmailAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailAdd.Name = "lblEmailAdd"
        Me.lblEmailAdd.Size = New System.Drawing.Size(103, 19)
        Me.lblEmailAdd.TabIndex = 85
        Me.lblEmailAdd.Text = "Email Address"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailAddress.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.LightGray
        Me.txtEmailAddress.Location = New System.Drawing.Point(60, 355)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(343, 22)
        Me.txtEmailAddress.TabIndex = 84
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(58, 380)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(345, 1)
        Me.Panel4.TabIndex = 83
        '
        'lblContactNumber
        '
        Me.lblContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.LightGray
        Me.lblContactNumber.Location = New System.Drawing.Point(57, 263)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(119, 19)
        Me.lblContactNumber.TabIndex = 82
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContactNumber.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.LightGray
        Me.txtContactNumber.Location = New System.Drawing.Point(60, 284)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(343, 22)
        Me.txtContactNumber.TabIndex = 81
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(58, 308)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 1)
        Me.Panel3.TabIndex = 80
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.LightGray
        Me.lblAddress.Location = New System.Drawing.Point(57, 198)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(63, 19)
        Me.lblAddress.TabIndex = 79
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.LightGray
        Me.txtAddress.Location = New System.Drawing.Point(60, 221)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(343, 22)
        Me.txtAddress.TabIndex = 78
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(58, 245)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 1)
        Me.Panel2.TabIndex = 77
        '
        'lblFullName
        '
        Me.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.LightGray
        Me.lblFullName.Location = New System.Drawing.Point(60, 126)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(76, 19)
        Me.lblFullName.TabIndex = 76
        Me.lblFullName.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.LightGray
        Me.txtFullName.Location = New System.Drawing.Point(62, 148)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(343, 22)
        Me.txtFullName.TabIndex = 75
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(60, 173)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 1)
        Me.Panel1.TabIndex = 74
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCustomerID.Location = New System.Drawing.Point(58, 83)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 87
        Me.txtCustomerID.Visible = False
        '
        'frmEditCostumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 665)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.btlSaveCustomer)
        Me.Controls.Add(Me.lblEmailAdd)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlCustormerTitleContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditCostumer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Customer Information"
        Me.pnlCustormerTitleContainer.ResumeLayout(False)
        Me.pnlCustormerTitleContainer.PerformLayout()
        CType(Me.pbCloseCustomerEditForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCustormerTitleContainer As Panel
    Friend WithEvents pbCloseCustomerForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblCustomerEditTitle As Label
    Friend WithEvents pbCloseCustomerEditForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btlSaveCustomer As Button
    Friend WithEvents lblEmailAdd As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCustomerID As TextBox
End Class
