Imports System.Windows.Forms

Public Class mainMenu

    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
    '    ' Create a new instance of the child form.
    '    Dim ChildForm As New System.Windows.Forms.Form
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Window " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub

    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
    '    Dim OpenFileDialog As New OpenFileDialog
    '    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    '    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = OpenFileDialog.FileName
    '        ' TODO: Add code here to open the file.
    '    End If
    'End Sub



    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub







    'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
    '    ' Close all child forms of the parent.
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    'End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        login.Show()
        Me.Close()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingToolStripMenuItem.Click
        Dim frm As New booking()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CheckInCheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInCheckOutToolStripMenuItem.Click
        Dim frm As New checkin_out()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AddRoomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRoomsToolStripMenuItem.Click
        Dim frm As New Addrooms()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentsToolStripMenuItem.Click
        Dim frm As New Payments()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
