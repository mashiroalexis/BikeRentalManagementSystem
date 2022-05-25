<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnAbout = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnCustomer = New FontAwesome.Sharp.IconButton()
        Me.pnlBikeSubMenu = New System.Windows.Forms.Panel()
        Me.btnReturn = New FontAwesome.Sharp.IconButton()
        Me.btnRent = New FontAwesome.Sharp.IconButton()
        Me.btnBikeMenu = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlChildFormContainer = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlMenu.SuspendLayout()
        Me.pnlBikeSubMenu.SuspendLayout()
        Me.pnlChildFormContainer.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnAbout)
        Me.pnlMenu.Controls.Add(Me.btnExit)
        Me.pnlMenu.Controls.Add(Me.btnCustomer)
        Me.pnlMenu.Controls.Add(Me.pnlBikeSubMenu)
        Me.pnlMenu.Controls.Add(Me.btnBikeMenu)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(333, 882)
        Me.pnlMenu.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.LightGray
        Me.btnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.btnAbout.IconColor = System.Drawing.Color.LightGray
        Me.btnAbout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAbout.IconSize = 35
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 343)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(333, 77)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.LightGray
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnExit.IconColor = System.Drawing.Color.LightGray
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 35
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 825)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(0, 0, 0, 16)
        Me.btnExit.Size = New System.Drawing.Size(333, 57)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.LightGray
        Me.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.btnCustomer.IconColor = System.Drawing.Color.LightGray
        Me.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomer.IconSize = 35
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.Location = New System.Drawing.Point(0, 281)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(333, 62)
        Me.btnCustomer.TabIndex = 4
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'pnlBikeSubMenu
        '
        Me.pnlBikeSubMenu.Controls.Add(Me.btnReturn)
        Me.pnlBikeSubMenu.Controls.Add(Me.btnRent)
        Me.pnlBikeSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBikeSubMenu.Location = New System.Drawing.Point(0, 178)
        Me.pnlBikeSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBikeSubMenu.Name = "pnlBikeSubMenu"
        Me.pnlBikeSubMenu.Size = New System.Drawing.Size(333, 103)
        Me.pnlBikeSubMenu.TabIndex = 2
        '
        'btnReturn
        '
        Me.btnReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.LightGray
        Me.btnReturn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnReturn.IconColor = System.Drawing.Color.Black
        Me.btnReturn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReturn.Location = New System.Drawing.Point(0, 44)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Padding = New System.Windows.Forms.Padding(58, 0, 0, 0)
        Me.btnReturn.Size = New System.Drawing.Size(333, 55)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnRent
        '
        Me.btnRent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRent.FlatAppearance.BorderSize = 0
        Me.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRent.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.ForeColor = System.Drawing.Color.LightGray
        Me.btnRent.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnRent.IconColor = System.Drawing.Color.Black
        Me.btnRent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRent.Location = New System.Drawing.Point(0, 0)
        Me.btnRent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Padding = New System.Windows.Forms.Padding(58, 0, 0, 0)
        Me.btnRent.Size = New System.Drawing.Size(333, 44)
        Me.btnRent.TabIndex = 0
        Me.btnRent.Text = "Rent"
        Me.btnRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'btnBikeMenu
        '
        Me.btnBikeMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBikeMenu.FlatAppearance.BorderSize = 0
        Me.btnBikeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBikeMenu.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBikeMenu.ForeColor = System.Drawing.Color.Silver
        Me.btnBikeMenu.IconChar = FontAwesome.Sharp.IconChar.Bicycle
        Me.btnBikeMenu.IconColor = System.Drawing.Color.LightGray
        Me.btnBikeMenu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBikeMenu.IconSize = 35
        Me.btnBikeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBikeMenu.Location = New System.Drawing.Point(0, 123)
        Me.btnBikeMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBikeMenu.Name = "btnBikeMenu"
        Me.btnBikeMenu.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnBikeMenu.Size = New System.Drawing.Size(333, 55)
        Me.btnBikeMenu.TabIndex = 1
        Me.btnBikeMenu.Text = "Bike"
        Me.btnBikeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBikeMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBikeMenu.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(333, 123)
        Me.pnlLogo.TabIndex = 0
        '
        'pnlChildFormContainer
        '
        Me.pnlChildFormContainer.Controls.Add(Me.IconPictureBox1)
        Me.pnlChildFormContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChildFormContainer.Location = New System.Drawing.Point(333, 0)
        Me.pnlChildFormContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlChildFormContainer.Name = "pnlChildFormContainer"
        Me.pnlChildFormContainer.Size = New System.Drawing.Size(1284, 882)
        Me.pnlChildFormContainer.TabIndex = 1
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.LightGray
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.LocationArrow
        Me.IconPictureBox1.IconColor = System.Drawing.Color.LightGray
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 431
        Me.IconPictureBox1.Location = New System.Drawing.Point(347, 212)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(479, 431)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1617, 882)
        Me.Controls.Add(Me.pnlChildFormContainer)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlBikeSubMenu.ResumeLayout(False)
        Me.pnlChildFormContainer.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlBikeSubMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pnlChildFormContainer As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnCustomer As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAbout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBikeMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReturn As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRent As FontAwesome.Sharp.IconButton
End Class
