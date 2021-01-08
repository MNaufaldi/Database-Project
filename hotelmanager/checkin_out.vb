Imports System.Data
Imports System.Data.SqlClient
Public Class checkin_out
    Public Sub Clear()
        txtsearch.Text = ""
        txtreservationid.Text = ""
        txtroomnumber.Text = ""
        txtguestid.Text = ""
        txtcheckindate.Text = "DD-MM-YYYY"
        txtcheckoutdate.Text = "DD-MM-YYYY"

        lbladults.Text = "0"
        lblchildren.Text = "0"
        lblstatus.Text = "N/A"
        listpayments.Items.Clear()

        txtsearch.Focus()

    End Sub

    Public Sub loadListview() ' this will load the list view for students
        Dim sqlQuery As String = "SELECT * FROM Payment where reservation_id = '" + txtreservationid.Text + "' "
        'Dim sqlAdapter As New SqlDataAdapter
        Dim sqlAdapter As New SqlDataAdapter
        Dim sqlCommand As New SqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer
        conn = GetConnect()
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        conn.Open()
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)

            'fix for listview not to duplicate items
            listpayments.Items.Clear()
        End With

        For i = 0 To TABLE.Rows.Count - 1
            With listpayments
                .Items.Add(TABLE.Rows(i)("payment_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("payment_ref"))
                    .Add(TABLE.Rows(i)("guest_id"))
                    .Add(TABLE.Rows(i)("reservation_id"))
                    .Add(TABLE.Rows(i)("status"))

                End With
            End With

        Next
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Dim sqlQuery As String = "SELECT * FROM Payment where reservation_id = '" + txtreservationid.Text + "' "
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
            txtroomnumber.Text = myreader.Item("room_id").ToString
            lbladults.Text = myreader.Item("adults").ToString
            lblchildren.Text = myreader.Item("children")
            txtcheckindate.Text = myreader.Item("check_in_date").ToString
            txtcheckoutdate.Text = myreader.Item("check_outdate").ToString
            lblstatus.Text = myreader.Item("status").ToString
            conn.Close()

            If lblstatus.Text = "Checked-IN" Then
                Button1.Enabled = False
                btncheckout.Enabled = True
            ElseIf lblstatus.Text = "Booked" Then
                Button1.Enabled = True
                btncheckout.Enabled = False

            Else
                Button1.Enabled = False
                btncheckout.Enabled = False

            End If
            loadListview()
        Else
            MsgBox("The Record You Are Looking for does not exist!")
        End If
    End Sub

    Private Sub checkin_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_System_Payment_DataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.Hotel_System_Payment_DataSet.Payment)

    End Sub

    Public Sub changeRoomStatus()
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("Update Room Set status_id = 1002 Where room_id = '" + txtroomnumber.Text + "' ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            ' MsgBox("Guest Has Been Checked In successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Payments.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("Update Reservation Set status = 'Checked-IN' Where reservation_id = '" + txtreservationid.Text + "' ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            MsgBox("Guest Has Been Checked In successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
        changeRoomStatus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("Update Reservation Set status = 'Checked-OUT' Where reservation_id = '" + txtreservationid.Text + "' ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            MsgBox("Guest Has Been Checked In successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
        changeRoomStatusback()
    End Sub

    Public Sub changeRoomStatusback()
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("Update Room Set status_id = 1001 Where room_id = '" + txtroomnumber.Text + "' ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            'MsgBox("Guest Has Been Checked In successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
    End Sub
End Class