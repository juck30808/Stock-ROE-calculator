Public Class Form1

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Money() As Double = {TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text}
        Dim RoeMoney() As Double = {TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text}
        Dim Roe() As Double = {Money(0) / RoeMoney(0), Money(1) / RoeMoney(1), Money(2) / RoeMoney(2), Money(3) / RoeMoney(3), Money(4) / RoeMoney(4)}
        Dim Total As Double
        For X As Integer = 0 To 4
            Total = Total + Roe(X)
        Next
        Label14.Text = Total / 5 * 100 '乘100表示將百分比轉換為一般數字

        Dim Number As Double
        If RadioButton1.Checked = True Then Number = 8
        If RadioButton2.Checked = True Then Number = 10
        If RadioButton3.Checked = True Then Number = 12

        Dim NAV As Double = TextBox11.Text
        Label15.Text = (Total / 5) * 100 * NAV / 100 * Number '5年內平均Roe * NAV(每股淨值) / 100 * 權益乘數

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("取自巴菲特選股魔法書,洪瑞泰/著" & vbNewLine & "書中計算方法為" & vbNewLine & _
               " 「當年度RoE=當年稅後淨利(資產負債表)/年股東權益總額(損益表) 」" & vbNewLine & _
                 "求得「5年內平均Roe * NAV(每股淨值) / 100」可得各股初步價值" & vbNewLine & _
                  "若其Roe平均高於15，則此股適合投資" & vbNewLine & _
                  "在將「初步價值 * 權益乘數」即得可投資價位。" & vbNewLine & _
                  "PS.股東權益=公司淨值=資產-負債")

        MsgBox("範例" & vbNewLine & "6206飛捷 (資料取自蕃薯藤)" & vbNewLine & _
               "_________________2012年__2011年__2010年__2009年__2008年___2007年" & vbNewLine & _
               "本期稅後淨利:______609_____538______582_____545_____470______617" & vbNewLine & _
               "股東權益總額:____2,788___2,488____2,305___1,984___1,757____1,865" & vbNewLine & _
               "每股淨值(元):30.3 " & vbNewLine & _
               "所得五年平均Roe為 24.4 " & vbNewLine & _
               "股票參考價位為 88.75 ")

        MsgBox("本期稅後淨利:財務報表→損益表→年報簡表" & vbNewLine & _
                "股東權益總額:財務報表→資產負債表→年報簡表→股東權益期→股東權益總額" & vbNewLine & _
                "每股淨值(元):基本分析→公司基本資料→每股淨值(元)")

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
