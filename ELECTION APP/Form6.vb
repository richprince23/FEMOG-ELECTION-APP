Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'selecting typed name

        'If ListBox1.Items.Contains(TextBox1.Text) Then
        '    MsgBox("Voter ID exists!", MsgBoxStyle.Information)
        '    ListBox1.SelectedItem = TextBox1.Text
        'Else
        '    MsgBox("Voter ID does not exist!", MsgBoxStyle.Exclamation)
        'End If


        On Error Resume Next
        'Dim dgv As DataGridView = DataGridView1
        'Dim temp As Integer = 0
        'For i As Integer = 0 To dgv.RowCount - 1
        '    For j As Integer = 0 To dgv.ColumnCount - 1
        '        If dgv.Rows(i).Cells(j).Value.ToString = TextBox1.Text Then
        '            MsgBox("Item found")

        '        End If
        '        temp = 1
        '        If temp = 0 Then
        '            MsgBox("Item not found")
        '        End If

        '    Next
        'Next

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.Cells(0).Value.ToString = TextBox1.Text Then  
            Dim _index As Integer = row.Index
            row.Selected = True
            DataGridView1.Rows(_index).Selected = True

            End If

        Next
    End Sub

    Private Sub Form6_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
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
        'TODO: This line of code loads data into the 'RegDataSet4.data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter1.Fill(Me.RegDataSet4.data)
        'TODO: This line of code loads data into the 'RegDataSet3.data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.RegDataSet3.data)
        DataGridView1.ClearSelection()
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
            DataGridView1.ClearSelection()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click

        Try
            ListBox1.ClearSelected()
            DataGridView1.ClearSelection()
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

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.ResetText()
        DataGridView1.ClearSelection()
    End Sub

 End Class