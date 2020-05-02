Public Class Form1

    Private Property Timer As Object
    Dim q As Integer = 100
    Dim w As Integer = 10
    Dim r As Integer

    Dim t As Integer = 10
    Dim Mynum As Double
    Dim point As Double

    '使用 Rnd 函式產生1到3的亂數整數
    ' 1 = 剪刀  2 = 石頭   3 = 布

    Private Sub Bt1_Click(sender As Object, e As EventArgs) Handles Bt1.Click '你點剪刀
        Label5.Text = "剪刀"
        Randomize(Timer) '使亂數不重覆
        Mynum = 1
        Dim Num = Int(Rnd() * 3 + 1) '取得1到3的亂數
        How(Num)
        X(point)
        Over(q, r)
        point = 0
    End Sub

    Private Sub Bt2_Click(sender As Object, e As EventArgs) Handles Bt2.Click '你點石頭
        Label5.Text = "石頭"
        Randomize(Timer) '使亂數不重覆
        Mynum = 2
        Dim Num = Int(Rnd() * 3 + 1) '取得1到3的亂數
        How(Num)
        X(point)
        Over(q, r)
        point = 0
    End Sub
    Private Sub Bt3_Click(sender As Object, e As EventArgs) Handles Bt3.Click '你點布
        Label5.Text = "布"
        Randomize(Timer) '使亂數不重覆
        Mynum = 3
        Dim Num = Int(Rnd() * 3 + 1) '取得1到3的亂數
        How(Num)
        X(point)
        Over(q, r)
        point = 0
    End Sub
    Function How(ByVal Num As Integer)
        If Mynum = 1 Then
            Select Case Num
                Case 1
                    Label.Text = "平手!"
                    Label3.Text = "剪刀"
                Case 2
                    Label.Text = "你輸了!"
                    point += 2
                    Label3.Text = "石頭"
                Case 3
                    Label.Text = "你贏了!"
                    point += 1
                    Label3.Text = "布"
            End Select
        End If
        If Mynum = 2 Then
            Select Case Num
                Case 1
                    Label.Text = "你贏了!"
                    point += 1
                    Label3.Text = "剪刀"
                Case 2
                    Label.Text = "平手!"
                    Label3.Text = "石頭"
                Case 3
                    Label.Text = "你輸了!"
                    point += 2
                    Label3.Text = "布"
            End Select
        End If
        If Mynum = 3 Then
            Select Case Num
                Case 1
                    Label.Text = "你輸了!"
                    point += 2
                    Label3.Text = "剪刀"
                Case 2
                    Label.Text = "你贏了!"
                    point += 1
                    Label3.Text = "石頭"
                Case 3
                    Label.Text = "平手!"
                    Label3.Text = "布"
            End Select
        End If
    End Function
    Function X(ByVal Point As Integer)
        If Point = 1 Then
            q = q - 10
            his_life.Text = q
        ElseIf Point = 2 Then
            r = r - 10
            my_life.Text = r
        Else
            q = q - 2
            r = r - 2
            his_life.Text = q
            my_life.Text = r
        End If
    End Function
    Function Over(ByVal X As Integer, ByVal Y As Integer)
        If X <= 0 Then
            MsgBox("遊戲結束，你贏了")
        ElseIf Y <= 0 Then
            MsgBox("遊戲結束，你輸了")
        End If
    End Function

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label6_TextChanged(sender As Object, e As EventArgs) Handles Label6.TextChanged
        r = CInt(Label6.Text)
    End Sub
End Class