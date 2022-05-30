<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentBike
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
        Me.dtpRentdate = New System.Windows.Forms.DateTimePicker()
        Me.lblRentDate = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblHoursrented = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtHoursrented = New System.Windows.Forms.TextBox()
        Me.lblfee = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtfee = New System.Windows.Forms.TextBox()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnAddNewRent = New FontAwesome.Sharp.IconButton()
        Me.pnlRentallist = New System.Windows.Forms.Panel()
        Me.lblRentalsList = New System.Windows.Forms.Label()
        Me.clbAvailableBikes = New System.Windows.Forms.CheckedListBox()
        Me.dtpRenttime = New System.Windows.Forms.DateTimePicker()
        Me.lblRenttime = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtpReturntime = New System.Windows.Forms.DateTimePicker()
        Me.lblReturntime = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.pnlRentTitleCover.SuspendLayout()
        CType(Me.pbCloseRentForm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlRentTitleCover.Name = "pnlRentTitleCover"
        Me.pnlRentTitleCover.Size = New System.Drawing.Size(963, 65)
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
        Me.pbCloseRentForm.IconSize = 50
        Me.pbCloseRentForm.Location = New System.Drawing.Point(903, 9)
        Me.pbCloseRentForm.Name = "pbCloseRentForm"
        Me.pbCloseRentForm.Size = New System.Drawing.Size(50, 50)
        Me.pbCloseRentForm.TabIndex = 4
        Me.pbCloseRentForm.TabStop = False
        '
        'lblRentTitle
        '
        Me.lblRentTitle.AutoSize = True
        Me.lblRentTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblRentTitle.Name = "lblRentTitle"
        Me.lblRentTitle.Size = New System.Drawing.Size(76, 37)
        Me.lblRentTitle.TabIndex = 0
        Me.lblRentTitle.Text = "Rent"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(43, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Available Bikes"
        '
        'lblNoOfBikesRented
        '
        Me.lblNoOfBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoOfBikesRented.AutoSize = True
        Me.lblNoOfBikesRented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBikesRented.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoOfBikesRented.Location = New System.Drawing.Point(382, 100)
        Me.lblNoOfBikesRented.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoOfBikesRented.Name = "lblNoOfBikesRented"
        Me.lblNoOfBikesRented.Size = New System.Drawing.Size(148, 20)
        Me.lblNoOfBikesRented.TabIndex = 29
        Me.lblNoOfBikesRented.Text = "No. of Bikes Rented"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(386, 152)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 1)
        Me.Panel2.TabIndex = 28
        '
        'txtNoofBikesRented
        '
        Me.txtNoofBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNoofBikesRented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtNoofBikesRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoofBikesRented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoofBikesRented.ForeColor = System.Drawing.Color.White
        Me.txtNoofBikesRented.Location = New System.Drawing.Point(386, 126)
        Me.txtNoofBikesRented.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNoofBikesRented.Multiline = True
        Me.txtNoofBikesRented.Name = "txtNoofBikesRented"
        Me.txtNoofBikesRented.Size = New System.Drawing.Size(180, 29)
        Me.txtNoofBikesRented.TabIndex = 27
        '
        'lblCustomername
        '
        Me.lblCustomername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCustomername.AutoSize = True
        Me.lblCustomername.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomername.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomername.Location = New System.Drawing.Point(710, 100)
        Me.lblCustomername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustomername.Name = "lblCustomername"
        Me.lblCustomername.Size = New System.Drawing.Size(123, 20)
        Me.lblCustomername.TabIndex = 32
        Me.lblCustomername.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(714, 152)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 1)
        Me.Panel1.TabIndex = 31
        '
        'txtCustomername
        '
        Me.txtCustomername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCustomername.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtCustomername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomername.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomername.ForeColor = System.Drawing.Color.White
        Me.txtCustomername.Location = New System.Drawing.Point(714, 126)
        Me.txtCustomername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCustomername.Multiline = True
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.Size = New System.Drawing.Size(180, 29)
        Me.txtCustomername.TabIndex = 30
        '
        'dtpRentdate
        '
        Me.dtpRentdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRentdate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRentdate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentdate.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentdate.Location = New System.Drawing.Point(45, 352)
        Me.dtpRentdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpRentdate.Name = "dtpRentdate"
        Me.dtpRentdate.Size = New System.Drawing.Size(181, 29)
        Me.dtpRentdate.TabIndex = 40
        Me.dtpRentdate.Visible = False
        '
        'lblRentDate
        '
        Me.lblRentDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentDate.AutoSize = True
        Me.lblRentDate.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentDate.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentDate.Location = New System.Drawing.Point(41, 323)
        Me.lblRentDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.Size = New System.Drawing.Size(79, 20)
        Me.lblRentDate.TabIndex = 39
        Me.lblRentDate.Text = "Rent Date"
        Me.lblRentDate.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(45, 383)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 1)
        Me.Panel3.TabIndex = 38
        Me.Panel3.Visible = False
        '
        'lblHoursrented
        '
        Me.lblHoursrented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHoursrented.AutoSize = True
        Me.lblHoursrented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursrented.ForeColor = System.Drawing.Color.LightGray
        Me.lblHoursrented.Location = New System.Drawing.Point(243, 318)
        Me.lblHoursrented.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoursrented.Name = "lblHoursrented"
        Me.lblHoursrented.Size = New System.Drawing.Size(112, 20)
        Me.lblHoursrented.TabIndex = 53
        Me.lblHoursrented.Text = "Hour/s Rented"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Location = New System.Drawing.Point(247, 378)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(180, 1)
        Me.Panel5.TabIndex = 52
        '
        'txtHoursrented
        '
        Me.txtHoursrented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHoursrented.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtHoursrented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHoursrented.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursrented.ForeColor = System.Drawing.Color.White
        Me.txtHoursrented.Location = New System.Drawing.Point(247, 352)
        Me.txtHoursrented.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHoursrented.Multiline = True
        Me.txtHoursrented.Name = "txtHoursrented"
        Me.txtHoursrented.Size = New System.Drawing.Size(180, 28)
        Me.txtHoursrented.TabIndex = 51
        '
        'lblfee
        '
        Me.lblfee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblfee.AutoSize = True
        Me.lblfee.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfee.ForeColor = System.Drawing.Color.LightGray
        Me.lblfee.Location = New System.Drawing.Point(571, 318)
        Me.lblfee.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfee.Name = "lblfee"
        Me.lblfee.Size = New System.Drawing.Size(33, 20)
        Me.lblfee.TabIndex = 56
        Me.lblfee.Text = "Fee"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(574, 378)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(180, 1)
        Me.Panel4.TabIndex = 55
        '
        'txtfee
        '
        Me.txtfee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfee.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtfee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfee.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfee.ForeColor = System.Drawing.Color.White
        Me.txtfee.Location = New System.Drawing.Point(574, 352)
        Me.txtfee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfee.Multiline = True
        Me.txtfee.Name = "txtfee"
        Me.txtfee.Size = New System.Drawing.Size(180, 28)
        Me.txtfee.TabIndex = 54
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
        Me.btnClear.Location = New System.Drawing.Point(574, 403)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 50)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddNewRent
        '
        Me.btnAddNewRent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNewRent.FlatAppearance.BorderSize = 0
        Me.btnAddNewRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewRent.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewRent.ForeColor = System.Drawing.Color.LightGray
        Me.btnAddNewRent.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddNewRent.IconColor = System.Drawing.Color.LightGray
        Me.btnAddNewRent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddNewRent.IconSize = 35
        Me.btnAddNewRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewRent.Location = New System.Drawing.Point(310, 403)
        Me.btnAddNewRent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddNewRent.Name = "btnAddNewRent"
        Me.btnAddNewRent.Size = New System.Drawing.Size(108, 50)
        Me.btnAddNewRent.TabIndex = 57
        Me.btnAddNewRent.Text = "Add"
        Me.btnAddNewRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewRent.UseVisualStyleBackColor = True
        '
        'pnlRentallist
        '
        Me.pnlRentallist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlRentallist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRentallist.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRentallist.ForeColor = System.Drawing.Color.LightGray
        Me.pnlRentallist.Location = New System.Drawing.Point(56, 486)
        Me.pnlRentallist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlRentallist.Name = "pnlRentallist"
        Me.pnlRentallist.Size = New System.Drawing.Size(840, 211)
        Me.pnlRentallist.TabIndex = 59
        '
        'lblRentalsList
        '
        Me.lblRentalsList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentalsList.AutoSize = True
        Me.lblRentalsList.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalsList.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentalsList.Location = New System.Drawing.Point(423, 446)
        Me.lblRentalsList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRentalsList.Name = "lblRentalsList"
        Me.lblRentalsList.Size = New System.Drawing.Size(120, 28)
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
        Me.clbAvailableBikes.Location = New System.Drawing.Point(45, 126)
        Me.clbAvailableBikes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clbAvailableBikes.Name = "clbAvailableBikes"
        Me.clbAvailableBikes.Size = New System.Drawing.Size(137, 136)
        Me.clbAvailableBikes.TabIndex = 61
        '
        'dtpRenttime
        '
        Me.dtpRenttime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRenttime.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRenttime.CustomFormat = "dd/MM/yyyy"
        Me.dtpRenttime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRenttime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpRenttime.Location = New System.Drawing.Point(386, 249)
        Me.dtpRenttime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpRenttime.Name = "dtpRenttime"
        Me.dtpRenttime.Size = New System.Drawing.Size(181, 29)
        Me.dtpRenttime.TabIndex = 64
        '
        'lblRenttime
        '
        Me.lblRenttime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRenttime.AutoSize = True
        Me.lblRenttime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenttime.ForeColor = System.Drawing.Color.LightGray
        Me.lblRenttime.Location = New System.Drawing.Point(382, 220)
        Me.lblRenttime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRenttime.Name = "lblRenttime"
        Me.lblRenttime.Size = New System.Drawing.Size(81, 20)
        Me.lblRenttime.TabIndex = 63
        Me.lblRenttime.Text = "Rent Time"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.Location = New System.Drawing.Point(386, 280)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(180, 1)
        Me.Panel6.TabIndex = 62
        '
        'dtpReturntime
        '
        Me.dtpReturntime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpReturntime.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpReturntime.CustomFormat = "dd/MM/yyyy"
        Me.dtpReturntime.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturntime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpReturntime.Location = New System.Drawing.Point(714, 249)
        Me.dtpReturntime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpReturntime.Name = "dtpReturntime"
        Me.dtpReturntime.Size = New System.Drawing.Size(181, 29)
        Me.dtpReturntime.TabIndex = 67
        '
        'lblReturntime
        '
        Me.lblReturntime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReturntime.AutoSize = True
        Me.lblReturntime.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturntime.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturntime.Location = New System.Drawing.Point(710, 220)
        Me.lblReturntime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReturntime.Name = "lblReturntime"
        Me.lblReturntime.Size = New System.Drawing.Size(96, 20)
        Me.lblReturntime.TabIndex = 66
        Me.lblReturntime.Text = "Return Time"
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Location = New System.Drawing.Point(714, 280)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(180, 1)
        Me.Panel7.TabIndex = 65
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(808, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "MMM dd, h:mm tt"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(417, 183)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(135, 20)
        Me.dtp1.TabIndex = 69
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "MMM dd, h:mm tt"
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(588, 183)
        Me.dtp2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(135, 20)
        Me.dtp2.TabIndex = 70
        '
        'frmRentBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(963, 717)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpReturntime)
        Me.Controls.Add(Me.lblReturntime)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.dtpRenttime)
        Me.Controls.Add(Me.lblRenttime)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.clbAvailableBikes)
        Me.Controls.Add(Me.lblRentalsList)
        Me.Controls.Add(Me.pnlRentallist)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddNewRent)
        Me.Controls.Add(Me.lblfee)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtfee)
        Me.Controls.Add(Me.lblHoursrented)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtHoursrented)
        Me.Controls.Add(Me.dtpRentdate)
        Me.Controls.Add(Me.lblRentDate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblCustomername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCustomername)
        Me.Controls.Add(Me.lblNoOfBikesRented)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtNoofBikesRented)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlRentTitleCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRentBike"
        Me.Text = "frmRentBike"
        Me.pnlRentTitleCover.ResumeLayout(False)
        Me.pnlRentTitleCover.PerformLayout()
        CType(Me.pbCloseRentForm, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtpRentdate As DateTimePicker
    Friend WithEvents lblRentDate As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblHoursrented As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtHoursrented As TextBox
    Friend WithEvents lblfee As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtfee As TextBox
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddNewRent As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlRentallist As Panel
    Friend WithEvents lblRentalsList As Label
    Friend WithEvents clbAvailableBikes As CheckedListBox
    Friend WithEvents dtpRenttime As DateTimePicker
    Friend WithEvents lblRenttime As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dtpReturntime As DateTimePicker
    Friend WithEvents lblReturntime As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents dtp2 As DateTimePicker
End Class
