Imports System.Data
Imports System.Data.SqlClient
Public Class Payments


    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = GetConnect()
        ' Dim sqlAdapter As New SqlDataAdapter
        Dim sqlCommand As New SqlCommand("Select * from Reservation where reservation_id = '" + txtsearch.Text + "'", conn)


        Dim myreader As SqlDataReader
        conn.Open()

        myreader = sqlCommand.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            txtreservationid.Text = myreader.Item("reservation_id").ToString
            txtguestid.Text = myreader.Item("guest_id").ToString
            txtbooked.Text = myreader.Item("reservation_date").ToString

            txtcheckin.Text = myreader.Item("check_in_date").ToString
            txtcheckout.Text = myreader.Item("check_outdate").ToString

            conn.Close()



        Else
            MsgBox("The Record You Are Looking for does not exist!")
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("INSERT INTO Payment (payment_ref, guest_id, reservation_id,status) VALUES ('" + txtpayref.Text + "','" + txtguestid.Text + "', '" + txtreservationid.Text + "', 'Paid') ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            MsgBox("Payment Record Saved Successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
    End Sub
End Class