Imports Windows.Devices.Geolocation 'Geolocation Namespace
Imports System.Threading 'Threading Namespace
Imports System.Threading.Tasks 'Tasks Namespace

Public Class Form1
    Private glGeo As New Geolocator 'Create New Geolocator Object With Its Associated Events
    Private objTelescope As ASCOM.DriverAccess.Telescope
    Private connected As Boolean = False

    Private Sub btnSelScope_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelScope.Click
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "Telescope"
        My.Settings.Telescope = obj.Choose(My.Settings.Telescope)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        objTelescope = New ASCOM.DriverAccess.Telescope(My.Settings.Telescope)
        objTelescope.Connected = True
        connected = True
        sender.enabled = False
        parkScope.Enabled = True
        setTracking.Enabled = True
        LoadTimer.Start()
    End Sub

    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        DataOutTimer.Start()
        LoadTimer.Stop()
    End Sub
    Private Sub DataOutTimer_Tick(sender As Object, e As EventArgs) Handles DataOutTimer.Tick
        UTCDateOut.Text = objTelescope.UTCDate
    End Sub
    Private Sub LSTTimer_Tick(sender As Object, e As EventArgs) Handles LSTTimer.Tick
        LSTOut.Text = objTelescope.SiderealTime
    End Sub

    Private Sub moveAxis0CCW_MouseDown(sender As Object, e As EventArgs) Handles moveAxis0CCW.MouseDown
        Dim Rate As Double
        Rate = moveAxisRate.Value
        objTelescope.MoveAxis(0, Rate)
    End Sub
    Private Sub moveAxis0CCW_MouseUp(sender As Object, e As EventArgs) Handles moveAxis0CCW.MouseUp
        objTelescope.MoveAxis(0, 0)
    End Sub

    Private Sub moveAxis0CW_MouseDown(sender As Object, e As EventArgs) Handles moveAxis0CW.MouseDown
        Dim Rate As Double
        Rate = moveAxisRate.Value * -1
        objTelescope.MoveAxis(0, Rate)
    End Sub
    Private Sub moveAxis0CW_MouseUp(sender As Object, e As EventArgs) Handles moveAxis0CW.MouseUp
        objTelescope.MoveAxis(0, 0)
    End Sub

    Private Sub moveAxis1Up_MouseDown(sender As Object, e As EventArgs) Handles moveAxis1Up.MouseDown
        Dim Rate As Double
        Rate = moveAxisRate.Value * -1
        objTelescope.MoveAxis(1, Rate)
    End Sub
    Private Sub moveAxis1Up_MouseUp(sender As Object, e As EventArgs) Handles moveAxis1Up.MouseUp
        objTelescope.MoveAxis(1, 0)
    End Sub

    Private Sub moveAxis1Dwn_MouseDown(sender As Object, e As EventArgs) Handles moveAxis1Dwn.MouseDown
        Dim Rate As Double
        Rate = moveAxisRate.Value
        objTelescope.MoveAxis(1, Rate)
    End Sub
    Private Sub moveAxis1Dwn_MouseUp(sender As Object, e As EventArgs) Handles moveAxis1Dwn.MouseUp
        objTelescope.MoveAxis(1, 0)
    End Sub

    Private Sub parkScope_CheckedChanged(sender As Object, e As EventArgs) Handles parkScope.CheckedChanged
        If parkScope.Checked Then
            If (connected) Then
                objTelescope.Park()
            End If
            moveAxis0CCW.Enabled = False
            moveAxis0CW.Enabled = False
            moveAxis1Dwn.Enabled = False
            moveAxis1Up.Enabled = False
            moveAxisRate.Enabled = False
        Else
            objTelescope.Unpark()
            moveAxis0CCW.Enabled = True
            moveAxis0CW.Enabled = True
            moveAxis1Dwn.Enabled = True
            moveAxis1Up.Enabled = True
            moveAxisRate.Enabled = True
        End If
    End Sub

    Private Sub setTracking_CheckedChanged(sender As Object, e As EventArgs) Handles setTracking.CheckedChanged
        If setTracking.Checked Then
            objTelescope.Tracking = True
        Else
            objTelescope.Tracking = False
        End If
    End Sub
    Private Sub LatLongIn_Click(sender As Object, e As EventArgs) Handles LatLongIn.Click
        Dim latIn As Double
        Dim longIn As Double
        latIn = LatInBx.Value
        longIn = LongInBx.Value
        objTelescope.SiteLatitude = latIn
        objTelescope.SiteLongitude = longIn
        LSTTimer.Start()
    End Sub
End Class
