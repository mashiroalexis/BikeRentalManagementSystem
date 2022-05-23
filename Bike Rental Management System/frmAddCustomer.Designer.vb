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
        Me.pbCloseAddCustomerForm = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblEmailAdd = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAddCustomerTitle = New System.Windows.Forms.Label()
        Me.pnlAddNewTitleCover.SuspendLayout()
        CType(Me.pbCloseAddCustomerForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAddNewTitleCover
        '
        Me.pnlAddNewTitleCover.BackColor = System.Drawing.Color.Transparent
        Me.pnlAddNewTitleCover.Controls.Add(Me.lblAddCustomerTitle)
        Me.pnlAddNewTitleCover.Controls.Add(Me.pbCloseAddCustomerForm)
        Me.pnlAddNewTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAddNewTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlAddNewTitleCover.Name = "pnlAddNewTitleCover"
        Me.pnlAddNewTitleCover.Size = New System.Drawing.Size(611, 80)
        Me.pnlAddNewTitleCover.TabIndex = 0
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
        Me.pbCloseAddCustomerForm.IconSize = 51
        Me.pbCloseAddCustomerForm.Location = New System.Drawing.Point(545, 12)
        Me.pbCloseAddCustomerForm.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCloseAddCustomerForm.Name = "pbCloseAddCustomerForm"
        Me.pbCloseAddCustomerForm.Size = New System.Drawing.Size(51, 51)
        Me.pbCloseAddCustomerForm.TabIndex = 4
        Me.pbCloseAddCustomerForm.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(87, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 1)
        Me.Panel1.TabIndex = 1
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.LightGray
        Me.txtFullName.Location = New System.Drawing.Point(90, 154)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(457, 27)
        Me.txtFullName.TabIndex = 2
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.LightGray
        Me.lblFullName.Location = New System.Drawing.Point(86, 126)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(91, 23)
        Me.lblFullName.TabIndex = 3
        Me.lblFullName.Text = "Full Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.LightGray
        Me.lblAddress.Location = New System.Drawing.Point(83, 215)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(74, 23)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.LightGray
        Me.txtAddress.Location = New System.Drawing.Point(87, 243)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(457, 27)
        Me.txtAddress.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(84, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 1)
        Me.Panel2.TabIndex = 4
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.LightGray
        Me.lblContactNumber.Location = New System.Drawing.Point(83, 296)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(143, 23)
        Me.lblContactNumber.TabIndex = 9
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContactNumber.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.ForeColor = System.Drawing.Color.LightGray
        Me.txtContactNumber.Location = New System.Drawing.Point(87, 321)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(457, 27)
        Me.txtContactNumber.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(84, 351)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(460, 1)
        Me.Panel3.TabIndex = 7
        '
        'lblEmailAdd
        '
        Me.lblEmailAdd.AutoSize = True
        Me.lblEmailAdd.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAdd.ForeColor = System.Drawing.Color.LightGray
        Me.lblEmailAdd.Location = New System.Drawing.Point(83, 381)
        Me.lblEmailAdd.Name = "lblEmailAdd"
        Me.lblEmailAdd.Size = New System.Drawing.Size(123, 23)
        Me.lblEmailAdd.TabIndex = 12
        Me.lblEmailAdd.Text = "Email Address"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailAddress.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.LightGray
        Me.txtEmailAddress.Location = New System.Drawing.Point(87, 409)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(457, 27)
        Me.txtEmailAddress.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(84, 439)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(460, 1)
        Me.Panel4.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(84, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(463, 42)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblAddCustomerTitle
        '
        Me.lblAddCustomerTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddCustomerTitle.AutoSize = True
        Me.lblAddCustomerTitle.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddCustomerTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblAddCustomerTitle.Location = New System.Drawing.Point(84, 28)
        Me.lblAddCustomerTitle.Name = "lblAddCustomerTitle"
        Me.lblAddCustomerTitle.Size = New System.Drawing.Size(294, 35)
        Me.lblAddCustomerTitle.TabIndex = 14
        Me.lblAddCustomerTitle.Text = "Customer's Information"
        '
        'frmAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(611, 603)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblEmailAdd As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblAddCustomerTitle As Label
End Class
