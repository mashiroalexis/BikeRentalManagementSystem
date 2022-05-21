<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reg))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcontact = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Personal Details"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstname.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(140, 88)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(97, 21)
        Me.lblFirstname.TabIndex = 1
        Me.lblFirstname.Text = "First Name:"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.Transparent
        Me.lblLastname.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(140, 126)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(95, 21)
        Me.lblLastname.TabIndex = 2
        Me.lblLastname.Text = "Last Name:"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(140, 165)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(122, 21)
        Me.lblemail.TabIndex = 3
        Me.lblemail.Text = "Email Address:"
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.BackColor = System.Drawing.Color.Transparent
        Me.lblcontact.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.Location = New System.Drawing.Point(140, 202)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(136, 21)
        Me.lblcontact.TabIndex = 4
        Me.lblcontact.Text = "Contact Number:"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(140, 239)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(91, 21)
        Me.lblusername.TabIndex = 5
        Me.lblusername.Text = "Username:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(140, 277)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(87, 21)
        Me.lblpassword.TabIndex = 6
        Me.lblpassword.Text = "Password:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(243, 85)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(236, 26)
        Me.txtFirstName.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(243, 125)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(236, 26)
        Me.txtLastName.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(268, 164)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(211, 26)
        Me.txtEmail.TabIndex = 9
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(297, 201)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(182, 26)
        Me.txtContact.TabIndex = 10
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(243, 237)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(236, 26)
        Me.txtUsername.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(243, 274)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(236, 26)
        Me.txtPassword.TabIndex = 12
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(468, 339)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 37)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(89, 339)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 37)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(616, 423)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblcontact)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblcontact As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtFirstName As TextBox
End Class
