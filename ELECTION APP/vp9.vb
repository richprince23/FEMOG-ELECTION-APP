Imports election_app.FormSerialisation

Public Class vp9
    Public xmlfile As String

    Private Sub vp9_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        FormSerialisor.Serialise(Me, xmlfile)
    End Sub

    Private Sub vp9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        xmlfile = Application.StartupPath & "\" + Me.Label7.Text + ".xml"
        FormSerialisor.Deserialise(Me, xmlfile)

        With Form1
            Label1.Text = .TextBox1.Text
            Label2.Text = .TextBox2.Text
            Label3.Text = .TextBox3.Text
            Label4.Text = .TextBox4.Text
            Label5.Text = .TextBox5.Text
            Label6.Text = .TextBox6.Text

        End With


        With Form1.ComboBox1
            If .Text = "5" Then
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = False
            ElseIf .Text = "4" Then
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = False
                Label6.Visible = False
            ElseIf .Text = "3" Then
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
            ElseIf .Text = "2" Then
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
            ElseIf .Text = "1" Then
                Label1.Visible = True
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
            End If
        End With
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        FormSerialisor.Serialise(Me, xmlfile)

        Me.Hide()
    End Sub

    Private Sub Label6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cleardata()
    End Sub
End Class