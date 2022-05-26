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
        Me.txtNoOfBikesRented = New System.Windows.Forms.TextBox()
        Me.lblNoOfBikesRented = New System.Windows.Forms.Label()
        Me.pnlRentalList = New System.Windows.Forms.Panel()
        Me.lblRentalsList = New System.Windows.Forms.Label()
        Me.lblReturnList = New System.Windows.Forms.Label()
        Me.pnlReturnList = New System.Windows.Forms.Panel()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblRentDate = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpRentDate = New System.Windows.Forms.DateTimePicker()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblHoursRented = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtHoursRented = New System.Windows.Forms.TextBox()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.dtpRentTime = New System.Windows.Forms.DateTimePicker()
        Me.lblRentTime = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtpReturnTime = New System.Windows.Forms.DateTimePicker()
        Me.lblReturnTime = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
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
        Me.Panel2.Location = New System.Drawing.Point(86, 187)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 1)
        Me.Panel2.TabIndex = 25
        '
        'txtNoOfBikesRented
        '
        Me.txtNoOfBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNoOfBikesRented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtNoOfBikesRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoOfBikesRented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfBikesRented.ForeColor = System.Drawing.Color.White
        Me.txtNoOfBikesRented.Location = New System.Drawing.Point(86, 155)
        Me.txtNoOfBikesRented.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoOfBikesRented.Multiline = True
        Me.txtNoOfBikesRented.Name = "txtNoOfBikesRented"
        Me.txtNoOfBikesRented.Size = New System.Drawing.Size(312, 28)
        Me.txtNoOfBikesRented.TabIndex = 24
        '
        'lblNoOfBikesRented
        '
        Me.lblNoOfBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoOfBikesRented.AutoSize = True
        Me.lblNoOfBikesRented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBikesRented.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoOfBikesRented.Location = New System.Drawing.Point(81, 113)
        Me.lblNoOfBikesRented.Name = "lblNoOfBikesRented"
        Me.lblNoOfBikesRented.Size = New System.Drawing.Size(186, 25)
        Me.lblNoOfBikesRented.TabIndex = 26
        Me.lblNoOfBikesRented.Text = "No. of Bikes Rented"
        '
        'pnlRentalList
        '
        Me.pnlRentalList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlRentalList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRentalList.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRentalList.ForeColor = System.Drawing.Color.LightGray
        Me.pnlRentalList.Location = New System.Drawing.Point(605, 137)
        Me.pnlRentalList.Name = "pnlRentalList"
        Me.pnlRentalList.Size = New System.Drawing.Size(645, 320)
        Me.pnlRentalList.TabIndex = 27
        '
        'lblRentalsList
        '
        Me.lblRentalsList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRentalsList.AutoSize = True
        Me.lblRentalsList.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalsList.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentalsList.Location = New System.Drawing.Point(856, 95)
        Me.lblRentalsList.Name = "lblRentalsList"
        Me.lblRentalsList.Size = New System.Drawing.Size(144, 32)
        Me.lblRentalsList.TabIndex = 28
        Me.lblRentalsList.Text = "Rentals List"
        '
        'lblReturnList
        '
        Me.lblReturnList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReturnList.AutoSize = True
        Me.lblReturnList.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnList.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnList.Location = New System.Drawing.Point(862, 487)
        Me.lblReturnList.Name = "lblReturnList"
        Me.lblReturnList.Size = New System.Drawing.Size(138, 32)
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
        'lblCustomerName
        '
        Me.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomerName.Location = New System.Drawing.Point(81, 230)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(155, 25)
        Me.lblCustomerName.TabIndex = 33
        Me.lblCustomerName.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(86, 304)
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
        Me.txtCustomerName.Location = New System.Drawing.Point(86, 272)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(312, 34)
        Me.txtCustomerName.TabIndex = 31
        '
        'lblRentDate
        '
        Me.lblRentDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentDate.AutoSize = True
        Me.lblRentDate.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentDate.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentDate.Location = New System.Drawing.Point(81, 449)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.Size = New System.Drawing.Size(98, 25)
        Me.lblRentDate.TabIndex = 36
        Me.lblRentDate.Text = "Rent Date"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(86, 523)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(312, 1)
        Me.Panel3.TabIndex = 35
        '
        'dtpRentDate
        '
        Me.dtpRentDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRentDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentDate.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentDate.Location = New System.Drawing.Point(86, 484)
        Me.dtpRentDate.Name = "dtpRentDate"
        Me.dtpRentDate.Size = New System.Drawing.Size(312, 34)
        Me.dtpRentDate.TabIndex = 37
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.LightGray
        Me.btnOK.Location = New System.Drawing.Point(443, 834)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(78, 41)
        Me.btnOK.TabIndex = 47
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblHoursRented
        '
        Me.lblHoursRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHoursRented.AutoSize = True
        Me.lblHoursRented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursRented.ForeColor = System.Drawing.Color.LightGray
        Me.lblHoursRented.Location = New System.Drawing.Point(81, 346)
        Me.lblHoursRented.Name = "lblHoursRented"
        Me.lblHoursRented.Size = New System.Drawing.Size(142, 25)
        Me.lblHoursRented.TabIndex = 50
        Me.lblHoursRented.Text = "Hour/s Rented"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Location = New System.Drawing.Point(86, 420)
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
        Me.txtHoursRented.Location = New System.Drawing.Point(86, 388)
        Me.txtHoursRented.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHoursRented.Multiline = True
        Me.txtHoursRented.Name = "txtHoursRented"
        Me.txtHoursRented.Size = New System.Drawing.Size(312, 34)
        Me.txtHoursRented.TabIndex = 48
        '
        'lblFee
        '
        Me.lblFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.ForeColor = System.Drawing.Color.LightGray
        Me.lblFee.Location = New System.Drawing.Point(81, 754)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(42, 25)
        Me.lblFee.TabIndex = 53
        Me.lblFee.Text = "Fee"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Location = New System.Drawing.Point(86, 828)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(312, 1)
        Me.Panel6.TabIndex = 52
        '
        'txtFee
        '
        Me.txtFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFee.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFee.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.ForeColor = System.Drawing.Color.White
        Me.txtFee.Location = New System.Drawing.Point(86, 796)
        Me.txtFee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFee.Multiline = True
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(312, 34)
        Me.txtFee.TabIndex = 51
        '
        'dtpRentTime
        '
        Me.dtpRentTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRentTime.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRentTime.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentTime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentTime.Location = New System.Drawing.Point(86, 597)
        Me.dtpRentTime.Name = "dtpRentTime"
        Me.dtpRentTime.Size = New System.Drawing.Size(312, 34)
        Me.dtpRentTime.TabIndex = 56
        '
        'lblRentTime
        '
        Me.lblRentTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentTime.AutoSize = True
        Me.lblRentTime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentTime.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentTime.Location = New System.Drawing.Point(81, 562)
        Me.lblRentTime.Name = "lblRentTime"
        Me.lblRentTime.Size = New System.Drawing.Size(100, 25)
        Me.lblRentTime.TabIndex = 55
        Me.lblRentTime.Text = "Rent Time"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(86, 636)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 1)
        Me.Panel4.TabIndex = 54
        '
        'dtpReturnTime
        '
        Me.dtpReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpReturnTime.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpReturnTime.CustomFormat = "dd/MM/yyyy"
        Me.dtpReturnTime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturnTime.Location = New System.Drawing.Point(86, 698)
        Me.dtpReturnTime.Name = "dtpReturnTime"
        Me.dtpReturnTime.Size = New System.Drawing.Size(312, 34)
        Me.dtpReturnTime.TabIndex = 59
        '
        'lblReturnTime
        '
        Me.lblReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReturnTime.AutoSize = True
        Me.lblReturnTime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnTime.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnTime.Location = New System.Drawing.Point(81, 663)
        Me.lblReturnTime.Name = "lblReturnTime"
        Me.lblReturnTime.Size = New System.Drawing.Size(120, 25)
        Me.lblReturnTime.TabIndex = 58
        Me.lblReturnTime.Text = "Return Time"
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Location = New System.Drawing.Point(86, 737)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(312, 1)
        Me.Panel7.TabIndex = 57
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 882)
        Me.Controls.Add(Me.dtpReturnTime)
        Me.Controls.Add(Me.lblReturnTime)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.dtpRentTime)
        Me.Controls.Add(Me.lblRentTime)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.lblHoursRented)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtHoursRented)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.dtpRentDate)
        Me.Controls.Add(Me.lblRentDate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblReturnList)
        Me.Controls.Add(Me.pnlReturnList)
        Me.Controls.Add(Me.lblRentalsList)
        Me.Controls.Add(Me.pnlRentalList)
        Me.Controls.Add(Me.lblNoOfBikesRented)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtNoOfBikesRented)
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
    Friend WithEvents txtNoOfBikesRented As TextBox
    Friend WithEvents lblNoOfBikesRented As Label
    Friend WithEvents pnlRentalList As Panel
    Friend WithEvents lblRentalsList As Label
    Friend WithEvents lblReturnList As Label
    Friend WithEvents pnlReturnList As Panel
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblRentDate As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpRentDate As DateTimePicker
    Friend WithEvents btnOK As Button
    Friend WithEvents lblHoursRented As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtHoursRented As TextBox
    Friend WithEvents lblFee As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtFee As TextBox
    Friend WithEvents dtpRentTime As DateTimePicker
    Friend WithEvents lblRentTime As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dtpReturnTime As DateTimePicker
    Friend WithEvents lblReturnTime As Label
    Friend WithEvents Panel7 As Panel
End Class
