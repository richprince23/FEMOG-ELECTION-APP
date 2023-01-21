Imports System.IO
Imports System.Diagnostics


Public Class admin1

    Private Sub admin1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Private Sub admin1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Button1.Visible = False
        Button2.Visible = False
        Button4.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Form6.Show()
        Form6.Hide()
        Form8.Show()
        Form8.Hide()
        ComboBox1.Text = Date.Today.Year

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sdss1.Show()
        sdss1.Label19.Text = ComboBox1.Text & "  " & "FEMOG ELECTIONS"
        Label2.Text = TextBox1.Text
        Me.WindowState = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ve.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label2.Text = ""
        GroupBox1.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button4.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        VCM.Show()
        Me.WindowState = 1
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dialog1.Show()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If Form8.ListBox1.Items.Contains(TextBox1.Text) Then
            ErrorProvider1.Clear()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Form8.ListBox1.Items.Contains(TextBox1.Text) And Form8.ListBox2.Items.Contains(TextBox2.Text) Then

            Label2.Text = TextBox1.Text
            GroupBox1.Visible = False
            Button1.Visible = True
            Button2.Visible = True
            Button4.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            Label10.Text = ""
            Label9.Text = ""

            '//VOICE NOTIFICATION
            Dim sapi
            sapi = CreateObject("sapi.spvoice")
            sapi.speak("welcome to femog election suite, " & Label2.Text)
        ElseIf Not Form8.ListBox1.Items.Contains(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, " Incorrect Username !")
        ElseIf Not Form8.ListBox2.Items.Contains(TextBox2.Text) Then
            ErrorProvider2.SetError(TextBox2, "Incorrect Password !")
        ElseIf Form8.ListBox1.Items.Contains(TextBox1.Text) Then
            ErrorProvider1.Clear()
        ElseIf Form8.ListBox2.Items.Contains(TextBox2.Text) Then
            ErrorProvider2.Clear()
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Form6.Show()
        Form6.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form7.Show()
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form8.Show()
        Form8.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ResumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Visible = False

    End Sub

    Private Sub BTnHALLELECTIONS_Click(sender As Object, e As EventArgs) Handles BTnHALLELECTIONS.Click
        Try
            Dim expath As String = Path.Combine("C:\Program Files\Richprince Systems Inc\HALL ELECTIONS\", "ELECTION APP(ADD-ON) FOR HALLS.exe")
            Process.Start(expath)
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("There is a problem with the Add-On installation, kindly check and/or reinstall", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub
End Class
