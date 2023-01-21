Public Class vc9

    Private Sub vc9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With vp5.ComboBox1
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
    End Sub
End Class