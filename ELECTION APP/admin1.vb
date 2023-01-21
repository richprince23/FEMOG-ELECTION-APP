Imports System.IO
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe


Public Class admin1


    Dim drag As Boolean
    Dim mx As Integer
    Dim msy As Integer


    Public Sub SAVE()
        For Each FF As Form In Application.OpenForms
            My.Settings.Save()
        Next
    End Sub
    Private Sub admin1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SAVE()

    End Sub
    Private Sub admin1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Button1.Visible = False
        Button2.Visible = False
        Button4.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button10.Visible = False
        
        Form8.Show()
        Form8.Hide()
        ComboBox1.Text = Date.Today.Year
        '// DISABLE VOTE BUTTONS FROM MODULE MDHP2

        disablebtns()

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
        Button10.Visible = False
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

        'If Form8.ListBox1.Items.Contains(TextBox1.Text) And Form8.ListBox2.Items.Contains(TextBox2.Text) Then

        '    Label2.Text = TextBox1.Text
        '    GroupBox1.Visible = False
        '    Button1.Visible = True
        '    Button2.Visible = True
        '    Button4.Visible = True
        '    Button7.Visible = True
        '    Button8.Visible = True
        '    Label10.Text = ""
        '    Label9.Text = ""

        '    '//VOICE NOTIFICATION
        '    Dim sapi
        '    sapi = CreateObject("sapi.spvoice")
        '    sapi.speak("welcome to femog election suite, " & Label2.Text)
        'ElseIf Not Form8.ListBox1.Items.Contains(TextBox1.Text) Then
        '    ErrorProvider1.SetError(TextBox1, " Incorrect Username !")
        'ElseIf Not Form8.ListBox2.Items.Contains(TextBox2.Text) Then
        '    ErrorProvider2.SetError(TextBox2, "Incorrect Password !")
        'ElseIf Form8.ListBox1.Items.Contains(TextBox1.Text) Then
        '    ErrorProvider1.Clear()
        'ElseIf Form8.ListBox2.Items.Contains(TextBox2.Text) Then
        '    ErrorProvider2.Clear()
        'End If
        Try
            Dim cmd As SqlCeCommand = New SqlCeCommand
            Dim CN As New SqlCeConnection

            cmd.CommandText = ("SELECT * FROM login WHERE usrn ='" + TextBox1.Text + "'and " + "pswd='" + TextBox2.Text + "'")
            cmd.Connection = CN
            CN.ConnectionString = My.Settings.regConnectionString
            CN.Open()
            'reading data( searching and displaying)
            Dim rd As SqlCeDataReader = cmd.ExecuteReader
            If rd.Read Then

                ErrorProvider1.Clear()
                ErrorProvider2.Clear()
                Label2.Text = TextBox1.Text
                GroupBox1.Visible = False
                Button1.Visible = True
                Button2.Visible = True
                Button4.Visible = True
                Button7.Visible = True
                Button8.Visible = True
                Button10.Visible = True
                Label10.Text = ""
                Label9.Text = ""

                'Regist.ToolStripStatusLabel2.Text = "Admin : " & TextBox7.Text
            Else
                ErrorProvider1.SetError(TextBox1, "Check")
                ErrorProvider2.SetError(TextBox2, "Check")

            End If

            CN.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

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

    Private Sub ResumeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResumeToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
        Me.Visible = False
        My.Settings.Save()
    End Sub

    Private Sub BTnHALLELECTIONS_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim expath As String = Path.Combine("C:\Program Files\Richprince Systems Inc\HALL ELECTIONS\", "HALL SUITE.exe")
            Process.Start(expath)
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("There is a problem with the Add-On installation, kindly check and/or reinstall", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub btnResetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetData.Click
        On Error Resume Next
        My.Settings.Reset()
        cleardata()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mx = Cursor.Position.X - Me.Left
        msy = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - msy
            Me.Left = Cursor.Position.X - mx

        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        voter_details.Show()
    End Sub
End Class
