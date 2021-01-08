Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Timer1.Start()
        Panel2.Width += 3
        If (Panel2.Width >= 700) Then
            Timer1.Stop()
            login.Show()
            Me.Hide()
        End If
    End Sub

    'Private Sub Timer1_Disposed(sender As Object, e As EventArgs) Handles Timer1.Disposed
    '    Panel2.Width = +3
    '    If (Panel2.Width >= 700) Then
    '        Timer1.Stop()
    '        login.Show()
    '        Me.Close()
    '    End If
    'End Sub
End Class
