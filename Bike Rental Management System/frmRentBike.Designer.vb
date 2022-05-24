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
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(57, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Available Bikes"
        '
        'lblNoOfBikesRented
        '
        Me.lblNoOfBikesRented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoOfBikesRented.AutoSize = True
        Me.lblNoOfBikesRented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfBikesRented.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoOfBikesRented.Location = New System.Drawing.Point(510, 123)
        Me.lblNoOfBikesRented.Name = "lblNoOfBikesRented"
        Me.lblNoOfBikesRented.Size = New System.Drawing.Size(186, 25)
        Me.lblNoOfBikesRented.TabIndex = 29
        Me.lblNoOfBikesRented.Text = "No. of Bikes Rented"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(515, 187)
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
        Me.txtNoofBikesRented.Location = New System.Drawing.Point(515, 155)
        Me.txtNoofBikesRented.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoofBikesRented.Multiline = True
        Me.txtNoofBikesRented.Name = "txtNoofBikesRented"
        Me.txtNoofBikesRented.Size = New System.Drawing.Size(240, 36)
        Me.txtNoofBikesRented.TabIndex = 27
        '
        'lblCustomername
        '
        Me.lblCustomername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCustomername.AutoSize = True
        Me.lblCustomername.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomername.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomername.Location = New System.Drawing.Point(947, 123)
        Me.lblCustomername.Name = "lblCustomername"
        Me.lblCustomername.Size = New System.Drawing.Size(155, 25)
        Me.lblCustomername.TabIndex = 32
        Me.lblCustomername.Text = "Customer Name"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(952, 187)
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
        Me.txtCustomername.Location = New System.Drawing.Point(952, 155)
        Me.txtCustomername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomername.Multiline = True
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.Size = New System.Drawing.Size(240, 36)
        Me.txtCustomername.TabIndex = 30
        '
        'dtpRentdate
        '
        Me.dtpRentdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRentdate.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.dtpRentdate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRentdate.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRentdate.Location = New System.Drawing.Point(61, 317)
        Me.dtpRentdate.Name = "dtpRentdate"
        Me.dtpRentdate.Size = New System.Drawing.Size(240, 34)
        Me.dtpRentdate.TabIndex = 40
        '
        'lblRentDate
        '
        Me.lblRentDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRentDate.AutoSize = True
        Me.lblRentDate.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentDate.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentDate.Location = New System.Drawing.Point(56, 282)
        Me.lblRentDate.Name = "lblRentDate"
        Me.lblRentDate.Size = New System.Drawing.Size(98, 25)
        Me.lblRentDate.TabIndex = 39
        Me.lblRentDate.Text = "Rent Date"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(61, 356)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 1)
        Me.Panel3.TabIndex = 38
        '
        'lblHoursrented
        '
        Me.lblHoursrented.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHoursrented.AutoSize = True
        Me.lblHoursrented.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursrented.ForeColor = System.Drawing.Color.LightGray
        Me.lblHoursrented.Location = New System.Drawing.Point(510, 282)
        Me.lblHoursrented.Name = "lblHoursrented"
        Me.lblHoursrented.Size = New System.Drawing.Size(142, 25)
        Me.lblHoursrented.TabIndex = 53
        Me.lblHoursrented.Text = "Hour/s Rented"
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.LightGray
        Me.Panel5.Location = New System.Drawing.Point(515, 356)
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
        Me.txtHoursrented.Location = New System.Drawing.Point(515, 324)
        Me.txtHoursrented.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHoursrented.Multiline = True
        Me.txtHoursrented.Name = "txtHoursrented"
        Me.txtHoursrented.Size = New System.Drawing.Size(240, 34)
        Me.txtHoursrented.TabIndex = 51
        '
        'lblfee
        '
        Me.lblfee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblfee.AutoSize = True
        Me.lblfee.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfee.ForeColor = System.Drawing.Color.LightGray
        Me.lblfee.Location = New System.Drawing.Point(947, 282)
        Me.lblfee.Name = "lblfee"
        Me.lblfee.Size = New System.Drawing.Size(42, 25)
        Me.lblfee.TabIndex = 56
        Me.lblfee.Text = "Fee"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(952, 356)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 1)
        Me.Panel4.TabIndex = 55
        '
        'txtfee
        '
        Me.txtfee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfee.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtfee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfee.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfee.ForeColor = System.Drawing.Color.White
        Me.txtfee.Location = New System.Drawing.Point(952, 324)
        Me.txtfee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfee.Multiline = True
        Me.txtfee.Name = "txtfee"
        Me.txtfee.Size = New System.Drawing.Size(240, 34)
        Me.txtfee.TabIndex = 54
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.LightGray
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.LightGray
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 35
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(714, 400)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 61)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddNewRent
        '
        Me.btnAddNewRent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddNewRent.FlatAppearance.BorderSize = 0
        Me.btnAddNewRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewRent.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewRent.ForeColor = System.Drawing.Color.LightGray
        Me.btnAddNewRent.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddNewRent.IconColor = System.Drawing.Color.LightGray
        Me.btnAddNewRent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddNewRent.IconSize = 35
        Me.btnAddNewRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewRent.Location = New System.Drawing.Point(471, 400)
        Me.btnAddNewRent.Name = "btnAddNewRent"
        Me.btnAddNewRent.Size = New System.Drawing.Size(129, 61)
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
        Me.pnlRentallist.Location = New System.Drawing.Point(60, 525)
        Me.pnlRentallist.Name = "pnlRentallist"
        Me.pnlRentallist.Size = New System.Drawing.Size(1132, 312)
        Me.pnlRentallist.TabIndex = 59
        '
        'lblRentalsList
        '
        Me.lblRentalsList.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRentalsList.AutoSize = True
        Me.lblRentalsList.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalsList.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentalsList.Location = New System.Drawing.Point(548, 477)
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
        Me.clbAvailableBikes.Location = New System.Drawing.Point(60, 155)
        Me.clbAvailableBikes.Name = "clbAvailableBikes"
        Me.clbAvailableBikes.Size = New System.Drawing.Size(181, 108)
        Me.clbAvailableBikes.TabIndex = 61
        '
        'frmRentBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 882)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
End Class
