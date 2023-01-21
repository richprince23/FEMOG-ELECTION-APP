

Public Class Form8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If TextBox1.Text = "" Then
        '    ErrorProvider1.SetError(TextBox1, "Field Required")
        '    Label5.Text = "Field Required !!!"
        'ElseIf TextBox2.Text = "" Then
        '    ErrorProvider2.SetError(TextBox2, "Field Required")
        '    Label6.Text = "Field Required !!!"
        'ElseIf TextBox3.Text <> "FEMOGFECFOSCO" Then
        '    ErrorProvider3.SetError(TextBox3, "Incorrect Password")
        '    Label7.Text = "Incorrect Password !!!"
        'Else
        '    ErrorProvider1.Clear()
        '    Label5.Text = ""
        '    Label6.Text = ""
        '    Label7.Text = ""
        '    Dim sapi
        '    sapi = CreateObject("sapi.spvoice")
        '    sapi.speak("account creation successful")
        '    MsgBox("Admin Creation Successful!")
        '    ListBox1.Items.Add(TextBox1.Text)
        '    ListBox2.Items.Add(TextBox2.Text)

        '    Dim mcw As New IO.StreamWriter(users)
        '    Dim msw2 As New IO.StreamWriter(pass)

        '    For Each cwit In ListBox1.Items
        '        mcw.WriteLine(cwit)
        '    Next
        '    mcw.Close()

        '    For Each pss In ListBox2.Items
        '        msw2.WriteLine(pss)
        '    Next
        '    msw2.Close()

        '    TextBox1.Text = ""
        '    TextBox2.Text = ""
        '    TextBox3.Text = ""
        '    Me.Hide()

        'End If

    End Sub

    Private Sub Form8_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


    End Sub

    Private Sub Form8_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.F4 Then
            Me.Hide()
        End If
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Try
            If IO.File.Exists(users) Then

                ListBox1.Items.AddRange(IO.File.ReadAllLines(users))
            End If

            If IO.File.Exists(pass) Then
                ListBox2.Items.AddRange(IO.File.ReadAllLines(pass))
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub SortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortToolStripMenuItem.Click
        ListBox1.Sorted = True
        SortToolStripMenuItem.CheckOnClick = True
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Dim c As Integer = ListBox1.Items.Count
        Dim i As Integer = ListBox1.SelectedIndex
        Try
            If ListBox1.SelectedIndex = i Then
                ListBox1.Items.RemoveAt(i)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
    End Sub
End Class