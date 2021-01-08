<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Addrooms
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cmblevel = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Access Level"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(147, 48)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(121, 20)
        Me.txtusername.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(147, 108)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(121, 20)
        Me.txtpassword.TabIndex = 5
        '
        'cmblevel
        '
        Me.cmblevel.FormattingEnabled = True
        Me.cmblevel.Items.AddRange(New Object() {"admin", "user"})
        Me.cmblevel.Location = New System.Drawing.Point(147, 182)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(121, 21)
        Me.cmblevel.TabIndex = 6
        Me.cmblevel.Text = "Choose Level"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(87, 310)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(269, 310)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmblevel)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 252)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New User"
        '
        'Addrooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 370)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "Addrooms"
        Me.Text = "Add Users"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents cmblevel As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
