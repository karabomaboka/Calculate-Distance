Public Class Form1
  Private Sub btnDistance_Click(sender As Object, e As EventArgs) Handles btnDistance.Click
    Dim rm(,) As Double = {{0, 1400, 1000, 600},
      {1400, 0, 750, 1600},
      {1000, 750, 0, 900},
      {600, 1600, 900, 0}}
    Dim row, col As Integer
    row = CInt(txtStartingPoint.Text)
    col = CInt(txtDestination.Text)
    If (row >= 1 And row <= 4) And (col >= 1 And col <= 4) Then
      txtDistance.Text = CStr(rm(row - 1, col - 1))
    Else
      MessageBox.Show("Starting Point and Destination must be numbers from 1 to 4",
      "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtDestination.Clear()
      txtStartingPoint.Clear()
      txtStartingPoint.Focus()
    End If
  End Sub

  Private Sub btnReenter_Click(sender As Object, e As EventArgs) Handles btnReenter.Click
    txtDistance.Clear()
    txtDestination.Clear()
    txtStartingPoint.Clear()
    txtStartingPoint.Focus()
  End Sub

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()
  End Sub

  Private Sub btnDisplayCity_Click(sender As Object, e As EventArgs) Handles btnDisplayCity.Click
    Dim row, col As Integer
    Dim city As String
    row = CInt(txtStartingPoint.Text)
    col = CInt(txtDestination.Text)
    If row = 0 And col = 0 Then
      city = "Johannesburg"
    End If
    If ((row = 0) And (col = 1)) Then
      city = "Johannesburg & Cape Town"
    End If
    If ((row = 0) And (col = 2)) Then
      city = "Johannesburg & Port Elizabeth"
    End If
    If ((row = 0) And (col = 3)) Then
      city = "Johannesburg & Durban"
    End If
    If ((row = 1) And (col = 0)) Then
      city = "Cape Town & Johannesburg"
    End If
    If ((row = 1) And (col = 1)) Then
      city = "Cape Town"
    End If
    If ((row = 1) And (col = 2)) Then
      city = "Cape Town & Port Elizabeth"
    End If
    If ((row = 1) And (col = 3)) Then
      city = "Cape Town & Durban"
    End If
    If ((row = 2) And (col = 0)) Then
      city = "Port Elizabeth & Johannesburg"
    End If
    If ((row = 2) And (col = 1)) Then
      city = "Port Elizabeth & Cape Town"
    End If
    If ((row = 2) And (col = 2)) Then
      city = "Port Elizabeth"
    End If
    If ((row = 2) And (col = 3)) Then
      city = "Port Elizabeth & Durban"
    End If
    If ((row = 3) And (col = 0)) Then
      city = "Durban & Johannesburg"
    End If
    If ((row = 3) And (col = 1)) Then
      city = "Durban & Cape Town"
    End If
    If ((row = 3) And (col = 2)) Then
      city = "Durban & Port Elizabeth"
    End If
    If ((row = 3) And (col = 3)) Then
      city = "Durban"
    End If
    lstResults.Text = city
  End Sub
End Class
