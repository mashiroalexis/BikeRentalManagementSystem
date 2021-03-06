Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make rounded corners
        roundCorners(Me)
        MsgBox(getUserId())
        'when main form loads hide all submenu
        hideSubMenu()
    End Sub

    'hide all enabled sub menu in the main form
    Private Sub hideSubMenu()
        If Me.pnlBikeSubMenu.Visible = True Then
            Me.pnlBikeSubMenu.Visible = False
        End If
    End Sub

    'show specific sub menu
    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub



    'switch forms
    Dim activeChildForm As Form = Nothing

    Private Sub switchMenu(panel As Form)

        If activeChildForm IsNot Nothing And activeChildForm IsNot panel Then
            activeChildForm.Close()
        End If

        activeChildForm = panel

        pnlChildFormContainer.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        panel.FormBorderStyle = FormBorderStyle.None
        pnlChildFormContainer.Controls.Add(panel)
        pnlChildFormContainer.Tag = panel
        panel.BringToFront()
        panel.Show()
    End Sub

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        switchMenu(frmRentBike)
        'switchFormsInMain(frmRentBike)

    End Sub


    Private Sub btnBikeMenu_Click_2(sender As Object, e As EventArgs) Handles btnBikeMenu.Click
        showSubMenu(Me.pnlBikeSubMenu)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        hideSubMenu()
        switchMenu(frmCustomer)

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        hideSubMenu()
        switchMenu(frmAbout)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        switchMenu(frmReturn)
    End Sub

    Private Sub pnlChildFormContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlChildFormContainer.Paint

    End Sub
End Class