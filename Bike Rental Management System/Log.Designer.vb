<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Log
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Log))
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblacc = New System.Windows.Forms.Label()
        Me.lblsignup = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnminimize = New System.Windows.Forms.Label()
        Me.btnmaxmimize = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.Color.LightGray
        Me.lblLogo.Location = New System.Drawing.Point(178, 72)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(155, 26)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "BIKE RENTAL"
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(45, 42)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(135, 74)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Snow
        Me.btnLogin.Location = New System.Drawing.Point(132, 298)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(262, 52)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblacc
        '
        Me.lblacc.AutoSize = True
        Me.lblacc.BackColor = System.Drawing.Color.Transparent
        Me.lblacc.Font = New System.Drawing.Font("Nirmala UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc.ForeColor = System.Drawing.Color.LightGray
        Me.lblacc.Location = New System.Drawing.Point(213, 536)
        Me.lblacc.Name = "lblacc"
        Me.lblacc.Size = New System.Drawing.Size(145, 13)
        Me.lblacc.TabIndex = 17
        Me.lblacc.Text = "Don't have an account yet?"
        '
        'lblsignup
        '
        Me.lblsignup.AutoSize = True
        Me.lblsignup.BackColor = System.Drawing.Color.Transparent
        Me.lblsignup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblsignup.Font = New System.Drawing.Font("Nirmala UI", 7.8!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignup.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblsignup.Location = New System.Drawing.Point(426, 535)
        Me.lblsignup.Name = "lblsignup"
        Me.lblsignup.Size = New System.Drawing.Size(48, 13)
        Me.lblsignup.TabIndex = 18
        Me.lblsignup.Text = "Sign Up"
        '
        'btnclose
        '
        Me.btnclose.AutoSize = True
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.LightGray
        Me.btnclose.Location = New System.Drawing.Point(642, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(18, 19)
        Me.btnclose.TabIndex = 19
        Me.btnclose.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Controls.Add(Me.lblLogo)
        Me.Panel1.Location = New System.Drawing.Point(90, 92)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 425)
        Me.Panel1.TabIndex = 20
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(117, 190)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(262, 35)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(117, 139)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(262, 35)
        Me.txtUsername.TabIndex = 7
        Me.txtUsername.Text = "Username"
        '
        'btnminimize
        '
        Me.btnminimize.AutoSize = True
        Me.btnminimize.BackColor = System.Drawing.Color.Transparent
        Me.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminimize.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.ForeColor = System.Drawing.Color.LightGray
        Me.btnminimize.Location = New System.Drawing.Point(576, 5)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(21, 19)
        Me.btnminimize.TabIndex = 22
        Me.btnminimize.Text = "__"
        '
        'btnmaxmimize
        '
        Me.btnmaxmimize.AutoSize = True
        Me.btnmaxmimize.BackColor = System.Drawing.Color.Transparent
        Me.btnmaxmimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmaxmimize.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmaxmimize.ForeColor = System.Drawing.Color.LightGray
        Me.btnmaxmimize.Location = New System.Drawing.Point(610, 12)
        Me.btnmaxmimize.Name = "btnmaxmimize"
        Me.btnmaxmimize.Size = New System.Drawing.Size(22, 19)
        Me.btnmaxmimize.TabIndex = 21
        Me.btnmaxmimize.Text = "□"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(117, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 1)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(117, 220)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(233, 1)
        Me.Panel3.TabIndex = 24
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 629)
        Me.Controls.Add(Me.btnminimize)
        Me.Controls.Add(Me.btnmaxmimize)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblsignup)
        Me.Controls.Add(Me.lblacc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Log"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogo As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblacc As Label
    Friend WithEvents lblsignup As Label
    Friend WithEvents btnclose As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnminimize As Label
    Friend WithEvents btnmaxmimize As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
