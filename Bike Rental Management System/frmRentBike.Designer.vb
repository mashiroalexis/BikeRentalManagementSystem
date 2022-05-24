<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentBike
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
        Me.pnlRentTitleCover = New System.Windows.Forms.Panel()
        Me.pbCloseRentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblRentTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlRentTitleCover.SuspendLayout()
        CType(Me.pbCloseRentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRentTitleCover
        '
        Me.pnlRentTitleCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlRentTitleCover.Controls.Add(Me.pbCloseRentForm)
        Me.pnlRentTitleCover.Controls.Add(Me.lblRentTitle)
        Me.pnlRentTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRentTitleCover.ForeColor = System.Drawing.Color.LightGray
        Me.pnlRentTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlRentTitleCover.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlRentTitleCover.Name = "pnlRentTitleCover"
        Me.pnlRentTitleCover.Size = New System.Drawing.Size(1284, 80)
        Me.pnlRentTitleCover.TabIndex = 0
        '
        'pbCloseRentForm
        '
        Me.pbCloseRentForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbCloseRentForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseRentForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseRentForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseRentForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseRentForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseRentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseRentForm.IconSize = 62
        Me.pbCloseRentForm.Location = New System.Drawing.Point(1204, 11)
        Me.pbCloseRentForm.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCloseRentForm.Name = "pbCloseRentForm"
        Me.pbCloseRentForm.Size = New System.Drawing.Size(67, 62)
        Me.pbCloseRentForm.TabIndex = 4
        Me.pbCloseRentForm.TabStop = False
        '
        'lblRentTitle
        '
        Me.lblRentTitle.AutoSize = True
        Me.lblRentTitle.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentTitle.Location = New System.Drawing.Point(16, 11)
        Me.lblRentTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRentTitle.Name = "lblRentTitle"
        Me.lblRentTitle.Size = New System.Drawing.Size(93, 46)
        Me.lblRentTitle.TabIndex = 0
        Me.lblRentTitle.Text = "Rent"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Bike_Rental_Management_System.My.Resources.Resources.loader
        Me.PictureBox1.Location = New System.Drawing.Point(387, 285)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(547, 414)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmRentBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 882)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlRentTitleCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRentBike"
        Me.Text = "frmRentBike"
        Me.pnlRentTitleCover.ResumeLayout(False)
        Me.pnlRentTitleCover.PerformLayout()
        CType(Me.pbCloseRentForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRentTitleCover As Panel
    Friend WithEvents lblRentTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbCloseRentForm As FontAwesome.Sharp.IconPictureBox
End Class
