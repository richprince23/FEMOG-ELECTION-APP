Imports System.IO

Public Class Form2
    Private a1 As Double = 0
    Private a2 As Double = 0
    Private a3 As Double = 0
    Private a4 As Double = 0
    Private a5 As Double = 0
    Private a6 As Double = 0
    Private p1 As String = Application.StartupPath & "\pe1.jpg"
    Private p2 As String = Application.StartupPath & "\pe2.jpg"
    Private p3 As String = Application.StartupPath & "\pe3.jpg"
    Private p4 As String = Application.StartupPath & "\pe4.jpg"
    Private p5 As String = Application.StartupPath & "\pe5.jpg"
    Private p6 As String = Application.StartupPath & "\pe6.jpg"
    Private Sub RegisterNewAspirantsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterNewAspirantsToolStripMenuItem.Click
        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        Button1.Visible = True
        ComboBox1.Visible = True
        Label2.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True
        LinkLabel5.Visible = True
        LinkLabel6.Visible = True
        LinkLabel7.Visible = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With vc1
            .Label1.Text = TextBox1.Text
            .Label2.Text = TextBox2.Text
            .Label3.Text = TextBox3.Text
            .Label4.Text = TextBox4.Text
            .Label5.Text = TextBox5.Text
            .Label6.Text = TextBox6.Text

        End With
        Label2.Visible = False
        LinkLabel2.Visible = False
        LinkLabel3.Visible = False
        LinkLabel4.Visible = False
        LinkLabel5.Visible = False
        LinkLabel6.Visible = False
        LinkLabel7.Visible = False

        With ComboBox1
            If .Text = "" Then
                MsgBox("please Choose No. Of Aspirants", MsgBoxStyle.Critical)
            ElseIf .Text = "6" Then
                Button7.Visible = True
                Button6.Visible = True
                Button5.Visible = True
                Button4.Visible = True
                Button3.Visible = True
                Button2.Visible = True
                TextBox6.Visible = True
                TextBox5.Visible = True
                TextBox4.Visible = True
                TextBox3.Visible = True
                TextBox2.Visible = True
                TextBox1.Visible = True
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = True
                PictureBox6.Visible = True
            ElseIf .Text = "5" Then
                Button7.Visible = False
                Button6.Visible = True
                Button5.Visible = True
                Button4.Visible = True
                Button3.Visible = True
                Button2.Visible = True
                TextBox6.Visible = False
                TextBox5.Visible = True
                TextBox4.Visible = True
                TextBox3.Visible = True
                TextBox2.Visible = True
                TextBox1.Visible = True
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = True
                PictureBox6.Visible = False
            ElseIf .Text = "4" Then
                Button7.Visible = False
                Button6.Visible = False
                Button5.Visible = True
                Button4.Visible = True
                Button3.Visible = True
                Button2.Visible = True
                TextBox6.Visible = False
                TextBox5.Visible = False
                TextBox4.Visible = True
                TextBox3.Visible = True
                TextBox2.Visible = True
                TextBox1.Visible = True
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = True
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            ElseIf .Text = "3" Then
                Button7.Visible = False
                Button6.Visible = False
                Button5.Visible = False
                Button4.Visible = True
                Button3.Visible = True
                Button2.Visible = True
                TextBox6.Visible = False
                TextBox5.Visible = False
                TextBox4.Visible = False
                TextBox3.Visible = True
                TextBox2.Visible = True
                TextBox1.Visible = True
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = True
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            ElseIf .Text = "2" Then
                Button7.Visible = False
                Button6.Visible = False
                Button5.Visible = False
                Button4.Visible = False
                Button3.Visible = True
                Button2.Visible = True
                TextBox6.Visible = False
                TextBox5.Visible = False
                TextBox4.Visible = False
                TextBox3.Visible = False
                TextBox2.Visible = True
                TextBox1.Visible = True
                PictureBox1.Visible = True
                PictureBox2.Visible = True
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            ElseIf .Text = "1" Then
                Button7.Visible = False
                Button6.Visible = False
                Button5.Visible = False
                Button4.Visible = False
                Button3.Visible = False
                Button2.Visible = True
                TextBox6.Visible = False
                TextBox5.Visible = False
                TextBox4.Visible = False
                TextBox3.Visible = False
                TextBox2.Visible = False
                TextBox1.Visible = True
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            End If
        End With
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        Button1.Visible = False
        ComboBox1.Visible = False
    End Sub
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Hide()
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip1.Visible = False
        Label2.Visible = False
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        LinkLabel8.Visible = False
        Button1.Visible = False
        ComboBox1.Visible = False
        LinkLabel8.Visible = False
        LinkLabel2.Visible = False
        LinkLabel3.Visible = False
        LinkLabel4.Visible = False
        LinkLabel5.Visible = False
        LinkLabel6.Visible = False
        LinkLabel7.Visible = False
        With vc1
            .Label1.Text = TextBox1.Text
            .Label2.Text = TextBox2.Text
            .Label3.Text = TextBox3.Text
            .Label4.Text = TextBox4.Text
            .Label5.Text = TextBox5.Text
            .Label6.Text = TextBox6.Text

        End With
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Try
            PictureBox1.Image = Image.FromFile(p1)
            PictureBox2.Image = Image.FromFile(p2)
            PictureBox3.Image = Image.FromFile(p3)
            PictureBox4.Image = Image.FromFile(p4)
            PictureBox5.Image = Image.FromFile(p5)
            PictureBox6.Image = Image.FromFile(p6)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Dim pic As String = OpenFileDialog1.FileName
            With OpenFileDialog1
                .Title = "Choose Picture"
                .Filter = "JPEG(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png"
                .FileName = ""
            End With
            Dim kk As Integer = OpenFileDialog1.ShowDialog()
            If kk <> DialogResult.Cancel Then
                pic = OpenFileDialog1.FileName
                PictureBox1.Image = Image.FromFile(pic)
                OpenFileDialog1.Reset()
                If FileIO.FileSystem.FileExists(p1) Then
                    File.Delete(p1)
                End If
                File.Copy(pic.ToString, p1.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Dim pic As String = OpenFileDialog1.FileName
            With OpenFileDialog1
                .Title = "Choose Picture"
                .Filter = "JPEG(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png"
                .FileName = ""
            End With
            Dim kk As Integer = OpenFileDialog1.ShowDialog()
            If kk <> DialogResult.Cancel Then
                pic = OpenFileDialog1.FileName
                PictureBox2.Image = Image.FromFile(pic)
                OpenFileDialog1.Reset()
                If FileIO.FileSystem.FileExists(p2) Then
                    File.Delete(p2)
                End If
                File.Copy(pic.ToString, p2.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Try
            Dim pic As String = OpenFileDialog1.FileName
            With OpenFileDialog1
                .Title = "Choose Picture"
                .Filter = "JPEG(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png"
                .FileName = ""
            End With
            Dim kk As Integer = OpenFileDialog1.ShowDialog()
            If kk <> DialogResult.Cancel Then
                pic = OpenFileDialog1.FileName
                PictureBox3.Image = Image.FromFile(pic)
                OpenFileDialog1.Reset()
                If FileIO.FileSystem.FileExists(p3) Then
                    File.Delete(p3)
                End If
                File.Copy(pic.ToString, p3.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Try
            Dim pic As String = OpenFileDialog1.FileName
            With OpenFileDialog1
                .Title = "Choose Picture"
                .Filter = "JPEG(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png"
                .FileName = ""
            End With
            Dim kk As Integer = OpenFileDialog1.ShowDialog()
            If kk <> DialogResult.Cancel Then
                pic = OpenFileDialog1.FileName
                PictureBox4.Image = Image.FromFile(pic)
                OpenFileDialog1.Reset()
                If FileIO.FileSystem.FileExists(p4) Then
                    File.Delete(p4)
                End If
                File.Copy(pic.ToString, p4.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Try
            Dim pic As String = OpenFileDialog1.FileName
            With OpenFileDialog1
                .Title = "Choose Picture"
                .Filter = "JPEG(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png"
                .FileName = ""
            End With
            Dim kk As Integer = OpenFileDialog1.ShowDialog()
            If kk <> DialogResult.Cancel Then
                pic = OpenFileDialog1.FileName
                PictureBox5.Image = Image.FromFile(pic)
                OpenFileDialog1.Reset()
                If FileIO.FileSystem.FileExists(p5) Then
                    File.Delete(p5)
                End If
                File.Copy(pic.ToString, p5.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Try
            Dim pic As String = OpenFileDialog1.FileName
            With OpenFileDialog1
                .Title = "Choose Picture"
                .Filter = "JPEG(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png"
                .FileName = ""
            End With
            Dim kk As Integer = OpenFileDialog1.ShowDialog()
            If kk <> DialogResult.Cancel Then
                pic = OpenFileDialog1.FileName
                PictureBox6.Image = Image.FromFile(pic)
                OpenFileDialog1.Reset()
                If FileIO.FileSystem.FileExists(p6) Then
                    File.Delete(p6)
                End If
                File.Copy(pic.ToString, p6.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a1 = a1 + 1
        vc1.TextBox1.Text = a1
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        a6 = a6 + 1
        vc1.TextBox6.Text = a6
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        a5 = a5 + 1
        vc1.TextBox5.Text = a5
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        a4 = a4 + 1
        vc1.TextBox4.Text = a4
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a3 = a3 + 1
        vc1.TextBox3.Text = a3
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a2 = a2 + 1
        vc1.TextBox2.Text = a2
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MenuStrip1.Visible = True Then
            MenuStrip1.Visible = False
            LinkLabel8.Visible = False
        Else
            MenuStrip1.Visible = True
            LinkLabel8.Visible = True
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Me.Hide()
    End Sub
End Class