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
        Me.pbDeveloper = New System.Windows.Forms.PictureBox()
        Me.lblTitleDeveloper = New System.Windows.Forms.Label()
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAboutTitleCover.SuspendLayout()
        CType(Me.pbDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pbDeveloper
        '
        Me.pbDeveloper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbDeveloper.Image = CType(resources.GetObject("pbDeveloper.Image"), System.Drawing.Image)
        Me.pbDeveloper.Location = New System.Drawing.Point(12, 98)
        Me.pbDeveloper.Name = "pbDeveloper"
        Me.pbDeveloper.Size = New System.Drawing.Size(323, 299)
        Me.pbDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDeveloper.TabIndex = 7
        Me.pbDeveloper.TabStop = False
        '
        'lblTitleDeveloper
        '
        Me.lblTitleDeveloper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitleDeveloper.AutoSize = True
        Me.lblTitleDeveloper.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleDeveloper.ForeColor = System.Drawing.Color.LightGray
        Me.lblTitleDeveloper.Location = New System.Drawing.Point(80, 411)
        Me.lblTitleDeveloper.Name = "lblTitleDeveloper"
        Me.lblTitleDeveloper.Size = New System.Drawing.Size(188, 35)
        Me.lblTitleDeveloper.TabIndex = 8
        Me.lblTitleDeveloper.Text = "The Developer"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1267, 800)
        Me.Controls.Add(Me.lblTitleDeveloper)
        Me.Controls.Add(Me.pbDeveloper)
        Me.Controls.Add(Me.pnlAboutTitleCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAboutTitleCover.ResumeLayout(False)
        Me.pnlAboutTitleCover.PerformLayout()
        CType(Me.pbDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAboutTitle As Label
    Friend WithEvents pbCloseAboutForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlAboutTitleCover As Panel
    Friend WithEvents pbDeveloper As PictureBox
    Friend WithEvents lblTitleDeveloper As Label
End Class
