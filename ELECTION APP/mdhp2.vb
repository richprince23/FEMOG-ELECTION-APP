Module mdhp2
    Public Sub enablebtns()
        Dim fms As New List(Of Form)
        fms.Add(Form1)
        'fms.Add(Form2)
        'fms.Add(Form3)
        fms.Add(Form4)
        fms.Add(Form5)
        fms.Add(DHP2)
        fms.Add(DHP3)
        fms.Add(ENT3)
        fms.Add(vp1)
        fms.Add(vp2)
        fms.Add(vp3)
        fms.Add(vp4)
        fms.Add(vp5)
        fms.Add(vp6)
        fms.Add(vp7)
        fms.Add(vp8)
        fms.Add(SPDP1)
        fms.Add(SPDP2)
        fms.Add(GNDP1)
        fms.Add(GNDP2)

        For Each one As Form In fms
            For Each cn As Control In one.Controls
                If TypeOf (cn) Is Button Then
                    Dim bt As Button = CType(cn, Button)
                    If bt.Text.Contains("VOTE") Then
                        bt.Enabled = True
                    End If

                End If

            Next
        Next
    End Sub
    Public Sub disablebtns()
        Dim fms As New List(Of Form)
        fms.Add(Form1)
        'fms.Add(Form2)
        'fms.Add(Form3)
        fms.Add(Form4)
        fms.Add(Form5)
        fms.Add(DHP2)
        fms.Add(DHP3)
        fms.Add(ENT3)
        fms.Add(vp1)
        fms.Add(vp2)
        fms.Add(vp3)
        fms.Add(vp4)
        fms.Add(vp5)
        fms.Add(vp6)
        fms.Add(vp7)
        fms.Add(vp8)
        fms.Add(SPDP1)
        fms.Add(SPDP2)
        fms.Add(GNDP1)
        fms.Add(GNDP2)

        For Each one As Form In fms
            For Each cn As Control In one.Controls
                If TypeOf (cn) Is Button Then
                    Dim bt As Button = CType(cn, Button)
                    If bt.Text.Contains("VOTE") Then
                        bt.Enabled = False
                    End If

                End If

            Next
        Next
    End Sub
    Public Sub cleardata()
        On Error Resume Next
        Dim fms As New List(Of Form)
        fms.Add(vp9)
        'fms.Add(vc1)
        'fms.Add(vc2)
        fms.Add(vc3)
        fms.Add(vc4)
        fms.Add(vc4)
        fms.Add(vc5)
        fms.Add(vc6)
        fms.Add(vc7)
        fms.Add(vc8)
        fms.Add(vc9)
        fms.Add(vc10)
        fms.Add(vc11)
        fms.Add(vc12)
        fms.Add(VCENT3)
        fms.Add(VCDHP2)
        fms.Add(VCDHP3)
        fms.Add(VCSPDP1)
        fms.Add(VCSPDP2)
        fms.Add(VCGNDP1)
        fms.Add(VCGNDP2)

        'reset textbox data
        For Each one As Form In fms
            For Each cn As Control In one.Controls
                If TypeOf (cn) Is TextBox Then
                    Dim tb As TextBox = CType(cn, TextBox)
                    tb.ResetText()

                End If
            Next
        Next
        'delete serialized data
        Dim dir As String = Application.StartupPath & "\"
        For Each fi As String In My.Computer.FileSystem.GetFiles(dir, FileIO.SearchOption.SearchAllSubDirectories, "*.xml*")
            If Not fi.Contains("FEMOG") And Not fi.Contains("HALL") Then
                FileIO.FileSystem.DeleteFile(fi)
            End If
        Next
        MsgBox("Data Cleared", MsgBoxStyle.Information)

    End Sub
End Module
