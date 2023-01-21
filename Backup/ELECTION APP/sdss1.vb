Public Class sdss1
    Public Y1 As String = "2016"
    Public Y2 As String = "2017"
    Public C1 As String = "SCIENCE"
    Public C1S As String = "SC"
    Public C2 As String = "GENERAL"
    Public rs As String
    Private rc As Integer
    Public C2S As String = "GN"
    



    Private Sub sdss1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' clear name
        Dim strwtr As New IO.StreamWriter(nms)
        For Each nam In ListBox1.Items
            strwtr.WriteLine(nam)
        Next
        strwtr.Close()

    End Sub

    Private Sub sdss1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label15.Text = admin1.TextBox1.Text

            Timer1.Enabled = True
            Timer1.Start()

            '// load listbox items
            
            If IO.File.Exists(nms) Then
                ListBox1.Items.AddRange(IO.File.ReadAllLines(nms))
                Dim rsc As Integer = ListBox1.Items.Count
                Label18.Text = rsc
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            '//generate id no.'

            If TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox1.Text <> "" And ComboBox2.Text <> "" And TextBox4.Text <> "" And ComboBox1.Items.Contains(ComboBox1.Text) Then
                '/ items to listbox1
                ListBox1.Items.Add(TextBox1.Text & "          " & TextBox2.Text & "         " & TextBox3.Text)
                If Label4.Text = C1 Then
                    Dim aa As String = ComboBox1.Text & TextBox4.Text & C1S
                    Label12.Text = aa
                    Form6.ListBox1.Items.Add(ComboBox1.Text & TextBox4.Text & C1S)

                  
                Else
                    Dim bb As String = ComboBox1.Text & TextBox4.Text & C2S
                    Label12.Text = bb
                    Form6.ListBox1.Items.Add(ComboBox1.Text & TextBox4.Text & C2S)

                  
                End If

                '// write to textfile
                Dim strwtr2 As New IO.StreamWriter(idnos)
                For Each id In Form6.ListBox1.Items
                    strwtr2.WriteLine(id)
                Next
                strwtr2.Close()


                ' clear name
                Dim strwtr As New IO.StreamWriter(nms)
                For Each nam In ListBox1.Items
                    strwtr.WriteLine(nam)
                Next
                strwtr.Close()


                '//count registered  

                rc = ListBox1.Items.Count
                Label18.Text = rc

                ErrorProvider1.Clear()
                ErrorProvider2.Clear()
            ElseIf Not IsNumeric(ComboBox2.Text) Then
                ErrorProvider1.SetError(ComboBox2, "Enter A valid Year")
            ElseIf IsNumeric(ComboBox2.Text) Then
                ErrorProvider1.Clear()
            ElseIf TextBox1.Text = "" Then
                MsgBox("Required Field!", MsgBoxStyle.Critical)
            ElseIf TextBox2.Text = "" Then
                MsgBox("Required Field!", MsgBoxStyle.Critical)
            ElseIf TextBox4.Text = "" Then
                ErrorProvider1.SetError(TextBox4, "Required Field!")
            ElseIf TextBox4.Text <> "" Then
                ErrorProvider1.Clear()
            ElseIf Not ComboBox1.Items.Contains(ComboBox1.Text) Then
                ErrorProvider2.SetError(ComboBox1, "Incorrect Data")
            ElseIf ComboBox1.Items.Contains(ComboBox1.Text) Then
                ErrorProvider2.Clear()

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label16.Text = TimeOfDay

    End Sub

    Private Sub ControlPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlPanelToolStripMenuItem.Click
        admin1.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DeleteEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteEntryToolStripMenuItem.Click
        Try
            Dim ab As Integer = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(ab)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.LostFocus
        'SPECIFY COURSE'
        With ComboBox1
            If .Text = "1A" Or .Text = "1B" Or .Text = "2A" Or .Text = "2B" Then
                Label4.Text = C1
            Else
                Label4.Text = C2
            End If
        End With
        If Not ComboBox1.Items.Contains(ComboBox1.Text) Then
            ErrorProvider1.SetError(ComboBox1, "Incorrect Data")
        ElseIf ComboBox1.Items.Contains(ComboBox1.Text) Then
            ErrorProvider1.Clear()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'SPECIFY COURSE'
        With ComboBox1

            If .Text = "1A" Or .Text = "1B" Or .Text = "2A" Or .Text = "2B" Then
                Label4.Text = C1
            Else
                Label4.Text = C2
            End If
        End With
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            Clipboard.SetText(String.Join(Environment.NewLine, ListBox1.SelectedItems.Cast(Of String).ToArray))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SortAscendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortAscendingToolStripMenuItem.Click
        ListBox1.Sorted = True
        SortAscendingToolStripMenuItem.CheckOnClick = True
    End Sub

    Private Sub SortDescendingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListBox1.Sorted = True
    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        With TextBox4
            If .TextLength = 3 Then
                .Text = .Text
            ElseIf .TextLength = 2 Then
                .Text = "0" & .Text
            ElseIf .TextLength = 1 Then
                .Text = "00" & .Text
            End If
        End With
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Not IsNumeric(TextBox4.Text) Then
            ErrorProvider1.SetError(TextBox4, "Please enter a 3-digit number")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub VoteResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoteResultsToolStripMenuItem.Click
        VCM.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            PrintDocument1.Print()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim fnt As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
            Dim lstbx As String = String.Empty
            For Each lbit As String In ListBox1.Items
                lstbx = lstbx & vbCrLf.Length & lbit
            Next
            lstbx = lstbx.Substring(vbCrLf.Length)
            e.Graphics.DrawString(lstbx, fnt, Brushes.Black, 0, 0)
            e.HasMorePages = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.LostFocus
        If Not IsNumeric(ComboBox2.Text) Then
            ErrorProvider1.SetError(ComboBox2, "Incorrect Data")
        ElseIf IsNumeric(ComboBox2.Text) Then
            ErrorProvider1.Clear()
        End If

    End Sub

    Private Sub ComboBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged
        If Not IsNumeric(ComboBox2.Text) And ComboBox2.SelectedText.StartsWith("20") Then
            ErrorProvider1.SetError(ComboBox2, "Enter A valid Year")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Label12.Text = "........."
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        '// clear all fields(reset)    
        Label4.Text = ""
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class

