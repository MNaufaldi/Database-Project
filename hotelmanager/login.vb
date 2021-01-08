Imports System.Data
'Imports System.SqlClient
Imports System.Data.SqlClient
Public Class login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Public Sub clear()
        txtpassword.Text = ""
        txtusername.Text = ""
        txtusername.Focus()

    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim sqlQuery As String = "SELECT * FROM users where username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'"
        Dim sqlAdapter As New SqlDataAdapter
        Dim sqlCommand As New SqlCommand
        Dim TABLE As New DataTable
        conn = GetConnect()
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        conn.Open()
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)

            If TABLE.Rows.Count > 0 Then
                mainMenu.Show()
                Me.Close()
            Else
                lblerror.Visible = True
                lblerror.Text = "Incorrect credentials!!!"
                clear()
                conn.Close()
            End If
        End With
        conn.Close()
    End Sub
End Class