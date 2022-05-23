<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminAccess
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSystemPassword = New System.Windows.Forms.TextBox()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFailMsg = New System.Windows.Forms.Label()
        Me.tmrFailMsgBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSystemPassword
        '
        Me.txtSystemPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtSystemPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSystemPassword.ForeColor = System.Drawing.Color.LightGray
        Me.txtSystemPassword.Location = New System.Drawing.Point(103, 100)
        Me.txtSystemPassword.Name = "txtSystemPassword"
        Me.txtSystemPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSystemPassword.Size = New System.Drawing.Size(310, 26)
        Me.txtSystemPassword.TabIndex = 3
        Me.txtSystemPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(514, 47)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(511, 38)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "SYSTEM PASSWORD"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFailMsg
        '
        Me.lblFailMsg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFailMsg.AutoSize = True
        Me.lblFailMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailMsg.ForeColor = System.Drawing.Color.IndianRed
        Me.lblFailMsg.Location = New System.Drawing.Point(195, 72)
        Me.lblFailMsg.Name = "lblFailMsg"
        Me.lblFailMsg.Size = New System.Drawing.Size(115, 13)
        Me.lblFailMsg.TabIndex = 5
        Me.lblFailMsg.Text = "Incorrect Access Code"
        Me.lblFailMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFailMsg.Visible = False
        '
        'tmrFailMsgBlinker
        '
        Me.tmrFailMsgBlinker.Interval = 400
        '
        'frmAdminAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 212)
        Me.Controls.Add(Me.lblFailMsg)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.txtSystemPassword)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdminAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTitle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSystemPassword As TextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFailMsg As Label
    Friend WithEvents tmrFailMsgBlinker As Timer
End Class
