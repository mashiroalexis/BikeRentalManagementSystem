<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlCustormerTitleContainer = New System.Windows.Forms.Panel()
        Me.pbCloseCustomerForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblCustomerTitle = New System.Windows.Forms.Label()
        Me.lblCustomersList = New System.Windows.Forms.Label()
        Me.pnlCustomersList = New System.Windows.Forms.Panel()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.customerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BikeRentalManagementSystemDataSet = New Bike_Rental_Management_System.BikeRentalManagementSystemDataSet()
        Me.BikeRentalManagementSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSystemAccessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSystemAccessTableAdapter = New Bike_Rental_Management_System.BikeRentalManagementSystemDataSetTableAdapters.tblSystemAccessTableAdapter()
        Me.btnEdit = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnAddNewCust = New FontAwesome.Sharp.IconButton()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlCustormerTitleContainer.SuspendLayout()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomersList.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeRentalManagementSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeRentalManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSystemAccessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustormerTitleContainer
        '
        Me.pnlCustormerTitleContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlCustormerTitleContainer.Controls.Add(Me.pbCloseCustomerForm)
        Me.pnlCustormerTitleContainer.Controls.Add(Me.lblCustomerTitle)
        Me.pnlCustormerTitleContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCustormerTitleContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustormerTitleContainer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlCustormerTitleContainer.Name = "pnlCustormerTitleContainer"
        Me.pnlCustormerTitleContainer.Size = New System.Drawing.Size(1267, 80)
        Me.pnlCustormerTitleContainer.TabIndex = 0
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
        Me.pbCloseCustomerForm.IconSize = 62
        Me.pbCloseCustomerForm.Location = New System.Drawing.Point(1191, 12)
        Me.pbCloseCustomerForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbCloseCustomerForm.Name = "pbCloseCustomerForm"
        Me.pbCloseCustomerForm.Size = New System.Drawing.Size(67, 62)
        Me.pbCloseCustomerForm.TabIndex = 3
        Me.pbCloseCustomerForm.TabStop = False
        '
        'lblCustomerTitle
        '
        Me.lblCustomerTitle.AutoSize = True
        Me.lblCustomerTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomerTitle.Location = New System.Drawing.Point(16, 11)
        Me.lblCustomerTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerTitle.Name = "lblCustomerTitle"
        Me.lblCustomerTitle.Size = New System.Drawing.Size(174, 46)
        Me.lblCustomerTitle.TabIndex = 1
        Me.lblCustomerTitle.Text = "Customer"
        '
        'lblCustomersList
        '
        Me.lblCustomersList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCustomersList.AutoSize = True
        Me.lblCustomersList.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomersList.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomersList.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomersList.Location = New System.Drawing.Point(533, 114)
        Me.lblCustomersList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomersList.Name = "lblCustomersList"
        Me.lblCustomersList.Size = New System.Drawing.Size(182, 32)
        Me.lblCustomersList.TabIndex = 4
        Me.lblCustomersList.Text = "Customers List"
        '
        'pnlCustomersList
        '
        Me.pnlCustomersList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCustomersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCustomersList.Controls.Add(Me.dgvCustomers)
        Me.pnlCustomersList.ForeColor = System.Drawing.Color.LightGray
        Me.pnlCustomersList.Location = New System.Drawing.Point(64, 174)
        Me.pnlCustomersList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlCustomersList.Name = "pnlCustomersList"
        Me.pnlCustomersList.Size = New System.Drawing.Size(1153, 496)
        Me.pnlCustomersList.TabIndex = 5
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customerId, Me.fname, Me.address, Me.contactNo, Me.email})
        Me.dgvCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomers.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowHeadersWidth = 62
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvCustomers.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustomers.RowTemplate.Height = 28
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(1149, 492)
        Me.dgvCustomers.TabIndex = 0
        '
        'customerId
        '
        Me.customerId.HeaderText = "ID"
        Me.customerId.MinimumWidth = 6
        Me.customerId.Name = "customerId"
        Me.customerId.Visible = False
        Me.customerId.Width = 125
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.MinimumWidth = 8
        Me.fname.Name = "fname"
        Me.fname.Width = 93
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.MinimumWidth = 8
        Me.address.Name = "address"
        Me.address.Width = 111
        '
        'contactNo
        '
        Me.contactNo.HeaderText = "Contact Number"
        Me.contactNo.MinimumWidth = 8
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Width = 170
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.MinimumWidth = 8
        Me.email.Name = "email"
        Me.email.Width = 88
        '
        'BikeRentalManagementSystemDataSet
        '
        Me.BikeRentalManagementSystemDataSet.DataSetName = "BikeRentalManagementSystemDataSet"
        Me.BikeRentalManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BikeRentalManagementSystemDataSetBindingSource
        '
        Me.BikeRentalManagementSystemDataSetBindingSource.DataSource = Me.BikeRentalManagementSystemDataSet
        Me.BikeRentalManagementSystemDataSetBindingSource.Position = 0
        '
        'TblSystemAccessBindingSource
        '
        Me.TblSystemAccessBindingSource.DataMember = "tblSystemAccess"
        Me.TblSystemAccessBindingSource.DataSource = Me.BikeRentalManagementSystemDataSetBindingSource
        '
        'TblSystemAccessTableAdapter
        '
        Me.TblSystemAccessTableAdapter.ClearBeforeFill = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.LightGray
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEdit.IconColor = System.Drawing.Color.LightGray
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 35
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(925, 690)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(132, 62)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.LightGray
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelete.IconColor = System.Drawing.Color.LightGray
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(1064, 690)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(155, 62)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddNewCust
        '
        Me.btnAddNewCust.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNewCust.FlatAppearance.BorderSize = 0
        Me.btnAddNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewCust.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewCust.ForeColor = System.Drawing.Color.LightGray
        Me.btnAddNewCust.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddNewCust.IconColor = System.Drawing.Color.LightGray
        Me.btnAddNewCust.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddNewCust.IconSize = 35
        Me.btnAddNewCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewCust.Location = New System.Drawing.Point(777, 690)
        Me.btnAddNewCust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddNewCust.Name = "btnAddNewCust"
        Me.btnAddNewCust.Size = New System.Drawing.Size(129, 62)
        Me.btnAddNewCust.TabIndex = 1
        Me.btnAddNewCust.Text = "Add"
        Me.btnAddNewCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewCust.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1267, 800)
        Me.Controls.Add(Me.pnlCustomersList)
        Me.Controls.Add(Me.lblCustomersList)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNewCust)
        Me.Controls.Add(Me.pnlCustormerTitleContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCustomer"
        Me.Text = "Customer"
        Me.pnlCustormerTitleContainer.ResumeLayout(False)
        Me.pnlCustormerTitleContainer.PerformLayout()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomersList.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeRentalManagementSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeRentalManagementSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSystemAccessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCustormerTitleContainer As Panel
    Friend WithEvents lblCustomerTitle As Label
    Friend WithEvents pbCloseCustomerForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnAddNewCust As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblCustomersList As Label
    Friend WithEvents pnlCustomersList As Panel
    Friend WithEvents BikeRentalManagementSystemDataSetBindingSource As BindingSource
    Friend WithEvents BikeRentalManagementSystemDataSet As BikeRentalManagementSystemDataSet
    Friend WithEvents TblSystemAccessBindingSource As BindingSource
    Friend WithEvents TblSystemAccessTableAdapter As BikeRentalManagementSystemDataSetTableAdapters.tblSystemAccessTableAdapter
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents customerId As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents contactNo As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
