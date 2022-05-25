<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblAboutTitle = New System.Windows.Forms.Label()
        Me.pbCloseAboutForm = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlAboutTitleCover = New System.Windows.Forms.Panel()
        Me.lblTitleDeveloper = New System.Windows.Forms.Label()
        Me.lblAboutMessage = New System.Windows.Forms.Label()
        Me.lblAboutUs = New System.Windows.Forms.Label()
        Me.pbFacebook = New FontAwesome.Sharp.IconButton()
        Me.pbInstagram = New FontAwesome.Sharp.IconButton()
        Me.pbTwitter = New FontAwesome.Sharp.IconButton()
        Me.pbDev = New System.Windows.Forms.PictureBox()
        Me.pnlDevMessage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAboutTitleCover.SuspendLayout()
        CType(Me.pbDev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDevMessage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAboutTitle
        '
        Me.lblAboutTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAboutTitle.AutoSize = True
        Me.lblAboutTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblAboutTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblAboutTitle.Location = New System.Drawing.Point(13, 12)
        Me.lblAboutTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAboutTitle.Name = "lblAboutTitle"
        Me.lblAboutTitle.Size = New System.Drawing.Size(120, 46)
        Me.lblAboutTitle.TabIndex = 1
        Me.lblAboutTitle.Text = "About"
        '
        'pbCloseAboutForm
        '
        Me.pbCloseAboutForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbCloseAboutForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseAboutForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseAboutForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseAboutForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseAboutForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseAboutForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseAboutForm.IconSize = 62
        Me.pbCloseAboutForm.Location = New System.Drawing.Point(1191, 12)
        Me.pbCloseAboutForm.Name = "pbCloseAboutForm"
        Me.pbCloseAboutForm.Size = New System.Drawing.Size(67, 62)
        Me.pbCloseAboutForm.TabIndex = 3
        Me.pbCloseAboutForm.TabStop = False
        '
        'pnlAboutTitleCover
        '
        Me.pnlAboutTitleCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlAboutTitleCover.Controls.Add(Me.lblAboutTitle)
        Me.pnlAboutTitleCover.Controls.Add(Me.pbCloseAboutForm)
        Me.pnlAboutTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAboutTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlAboutTitleCover.Name = "pnlAboutTitleCover"
        Me.pnlAboutTitleCover.Size = New System.Drawing.Size(1267, 80)
        Me.pnlAboutTitleCover.TabIndex = 6
        '
        'lblTitleDeveloper
        '
        Me.lblTitleDeveloper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitleDeveloper.AutoSize = True
        Me.lblTitleDeveloper.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleDeveloper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTitleDeveloper.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDeveloper.ForeColor = System.Drawing.Color.LightGray
        Me.lblTitleDeveloper.Location = New System.Drawing.Point(537, 668)
        Me.lblTitleDeveloper.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleDeveloper.Name = "lblTitleDeveloper"
        Me.lblTitleDeveloper.Size = New System.Drawing.Size(188, 35)
        Me.lblTitleDeveloper.TabIndex = 4
        Me.lblTitleDeveloper.Text = "The Developer"
        '
        'lblAboutMessage
        '
        Me.lblAboutMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAboutMessage.AutoSize = True
        Me.lblAboutMessage.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutMessage.ForeColor = System.Drawing.Color.LightGray
        Me.lblAboutMessage.Location = New System.Drawing.Point(43, 185)
        Me.lblAboutMessage.Name = "lblAboutMessage"
        Me.lblAboutMessage.Size = New System.Drawing.Size(893, 140)
        Me.lblAboutMessage.TabIndex = 10
        Me.lblAboutMessage.Text = resources.GetString("lblAboutMessage.Text")
        '
        'lblAboutUs
        '
        Me.lblAboutUs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAboutUs.AutoSize = True
        Me.lblAboutUs.BackColor = System.Drawing.Color.Transparent
        Me.lblAboutUs.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutUs.ForeColor = System.Drawing.Color.LightGray
        Me.lblAboutUs.Location = New System.Drawing.Point(535, 98)
        Me.lblAboutUs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAboutUs.Name = "lblAboutUs"
        Me.lblAboutUs.Size = New System.Drawing.Size(169, 46)
        Me.lblAboutUs.TabIndex = 4
        Me.lblAboutUs.Text = "About Us"
        '
        'pbFacebook
        '
        Me.pbFacebook.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbFacebook.FlatAppearance.BorderSize = 0
        Me.pbFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pbFacebook.IconChar = FontAwesome.Sharp.IconChar.FacebookSquare
        Me.pbFacebook.IconColor = System.Drawing.Color.LightGray
        Me.pbFacebook.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbFacebook.IconSize = 50
        Me.pbFacebook.Location = New System.Drawing.Point(561, 720)
        Me.pbFacebook.Name = "pbFacebook"
        Me.pbFacebook.Size = New System.Drawing.Size(51, 57)
        Me.pbFacebook.TabIndex = 11
        Me.pbFacebook.UseVisualStyleBackColor = True
        '
        'pbInstagram
        '
        Me.pbInstagram.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbInstagram.FlatAppearance.BorderSize = 0
        Me.pbInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pbInstagram.IconChar = FontAwesome.Sharp.IconChar.InstagramSquare
        Me.pbInstagram.IconColor = System.Drawing.Color.LightGray
        Me.pbInstagram.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbInstagram.IconSize = 50
        Me.pbInstagram.Location = New System.Drawing.Point(636, 720)
        Me.pbInstagram.Name = "pbInstagram"
        Me.pbInstagram.Size = New System.Drawing.Size(51, 57)
        Me.pbInstagram.TabIndex = 12
        Me.pbInstagram.UseVisualStyleBackColor = True
        '
        'pbTwitter
        '
        Me.pbTwitter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbTwitter.FlatAppearance.BorderSize = 0
        Me.pbTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pbTwitter.IconChar = FontAwesome.Sharp.IconChar.TwitterSquare
        Me.pbTwitter.IconColor = System.Drawing.Color.LightGray
        Me.pbTwitter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbTwitter.IconSize = 50
        Me.pbTwitter.Location = New System.Drawing.Point(708, 720)
        Me.pbTwitter.Name = "pbTwitter"
        Me.pbTwitter.Size = New System.Drawing.Size(51, 57)
        Me.pbTwitter.TabIndex = 13
        Me.pbTwitter.UseVisualStyleBackColor = True
        '
        'pbDev
        '
        Me.pbDev.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbDev.Image = CType(resources.GetObject("pbDev.Image"), System.Drawing.Image)
        Me.pbDev.Location = New System.Drawing.Point(525, 404)
        Me.pbDev.Name = "pbDev"
        Me.pbDev.Size = New System.Drawing.Size(270, 261)
        Me.pbDev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDev.TabIndex = 14
        Me.pbDev.TabStop = False
        '
        'pnlDevMessage
        '
        Me.pnlDevMessage.Controls.Add(Me.PictureBox1)
        Me.pnlDevMessage.Controls.Add(Me.Label1)
        Me.pnlDevMessage.Location = New System.Drawing.Point(175, 404)
        Me.pnlDevMessage.Name = "pnlDevMessage"
        Me.pnlDevMessage.Size = New System.Drawing.Size(276, 204)
        Me.pnlDevMessage.TabIndex = 15
        Me.pnlDevMessage.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(-435, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 35)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "The Developer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-447, -197)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1267, 800)
        Me.Controls.Add(Me.pnlDevMessage)
        Me.Controls.Add(Me.pbDev)
        Me.Controls.Add(Me.pbTwitter)
        Me.Controls.Add(Me.pbInstagram)
        Me.Controls.Add(Me.pbFacebook)
        Me.Controls.Add(Me.lblAboutUs)
        Me.Controls.Add(Me.lblAboutMessage)
        Me.Controls.Add(Me.lblTitleDeveloper)
        Me.Controls.Add(Me.pnlAboutTitleCover)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAboutTitleCover.ResumeLayout(False)
        Me.pnlAboutTitleCover.PerformLayout()
        CType(Me.pbDev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDevMessage.ResumeLayout(False)
        Me.pnlDevMessage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutTitle As Label
    Friend WithEvents pbCloseAboutForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlAboutTitleCover As Panel
    Friend WithEvents lblTitleDeveloper As Label
    Friend WithEvents lblAboutMessage As Label
    Friend WithEvents lblAboutUs As Label
    Friend WithEvents pbFacebook As FontAwesome.Sharp.IconButton
    Friend WithEvents pbInstagram As FontAwesome.Sharp.IconButton
    Friend WithEvents pbTwitter As FontAwesome.Sharp.IconButton
    Friend WithEvents pbDev As PictureBox
    Friend WithEvents pnlDevMessage As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
