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
        Me.pbDev = New System.Windows.Forms.PictureBox()
        Me.pnlDevMessage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbFB = New FontAwesome.Sharp.IconPictureBox()
        Me.pbTwt = New FontAwesome.Sharp.IconPictureBox()
        Me.pbInsta = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAboutTitleCover.SuspendLayout()
        CType(Me.pbDev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDevMessage.SuspendLayout()
        CType(Me.pbFB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTwt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbInsta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblAboutMessage.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutMessage.ForeColor = System.Drawing.Color.LightGray
        Me.lblAboutMessage.Location = New System.Drawing.Point(58, 194)
        Me.lblAboutMessage.Name = "lblAboutMessage"
        Me.lblAboutMessage.Size = New System.Drawing.Size(858, 125)
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
        Me.lblAboutUs.Size = New System.Drawing.Size(180, 46)
        Me.lblAboutUs.TabIndex = 4
        Me.lblAboutUs.Text = "About Me"
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
        Me.pnlDevMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlDevMessage.Controls.Add(Me.Label1)
        Me.pnlDevMessage.Location = New System.Drawing.Point(0, 399)
        Me.pnlDevMessage.Name = "pnlDevMessage"
        Me.pnlDevMessage.Size = New System.Drawing.Size(1267, 300)
        Me.pnlDevMessage.TabIndex = 15
        Me.pnlDevMessage.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(46, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(915, 100)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'pbFB
        '
        Me.pbFB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbFB.BackColor = System.Drawing.Color.Transparent
        Me.pbFB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFB.ForeColor = System.Drawing.Color.LightGray
        Me.pbFB.IconChar = FontAwesome.Sharp.IconChar.FacebookSquare
        Me.pbFB.IconColor = System.Drawing.Color.LightGray
        Me.pbFB.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbFB.IconSize = 48
        Me.pbFB.Location = New System.Drawing.Point(559, 717)
        Me.pbFB.Name = "pbFB"
        Me.pbFB.Size = New System.Drawing.Size(52, 48)
        Me.pbFB.TabIndex = 16
        Me.pbFB.TabStop = False
        '
        'pbTwt
        '
        Me.pbTwt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbTwt.BackColor = System.Drawing.Color.Transparent
        Me.pbTwt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTwt.ForeColor = System.Drawing.Color.LightGray
        Me.pbTwt.IconChar = FontAwesome.Sharp.IconChar.TwitterSquare
        Me.pbTwt.IconColor = System.Drawing.Color.LightGray
        Me.pbTwt.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbTwt.IconSize = 48
        Me.pbTwt.Location = New System.Drawing.Point(706, 717)
        Me.pbTwt.Name = "pbTwt"
        Me.pbTwt.Size = New System.Drawing.Size(52, 48)
        Me.pbTwt.TabIndex = 17
        Me.pbTwt.TabStop = False
        '
        'pbInsta
        '
        Me.pbInsta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbInsta.BackColor = System.Drawing.Color.Transparent
        Me.pbInsta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbInsta.ForeColor = System.Drawing.Color.LightGray
        Me.pbInsta.IconChar = FontAwesome.Sharp.IconChar.InstagramSquare
        Me.pbInsta.IconColor = System.Drawing.Color.LightGray
        Me.pbInsta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbInsta.IconSize = 48
        Me.pbInsta.Location = New System.Drawing.Point(634, 717)
        Me.pbInsta.Name = "pbInsta"
        Me.pbInsta.Size = New System.Drawing.Size(52, 48)
        Me.pbInsta.TabIndex = 18
        Me.pbInsta.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1267, 800)
        Me.Controls.Add(Me.pnlDevMessage)
        Me.Controls.Add(Me.pbDev)
        Me.Controls.Add(Me.lblAboutUs)
        Me.Controls.Add(Me.lblAboutMessage)
        Me.Controls.Add(Me.lblTitleDeveloper)
        Me.Controls.Add(Me.pnlAboutTitleCover)
        Me.Controls.Add(Me.pbInsta)
        Me.Controls.Add(Me.pbTwt)
        Me.Controls.Add(Me.pbFB)
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
        CType(Me.pbFB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTwt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbInsta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutTitle As Label
    Friend WithEvents pbCloseAboutForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlAboutTitleCover As Panel
    Friend WithEvents lblTitleDeveloper As Label
    Friend WithEvents lblAboutMessage As Label
    Friend WithEvents lblAboutUs As Label
    Friend WithEvents pbDev As PictureBox
    Friend WithEvents pnlDevMessage As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pbFB As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pbTwt As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pbInsta As FontAwesome.Sharp.IconPictureBox
End Class
