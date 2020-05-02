Public Class Form2
    Private Sub Button_north_Click(sender As Object, e As EventArgs) Handles Button_north.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDap.Fill(DataSet1)
        '   If ComboBox1.Text = "簡單" Then
        'life = 150
        '  End If
        '   If ComboBox1.Text = "一般" Then
        '  life = 100
        '  End If
        ' If ComboBox1.Text = "困難" Then
        'life = 70
        '  End If
        '   If ComboBox1.Text = "超難der啦" Then
        'life = 20
        '   End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Form1.Label6.Text = Me.ComboBox1.SelectedValue
    End Sub
End Class