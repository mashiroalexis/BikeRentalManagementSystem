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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvRentalList = New System.Windows.Forms.DataGridView()
        Me.customerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.returnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrsRented = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noOfBikeRented = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlReturnTitleCover.SuspendLayout()
        CType(Me.pbCloseReturnForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRentalList.SuspendLayout()
        Me.pnlReturnList.SuspendLayout()
        CType(Me.dgvRentalList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReturnTitleCover
        '
        Me.pnlReturnTitleCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlReturnTitleCover.Controls.Add(Me.pbCloseReturnForm)
        Me.pnlReturnTitleCover.Controls.Add(Me.lblReturnTitle)
        Me.pnlReturnTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReturnTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlReturnTitleCover.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlReturnTitleCover.Name = "pnlReturnTitleCover"
        Me.pnlReturnTitleCover.Size = New System.Drawing.Size(963, 65)
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
        Me.pbCloseReturnForm.IconSize = 50
        Me.pbCloseReturnForm.Location = New System.Drawing.Point(910, 10)
        Me.pbCloseReturnForm.Name = "pbCloseReturnForm"
        Me.pbCloseReturnForm.Size = New System.Drawing.Size(50, 50)
        Me.pbCloseReturnForm.TabIndex = 5
        Me.pbCloseReturnForm.TabStop = False
        '
        'lblReturnTitle
        '
        Me.lblReturnTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReturnTitle.AutoSize = True
        Me.lblReturnTitle.Font = New System.Drawing.Font("Nirmala UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnTitle.Location = New System.Drawing.Point(10, 7)
        Me.lblReturnTitle.Name = "lblReturnTitle"
        Me.lblReturnTitle.Size = New System.Drawing.Size(103, 37)
        Me.lblReturnTitle.TabIndex = 1
        Me.lblReturnTitle.Text = "Return"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(64, 152)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 1)
        Me.Panel2.TabIndex = 25
        '
        'txtNoOfBikesRented
        '
        Me.txtNoOfBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNoOfBikesRented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtNoOfBikesRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoOfBikesRented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfBikesRented.ForeColor = System.Drawing.Color.White
        Me.txtNoOfBikesRented.Location = New System.Drawing.Point(64, 126)
        Me.txtNoOfBikesRented.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNoOfBikesRented.Multiline = True
        Me.txtNoOfBikesRented.Name = "txtNoOfBikesRented"
        Me.txtNoOfBikesRented.Size = New System.Drawing.Size(234, 23)
        Me.txtNoOfBikesRented.TabIndex = 24
        '
        'lblNoOfBikesRented
        '
        Me.lblNoOfBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoOfBikesRented.AutoSize = True
        Me.lblNoOfBikesRented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBikesRented.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoOfBikesRented.Location = New System.Drawing.Point(61, 92)
        Me.lblNoOfBikesRented.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoOfBikesRented.Name = "lblNoOfBikesRented"
        Me.lblNoOfBikesRented.Size = New System.Drawing.Size(148, 20)
        Me.lblNoOfBikesRented.TabIndex = 26
        Me.lblNoOfBikesRented.Text = "No. of Bikes Rented"
        '
        'pnlRentalList
        '
        Me.pnlRentalList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlRentalList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRentalList.Controls.Add(Me.dgvRentalList)
        Me.pnlRentalList.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRentalList.ForeColor = System.Drawing.Color.LightGray
        Me.pnlRentalList.Location = New System.Drawing.Point(454, 111)
        Me.pnlRentalList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlRentalList.Name = "pnlRentalList"
        Me.pnlRentalList.Size = New System.Drawing.Size(485, 261)
        Me.pnlRentalList.TabIndex = 27
        '
        'lblRentalsList
        '
        Me.lblRentalsList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRentalsList.AutoSize = True
        Me.lblRentalsList.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalsList.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentalsList.Location = New System.Drawing.Point(642, 77)
        Me.lblRentalsList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRentalsList.Name = "lblRentalsList"
        Me.lblRentalsList.Size = New System.Drawing.Size(110, 25)
        Me.lblRentalsList.TabIndex = 28
        Me.lblRentalsList.Text = "Rentals List"
        '
        'lblReturnList
        '
        Me.lblReturnList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReturnList.AutoSize = True
        Me.lblReturnList.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnList.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnList.Location = New System.Drawing.Point(646, 396)
        Me.lblReturnList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReturnList.Name = "lblReturnList"
        Me.lblReturnList.Size = New System.Drawing.Size(107, 25)
        Me.lblReturnList.TabIndex = 30
        Me.lblReturnList.Text = "Return List"
        '
        'pnlReturnList
        '
        Me.pnlReturnList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlReturnList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlReturnList.Controls.Add(Me.DataGridView1)
        Me.pnlReturnList.Location = New System.Drawing.Point(454, 431)
        Me.pnlReturnList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlReturnList.Name = "pnlReturnList"
        Me.pnlReturnList.Size = New System.Drawing.Size(485, 261)
        Me.pnlReturnList.TabIndex = 29
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomerName.Location = New System.Drawing.Point(61, 187)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(123, 20)
        Me.lblCustomerName.TabIndex = 33
        Me.lblCustomerName.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(64, 247)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 1)
        Me.Panel1.TabIndex = 32
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerName.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.ForeColor = System.Drawing.Color.White
        Me.txtCustomerName.Location = New System.Drawing.Point(64, 221)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(234, 28)
        Me.txtCustomerName.TabIndex = 31
        '
        'lblRentDate
        '
        Me.lblRentDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentDate.AutoSize = True
        Me.lblRentDate.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentDate.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentDate.Location = New System.Drawing.Point(61, 365)
        Me.lblRentDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.Size = New System.Drawing.Size(79, 20)
        Me.lblRentDate.TabIndex = 36
        Me.lblRentDate.Text = "Rent Date"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(64, 425)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 1)
        Me.Panel3.TabIndex = 35
        '
        'dtpRentDate
        '
        Me.dtpRentDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRentDate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentDate.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentDate.Location = New System.Drawing.Point(64, 393)
        Me.dtpRentDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpRentDate.Name = "dtpRentDate"
        Me.dtpRentDate.Size = New System.Drawing.Size(235, 29)
        Me.dtpRentDate.TabIndex = 37
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.LightGray
        Me.btnOK.Location = New System.Drawing.Point(332, 678)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(58, 33)
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
        Me.lblHoursRented.Location = New System.Drawing.Point(61, 281)
        Me.lblHoursRented.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoursRented.Name = "lblHoursRented"
        Me.lblHoursRented.Size = New System.Drawing.Size(112, 20)
        Me.lblHoursRented.TabIndex = 50
        Me.lblHoursRented.Text = "Hour/s Rented"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Location = New System.Drawing.Point(64, 341)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(234, 1)
        Me.Panel5.TabIndex = 49
        '
        'txtHoursRented
        '
        Me.txtHoursRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHoursRented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtHoursRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHoursRented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursRented.ForeColor = System.Drawing.Color.White
        Me.txtHoursRented.Location = New System.Drawing.Point(64, 315)
        Me.txtHoursRented.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHoursRented.Multiline = True
        Me.txtHoursRented.Name = "txtHoursRented"
        Me.txtHoursRented.Size = New System.Drawing.Size(234, 28)
        Me.txtHoursRented.TabIndex = 48
        '
        'lblFee
        '
        Me.lblFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.ForeColor = System.Drawing.Color.LightGray
        Me.lblFee.Location = New System.Drawing.Point(61, 613)
        Me.lblFee.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(33, 20)
        Me.lblFee.TabIndex = 53
        Me.lblFee.Text = "Fee"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Location = New System.Drawing.Point(64, 673)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(234, 1)
        Me.Panel6.TabIndex = 52
        '
        'txtFee
        '
        Me.txtFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFee.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFee.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.ForeColor = System.Drawing.Color.White
        Me.txtFee.Location = New System.Drawing.Point(64, 647)
        Me.txtFee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFee.Multiline = True
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(234, 28)
        Me.txtFee.TabIndex = 51
        '
        'dtpRentTime
        '
        Me.dtpRentTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRentTime.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRentTime.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentTime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentTime.Location = New System.Drawing.Point(64, 485)
        Me.dtpRentTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpRentTime.Name = "dtpRentTime"
        Me.dtpRentTime.Size = New System.Drawing.Size(235, 29)
        Me.dtpRentTime.TabIndex = 56
        '
        'lblRentTime
        '
        Me.lblRentTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentTime.AutoSize = True
        Me.lblRentTime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentTime.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentTime.Location = New System.Drawing.Point(61, 457)
        Me.lblRentTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRentTime.Name = "lblRentTime"
        Me.lblRentTime.Size = New System.Drawing.Size(81, 20)
        Me.lblRentTime.TabIndex = 55
        Me.lblRentTime.Text = "Rent Time"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(64, 517)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(234, 1)
        Me.Panel4.TabIndex = 54
        '
        'dtpReturnTime
        '
        Me.dtpReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpReturnTime.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpReturnTime.CustomFormat = "dd/MM/yyyy"
        Me.dtpReturnTime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturnTime.Location = New System.Drawing.Point(64, 567)
        Me.dtpReturnTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpReturnTime.Name = "dtpReturnTime"
        Me.dtpReturnTime.Size = New System.Drawing.Size(235, 29)
        Me.dtpReturnTime.TabIndex = 59
        '
        'lblReturnTime
        '
        Me.lblReturnTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReturnTime.AutoSize = True
        Me.lblReturnTime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnTime.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnTime.Location = New System.Drawing.Point(61, 539)
        Me.lblReturnTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReturnTime.Name = "lblReturnTime"
        Me.lblReturnTime.Size = New System.Drawing.Size(96, 20)
        Me.lblReturnTime.TabIndex = 58
        Me.lblReturnTime.Text = "Return Time"
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Location = New System.Drawing.Point(64, 599)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(234, 1)
        Me.Panel7.TabIndex = 57
        '
        'dgvRentalList
        '
        Me.dgvRentalList.AllowUserToAddRows = False
        Me.dgvRentalList.AllowUserToDeleteRows = False
        Me.dgvRentalList.AllowUserToResizeColumns = False
        Me.dgvRentalList.AllowUserToResizeRows = False
        Me.dgvRentalList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentalList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRentalList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customerId, Me.fname, Me.rentDate, Me.returnDate, Me.hrsRented, Me.fee, Me.noOfBikeRented})
        Me.dgvRentalList.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRentalList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRentalList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRentalList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgvRentalList.GridColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.dgvRentalList.Location = New System.Drawing.Point(0, 0)
        Me.dgvRentalList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRentalList.MultiSelect = False
        Me.dgvRentalList.Name = "dgvRentalList"
        Me.dgvRentalList.ReadOnly = True
        Me.dgvRentalList.RowHeadersVisible = False
        Me.dgvRentalList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvRentalList.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRentalList.RowTemplate.Height = 28
        Me.dgvRentalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRentalList.Size = New System.Drawing.Size(481, 257)
        Me.dgvRentalList.TabIndex = 4
        '
        'customerId
        '
        Me.customerId.HeaderText = "ID"
        Me.customerId.Name = "customerId"
        Me.customerId.ReadOnly = True
        Me.customerId.Visible = False
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.MinimumWidth = 8
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        Me.fname.Width = 150
        '
        'rentDate
        '
        Me.rentDate.HeaderText = "Rent Date"
        Me.rentDate.Name = "rentDate"
        Me.rentDate.ReadOnly = True
        '
        'returnDate
        '
        Me.returnDate.HeaderText = "Return Date"
        Me.returnDate.Name = "returnDate"
        Me.returnDate.ReadOnly = True
        '
        'hrsRented
        '
        Me.hrsRented.HeaderText = "Hour(s) Rented"
        Me.hrsRented.Name = "hrsRented"
        Me.hrsRented.ReadOnly = True
        '
        'fee
        '
        Me.fee.HeaderText = "Fee"
        Me.fee.Name = "fee"
        Me.fee.ReadOnly = True
        '
        'noOfBikeRented
        '
        Me.noOfBikeRented.HeaderText = "Qty"
        Me.noOfBikeRented.Name = "noOfBikeRented"
        Me.noOfBikeRented.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(481, 257)
        Me.DataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Rent Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Return Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hour(s) Rented"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fee"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(963, 717)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmReturn"
        Me.Text = "frmReturn"
        Me.pnlReturnTitleCover.ResumeLayout(False)
        Me.pnlReturnTitleCover.PerformLayout()
        CType(Me.pbCloseReturnForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRentalList.ResumeLayout(False)
        Me.pnlReturnList.ResumeLayout(False)
        CType(Me.dgvRentalList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvRentalList As DataGridView
    Friend WithEvents customerId As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents rentDate As DataGridViewTextBoxColumn
    Friend WithEvents returnDate As DataGridViewTextBoxColumn
    Friend WithEvents hrsRented As DataGridViewTextBoxColumn
    Friend WithEvents fee As DataGridViewTextBoxColumn
    Friend WithEvents noOfBikeRented As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
