Public Class 霧雨魔理沙
    Dim DM As Integer
    Dim mxa, mxd, mma, mmd, mss, mhp, mexp As Integer
    Dim str As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\力量.txt")
    Dim spd As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\敏捷.txt")
    Dim sma As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\智力.txt")
    Dim shp As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\體力.txt")
    Dim ski As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\靈力.txt")
    Dim xa As Integer = str * 6 + spd * 2
    Dim xd As Integer = spd * 2 + shp * 5
    Dim ma As Integer = sma * 7 + ski * 1
    Dim md As Integer = ski * 5 + sma * 2
    Dim ss As Integer = spd * 4 + shp * 1
    Dim hp As Integer = shp * 8 + str * 2
    Dim yhp As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\nhp.txt")
    Dim MP As Integer = ski * 8 + sma * 2
    Dim yMP As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\nmp.txt")
    Dim nexp As Integer = 0
    Dim exp As Integer = (lv + 3 - 1) + (lv + 2) * (lv + 3 - 2)
    Dim lv As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\等級.txt")
    Dim sp As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\SP.txt")
    Dim LD As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\LD.txt")
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        If lv <= 10 Then
            PictureBox2.Image = WindowsApplication6.My.Resources.霧雨_魔理沙
        End If
        If LD <= 3 Then
            Me.BackgroundImage = WindowsApplication6.My.Resources.Forest_ruin
            PictureBox1.Image = WindowsApplication6.My.Resources.icon36b
            mxa = 35
            mxd = 24
            mma = 35
            mmd = 24
            mss = 14
            mhp = 50
            mexp = 12
        ElseIf LD = 4 Then
            Me.BackgroundImage = WindowsApplication6.My.Resources.Forest_ruin
            PictureBox1.Image = WindowsApplication6.My.Resources._55621491201104032112043884947680543_075
            mxa = 25
            mxd = 100
            mma = 51
            mmd = 75
            mss = 50
            mhp = 96
            mexp = 32
        ElseIf LD = 5 Then
            Me.BackgroundImage = WindowsApplication6.My.Resources.images
            PictureBox1.Image = WindowsApplication6.My.Resources.愛莉絲
            mxa = 45
            mxd = 175
            mma = 85
            mmd = 75
            mss = 50
            mhp = 357
            mexp = 32
        Else
            MsgBox("COMING SOON")
            開始.Show()
            Me.Hide()
        End If

        SqlDataAdapter1.Fill(Cmdsk1)
        Label1.Text = My.Computer.FileSystem.ReadAllText("F:\DDT\名字.txt")
        Label2.Text = (hp)
        Label3.Text = (MP)
        Label10.Text = (yMP)
        Label7.Text = (yhp)
        If yhp <= 0 Then
            MsgBox("GAME OVER")
            Close()
        End If
        If mhp <= 0 Then
            nexp += mexp
            If nexp >= exp Then
                nexp = nexp - exp
                lv += 1
                sp += 4
                My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", hp, False)
                My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", MP, False)
                MsgBox("恭喜升級至" & lv & "級")
            End If
        End If
        'Label3.Text = (("MP") & MP("/") & yMP) skll.Text =
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h = Label18.Text
        Dim m = ComboBox2.Text
        Dim t = Label12.Text
        Dim d = Label13.Text
        Dim c = Label4.Text
        Dim a = Label14.Text
        Dim atttt As Integer
       
            Select Case a
                Case 1
                    If ss >= mss Then
                        yhp = yhp - h
                        yMP = yMP - m
                        For atttt = 1 To t
                            DM = ((ma * c) + d) - mmd
                            mhp = mhp - DM
                        Next
                    Else
                        DM = mxa - xd
                        yhp = yhp - DM
                    End If

                Case 2
                    If ss >= mss Then
                        yhp = yhp - h
                        yMP = yMP - m
                        For atttt = 1 To t
                            DM = ((xa * c) + d) - mxd
                            mhp = mhp - DM
                        Next
                    Else
                        DM = mxa - xd
                        yhp = yhp - DM
                    End If

            End Select


        My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", yhp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", yMP, False)

        Select Case a
            Case 1
                If ss < mss Then
                    yhp = yhp - h
                    yMP = yMP - m
                    For atttt = 1 To t
                        DM = ((ma * c) + d) - mmd
                        mhp = mhp - DM
                    Next
                Else
                    DM = mxa - md
                    yhp = yhp - DM
                End If

            Case 2
                If ss < mss Then
                    yhp = yhp - h
                    yMP = yMP - m
                    For atttt = 1 To t
                        DM = ((xa * c) + d) - mxd
                        mhp = mhp - DM
                    Next
                Else
                    DM = mxa - md
                    yhp = yhp - DM
                End If

        End Select

        My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", yhp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", yMP, False)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'If DataTable.row(0) Then

        ' End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ss >= mss Then
            For atttt = 1 To 1
                DM = xa - mxd
                mhp = mhp - DM
            Next
        Else
            DM = mxa - xd
            yhp = yhp - DM
        End If
        My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", yhp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", yMP, False)
        If ss < mss Then
            For atttt = 1 To 1
                DM = xa - mxd
                mhp = mhp - DM
            Next
        Else
            DM = mxa - xd
            yhp = yhp - DM
        End If
        My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", yhp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", yMP, False)
    End Sub
End Class
