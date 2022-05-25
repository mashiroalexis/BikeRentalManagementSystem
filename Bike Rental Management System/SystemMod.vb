Module SystemMod

    '
    '   teporary fix for connection string storage
    '   use this everytime you need to use a database connection
    '
    Dim systemDatabaseConnectionString As String = "Data Source=ASPIRE\SQLEXPRESS;Initial Catalog=BikeRentalManagementDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"


    Public Sub roundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        'obj.BackColor = Color.Cyan


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)


    End Sub

    Public Function getConnectionString() As String
        Return systemDatabaseConnectionString
    End Function
End Module
