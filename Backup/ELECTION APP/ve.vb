Public Class ve

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Form6.ListBox1.Items.Contains(TextBox1.Text) Then

            NN = TextBox1.Text
            Form1.Show()
            Me.Close()
        Else
            MsgBox("Please Enter A Valid ID No.", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub ve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class