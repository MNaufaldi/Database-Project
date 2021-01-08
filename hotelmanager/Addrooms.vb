Imports System.Data
Imports System.Data.SqlClient

Public Class Addrooms
    Private Sub Addrooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("INSERT INTO users (username, password, access) VALUES ('" + txtusername.Text + "','" + txtpassword.Text + "', '" + cmblevel.Text + "') ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            MsgBox("User Details Saved successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
    End Sub
End Class