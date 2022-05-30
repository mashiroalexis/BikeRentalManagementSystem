<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectCustomer
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
        Me.pnlSelectCustomerTitleContainer = New System.Windows.Forms.Panel()
        Me.lblCustomerTitle = New System.Windows.Forms.Label()
        Me.dgvCustomerList = New System.Windows.Forms.DataGridView()
        Me.customerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSelectCustomer = New FontAwesome.Sharp.IconButton()
        Me.btnBack = New FontAwesome.Sharp.IconButton()
        Me.pnlSelectCustomerTitleContainer.SuspendLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSelectCustomerTitleContainer
        '
        Me.pnlSelectCustomerTitleContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlSelectCustomerTitleContainer.Controls.Add(Me.lblCustomerTitle)
        Me.pnlSelectCustomerTitleContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSelectCustomerTitleContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlSelectCustomerTitleContainer.Name = "pnlSelectCustomerTitleContainer"
        Me.pnlSelectCustomerTitleContainer.Size = New System.Drawing.Size(1031, 65)
        Me.pnlSelectCustomerTitleContainer.TabIndex = 0
        '
        'lblCustomerTitle
        '
        Me.lblCustomerTitle.AutoSize = True
        Me.lblCustomerTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomerTitle.Location = New System.Drawing.Point(50, 7)
        Me.lblCustomerTitle.Name = "lblCustomerTitle"
        Me.lblCustomerTitle.Size = New System.Drawing.Size(225, 37)
        Me.lblCustomerTitle.TabIndex = 4
        Me.lblCustomerTitle.Text = "Select Customer"
        '
        'dgvCustomerList
        '
        Me.dgvCustomerList.AllowUserToAddRows = False
        Me.dgvCustomerList.AllowUserToDeleteRows = False
        Me.dgvCustomerList.AllowUserToOrderColumns = True
        Me.dgvCustomerList.AllowUserToResizeColumns = False
        Me.dgvCustomerList.AllowUserToResizeRows = False
        Me.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customerId, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvCustomerList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvCustomerList.Location = New System.Drawing.Point(198, 88)
        Me.dgvCustomerList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCustomerList.Name = "dgvCustomerList"
        Me.dgvCustomerList.RowHeadersVisible = False
        Me.dgvCustomerList.RowHeadersWidth = 62
        Me.dgvCustomerList.RowTemplate.Height = 28
        Me.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerList.Size = New System.Drawing.Size(603, 353)
        Me.dgvCustomerList.TabIndex = 2
        '
        'customerId
        '
        Me.customerId.HeaderText = "ID"
        Me.customerId.Name = "customerId"
        Me.customerId.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'btnSelectCustomer
        '
        Me.btnSelectCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelectCustomer.FlatAppearance.BorderSize = 0
        Me.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectCustomer.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectCustomer.ForeColor = System.Drawing.Color.LightGray
        Me.btnSelectCustomer.IconChar = FontAwesome.Sharp.IconChar.CheckSquare
        Me.btnSelectCustomer.IconColor = System.Drawing.Color.LightGray
        Me.btnSelectCustomer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSelectCustomer.IconSize = 35
        Me.btnSelectCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectCustomer.Location = New System.Drawing.Point(561, 460)
        Me.btnSelectCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectCustomer.Name = "btnSelectCustomer"
        Me.btnSelectCustomer.Size = New System.Drawing.Size(97, 50)
        Me.btnSelectCustomer.TabIndex = 3
        Me.btnSelectCustomer.Text = "Select"
        Me.btnSelectCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelectCustomer.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.LightGray
        Me.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.btnBack.IconColor = System.Drawing.Color.LightGray
        Me.btnBack.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBack.IconSize = 35
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(344, 460)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(97, 50)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmSelectCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 549)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSelectCustomer)
        Me.Controls.Add(Me.dgvCustomerList)
        Me.Controls.Add(Me.pnlSelectCustomerTitleContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSelectCustomer"
        Me.Text = "Select Customer"
        Me.pnlSelectCustomerTitleContainer.ResumeLayout(False)
        Me.pnlSelectCustomerTitleContainer.PerformLayout()
        CType(Me.dgvCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSelectCustomerTitleContainer As Panel
    Friend WithEvents lblCustomerTitle As Label
    Friend WithEvents dgvCustomerList As DataGridView
    Friend WithEvents customerId As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents btnSelectCustomer As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBack As FontAwesome.Sharp.IconButton
End Class
