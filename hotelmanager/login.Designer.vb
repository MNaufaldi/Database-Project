<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(174, 148)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(180, 26)
        Me.txtusername.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(174, 203)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(111)
        Me.txtpassword.Size = New System.Drawing.Size(180, 26)
        Me.txtpassword.TabIndex = 1
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(145, 275)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(91, 33)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(292, 275)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(93, 33)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(171, 242)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(51, 17)
        Me.lblerror.TabIndex = 5
        Me.lblerror.Text = "Label1"
        Me.lblerror.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.hotelmanager.My.Resources.Resources.keys
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(516, 489)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 492)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblerror As Label
End Class
