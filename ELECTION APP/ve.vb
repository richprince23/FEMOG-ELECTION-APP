Imports System.Data.SqlServerCe

Public Class ve

    Public Function MVLFT(ByVal Text As String)
        Dim str1 As String = Text.Remove(0, 1)
        Dim str2 As String = Text(0)
        Return str1 & str2
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' On Error Resume Next
        'If Form6.ListBox1.Items.Contains(TextBox1.Text) Then
        '    Form6.ListBox1.SelectedItem = TextBox1.Text
        '    Form6.ListBox1.Items.Remove(Form6.ListBox1.SelectedItem)
        '    enablebtns()
        '    Form1.Show()
        '    Me.Close()
        '    'delete 
        '    '// write to textfile( update idnos after deletion
        '    Dim strwtr2 As New IO.StreamWriter(idnos)
        '    For Each id In Form6.ListBox1.Items
        '        strwtr2.WriteLine(id)
        '    Next
        '    strwtr2.Close()
        'Else
        '    MsgBox("Please Enter A Valid ID Number.", MsgBoxStyle.Critical)
        'End If
        Try
            'For Each row As DataGridViewRow In Form6.DataGridView1.Rows

            'If row.Cells(0).Value.ToString = TextBox1.Text Then
            '    Dim _index As Integer = row.Index
            '    row.Selected = True

            '    ' Form6.DataGridView1.Rows(_index).Selected = True
            '    '' delete verified voter
            '    enablebtns()
            '    Form1.Show()
            '    Me.Close()
            Dim cn As New SqlCeConnection
            Dim cmmd As New SqlCeCommand
            cmmd.CommandText = ("SELECT * FROM data WHERE id ='" + TextBox1.Text + "'")
            cmmd.Connection = cn
            cn.ConnectionString = My.Settings.regConnectionString
            cn.Open()
            'reading data( searching and displaying)
            Dim rd As SqlCeDataReader = cmmd.ExecuteReader
            If rd.Read Then



                Dim con As New SqlCeConnection
                Dim cmd As New SqlCeCommand
                con.ConnectionString = My.Settings.regConnectionString
                cmd.Connection = con
                cmd.CommandText = "DELETE FROM data Where id='" + TextBox1.Text + "'"
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                enablebtns()
                Form1.Show()
                Me.Close()
                Form6.DataGridView1.Update()
                If Form6.Visible = True Then
                    Form6.Close()
                    Form6.Show()
                End If
            End If
            cn.Close()
           ' Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub ve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tm1.Start()
        TextBox1.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub tm1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm1.Tick

        Label1.Text = MVLFT(Label1.Text)
        Me.Text = (MVLFT(Me.Text))

    End Sub
End Class