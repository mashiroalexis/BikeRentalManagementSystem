<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        Me.pnlReturnTitleCover = New System.Windows.Forms.Panel()
        Me.pbCloseReturnForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblReturnTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNoOfBikes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRentalList = New System.Windows.Forms.Panel()
        Me.lblRentalsList = New System.Windows.Forms.Label()
        Me.lblReturnList = New System.Windows.Forms.Label()
        Me.pnlReturnList = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpRentDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.lblReturnDate = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblHoursRented = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtHoursRented = New System.Windows.Forms.TextBox()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.pnlReturnTitleCover.SuspendLayout()
        CType(Me.pbCloseReturnForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReturnTitleCover
        '
        Me.pnlReturnTitleCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlReturnTitleCover.Controls.Add(Me.pbCloseReturnForm)
        Me.pnlReturnTitleCover.Controls.Add(Me.lblReturnTitle)
        Me.pnlReturnTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReturnTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlReturnTitleCover.Name = "pnlReturnTitleCover"
        Me.pnlReturnTitleCover.Size = New System.Drawing.Size(1284, 80)
        Me.pnlReturnTitleCover.TabIndex = 0
        '
        'pbCloseReturnForm
        '
        Me.pbCloseReturnForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbCloseReturnForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseReturnForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseReturnForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseReturnForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseReturnForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseReturnForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseReturnForm.IconSize = 62
        Me.pbCloseReturnForm.Location = New System.Drawing.Point(1213, 12)
        Me.pbCloseReturnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCloseReturnForm.Name = "pbCloseReturnForm"
        Me.pbCloseReturnForm.Size = New System.Drawing.Size(67, 62)
        Me.pbCloseReturnForm.TabIndex = 5
        Me.pbCloseReturnForm.TabStop = False
        '
        'lblReturnTitle
        '
        Me.lblReturnTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReturnTitle.AutoSize = True
        Me.lblReturnTitle.Font = New System.Drawing.Font("Nirmala UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnTitle.Location = New System.Drawing.Point(13, 9)
        Me.lblReturnTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturnTitle.Name = "lblReturnTitle"
        Me.lblReturnTitle.Size = New System.Drawing.Size(125, 45)
        Me.lblReturnTitle.TabIndex = 1
        Me.lblReturnTitle.Text = "Return"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(73, 211)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 1)
        Me.Panel2.TabIndex = 25
        '
        'txtNoOfBikes
        '
        Me.txtNoOfBikes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNoOfBikes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtNoOfBikes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoOfBikes.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfBikes.ForeColor = System.Drawing.Color.White
        Me.txtNoOfBikes.Location = New System.Drawing.Point(73, 179)
        Me.txtNoOfBikes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoOfBikes.Multiline = True
        Me.txtNoOfBikes.Name = "txtNoOfBikes"
        Me.txtNoOfBikes.Size = New System.Drawing.Size(312, 28)
        Me.txtNoOfBikes.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(68, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "No. Of Bikes Rented"
        '
        'pnlRentalList
        '
        Me.pnlRentalList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlRentalList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRentalList.Location = New System.Drawing.Point(605, 137)
        Me.pnlRentalList.Name = "pnlRentalList"
        Me.pnlRentalList.Size = New System.Drawing.Size(645, 320)
        Me.pnlRentalList.TabIndex = 27
        '
        'lblRentalsList
        '
        Me.lblRentalsList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRentalsList.AutoSize = True
        Me.lblRentalsList.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalsList.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentalsList.Location = New System.Drawing.Point(856, 95)
        Me.lblRentalsList.Name = "lblRentalsList"
        Me.lblRentalsList.Size = New System.Drawing.Size(120, 28)
        Me.lblRentalsList.TabIndex = 28
        Me.lblRentalsList.Text = "Rentals List"
        '
        'lblReturnList
        '
        Me.lblReturnList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReturnList.AutoSize = True
        Me.lblReturnList.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnList.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnList.Location = New System.Drawing.Point(856, 490)
        Me.lblReturnList.Name = "lblReturnList"
        Me.lblReturnList.Size = New System.Drawing.Size(114, 28)
        Me.lblReturnList.TabIndex = 30
        Me.lblReturnList.Text = "Return List"
        '
        'pnlReturnList
        '
        Me.pnlReturnList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlReturnList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlReturnList.Location = New System.Drawing.Point(605, 531)
        Me.pnlReturnList.Name = "pnlReturnList"
        Me.pnlReturnList.Size = New System.Drawing.Size(645, 320)
        Me.pnlReturnList.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(68, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(73, 328)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 1)
        Me.Panel1.TabIndex = 32
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.ForeColor = System.Drawing.Color.White
        Me.txtCustomerName.Location = New System.Drawing.Point(73, 296)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(312, 34)
        Me.txtCustomerName.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(68, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Rent Date"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(73, 547)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(312, 1)
        Me.Panel3.TabIndex = 35
        '
        'dtpRentDate
        '
        Me.dtpRentDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentDate.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentDate.Location = New System.Drawing.Point(73, 508)
        Me.dtpRentDate.Name = "dtpRentDate"
        Me.dtpRentDate.Size = New System.Drawing.Size(312, 34)
        Me.dtpRentDate.TabIndex = 37
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpReturnDate.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturnDate.Location = New System.Drawing.Point(73, 630)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(312, 34)
        Me.dtpReturnDate.TabIndex = 40
        '
        'lblReturnDate
        '
        Me.lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReturnDate.AutoSize = True
        Me.lblReturnDate.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnDate.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnDate.Location = New System.Drawing.Point(68, 595)
        Me.lblReturnDate.Name = "lblReturnDate"
        Me.lblReturnDate.Size = New System.Drawing.Size(118, 25)
        Me.lblReturnDate.TabIndex = 39
        Me.lblReturnDate.Text = "Return Date"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(73, 669)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 1)
        Me.Panel4.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(391, 810)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 41)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblHoursRented
        '
        Me.lblHoursRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHoursRented.AutoSize = True
        Me.lblHoursRented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursRented.ForeColor = System.Drawing.Color.LightGray
        Me.lblHoursRented.Location = New System.Drawing.Point(68, 370)
        Me.lblHoursRented.Name = "lblHoursRented"
        Me.lblHoursRented.Size = New System.Drawing.Size(142, 25)
        Me.lblHoursRented.TabIndex = 50
        Me.lblHoursRented.Text = "Hour/s Rented"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Location = New System.Drawing.Point(73, 444)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(312, 1)
        Me.Panel5.TabIndex = 49
        '
        'txtHoursRented
        '
        Me.txtHoursRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHoursRented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtHoursRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHoursRented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursRented.ForeColor = System.Drawing.Color.White
        Me.txtHoursRented.Location = New System.Drawing.Point(73, 412)
        Me.txtHoursRented.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHoursRented.Multiline = True
        Me.txtHoursRented.Name = "txtHoursRented"
        Me.txtHoursRented.Size = New System.Drawing.Size(312, 34)
        Me.txtHoursRented.TabIndex = 48
        '
        'lblCharge
        '
        Me.lblCharge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharge.ForeColor = System.Drawing.Color.LightGray
        Me.lblCharge.Location = New System.Drawing.Point(68, 698)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(75, 25)
        Me.lblCharge.TabIndex = 53
        Me.lblCharge.Text = "Charge"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Location = New System.Drawing.Point(73, 772)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(312, 1)
        Me.Panel6.TabIndex = 52
        '
        'txtCharge
        '
        Me.txtCharge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCharge.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtCharge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCharge.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharge.ForeColor = System.Drawing.Color.White
        Me.txtCharge.Location = New System.Drawing.Point(73, 740)
        Me.txtCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCharge.Multiline = True
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(312, 34)
        Me.txtCharge.TabIndex = 51
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 882)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtCharge)
        Me.Controls.Add(Me.lblHoursRented)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtHoursRented)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.lblReturnDate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dtpRentDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblReturnList)
        Me.Controls.Add(Me.pnlReturnList)
        Me.Controls.Add(Me.lblRentalsList)
        Me.Controls.Add(Me.pnlRentalList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtNoOfBikes)
        Me.Controls.Add(Me.pnlReturnTitleCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturn"
        Me.Text = "frmReturn"
        Me.pnlReturnTitleCover.ResumeLayout(False)
        Me.pnlReturnTitleCover.PerformLayout()
        CType(Me.pbCloseReturnForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlReturnTitleCover As Panel
    Friend WithEvents lblReturnTitle As Label
    Friend WithEvents pbCloseReturnForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNoOfBikes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlRentalList As Panel
    Friend WithEvents lblRentalsList As Label
    Friend WithEvents lblReturnList As Label
    Friend WithEvents pnlReturnList As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpRentDate As DateTimePicker
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents lblReturnDate As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblHoursRented As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtHoursRented As TextBox
    Friend WithEvents lblCharge As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtCharge As TextBox
End Class
