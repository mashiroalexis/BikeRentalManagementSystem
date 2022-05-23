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
        Me.lblRentTitle = New System.Windows.Forms.Label()
        Me.pbCustomerLogo = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlCustormerTitleContainer.SuspendLayout()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCustomerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCustormerTitleContainer
        '
        Me.pnlCustormerTitleContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlCustormerTitleContainer.Controls.Add(Me.pbCloseCustomerForm)
        Me.pnlCustormerTitleContainer.Controls.Add(Me.lblRentTitle)
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
        'lblRentTitle
        '
        Me.lblRentTitle.AutoSize = True
        Me.lblRentTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblRentTitle.Location = New System.Drawing.Point(16, 11)
        Me.lblRentTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRentTitle.Name = "lblRentTitle"
        Me.lblRentTitle.Size = New System.Drawing.Size(174, 46)
        Me.lblRentTitle.TabIndex = 1
        Me.lblRentTitle.Text = "Customer"
        '
        'pbCustomerLogo
        '
        Me.pbCustomerLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pbCustomerLogo.ForeColor = System.Drawing.Color.LightGray
        Me.pbCustomerLogo.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.pbCustomerLogo.IconColor = System.Drawing.Color.LightGray
        Me.pbCustomerLogo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCustomerLogo.IconSize = 255
        Me.pbCustomerLogo.Location = New System.Drawing.Point(476, 231)
        Me.pbCustomerLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbCustomerLogo.Name = "pbCustomerLogo"
        Me.pbCustomerLogo.Size = New System.Drawing.Size(281, 255)
        Me.pbCustomerLogo.TabIndex = 1
        Me.pbCustomerLogo.TabStop = False
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1267, 800)
        Me.Controls.Add(Me.pbCustomerLogo)
        Me.Controls.Add(Me.pnlCustormerTitleContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCustomer"
        Me.Text = "Customer"
        Me.pnlCustormerTitleContainer.ResumeLayout(False)
        Me.pnlCustormerTitleContainer.PerformLayout()
        CType(Me.pbCloseCustomerForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCustomerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCustormerTitleContainer As Panel
    Friend WithEvents lblRentTitle As Label
    Friend WithEvents pbCustomerLogo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pbCloseCustomerForm As FontAwesome.Sharp.IconPictureBox
End Class
