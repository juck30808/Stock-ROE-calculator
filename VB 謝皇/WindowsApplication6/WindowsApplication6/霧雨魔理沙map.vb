Public Class 霧雨魔理沙map
    Dim str As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\力量.txt")
    Dim spd As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\敏捷.txt")
    Dim sma As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\智力.txt")
    Dim shp As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\體力.txt")
    Dim ski As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\靈力.txt")
    Dim xa As Integer = str * 4 + spd * 2
    Dim xd As Integer = spd * 1 + shp * 3
    Dim ma As Integer = sma * 5 + ski * 1
    Dim md As Integer = ski * 3 + sma * 1
    Dim ss As Integer = spd * 2 + str * 1
    Dim hp As Integer = shp * 8 + str * 2
    Dim yhp As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\nhp.txt")
    Dim MP As Integer = ski * 8 + sma * 2
    Dim yMP As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\nmp.txt")
    Dim nexp As Integer = 0
    Dim exp As Integer = (lv + 3 - 1) + (lv + 2) * (lv + 3 - 2)
    Dim lv As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\等級.txt")
    Dim sp As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\SP.txt")
    Dim LD As Integer = My.Computer.FileSystem.ReadAllText("F:\DDT\LD.txt")
    Private Sub 霧雨魔理沙map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case lv
            Case Is >= 1 < 10
                PictureBox2.Image = WindowsApplication6.My.Resources.霧雨_魔理沙

        End Select
        If LD <= 4 Then
            Me.BackgroundImage = WindowsApplication6.My.Resources.Forest_ruin
        ElseIf LD = 5 Then
            Me.BackgroundImage = WindowsApplication6.My.Resources.images
        End If

        If nexp >= exp Then
            nexp = nexp - exp
            lv += 1
            sp += 4
            My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", hp, False)
            My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", MP, False)
            My.Computer.FileSystem.WriteAllText("F:\DDT\SP.txt", lv, False)
            My.Computer.FileSystem.WriteAllText("F:\DDT\LD.txt", sp, False)
            MsgBox("恭喜升級至" & lv & "級")
        End If

        TextBox1.Text = str
        TextBox2.Text = spd
        TextBox3.Text = sma
        TextBox4.Text = shp
        TextBox6.Text = ski
        TextBox5.Text = sp
        Label7.Text = ("LV :  " & lv)
        Label8.Text = ("HP :  " & hp & "/" & yhp)
        Label9.Text = ("MP :  " & MP & "/" & yMP)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = False
        My.Computer.FileSystem.WriteAllText("F:\DDT\力量.txt", str, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\智力.txt", spd, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\敏捷.txt", sma, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\體力.txt", shp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\靈力.txt", ski, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\SP.txt", sp, False)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If sp < 0 Then
            str += 1
            sp += -1
        End If
      
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If sp < 0 Then
            spd += 1
            sp += -1
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If sp < 0 Then
            sma += 1
            sp += -1
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If sp < 0 Then
            shp += 1
            sp += -1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If sp < 0 Then
            ski += 1
            sp += -1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText("F:\DDT\SP.txt", sp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\LD.txt", LD, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\力量.txt", str, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\敏捷.txt", spd, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\智力.txt", sma, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\體力.txt", shp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\靈力.txt", ski, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\等級.txt", lv, False)
        Dim MB As String
        MB = MsgBox("要繼續遊戲嗎?", vbYesNo)
            If MB = vbNo Then
            Me.Hide()
            開始.Show()
            End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LD += 1
        My.Computer.FileSystem.WriteAllText("F:\DDT\LD.txt", LD, False)
        Me.Hide()
        霧雨魔理沙.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LD <> 0 Then
            My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", yhp + 20, False)
            My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", yMP + 20, False)
            Me.Hide()
            霧雨魔理沙.Show()
        End If
    End Sub
End Class