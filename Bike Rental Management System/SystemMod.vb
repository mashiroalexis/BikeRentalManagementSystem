Module SystemMod

    '
    '   teporary fix for connection string storage
    '   use this everytime you need to use a database connection
    '
    Dim systemDatabaseConnectionString As String = "Data Source=ALEXIS\SQLEXPRESS;Initial Catalog=BikeRentalManagementSystem;Integrated Security=True"


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

    ' 
    ' 
    ' 
    Dim activeChildForm As Form = Nothing
    Public Sub switchFormsInMain(frmChild As Form)
        If activeChildForm IsNot Nothing Then
            activeChildForm.Close()
        End If

        frmMain.pnlChildFormContainer.Controls.Clear()
        frmChild.TopLevel = False
        frmChild.Dock = DockStyle.Fill
        frmChild.FormBorderStyle = FormBorderStyle.None
        frmMain.pnlChildFormContainer.Controls.Add(frmChild)
        frmMain.pnlChildFormContainer.Tag = frmChild
        frmChild.BringToFront()
        frmChild.Activate()
        frmChild.Show()
    End Sub

    Public Function countTimeDiff(time1 As Date, time2 As Date) As Double
        Dim timeHour As Double
        Dim timeMins As Double
        Dim timeSec As Double
        Dim completeTime As Double

        timeHour = DateDiff(DateInterval.Hour, time1, time2)
        timeMins = DateDiff(DateInterval.Minute, time1, time2)
        timeSec = DateDiff(DateInterval.Second, time1, time2)


        completeTime = Date.Now.ToString(timeHour & ":" & timeMins & ":" & timeSec)

        Return completeTime
    End Function


End Module
