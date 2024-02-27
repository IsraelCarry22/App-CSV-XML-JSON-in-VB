Public Class Form2
    Public ReadOnly Property NombreColumna As String
        Get
            Return NombreColumnaTXT.Text
        End Get
    End Property

    Private Sub NombreColumnaTXT_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles NombreColumnaTXT.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            AceptarBTM.PerformClick()
        End If
    End Sub

    Private Sub AceptarBTM_Click(sender As Object, e As EventArgs) Handles AceptarBTM.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class