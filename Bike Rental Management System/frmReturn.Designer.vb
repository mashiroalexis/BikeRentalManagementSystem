<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        Me.pnlReturnTitleCover = New System.Windows.Forms.Panel()
        Me.pbCloseReturnForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblReturnTitle = New System.Windows.Forms.Label()
        Me.pnlReturnTitleCover.SuspendLayout()
        CType(Me.pbCloseReturnForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReturnTitleCover
        '
        Me.pnlReturnTitleCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlReturnTitleCover.Controls.Add(Me.pbCloseReturnForm)
        Me.pnlReturnTitleCover.Controls.Add(Me.lblReturnTitle)
        Me.pnlReturnTitleCover.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlReturnTitleCover.Location = New System.Drawing.Point(0, 0)
        Me.pnlReturnTitleCover.Name = "pnlReturnTitleCover"
        Me.pnlReturnTitleCover.Size = New System.Drawing.Size(1047, 80)
        Me.pnlReturnTitleCover.TabIndex = 0
        '
        'pbCloseReturnForm
        '
        Me.pbCloseReturnForm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbCloseReturnForm.BackColor = System.Drawing.Color.Transparent
        Me.pbCloseReturnForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCloseReturnForm.ForeColor = System.Drawing.Color.LightGray
        Me.pbCloseReturnForm.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.pbCloseReturnForm.IconColor = System.Drawing.Color.LightGray
        Me.pbCloseReturnForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbCloseReturnForm.IconSize = 62
        Me.pbCloseReturnForm.Location = New System.Drawing.Point(976, 12)
        Me.pbCloseReturnForm.Margin = New System.Windows.Forms.Padding(4)
        Me.pbCloseReturnForm.Name = "pbCloseReturnForm"
        Me.pbCloseReturnForm.Size = New System.Drawing.Size(67, 62)
        Me.pbCloseReturnForm.TabIndex = 5
        Me.pbCloseReturnForm.TabStop = False
        '
        'lblReturnTitle
        '
        Me.lblReturnTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReturnTitle.AutoSize = True
        Me.lblReturnTitle.Font = New System.Drawing.Font("Nirmala UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblReturnTitle.Location = New System.Drawing.Point(13, 9)
        Me.lblReturnTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturnTitle.Name = "lblReturnTitle"
        Me.lblReturnTitle.Size = New System.Drawing.Size(125, 45)
        Me.lblReturnTitle.TabIndex = 1
        Me.lblReturnTitle.Text = "Return"
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1047, 593)
        Me.Controls.Add(Me.pnlReturnTitleCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturn"
        Me.Text = "frmReturn"
        Me.pnlReturnTitleCover.ResumeLayout(False)
        Me.pnlReturnTitleCover.PerformLayout()
        CType(Me.pbCloseReturnForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlReturnTitleCover As Panel
    Friend WithEvents lblReturnTitle As Label
    Friend WithEvents pbCloseReturnForm As FontAwesome.Sharp.IconPictureBox
End Class
