Imports System
Imports System.Data.SqlClient
Public Class booking



    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub



    Public Sub vat(X)
        Dim vat As Double
        Dim tax As Double

        vat = 0.15
        tax = vat * X
        lblvat.Text = tax

        lbltotal.Text = tax + lblroomamnt.Text
    End Sub
    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        Dim RAmount As Double
        Dim dt As Double
        dt = DateDifference()

        If dtcheckin.Value < Date.Now Then
            MsgBox("CHECK IN DATE CANNOT BE BEFORE TODAY!", vbCritical, "INVALID DATE")
            dtcheckin.Focus()
            Exit Sub
        End If
        If dtcheckout.Value < dtcheckin.Value Then
            MsgBox("CHECK OUT DATE CANNOT BE BEFORE CHECK-IN DATE !", vbCritical, "INVALID DATE")
            dtcheckout.Focus()
            Exit Sub
        End If

        If cmbtype.Text = "Single" Then
            RAmount = 50.0
            lblroomamnt.Text = RAmount * dt


        ElseIf cmbtype.Text = "Double" Then
            RAmount = 75.0
            lblroomamnt.Text = RAmount * dt

        ElseIf cmbtype.Text = "Family" Then
            RAmount = 125.0
            lblroomamnt.Text = RAmount * dt

        End If

        vat(RAmount)
    End Sub



    'Other Subsidiary functions
    Public Sub clear()
        txtaddress.Text = ""
        txtadults.Text = ""
        txtcity.Text = ""
        txtcountry.Text = ""
        txtemail.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        cmbtype.Text = "Single"
        txtchildren.Text = ""
        txtidnumber.Text = ""
        txtphone.Text = ""
        lblroomamnt.Text = "0.00"
        lbltotal.Text = "0.00"
        lblvat.Text = "0.00"
        lblrr.Text = "RESERVATION NUMBER"
        lbltt.Text = "0.00"
        ComboBox1.Text = ""
        txtfname.Focus()
    End Sub

    Public Sub checkEmptyFields()
        'check First Name
        If txtfname.Text = "" Then
            MsgBox("Fisrt Name Cannot be BLANK", vbCritical, "Missing First Name")
            txtfname.Focus()
            Exit Sub
        End If

        'check Last Name
        If txtlname.Text = "" Then
            MsgBox("Last Name Cannot be BLANK", vbCritical, "Missing LAst Name")
            txtlname.Focus()
            Exit Sub
        End If

        'check Address
        If txtaddress.Text = "" Then
            MsgBox("Address Cannot be BLANK.", vbCritical, "Missing Address")
            txtaddress.Focus()
            Exit Sub
        End If

        'check Email
        If txtemail.Text = "" Then
            MsgBox("Email Cannot Be BLANK.", vbCritical, "Missing Email")
            txtemail.Focus()
            Exit Sub
        End If

        'check Phone Number
        If txtphone.Text = "" Then
            MsgBox("Phone Number Cannot Be BLANK.", vbCritical, "Missing Phone Number")
            txtphone.Focus()
            Exit Sub
        End If

        'check City
        If txtcity.Text = "" Then
            MsgBox("City Cannot Be BLANK.", vbCritical, "Missing City")
            txtcity.Focus()
            Exit Sub
        End If

        'Check Country
        If txtcountry.Text = "" Then
            MsgBox("Country Cannot Be BLANK.", vbCritical, "Missing Country")
            txtcountry.Focus()
            Exit Sub
        End If

        'Check ID Number
        If txtidnumber.Text = "" Then
            MsgBox("ID Number Cannot Be BLANK.", vbCritical, "Missing ID Number")
            txtidnumber.Focus()
            Exit Sub
        End If

        ''check DOB
        'If dtpDOB.Text = "" Then
        '    Dim qn As VariantType = MsgBox("Date Of Birth is missing. Do you want to correct this error? Ignoring error will result in the default date '01/01/2000' being assigned to student", vbYesNo + vbQuestion, "Invalid Date")
        '    If qn = vbYes Then
        '        dtpDOB.Focus()

        '        Exit Sub
        '    Else
        '        dtpDOB.Text = "01/01/2000"
        '    End If
        'End If

        ''check Day/ Boarder status
        'If cboDayBorder.Text = "" Then
        '    Dim qn As VariantType = MsgBox("Day / Boarder not specified. Do you want to correct this error?", vbYesNo + vbQuestion, "Missing Data")
        '    If qn = vbYes Then
        '        cboDayBorder.Focus()
        '        Exit Sub
        '    Else
        '        cboDayBorder.Text = "NA"
        '    End If
        'End If

    End Sub

    Public Function DateDifference()
        Dim dt As Double
        Dim dateOne = dtcheckin.Value
        Dim dateTwo = dtcheckout.Value
        Dim diff As TimeSpan = dateTwo.Subtract(dateOne)
        Dim years As Double = diff.TotalDays / 365
        'txtyrs.Text = years.ToString
        'txtmonsh.Text = (years * 12).ToString
        'Label17.Text = diff.TotalDays.ToString
        dt = diff.TotalDays
        Return dt

    End Function
    Public Sub SaveGuest()
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("INSERT INTO Guest (first_name, last_name, address,  email, phone, city, country, id_number,tagnum) VALUES ('" + txtfname.Text + "','" + txtlname.Text + "', '" + txtaddress.Text + "', '" + txtemail.Text + "', '" + txtphone.Text + "', '" + txtcity.Text + "', '" + txtcountry.Text + "','" + txtidnumber.Text + "', '" + txttag.Text + "') ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            MsgBox("Record Saved successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
    End Sub

    Public Function getStamp()
        Dim tagnum As String
        tagnum = GetTimeStamp()
        Return tagnum
    End Function

    Public Sub getReservation()
        conn = GetConnect()
        ' Dim sqlAdapter As New SqlDataAdapter
        Dim sqlCommand As New SqlCommand("Select * from Reservation where guest_id = '" + txtguestid.Text + "'", conn)


        Dim myreader As SqlDataReader
        conn.Open()

        myreader = sqlCommand.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            lblrr.Text = myreader.Item("reservation_id").ToString

            conn.Close()
        End If

    End Sub
    Public Function GetGuestID()
        Dim guestid As String
        Dim command As SqlCommand
        Dim query As String = "SELECT guest_id FROM Guest where tagnum = '" + txttag.Text + "'"
        command = New SqlCommand(query, conn)
        conn.Open()
        Dim datareader As SqlDataReader = command.ExecuteReader()
        If datareader.Read() Then
            guestid = datareader.GetValue(0)
        End If
        datareader.Close()

        Return guestid

    End Function



    Public Sub SaveReservation()
        txtguestid.Text = GetGuestID()
        conn = GetConnect()
        Dim sqlCommand As New SqlCommand("INSERT INTO Reservation (guest_id, room_id, reservation_date,  check_in_date, check_outdate, adults, children, status, amount) VALUES ('" + txtguestid.Text + "','" & ComboBox1.Text & "', '" & Date.Now & "', '" & dtcheckin.Value & "', '" & dtcheckout.Value & "', '" + txtadults.Text + "', '" + txtchildren.Text + "','Booked', '" + lbltotal.Text + "') ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            'MsgBox("Record Saved successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
    End Sub



    Private Sub btnbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        txttag.Text = getStamp()
        checkEmptyFields()
        SaveGuest()
        ' GetGuestID()
        SaveReservation()

        'Create Invoice
        Dim newstamp As String
        newstamp = GetTimeStamp()
        txtreff.Text = newstamp

        lbltt.Text = lbltotal.Text
        getReservation()


    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

    End Sub

    Public Function roomtypeid()
        Dim x As Integer

        If cmbtype.Text = "Single" Then
            x = 1001
            Return x
        ElseIf cmbtype.Text = "Double" Then
            x = 1002
            Return x
        ElseIf cmbtype.Text = "Family" Then
            x = 1003
            Return x

        End If
    End Function


    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick
        Dim roomtype As Integer
        roomtype = roomtypeid()

        conn = GetConnect()
        Dim command As New SqlCommand("Select room_id From Room where room_type_id = '1001' and status_id = '1001' ")
        command.Connection = conn

        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        Adapter.Fill(table)

        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "room_id"
    End Sub
End Class