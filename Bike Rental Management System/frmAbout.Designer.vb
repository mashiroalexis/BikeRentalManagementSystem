<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.pnlAboutTitleContainer = New System.Windows.Forms.PictureBox()
        Me.lblAboutTitle = New System.Windows.Forms.Label()
        Me.pbCloseAboutForm = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.pnlAboutTitleContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAboutTitleContainer
        '
        Me.pnlAboutTitleContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlAboutTitleContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAboutTitleContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlAboutTitleContainer.Name = "pnlAboutTitleContainer"
        Me.pnlAboutTitleContainer.Size = New System.Drawing.Size(993, 100)
        Me.pnlAboutTitleContainer.TabIndex = 0
        Me.pnlAboutTitleContainer.TabStop = False
        '
        'lblAboutTitle
        '
        Me.lblAboutTitle.AutoSize = True
        Me.lblAboutTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblAboutTitle.Location = New System.Drawing.Point(13, 26)
        Me.lblAboutTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAboutTitle.Name = "lblAboutTitle"
        Me.lblAboutTitle.Size = New System.Drawing.Size(120, 46)
        Me.lblAboutTitle.TabIndex = 1
        Me.lblAboutTitle.Text = "About"
        '
        'pbCloseAboutForm
        '
        Me.pbCloseAboutForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseAboutForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseAboutForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseAboutForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseAboutForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseAboutForm.IconSize = 62
        Me.pbCloseAboutForm.Location = New System.Drawing.Point(859, 12)
        Me.pbCloseAboutForm.Name = "pbCloseAboutForm"
        Me.pbCloseAboutForm.Size = New System.Drawing.Size(67, 62)
        Me.pbCloseAboutForm.TabIndex = 3
        Me.pbCloseAboutForm.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 48
        Me.IconPictureBox1.Location = New System.Drawing.Point(472, 24)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(51, 48)
        Me.IconPictureBox1.TabIndex = 4
        Me.IconPictureBox1.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 597)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.pbCloseAboutForm)
        Me.Controls.Add(Me.lblAboutTitle)
        Me.Controls.Add(Me.pnlAboutTitleContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        CType(Me.pnlAboutTitleContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlAboutTitleContainer As PictureBox
    Friend WithEvents lblAboutTitle As Label
    Friend WithEvents pbCloseAboutForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
