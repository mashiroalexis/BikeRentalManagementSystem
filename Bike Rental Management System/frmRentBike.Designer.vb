<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRentBike
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlRentTitleCover = New System.Windows.Forms.Panel()
        Me.pbCloseRentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblRentTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoOfBikesRented = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNoofBikesRented = New System.Windows.Forms.TextBox()
        Me.lblCustomername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCustomername = New System.Windows.Forms.TextBox()
        Me.lblHoursrented = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtHoursrented = New System.Windows.Forms.TextBox()
        Me.lblfee = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.pnlRentallist = New System.Windows.Forms.Panel()
        Me.dgvRentalList = New System.Windows.Forms.DataGridView()
        Me.customerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.returnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrsRented = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noOfBikeRented = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRentalsList = New System.Windows.Forms.Label()
        Me.clbAvailableBikes = New System.Windows.Forms.CheckedListBox()
        Me.lblRenttime = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblReturntime = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnAddNewRent = New FontAwesome.Sharp.IconButton()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New FontAwesome.Sharp.IconButton()
        Me.pnlRentTitleCover.SuspendLayout()
        CType(Me.pbCloseRentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRentallist.SuspendLayout()
        CType(Me.dgvRentalList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRentTitleCover
        '
        Me.pnlRentTitleCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlRentTitleCover.Controls.Add(Me.pbCloseRentForm)
        Me.pnlRentTitleCover.Controls.Add(Me.lblRentTitle)
        Me.pnlRentTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRentTitleCover.ForeColor = System.Drawing.Color.LightGray
        Me.pnlRentTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlRentTitleCover.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlRentTitleCover.Name = "pnlRentTitleCover"
        Me.pnlRentTitleCover.Size = New System.Drawing.Size(1284, 80)
        Me.pnlRentTitleCover.TabIndex = 0
        '
        'pbCloseRentForm
        '
        Me.pbCloseRentForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbCloseRentForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseRentForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseRentForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseRentForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseRentForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseRentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseRentForm.IconSize = 62
        Me.pbCloseRentForm.Location = New System.Drawing.Point(1204, 11)
        Me.pbCloseRentForm.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCloseRentForm.Name = "pbCloseRentForm"
        Me.pbCloseRentForm.Size = New System.Drawing.Size(67, 62)
        Me.pbCloseRentForm.TabIndex = 4
        Me.pbCloseRentForm.TabStop = False
        '
        'lblRentTitle
        '
        Me.lblRentTitle.AutoSize = True
        Me.lblRentTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentTitle.Location = New System.Drawing.Point(16, 11)
        Me.lblRentTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRentTitle.Name = "lblRentTitle"
        Me.lblRentTitle.Size = New System.Drawing.Size(93, 46)
        Me.lblRentTitle.TabIndex = 0
        Me.lblRentTitle.Text = "Rent"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(165, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Available Bikes"
        '
        'lblNoOfBikesRented
        '
        Me.lblNoOfBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoOfBikesRented.AutoSize = True
        Me.lblNoOfBikesRented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBikesRented.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoOfBikesRented.Location = New System.Drawing.Point(467, 124)
        Me.lblNoOfBikesRented.Name = "lblNoOfBikesRented"
        Me.lblNoOfBikesRented.Size = New System.Drawing.Size(186, 25)
        Me.lblNoOfBikesRented.TabIndex = 29
        Me.lblNoOfBikesRented.Text = "No. of Bikes Rented"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(473, 188)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 1)
        Me.Panel2.TabIndex = 28
        '
        'txtNoofBikesRented
        '
        Me.txtNoofBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNoofBikesRented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtNoofBikesRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoofBikesRented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoofBikesRented.ForeColor = System.Drawing.Color.White
        Me.txtNoofBikesRented.Location = New System.Drawing.Point(473, 156)
        Me.txtNoofBikesRented.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoofBikesRented.Multiline = True
        Me.txtNoofBikesRented.Name = "txtNoofBikesRented"
        Me.txtNoofBikesRented.ReadOnly = True
        Me.txtNoofBikesRented.Size = New System.Drawing.Size(240, 36)
        Me.txtNoofBikesRented.TabIndex = 27
        Me.txtNoofBikesRented.Text = "0"
        '
        'lblCustomername
        '
        Me.lblCustomername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCustomername.AutoSize = True
        Me.lblCustomername.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomername.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomername.Location = New System.Drawing.Point(905, 124)
        Me.lblCustomername.Name = "lblCustomername"
        Me.lblCustomername.Size = New System.Drawing.Size(155, 25)
        Me.lblCustomername.TabIndex = 32
        Me.lblCustomername.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(910, 188)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 1)
        Me.Panel1.TabIndex = 31
        '
        'txtCustomername
        '
        Me.txtCustomername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCustomername.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtCustomername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomername.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomername.ForeColor = System.Drawing.Color.White
        Me.txtCustomername.Location = New System.Drawing.Point(910, 156)
        Me.txtCustomername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomername.Multiline = True
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.ReadOnly = True
        Me.txtCustomername.Size = New System.Drawing.Size(240, 36)
        Me.txtCustomername.TabIndex = 30
        '
        'lblHoursrented
        '
        Me.lblHoursrented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHoursrented.AutoSize = True
        Me.lblHoursrented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursrented.ForeColor = System.Drawing.Color.LightGray
        Me.lblHoursrented.Location = New System.Drawing.Point(339, 388)
        Me.lblHoursrented.Name = "lblHoursrented"
        Me.lblHoursrented.Size = New System.Drawing.Size(142, 25)
        Me.lblHoursrented.TabIndex = 53
        Me.lblHoursrented.Text = "Hour/s Rented"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Location = New System.Drawing.Point(344, 462)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(240, 1)
        Me.Panel5.TabIndex = 52
        '
        'txtHoursrented
        '
        Me.txtHoursrented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHoursrented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtHoursrented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHoursrented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursrented.ForeColor = System.Drawing.Color.White
        Me.txtHoursrented.Location = New System.Drawing.Point(344, 430)
        Me.txtHoursrented.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHoursrented.Multiline = True
        Me.txtHoursrented.Name = "txtHoursrented"
        Me.txtHoursrented.ReadOnly = True
        Me.txtHoursrented.Size = New System.Drawing.Size(240, 34)
        Me.txtHoursrented.TabIndex = 51
        Me.txtHoursrented.Text = "0"
        '
        'lblfee
        '
        Me.lblfee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblfee.AutoSize = True
        Me.lblfee.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfee.ForeColor = System.Drawing.Color.LightGray
        Me.lblfee.Location = New System.Drawing.Point(795, 388)
        Me.lblfee.Name = "lblfee"
        Me.lblfee.Size = New System.Drawing.Size(42, 25)
        Me.lblfee.TabIndex = 56
        Me.lblfee.Text = "Fee"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(799, 462)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 1)
        Me.Panel4.TabIndex = 55
        '
        'txtFee
        '
        Me.txtFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFee.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFee.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.ForeColor = System.Drawing.Color.White
        Me.txtFee.Location = New System.Drawing.Point(799, 430)
        Me.txtFee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFee.Multiline = True
        Me.txtFee.Name = "txtFee"
        Me.txtFee.ReadOnly = True
        Me.txtFee.Size = New System.Drawing.Size(240, 34)
        Me.txtFee.TabIndex = 54
        '
        'pnlRentallist
        '
        Me.pnlRentallist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRentallist.Controls.Add(Me.dgvRentalList)
        Me.pnlRentallist.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRentallist.ForeColor = System.Drawing.Color.LightGray
        Me.pnlRentallist.Location = New System.Drawing.Point(114, 612)
        Me.pnlRentallist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlRentallist.Name = "pnlRentallist"
        Me.pnlRentallist.Size = New System.Drawing.Size(1058, 249)
        Me.pnlRentallist.TabIndex = 59
        '
        'dgvRentalList
        '
        Me.dgvRentalList.AllowUserToAddRows = False
        Me.dgvRentalList.AllowUserToDeleteRows = False
        Me.dgvRentalList.AllowUserToResizeColumns = False
        Me.dgvRentalList.AllowUserToResizeRows = False
        Me.dgvRentalList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRentalList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRentalList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentalList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvRentalList.ColumnHeadersHeight = 65
        Me.dgvRentalList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customerId, Me.fname, Me.rentDate, Me.returnDate, Me.hrsRented, Me.fee, Me.noOfBikeRented})
        Me.dgvRentalList.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRentalList.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgvRentalList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRentalList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgvRentalList.GridColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.dgvRentalList.Location = New System.Drawing.Point(0, 0)
        Me.dgvRentalList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvRentalList.MultiSelect = False
        Me.dgvRentalList.Name = "dgvRentalList"
        Me.dgvRentalList.ReadOnly = True
        Me.dgvRentalList.RowHeadersVisible = False
        Me.dgvRentalList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        Me.dgvRentalList.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvRentalList.RowTemplate.Height = 28
        Me.dgvRentalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRentalList.Size = New System.Drawing.Size(1054, 245)
        Me.dgvRentalList.TabIndex = 3
        '
        'customerId
        '
        Me.customerId.HeaderText = "ID"
        Me.customerId.MinimumWidth = 6
        Me.customerId.Name = "customerId"
        Me.customerId.ReadOnly = True
        Me.customerId.Visible = False
        Me.customerId.Width = 125
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.MinimumWidth = 8
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        Me.fname.Width = 85
        '
        'rentDate
        '
        Me.rentDate.HeaderText = "Rent Date"
        Me.rentDate.MinimumWidth = 6
        Me.rentDate.Name = "rentDate"
        Me.rentDate.ReadOnly = True
        Me.rentDate.Width = 106
        '
        'returnDate
        '
        Me.returnDate.HeaderText = "Return Date"
        Me.returnDate.MinimumWidth = 6
        Me.returnDate.Name = "returnDate"
        Me.returnDate.ReadOnly = True
        Me.returnDate.Width = 120
        '
        'hrsRented
        '
        Me.hrsRented.HeaderText = "Hour(s) Rented"
        Me.hrsRented.MinimumWidth = 6
        Me.hrsRented.Name = "hrsRented"
        Me.hrsRented.ReadOnly = True
        Me.hrsRented.Width = 140
        '
        'fee
        '
        Me.fee.HeaderText = "Fee"
        Me.fee.MinimumWidth = 6
        Me.fee.Name = "fee"
        Me.fee.ReadOnly = True
        Me.fee.Width = 65
        '
        'noOfBikeRented
        '
        Me.noOfBikeRented.HeaderText = "Qty"
        Me.noOfBikeRented.MinimumWidth = 6
        Me.noOfBikeRented.Name = "noOfBikeRented"
        Me.noOfBikeRented.ReadOnly = True
        Me.noOfBikeRented.Width = 66
        '
        'lblRentalsList
        '
        Me.lblRentalsList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentalsList.AutoSize = True
        Me.lblRentalsList.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalsList.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentalsList.Location = New System.Drawing.Point(588, 565)
        Me.lblRentalsList.Name = "lblRentalsList"
        Me.lblRentalsList.Size = New System.Drawing.Size(148, 35)
        Me.lblRentalsList.TabIndex = 60
        Me.lblRentalsList.Text = "Rentals List"
        '
        'clbAvailableBikes
        '
        Me.clbAvailableBikes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.clbAvailableBikes.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.clbAvailableBikes.CheckOnClick = True
        Me.clbAvailableBikes.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAvailableBikes.ForeColor = System.Drawing.Color.LightGray
        Me.clbAvailableBikes.FormattingEnabled = True
        Me.clbAvailableBikes.Items.AddRange(New Object() {"BIKE 1", "BIKE 2", "BIKE 3", "BIKE 4", "BIKE 5", "BIKE 6", "BIKE 7", "BIKE 8", "BIKE 9", "BIKE 10"})
        Me.clbAvailableBikes.Location = New System.Drawing.Point(169, 155)
        Me.clbAvailableBikes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clbAvailableBikes.Name = "clbAvailableBikes"
        Me.clbAvailableBikes.Size = New System.Drawing.Size(181, 160)
        Me.clbAvailableBikes.TabIndex = 61
        '
        'lblRenttime
        '
        Me.lblRenttime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRenttime.AutoSize = True
        Me.lblRenttime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenttime.ForeColor = System.Drawing.Color.LightGray
        Me.lblRenttime.Location = New System.Drawing.Point(467, 257)
        Me.lblRenttime.Name = "lblRenttime"
        Me.lblRenttime.Size = New System.Drawing.Size(100, 25)
        Me.lblRenttime.TabIndex = 63
        Me.lblRenttime.Text = "Rent Time"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Location = New System.Drawing.Point(473, 331)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(240, 1)
        Me.Panel6.TabIndex = 62
        '
        'lblReturntime
        '
        Me.lblReturntime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReturntime.AutoSize = True
        Me.lblReturntime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturntime.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturntime.Location = New System.Drawing.Point(905, 257)
        Me.lblReturntime.Name = "lblReturntime"
        Me.lblReturntime.Size = New System.Drawing.Size(120, 25)
        Me.lblReturntime.TabIndex = 66
        Me.lblReturntime.Text = "Return Time"
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Location = New System.Drawing.Point(910, 331)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(240, 1)
        Me.Panel7.TabIndex = 65
        '
        'dtp1
        '
        Me.dtp1.CalendarFont = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.CustomFormat = "MMM dd, h:mm tt"
        Me.dtp1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(473, 293)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(240, 34)
        Me.dtp1.TabIndex = 69
        '
        'dtp2
        '
        Me.dtp2.CalendarFont = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.CustomFormat = "MMM dd, h:mm tt"
        Me.dtp2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(909, 293)
        Me.dtp2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(240, 34)
        Me.dtp2.TabIndex = 70
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.LightGray
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.LightGray
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 35
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(611, 492)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 62)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddNewRent
        '
        Me.btnAddNewRent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNewRent.Enabled = False
        Me.btnAddNewRent.FlatAppearance.BorderSize = 0
        Me.btnAddNewRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewRent.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewRent.ForeColor = System.Drawing.Color.LightGray
        Me.btnAddNewRent.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddNewRent.IconColor = System.Drawing.Color.LightGray
        Me.btnAddNewRent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddNewRent.IconSize = 35
        Me.btnAddNewRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewRent.Location = New System.Drawing.Point(414, 492)
        Me.btnAddNewRent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddNewRent.Name = "btnAddNewRent"
        Me.btnAddNewRent.Size = New System.Drawing.Size(144, 62)
        Me.btnAddNewRent.TabIndex = 57
        Me.btnAddNewRent.Text = "Add"
        Me.btnAddNewRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewRent.UseVisualStyleBackColor = True
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCustomerId.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerId.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerId.ForeColor = System.Drawing.Color.White
        Me.txtCustomerId.Location = New System.Drawing.Point(1074, 114)
        Me.txtCustomerId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerId.Multiline = True
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(85, 34)
        Me.txtCustomerId.TabIndex = 71
        Me.txtCustomerId.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalculate.FlatAppearance.BorderSize = 0
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.LightGray
        Me.btnCalculate.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.btnCalculate.IconColor = System.Drawing.Color.LightGray
        Me.btnCalculate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCalculate.IconSize = 30
        Me.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.Location = New System.Drawing.Point(819, 492)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(243, 62)
        Me.btnCalculate.TabIndex = 72
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmRentBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 882)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCustomerId)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.lblReturntime)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.lblRenttime)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.clbAvailableBikes)
        Me.Controls.Add(Me.lblRentalsList)
        Me.Controls.Add(Me.pnlRentallist)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddNewRent)
        Me.Controls.Add(Me.lblfee)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.lblHoursrented)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtHoursrented)
        Me.Controls.Add(Me.lblCustomername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCustomername)
        Me.Controls.Add(Me.lblNoOfBikesRented)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtNoofBikesRented)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlRentTitleCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRentBike"
        Me.Text = "frmRentBike"
        Me.pnlRentTitleCover.ResumeLayout(False)
        Me.pnlRentTitleCover.PerformLayout()
        CType(Me.pbCloseRentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRentallist.ResumeLayout(False)
        CType(Me.dgvRentalList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRentTitleCover As Panel
    Friend WithEvents lblRentTitle As Label
    Friend WithEvents pbCloseRentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNoOfBikesRented As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNoofBikesRented As TextBox
    Friend WithEvents lblCustomername As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCustomername As TextBox
    Friend WithEvents lblHoursrented As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtHoursrented As TextBox
    Friend WithEvents lblfee As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtFee As TextBox
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddNewRent As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlRentallist As Panel
    Friend WithEvents lblRentalsList As Label
    Friend WithEvents clbAvailableBikes As CheckedListBox
    Friend WithEvents lblRenttime As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblReturntime As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dgvRentalList As DataGridView
    Friend WithEvents customerId As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents rentDate As DataGridViewTextBoxColumn
    Friend WithEvents returnDate As DataGridViewTextBoxColumn
    Friend WithEvents hrsRented As DataGridViewTextBoxColumn
    Friend WithEvents fee As DataGridViewTextBoxColumn
    Friend WithEvents noOfBikeRented As DataGridViewTextBoxColumn
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents btnCalculate As FontAwesome.Sharp.IconButton
End Class
