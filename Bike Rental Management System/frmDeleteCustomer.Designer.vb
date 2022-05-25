<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteCustomer
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
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.btnCancel = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.pbDeleteIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.lblDeleteMessage = New System.Windows.Forms.Label()
        CType(Me.pbDeleteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(12, 12)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerId.TabIndex = 1
        Me.txtCustomerId.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.LightGray
        Me.btnCancel.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.btnCancel.IconColor = System.Drawing.Color.LightGray
        Me.btnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancel.IconSize = 35
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(234, 380)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 50)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Back"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.LightGray
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelete.IconColor = System.Drawing.Color.LightGray
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 35
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(375, 380)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 50)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'pbDeleteIcon
        '
        Me.pbDeleteIcon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbDeleteIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pbDeleteIcon.ForeColor = System.Drawing.Color.Brown
        Me.pbDeleteIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle
        Me.pbDeleteIcon.IconColor = System.Drawing.Color.Brown
        Me.pbDeleteIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbDeleteIcon.IconSize = 190
        Me.pbDeleteIcon.Location = New System.Drawing.Point(254, 68)
        Me.pbDeleteIcon.Name = "pbDeleteIcon"
        Me.pbDeleteIcon.Size = New System.Drawing.Size(198, 190)
        Me.pbDeleteIcon.TabIndex = 7
        Me.pbDeleteIcon.TabStop = False
        '
        'lblDeleteMessage
        '
        Me.lblDeleteMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDeleteMessage.AutoSize = True
        Me.lblDeleteMessage.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.lblDeleteMessage.Location = New System.Drawing.Point(88, 309)
        Me.lblDeleteMessage.Name = "lblDeleteMessage"
        Me.lblDeleteMessage.Size = New System.Drawing.Size(553, 21)
        Me.lblDeleteMessage.TabIndex = 6
        Me.lblDeleteMessage.Text = "You are about to delete this customer data, this action is not revertable."
        '
        'frmDeleteCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 498)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.pbDeleteIcon)
        Me.Controls.Add(Me.lblDeleteMessage)
        Me.Controls.Add(Me.txtCustomerId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDeleteCustomer"
        Me.Text = "Delete Customer Information"
        CType(Me.pbDeleteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents btnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents pbDeleteIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblDeleteMessage As Label
End Class
