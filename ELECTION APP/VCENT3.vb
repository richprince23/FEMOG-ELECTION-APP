Public Class VCENT3
    Private xmlfile As String
    Private Sub VCENT3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormSerialisation.FormSerialisor.Serialise(Me, xmlfile)
    End Sub
    Private Sub vcENT3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        xmlfile = Application.StartupPath & "\" + Me.Label7.Text + ".xml"
        FormSerialisation.FormSerialisor.Deserialise(Me, xmlfile)

        With ENT3
            Label1.Text = .TextBox1.Text
            Label2.Text = .TextBox2.Text
            Label3.Text = .TextBox3.Text
            Label4.Text = .TextBox4.Text
            Label5.Text = .TextBox5.Text
            Label6.Text = .TextBox6.Text

        End With

        With ENT3.ComboBox1
            If .Text = "6" Then
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
            ElseIf .Text = "5" Then
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormSerialisation.FormSerialisor.Serialise(Me, xmlfile)

        Me.Hide()
    End Sub
End Class