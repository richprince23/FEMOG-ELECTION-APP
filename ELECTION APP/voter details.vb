Public Class voter_details

    Private Sub voter_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegDataSet2.data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.RegDataSet2.data)

    End Sub
End Class