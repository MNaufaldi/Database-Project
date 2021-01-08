<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcheckout = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcheckin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbooked = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtguestid = New System.Windows.Forms.TextBox()
        Me.txtreservationid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtpayref = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Guest  Reservation Record"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(266, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "<< Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(83, 22)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(111, 22)
        Me.txtsearch.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcheckout)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtcheckin)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtbooked)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtguestid)
        Me.GroupBox2.Controls.Add(Me.txtreservationid)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reservation Details"
        '
        'txtcheckout
        '
        Me.txtcheckout.Enabled = False
        Me.txtcheckout.Location = New System.Drawing.Point(123, 141)
        Me.txtcheckout.Name = "txtcheckout"
        Me.txtcheckout.Size = New System.Drawing.Size(95, 20)
        Me.txtcheckout.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Check Out Date"
        '
        'txtcheckin
        '
        Me.txtcheckin.Enabled = False
        Me.txtcheckin.Location = New System.Drawing.Point(344, 93)
        Me.txtcheckin.Name = "txtcheckin"
        Me.txtcheckin.Size = New System.Drawing.Size(100, 20)
        Me.txtcheckin.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Check In Date"
        '
        'txtbooked
        '
        Me.txtbooked.Enabled = False
        Me.txtbooked.Location = New System.Drawing.Point(123, 93)
        Me.txtbooked.Name = "txtbooked"
        Me.txtbooked.Size = New System.Drawing.Size(95, 20)
        Me.txtbooked.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Booked On"
        '
        'txtguestid
        '
        Me.txtguestid.Enabled = False
        Me.txtguestid.Location = New System.Drawing.Point(341, 46)
        Me.txtguestid.Name = "txtguestid"
        Me.txtguestid.Size = New System.Drawing.Size(103, 20)
        Me.txtguestid.TabIndex = 3
        '
        'txtreservationid
        '
        Me.txtreservationid.Enabled = False
        Me.txtreservationid.Location = New System.Drawing.Point(123, 46)
        Me.txtreservationid.Name = "txtreservationid"
        Me.txtreservationid.Size = New System.Drawing.Size(95, 20)
        Me.txtreservationid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Guest ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(27, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservation ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtpayref)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 63)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtpayref
        '
        Me.txtpayref.Location = New System.Drawing.Point(251, 27)
        Me.txtpayref.Name = "txtpayref"
        Me.txtpayref.Size = New System.Drawing.Size(134, 20)
        Me.txtpayref.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Please Enter Payment Reference "
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(85, 459)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(216, 459)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(348, 459)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 521)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Payments"
        Me.Text = "Payments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtreservationid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtguestid As TextBox
    Friend WithEvents txtcheckout As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcheckin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbooked As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtpayref As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btncancel As Button
End Class
