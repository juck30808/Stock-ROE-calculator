'Imports System.Data.SqlClient

Public Class 開始

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ' skill.DeleteCommand = New SqlCommand("Delete From table Where 名字= ", consk)
        ' skill.DeleteCommand = New SqlCommand("Delete From table Where 名字= ", consk)
        ' skill.DeleteCommand = New SqlCommand("Delete From table Where 名字= ", consk)
        ' skill.DeleteCommand = New SqlCommand("Delete From table Where 名字= ", consk)
        ' skill.DeleteCommand = New SqlCommand("Delete From table Where 名字= ", consk)
        ' skill.DeleteCommand = New SqlCommand("Delete From table Where 名字= ", consk)
        MsgBox("你好，玩家歡迎進入這個遊戲，接下來會做幾個小測驗")
        MsgBox("不過你的選擇將會影響到你的能力值、角色強度、劇情走向和難易度")
        MsgBox("放輕鬆，不會差很多")
        MsgBox("那就從現在開始吧~")
        Dim St, Sp, Sm, Sh, Sk As Integer
        Dim MB As String
        St = 4
        Sp = 4
        Sm = 4
        Sh = 4
        Sk = 4
        MB = MsgBox("1.你認為你是(文)大於(武)的人嗎?", vbYesNo)
        If MB = vbYes Then
            Sm = Sm + 4
            Sk = Sk + 2
        ElseIf MB = vbNo Then
            St = St + 2
            Sp = Sp + 2
            Sh = Sh + 2
        End If
        MB = MsgBox("2.你是否有宗教?", vbYesNo)
        If MB = vbYes Then
            St = St + 2
            Sp = Sp + 2
            Sm = Sm + 2
            Sh = Sh + 2
        ElseIf MB = vbNo Then
            Sk = Sk + 4
            Sh = Sh + 2
        End If
        MB = MsgBox("比起貓更喜歡狗?", vbYesNo)
        If MB = vbYes Then
            St = St + 4
            Sp = Sp + 2
        ElseIf MB = vbNo Then
            Sp = Sp + 2
            Sm = Sm + 2
            Sh = Sh + 2
        End If
        Dim P, Pe As Integer
        P = 0
        Pe = 0
        Do
            If Pe = 0 Then
                Select Case P
                    Case 0
                        P = InputBox("請輸入1~9", "角色選擇")
                    Case 1
                        MB = MsgBox("博麗 靈夢  高魔量物攻角", vbOKCancel)
                        If MB = vbOK Then
                            Sk = (Sk * 2.0)
                            St = (St * 1.5)
                            Pe = 1
                            My.Computer.FileSystem.WriteAllText("F:\DDT\角色.txt", "1", False)
                            My.Computer.FileSystem.WriteAllText("F:\DDT\名字.txt", "博麗靈夢", False)
                            'skill.InsertCommand = New SqlCommand("Insert From table Where 名字= 博麗 靈夢", consk)
                        Else
                            P = 0
                        End If

                    Case 2
                        MB = MsgBox("霧雨 魔理沙  高速度魔攻角", vbOKCancel)
                        If MB = vbOK Then
                            Sm = (Sm * 1.5)
                            Sp = (Sp * 2.0)
                            Pe = 1
                            My.Computer.FileSystem.WriteAllText("F:\DDT\角色.txt", "2", False)
                            My.Computer.FileSystem.WriteAllText("F:\DDT\名字.txt", "霧雨魔理沙 ", False)
                            'skill.InsertCommand = New SqlCommand("Insert From table Where 名字= 霧雨 魔理沙", consk)
                        Else
                            P = 0
                        End If
                    Case 3
                        MB = MsgBox("十六夜 咲夜   高能量消耗角", vbOKCancel)
                        If MB = vbOK Then
                            Sk = (Sk * 1.5)
                            Sh = (Sh * 2.0)
                            Pe = 1
                            My.Computer.FileSystem.WriteAllText("F:\DDT\角色.txt", "3", False)
                            My.Computer.FileSystem.WriteAllText("F:\DDT\名字.txt", "十六夜咲夜 ", False)
                            'skill.InsertCommand = New SqlCommand("Insert From table Where 名字= 十六夜 咲夜", consk)
                        Else
                            P = 0
                        End If
                    Case 4
                        MB = MsgBox("魂魄 妖夢    高速度物攻角", vbOKCancel)
                        If MB = vbOK Then
                            St = (St * 2.0)
                            Sp = (Sp * 1.5)
                            Pe = 1
                            My.Computer.FileSystem.WriteAllText("F:\DDT\角色.txt", "4", False)
                            My.Computer.FileSystem.WriteAllText("F:\DDT\名字.txt", "魂魄妖夢 ", False)
                            'skill.InsertCommand = New SqlCommand("Insert From table Where 名字= 魂魄 妖夢", consk)
                        Else
                            P = 0
                        End If
                    Case 5
                        MB = MsgBox("帕秋莉 諾蕾姬   低體能超魔攻角", vbOKCancel)
                        If MB = vbOK Then
                            Sm = (Sm * 4.5)
                            St = (St * 0.5)
                            Sp = (Sp * 0.5)
                            Sh = (Sh * 0.5)
                            Pe = 1
                            My.Computer.FileSystem.WriteAllText("F:\DDT\角色.txt", "5", False)
                            My.Computer.FileSystem.WriteAllText("F:\DDT\名字.txt", "帕秋莉諾蕾姬  ", False)
                        Else
                            P = 0
                        End If
                    Case 6
                        MB = MsgBox("此幻想未實體化", vbOKCancel)
                        '  If vbOK Then

                        ' End If
                    Case 7
                        MB = MsgBox("此幻想未實體化", vbOKCancel)
                        ' If vbOK Then
                        P = 0
                        ' End If
                    Case 8
                        MB = MsgBox("此幻想未實體化", vbOKCancel)
                        '  If vbOK Then
                        P = 0
                        ' End If
                    Case 9
                        MB = MsgBox("此幻想未實體化", vbOKCancel)
                        '  If vbOK Then
                        P = 0
                        '  End If
                    Case Not 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9
                        MsgBox("輸入錯誤")
                        P = 0
                End Select

            ElseIf Pe = 1 Then
                Exit Do
            End If
        Loop
        My.Computer.FileSystem.WriteAllText("F:\DDT\力量.txt", St, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\智力.txt", Sm, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\敏捷.txt", Sp, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\體力.txt", Sh, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\靈力.txt", Sk, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\等級.txt", "1", False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\nhp.txt", Sh * 8 + St * 2, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\nmp.txt", Sk * 8 + Sm * 2, False)
        My.Computer.FileSystem.WriteAllText("F:\DDT\LD.txt", 0, False)
        ' skill.InsertCommand = New SqlCommand("Insert From table Where 力量= " & St, consk)
        ' skill.InsertCommand = New SqlCommand("Insert From table Where 敏捷= " & Sp, consk)
        ' skill.InsertCommand = New SqlCommand("Insert From table Where 智力= " & Sm, consk)
        ' skill.InsertCommand = New SqlCommand("Insert From table Where 體力= " & Sh, consk)
        ' skill.InsertCommand = New SqlCommand("Insert From table Where 靈力= " & Sk, consk)
        ' Update()
        ' Form4.Show()
        ' MsgBox((St)(Sp)(Sm)(Sh)(Sk))       東方.Recordset.addnew() '("力量") = St
        MsgBox("按下<存取資料>就可以玩囉~")
        Me.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Select My.Computer.FileSystem.ReadAllText("F:\DDT\角色.txt")
            Case 1

            Case 2
                霧雨魔理沙map.Show()
        End Select


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
'MsgBox("", vbYesNo)       MsgBox("", vbOKCancel)
'  Form2.Show()   Me.Hide() 
'MsgBox("")
'《Grimoire of Alice》