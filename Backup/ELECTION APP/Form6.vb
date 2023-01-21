Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'selecting typed name

        If ListBox1.Items.Contains(TextBox1.Text) Then
            MsgBox("Voter ID exists!", MsgBoxStyle.Information)
            ListBox1.SelectedItem = TextBox1.Text
        Else
            MsgBox("Voter ID does not exist!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Form6_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '// write to textfile
        Dim strwtr2 As New IO.StreamWriter(idnos)
        For Each id In ListBox1.Items
            strwtr2.WriteLine(id)
        Next
        strwtr2.Close()

    End Sub

    Private Sub Form6_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.F4 Then
            Me.Hide()
        End If


    End Sub

    Private Sub Form6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
     
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If IO.File.Exists(idnos) Then
                ListBox1.Items.AddRange(IO.File.ReadAllLines(idnos))
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Me.Hide()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Try
            ListBox1.ClearSelected()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click

        Try
            ListBox1.ClearSelected()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DeleteEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteEntryToolStripMenuItem.Click
        Try
            Dim ax As Integer = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(ax)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortToolStripMenuItem.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        Try
            ListBox1.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
    End Sub
End Class