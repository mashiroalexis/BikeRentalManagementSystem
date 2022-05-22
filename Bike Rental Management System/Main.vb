Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make rounded corners
        roundCorners(Me)

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

    Private Sub btnBikeMenu_Click(sender As Object, e As EventArgs) Handles btnBikeMenu.Click
        showSubMenu(Me.pnlBikeSubMenu)
        'hideSubMenu()
    End Sub
End Class