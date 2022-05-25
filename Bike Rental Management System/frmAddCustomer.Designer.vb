<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomer
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
        Me.pnlAddNewTitleCover = New System.Windows.Forms.Panel()
        Me.lblAddCustomerTitle = New System.Windows.Forms.Label()
        Me.pbCloseAddCustomerForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
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
        Me.pnlAddNewTitleCover.SuspendLayout()
        CType(Me.pbCloseAddCustomerForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAddNewTitleCover
        '
        Me.pnlAddNewTitleCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlAddNewTitleCover.Controls.Add(Me.lblAddCustomerTitle)
        Me.pnlAddNewTitleCover.Controls.Add(Me.pbCloseAddCustomerForm)
        Me.pnlAddNewTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAddNewTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlAddNewTitleCover.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlAddNewTitleCover.Name = "pnlAddNewTitleCover"
        Me.pnlAddNewTitleCover.Size = New System.Drawing.Size(458, 65)
        Me.pnlAddNewTitleCover.TabIndex = 0
        '
        'lblAddCustomerTitle
        '
        Me.lblAddCustomerTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAddCustomerTitle.AutoSize = True
        Me.lblAddCustomerTitle.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddCustomerTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblAddCustomerTitle.Location = New System.Drawing.Point(63, 23)
        Me.lblAddCustomerTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddCustomerTitle.Name = "lblAddCustomerTitle"
        Me.lblAddCustomerTitle.Size = New System.Drawing.Size(224, 25)
        Me.lblAddCustomerTitle.TabIndex = 14
        Me.lblAddCustomerTitle.Text = "Customer's Information"
        '
        'pbCloseAddCustomerForm
        '
        Me.pbCloseAddCustomerForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbCloseAddCustomerForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseAddCustomerForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseAddCustomerForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseAddCustomerForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseAddCustomerForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseAddCustomerForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseAddCustomerForm.IconSize = 38
        Me.pbCloseAddCustomerForm.Location = New System.Drawing.Point(409, 10)
        Me.pbCloseAddCustomerForm.Name = "pbCloseAddCustomerForm"
        Me.pbCloseAddCustomerForm.Size = New System.Drawing.Size(38, 42)
        Me.pbCloseAddCustomerForm.TabIndex = 4
        Me.pbCloseAddCustomerForm.TabStop = False
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddCustomer.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCustomer.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.Snow
        Me.btnAddCustomer.Location = New System.Drawing.Point(56, 368)
        Me.btnAddCustomer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(347, 34)
        Me.btnAddCustomer.TabIndex = 26
        Me.btnAddCustomer.Text = "Add"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'lblEmailAdd
        '
        Me.lblEmailAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmailAdd.AutoSize = True
        Me.lblEmailAdd.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAdd.ForeColor = System.Drawing.Color.LightGray
        Me.lblEmailAdd.Location = New System.Drawing.Point(55, 294)
        Me.lblEmailAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailAdd.Name = "lblEmailAdd"
        Me.lblEmailAdd.Size = New System.Drawing.Size(103, 19)
        Me.lblEmailAdd.TabIndex = 25
        Me.lblEmailAdd.Text = "Email Address"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailAddress.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.LightGray
        Me.txtEmailAddress.Location = New System.Drawing.Point(58, 317)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(343, 22)
        Me.txtEmailAddress.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(56, 342)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(345, 1)
        Me.Panel4.TabIndex = 23
        '
        'lblContactNumber
        '
        Me.lblContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.LightGray
        Me.lblContactNumber.Location = New System.Drawing.Point(55, 225)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(119, 19)
        Me.lblContactNumber.TabIndex = 22
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContactNumber.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.LightGray
        Me.txtContactNumber.Location = New System.Drawing.Point(58, 246)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(343, 22)
        Me.txtContactNumber.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(56, 270)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 1)
        Me.Panel3.TabIndex = 20
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.LightGray
        Me.lblAddress.Location = New System.Drawing.Point(55, 160)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(63, 19)
        Me.lblAddress.TabIndex = 19
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.LightGray
        Me.txtAddress.Location = New System.Drawing.Point(58, 183)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(343, 22)
        Me.txtAddress.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(56, 207)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 1)
        Me.Panel2.TabIndex = 17
        '
        'lblFullName
        '
        Me.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.LightGray
        Me.lblFullName.Location = New System.Drawing.Point(58, 88)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(76, 19)
        Me.lblFullName.TabIndex = 16
        Me.lblFullName.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.LightGray
        Me.txtFullName.Location = New System.Drawing.Point(60, 110)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(343, 22)
        Me.txtFullName.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(58, 135)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 1)
        Me.Panel1.TabIndex = 14
        '
        'frmAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 490)
        Me.Controls.Add(Me.btnAddCustomer)
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
        Me.Controls.Add(Me.pnlAddNewTitleCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddCustomer"
        Me.pnlAddNewTitleCover.ResumeLayout(False)
        Me.pnlAddNewTitleCover.PerformLayout()
        CType(Me.pbCloseAddCustomerForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAddNewTitleCover As Panel
    Friend WithEvents pbCloseAddCustomerForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblAddCustomerTitle As Label
    Friend WithEvents btnAddCustomer As Button
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
End Class
