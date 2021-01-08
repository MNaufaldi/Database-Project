<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class checkin_out
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcheckoutdate = New System.Windows.Forms.TextBox()
        Me.lblchildren = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbladults = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcheckindate = New System.Windows.Forms.TextBox()
        Me.txtroomnumber = New System.Windows.Forms.TextBox()
        Me.txtguestid = New System.Windows.Forms.TextBox()
        Me.txtreservationid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Hotel_System_Payment_DataSet = New hotelmanager.Hotel_System_Payment_DataSet()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New hotelmanager.Hotel_System_Payment_DataSetTableAdapters.PaymentTableAdapter()
        Me.listpayments = New System.Windows.Forms.ListView()
        Me.paymentid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.paymentref = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resevationid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.guestid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Hotel_System_Payment_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Use Reservation Number "
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(116, 28)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(79, 26)
        Me.btnsearch.TabIndex = 1
        Me.btnsearch.Text = "Search >>"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(255, 32)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(127, 20)
        Me.txtsearch.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblstatus)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtcheckoutdate)
        Me.GroupBox2.Controls.Add(Me.lblchildren)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lbladults)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtcheckindate)
        Me.GroupBox2.Controls.Add(Me.txtroomnumber)
        Me.GroupBox2.Controls.Add(Me.txtguestid)
        Me.GroupBox2.Controls.Add(Me.txtreservationid)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 202)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guest Details"
        '
        'txtcheckoutdate
        '
        Me.txtcheckoutdate.Enabled = False
        Me.txtcheckoutdate.Location = New System.Drawing.Point(408, 136)
        Me.txtcheckoutdate.Name = "txtcheckoutdate"
        Me.txtcheckoutdate.Size = New System.Drawing.Size(107, 20)
        Me.txtcheckoutdate.TabIndex = 14
        '
        'lblchildren
        '
        Me.lblchildren.AutoSize = True
        Me.lblchildren.Location = New System.Drawing.Point(490, 98)
        Me.lblchildren.Name = "lblchildren"
        Me.lblchildren.Size = New System.Drawing.Size(13, 13)
        Me.lblchildren.TabIndex = 13
        Me.lblchildren.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(424, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Children: "
        '
        'lbladults
        '
        Me.lbladults.AutoSize = True
        Me.lbladults.Location = New System.Drawing.Point(363, 98)
        Me.lbladults.Name = "lbladults"
        Me.lbladults.Size = New System.Drawing.Size(13, 13)
        Me.lbladults.TabIndex = 11
        Me.lbladults.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Adults: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Check Out Date"
        '
        'txtcheckindate
        '
        Me.txtcheckindate.Enabled = False
        Me.txtcheckindate.Location = New System.Drawing.Point(148, 136)
        Me.txtcheckindate.Name = "txtcheckindate"
        Me.txtcheckindate.Size = New System.Drawing.Size(107, 20)
        Me.txtcheckindate.TabIndex = 7
        '
        'txtroomnumber
        '
        Me.txtroomnumber.Enabled = False
        Me.txtroomnumber.Location = New System.Drawing.Point(148, 91)
        Me.txtroomnumber.Name = "txtroomnumber"
        Me.txtroomnumber.Size = New System.Drawing.Size(107, 20)
        Me.txtroomnumber.TabIndex = 6
        '
        'txtguestid
        '
        Me.txtguestid.Enabled = False
        Me.txtguestid.Location = New System.Drawing.Point(408, 40)
        Me.txtguestid.Name = "txtguestid"
        Me.txtguestid.Size = New System.Drawing.Size(107, 20)
        Me.txtguestid.TabIndex = 5
        '
        'txtreservationid
        '
        Me.txtreservationid.Enabled = False
        Me.txtreservationid.Location = New System.Drawing.Point(148, 40)
        Me.txtreservationid.Name = "txtreservationid"
        Me.txtreservationid.Size = New System.Drawing.Size(107, 20)
        Me.txtreservationid.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Check In Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Room Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Guest ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservation ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listpayments)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(562, 148)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Details"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(81, 115)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(422, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "If Payment Does Not Show Here Please Go To Payment Page and Process Payment >>"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CHECK IN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(417, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btncheckout
        '
        Me.btncheckout.Location = New System.Drawing.Point(225, 507)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(77, 31)
        Me.btncheckout.TabIndex = 5
        Me.btncheckout.Text = "CHECK OUT"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(324, 507)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 31)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Hotel_System_Payment_DataSet
        '
        Me.Hotel_System_Payment_DataSet.DataSetName = "Hotel_System_Payment_DataSet"
        Me.Hotel_System_Payment_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.Hotel_System_Payment_DataSet
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'listpayments
        '
        Me.listpayments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.paymentid, Me.paymentref, Me.guestid, Me.resevationid, Me.status})
        Me.listpayments.GridLines = True
        Me.listpayments.HideSelection = False
        Me.listpayments.Location = New System.Drawing.Point(28, 29)
        Me.listpayments.Name = "listpayments"
        Me.listpayments.Size = New System.Drawing.Size(509, 74)
        Me.listpayments.TabIndex = 7
        Me.listpayments.UseCompatibleStateImageBehavior = False
        Me.listpayments.View = System.Windows.Forms.View.Details
        '
        'paymentid
        '
        Me.paymentid.Text = "Payment ID"
        Me.paymentid.Width = 110
        '
        'paymentref
        '
        Me.paymentref.Text = "Payment Ref"
        Me.paymentref.Width = 121
        '
        'resevationid
        '
        Me.resevationid.DisplayIndex = 2
        Me.resevationid.Text = "Reservation ID"
        Me.resevationid.Width = 90
        '
        'guestid
        '
        Me.guestid.DisplayIndex = 3
        Me.guestid.Text = "Guest ID"
        Me.guestid.Width = 104
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(150, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "BOOKING STATUS:"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Blue
        Me.lblstatus.Location = New System.Drawing.Point(311, 181)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(35, 18)
        Me.lblstatus.TabIndex = 16
        Me.lblstatus.Text = "N/A"
        '
        'checkin_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 553)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "checkin_out"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHECK IN/CHECK OUT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Hotel_System_Payment_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcheckoutdate As TextBox
    Friend WithEvents lblchildren As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbladults As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcheckindate As TextBox
    Friend WithEvents txtroomnumber As TextBox
    Friend WithEvents txtguestid As TextBox
    Friend WithEvents txtreservationid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btncheckout As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Hotel_System_Payment_DataSet As Hotel_System_Payment_DataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As Hotel_System_Payment_DataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents listpayments As ListView
    Friend WithEvents paymentid As ColumnHeader
    Friend WithEvents paymentref As ColumnHeader
    Friend WithEvents resevationid As ColumnHeader
    Friend WithEvents guestid As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents lblstatus As Label
    Friend WithEvents Label7 As Label
End Class
