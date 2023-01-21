Public Class Form9
    Private tm As Integer
    Private ds As Integer = 0
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ProgressBar1
            .Maximum = 100
            .Minimum = 0
            .Value = 0
            Timer1.Enabled = True

            Timer1.Start()

            Timer1.Interval = 10
            Label1.Text = "Saving User Data..."
            Me.Text = Label1.Text
            Label2.Text = ds
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + 1

            End If
            If ProgressBar1.Value = 100 Then
                Label1.Text = "Saving Complete."
                Me.Text = Label1.Text
            End If
            Label2.Text = Label2.Text + 1
            If Label2.Text = "200" Then
                Me.Close()
                admin1.Close()
            End If
        Catch ex As Exception

        End Try



    End Sub
End Class