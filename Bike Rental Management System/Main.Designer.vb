﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.btnBikeMenu = New System.Windows.Forms.Button()
        Me.pnlBikeSubMenu = New System.Windows.Forms.Panel()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.pnlMenu.SuspendLayout()
        Me.pnlBikeSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnCustomers)
        Me.pnlMenu.Controls.Add(Me.pnlBikeSubMenu)
        Me.pnlMenu.Controls.Add(Me.btnBikeMenu)
        Me.pnlMenu.Controls.Add(Me.pnlLogo)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(250, 749)
        Me.pnlMenu.TabIndex = 0
        '
        'pnlLogo
        '
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(250, 100)
        Me.pnlLogo.TabIndex = 0
        '
        'btnBikeMenu
        '
        Me.btnBikeMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBikeMenu.FlatAppearance.BorderSize = 0
        Me.btnBikeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBikeMenu.ForeColor = System.Drawing.Color.Silver
        Me.btnBikeMenu.Location = New System.Drawing.Point(0, 100)
        Me.btnBikeMenu.Name = "btnBikeMenu"
        Me.btnBikeMenu.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBikeMenu.Size = New System.Drawing.Size(250, 45)
        Me.btnBikeMenu.TabIndex = 1
        Me.btnBikeMenu.Text = "Bike"
        Me.btnBikeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBikeMenu.UseVisualStyleBackColor = True
        '
        'pnlBikeSubMenu
        '
        Me.pnlBikeSubMenu.Controls.Add(Me.btnReturn)
        Me.pnlBikeSubMenu.Controls.Add(Me.btnRent)
        Me.pnlBikeSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBikeSubMenu.Location = New System.Drawing.Point(0, 145)
        Me.pnlBikeSubMenu.Name = "pnlBikeSubMenu"
        Me.pnlBikeSubMenu.Size = New System.Drawing.Size(250, 84)
        Me.pnlBikeSubMenu.TabIndex = 2
        '
        'btnRent
        '
        Me.btnRent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRent.FlatAppearance.BorderSize = 0
        Me.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRent.ForeColor = System.Drawing.Color.LightGray
        Me.btnRent.Location = New System.Drawing.Point(0, 0)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnRent.Size = New System.Drawing.Size(250, 36)
        Me.btnRent.TabIndex = 0
        Me.btnRent.Text = "Rent"
        Me.btnRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.ForeColor = System.Drawing.Color.LightGray
        Me.btnReturn.Location = New System.Drawing.Point(0, 36)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnReturn.Size = New System.Drawing.Size(250, 45)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.Color.LightGray
        Me.btnCustomers.Location = New System.Drawing.Point(0, 229)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(250, 45)
        Me.btnCustomers.TabIndex = 3
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1213, 749)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlBikeSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlBikeSubMenu As Panel
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRent As Button
    Friend WithEvents btnBikeMenu As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents btnCustomers As Button
End Class
