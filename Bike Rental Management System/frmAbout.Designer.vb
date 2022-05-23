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
        Me.lblAboutTitle = New System.Windows.Forms.Label()
        Me.pbCloseAboutForm = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAboutTitle)
        Me.Panel1.Controls.Add(Me.pbCloseAboutForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1267, 80)
        Me.Panel1.TabIndex = 6
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1267, 800)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        CType(Me.pbCloseAboutForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAboutTitle As Label
    Friend WithEvents pbCloseAboutForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
End Class
