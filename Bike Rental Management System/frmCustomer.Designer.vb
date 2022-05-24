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
        Me.pnlCustormerTitleContainer = New System.Windows.Forms.Panel()
        Me.pbCloseCustomerForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblCustomerTitle = New System.Windows.Forms.Label()
        Me.btnAddNewCust = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnEdit = New FontAwesome.Sharp.IconButton()
        Me.lblCustomersList = New System.Windows.Forms.Label()
        Me.pnlCustomersList = New System.Windows.Forms.Panel()
        Me.pnlCustormerTitleContainer.SuspendLayout()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustormerTitleContainer
        '
        Me.pnlCustormerTitleContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlCustormerTitleContainer.Controls.Add(Me.pbCloseCustomerForm)
        Me.pnlCustormerTitleContainer.Controls.Add(Me.lblCustomerTitle)
        Me.pnlCustormerTitleContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCustormerTitleContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlCustormerTitleContainer.Margin = New System.Windows.Forms.Padding(4)
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
        Me.pbCloseCustomerForm.Margin = New System.Windows.Forms.Padding(4)
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
        'btnAddNewCust
        '
        Me.btnAddNewCust.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddNewCust.FlatAppearance.BorderSize = 0
        Me.btnAddNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewCust.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewCust.ForeColor = System.Drawing.Color.LightGray
        Me.btnAddNewCust.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddNewCust.IconColor = System.Drawing.Color.LightGray
        Me.btnAddNewCust.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddNewCust.IconSize = 35
        Me.btnAddNewCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewCust.Location = New System.Drawing.Point(777, 668)
        Me.btnAddNewCust.Name = "btnAddNewCust"
        Me.btnAddNewCust.Size = New System.Drawing.Size(129, 61)
        Me.btnAddNewCust.TabIndex = 1
        Me.btnAddNewCust.Text = "Add"
        Me.btnAddNewCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewCust.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.LightGray
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelete.IconColor = System.Drawing.Color.LightGray
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(1064, 668)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(155, 61)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.LightGray
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEdit.IconColor = System.Drawing.Color.LightGray
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 35
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(926, 668)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(132, 61)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblCustomersList
        '
        Me.lblCustomersList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCustomersList.AutoSize = True
        Me.lblCustomersList.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomersList.Font = New System.Drawing.Font("Nirmala UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomersList.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustomersList.Location = New System.Drawing.Point(534, 104)
        Me.lblCustomersList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomersList.Name = "lblCustomersList"
        Me.lblCustomersList.Size = New System.Drawing.Size(182, 32)
        Me.lblCustomersList.TabIndex = 4
        Me.lblCustomersList.Text = "Customers List"
        '
        'pnlCustomersList
        '
        Me.pnlCustomersList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlCustomersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCustomersList.ForeColor = System.Drawing.Color.LightGray
        Me.pnlCustomersList.Location = New System.Drawing.Point(65, 162)
        Me.pnlCustomersList.Name = "pnlCustomersList"
        Me.pnlCustomersList.Size = New System.Drawing.Size(1154, 496)
        Me.pnlCustomersList.TabIndex = 5
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCustomer"
        Me.Text = "Customer"
        Me.pnlCustormerTitleContainer.ResumeLayout(False)
        Me.pnlCustormerTitleContainer.PerformLayout()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
