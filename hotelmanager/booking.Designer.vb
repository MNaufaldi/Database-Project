<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnbook = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidnumber = New System.Windows.Forms.TextBox()
        Me.txtcountry = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtchildren = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtadults = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtcheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtcheckin = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.LinkLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblvat = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblroomamnt = New System.Windows.Forms.LinkLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.txttag = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtguestid = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblrr = New System.Windows.Forms.Label()
        Me.lbltt = New System.Windows.Forms.LinkLabel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtreff = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Hotel_System_Payment_DataSet1 = New hotelmanager.Hotel_System_Payment_DataSet()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Hotel_System_Payment_DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbook
        '
        Me.btnbook.Location = New System.Drawing.Point(176, 414)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(73, 27)
        Me.btnbook.TabIndex = 0
        Me.btnbook.Text = "BOOK"
        Me.btnbook.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidnumber)
        Me.GroupBox1.Controls.Add(Me.txtcountry)
        Me.GroupBox1.Controls.Add(Me.txtcity)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Guest Details"
        '
        'txtidnumber
        '
        Me.txtidnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidnumber.Location = New System.Drawing.Point(353, 173)
        Me.txtidnumber.Name = "txtidnumber"
        Me.txtidnumber.Size = New System.Drawing.Size(127, 22)
        Me.txtidnumber.TabIndex = 15
        '
        'txtcountry
        '
        Me.txtcountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcountry.Location = New System.Drawing.Point(353, 133)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(127, 22)
        Me.txtcountry.TabIndex = 14
        '
        'txtcity
        '
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(353, 93)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(127, 22)
        Me.txtcity.TabIndex = 13
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(353, 47)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(127, 22)
        Me.txtphone.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(259, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "ID Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(259, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Country"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(259, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone No."
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(110, 174)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(111, 22)
        Me.txtemail.TabIndex = 7
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(110, 134)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(111, 22)
        Me.txtaddress.TabIndex = 6
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(110, 94)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(111, 22)
        Me.txtlname.TabIndex = 5
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(110, 47)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(111, 22)
        Me.txtfname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtchildren)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtadults)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbtype)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(556, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 114)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room Details"
        '
        'txtchildren
        '
        Me.txtchildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchildren.Location = New System.Drawing.Point(228, 79)
        Me.txtchildren.Name = "txtchildren"
        Me.txtchildren.Size = New System.Drawing.Size(51, 22)
        Me.txtchildren.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(157, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Children"
        '
        'txtadults
        '
        Me.txtadults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadults.Location = New System.Drawing.Point(84, 79)
        Me.txtadults.Name = "txtadults"
        Me.txtadults.Size = New System.Drawing.Size(51, 22)
        Me.txtadults.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Adults"
        '
        'cmbtype
        '
        Me.cmbtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Single", "Double", "Family", "Delux"})
        Me.cmbtype.Location = New System.Drawing.Point(131, 31)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(148, 24)
        Me.cmbtype.TabIndex = 1
        Me.cmbtype.Text = "Choose Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Room Type"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtcheckout)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.dtcheckin)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(556, 197)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(318, 96)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Check In Details"
        '
        'dtcheckout
        '
        Me.dtcheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtcheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtcheckout.Location = New System.Drawing.Point(131, 61)
        Me.dtcheckout.Name = "dtcheckout"
        Me.dtcheckout.Size = New System.Drawing.Size(181, 22)
        Me.dtcheckout.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Check Out Date"
        '
        'dtcheckin
        '
        Me.dtcheckin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtcheckin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtcheckin.Location = New System.Drawing.Point(131, 22)
        Me.dtcheckin.Name = "dtcheckin"
        Me.dtcheckin.Size = New System.Drawing.Size(181, 22)
        Me.dtcheckin.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Check In Date"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbltotal)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.lblvat)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lblroomamnt)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(556, 324)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(319, 151)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cost"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Enabled = False
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(224, 109)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(55, 24)
        Me.lbltotal.TabIndex = 5
        Me.lbltotal.TabStop = True
        Me.lbltotal.Text = "00.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 24)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "TOTAL AMOUNT"
        '
        'lblvat
        '
        Me.lblvat.AutoSize = True
        Me.lblvat.Enabled = False
        Me.lblvat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvat.Location = New System.Drawing.Point(224, 71)
        Me.lblvat.Name = "lblvat"
        Me.lblvat.Size = New System.Drawing.Size(55, 24)
        Me.lblvat.TabIndex = 3
        Me.lblvat.TabStop = True
        Me.lblvat.Text = "00.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 24)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "V.A.T 15%"
        '
        'lblroomamnt
        '
        Me.lblroomamnt.AutoSize = True
        Me.lblroomamnt.Enabled = False
        Me.lblroomamnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroomamnt.Location = New System.Drawing.Point(224, 32)
        Me.lblroomamnt.Name = "lblroomamnt"
        Me.lblroomamnt.Size = New System.Drawing.Size(55, 24)
        Me.lblroomamnt.TabIndex = 1
        Me.lblroomamnt.TabStop = True
        Me.lblroomamnt.Text = "00.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ROOM AMOUNT"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(282, 414)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 27)
        Me.btnclear.TabIndex = 5
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(386, 414)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 27)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btncheck
        '
        Me.btncheck.Location = New System.Drawing.Point(81, 414)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(75, 27)
        Me.btncheck.TabIndex = 7
        Me.btncheck.Text = "CHECK"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'txttag
        '
        Me.txttag.Enabled = False
        Me.txttag.Location = New System.Drawing.Point(405, 464)
        Me.txttag.Name = "txttag"
        Me.txttag.Size = New System.Drawing.Size(100, 20)
        Me.txttag.TabIndex = 8
        Me.txttag.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(449, 78)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Room Number "
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(225, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(175, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Choose Room Number "
        '
        'txtguestid
        '
        Me.txtguestid.Enabled = False
        Me.txtguestid.Location = New System.Drawing.Point(274, 464)
        Me.txtguestid.Name = "txtguestid"
        Me.txtguestid.Size = New System.Drawing.Size(100, 20)
        Me.txtguestid.TabIndex = 10
        Me.txtguestid.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblrr)
        Me.GroupBox6.Controls.Add(Me.lbltt)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.GroupBox9)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtreff)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Location = New System.Drawing.Point(932, 62)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(215, 412)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        '
        'lblrr
        '
        Me.lblrr.AutoSize = True
        Me.lblrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrr.Location = New System.Drawing.Point(19, 211)
        Me.lblrr.Name = "lblrr"
        Me.lblrr.Size = New System.Drawing.Size(186, 20)
        Me.lblrr.TabIndex = 8
        Me.lblrr.Text = "Reservation Number "
        '
        'lbltt
        '
        Me.lbltt.AutoSize = True
        Me.lbltt.Location = New System.Drawing.Point(138, 333)
        Me.lbltt.Name = "lbltt"
        Me.lbltt.Size = New System.Drawing.Size(34, 13)
        Me.lbltt.TabIndex = 7
        Me.lbltt.TabStop = True
        Me.lbltt.Text = "00.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 333)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "TOTAL AMOUNT"
        '
        'GroupBox9
        '
        Me.GroupBox9.Location = New System.Drawing.Point(2, 107)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(213, 10)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(42, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(130, 26)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Please Make Sure to Pay " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Bill Before Check In"
        '
        'txtreff
        '
        Me.txtreff.Enabled = False
        Me.txtreff.Location = New System.Drawing.Point(109, 77)
        Me.txtreff.Name = "txtreff"
        Me.txtreff.Size = New System.Drawing.Size(100, 20)
        Me.txtreff.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "REFERENCE NO."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(32, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "HOTEL MANAGMENT SYSTEM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(20, 382)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(189, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Please Keep This Invoice Its Important"
        '
        'Hotel_System_Payment_DataSet1
        '
        Me.Hotel_System_Payment_DataSet1.DataSetName = "Hotel_System_Payment_DataSet"
        Me.Hotel_System_Payment_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(932, 108)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(215, 10)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Location = New System.Drawing.Point(932, 426)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(212, 10)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        '
        'booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 559)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.txtguestid)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txttag)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnbook)
        Me.Name = "booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOOKING"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Hotel_System_Payment_DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbook As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidnumber As TextBox
    Friend WithEvents txtcountry As TextBox
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtchildren As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtadults As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbtype As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtcheckout As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents dtcheckin As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbltotal As LinkLabel
    Friend WithEvents Label16 As Label
    Friend WithEvents lblvat As LinkLabel
    Friend WithEvents Label15 As Label
    Friend WithEvents lblroomamnt As LinkLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btncheck As Button
    Friend WithEvents txttag As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtguestid As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbltt As LinkLabel
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtreff As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Hotel_System_Payment_DataSet1 As Hotel_System_Payment_DataSet
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblrr As Label
End Class
