<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Bt1 = New System.Windows.Forms.Button()
        Me.Bt2 = New System.Windows.Forms.Button()
        Me.Bt3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.My_inf = New System.Windows.Forms.Label()
        Me.His_inf = New System.Windows.Forms.Label()
        Me.his_life = New System.Windows.Forms.Label()
        Me.my_hurt = New System.Windows.Forms.Label()
        Me.my_life = New System.Windows.Forms.Label()
        Me.his_hurt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bt1
        '
        Me.Bt1.Location = New System.Drawing.Point(14, 169)
        Me.Bt1.Name = "Bt1"
        Me.Bt1.Size = New System.Drawing.Size(75, 23)
        Me.Bt1.TabIndex = 0
        Me.Bt1.Text = "剪刀"
        Me.Bt1.UseVisualStyleBackColor = True
        '
        'Bt2
        '
        Me.Bt2.Location = New System.Drawing.Point(95, 169)
        Me.Bt2.Name = "Bt2"
        Me.Bt2.Size = New System.Drawing.Size(75, 23)
        Me.Bt2.TabIndex = 0
        Me.Bt2.Text = "石頭"
        Me.Bt2.UseVisualStyleBackColor = True
        '
        'Bt3
        '
        Me.Bt3.Location = New System.Drawing.Point(176, 169)
        Me.Bt3.Name = "Bt3"
        Me.Bt3.Size = New System.Drawing.Size(75, 23)
        Me.Bt3.TabIndex = 0
        Me.Bt3.Text = "布"
        Me.Bt3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 1
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(195, 110)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(77, 12)
        Me.Label.TabIndex = 2
        Me.Label.Text = "____________"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "電腦出....."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "你出....."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 27)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "."
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\inf\Documents\Role.mdf;Inte" & _
    "grated Security=True;Connect Timeout=30"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'My_inf
        '
        Me.My_inf.AutoSize = True
        Me.My_inf.Location = New System.Drawing.Point(60, 199)
        Me.My_inf.Name = "My_inf"
        Me.My_inf.Size = New System.Drawing.Size(29, 36)
        Me.My_inf.TabIndex = 3
        Me.My_inf.Text = "血量" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "傷害"
        '
        'His_inf
        '
        Me.His_inf.AutoSize = True
        Me.His_inf.Location = New System.Drawing.Point(60, 29)
        Me.His_inf.Name = "His_inf"
        Me.His_inf.Size = New System.Drawing.Size(29, 36)
        Me.His_inf.TabIndex = 3
        Me.His_inf.Text = "血量" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "傷害"
        '
        'his_life
        '
        Me.his_life.AutoSize = True
        Me.his_life.Location = New System.Drawing.Point(93, 29)
        Me.his_life.Name = "his_life"
        Me.his_life.Size = New System.Drawing.Size(23, 12)
        Me.his_life.TabIndex = 4
        Me.his_life.Text = "100"
        '
        'my_hurt
        '
        Me.my_hurt.AutoSize = True
        Me.my_hurt.Location = New System.Drawing.Point(95, 223)
        Me.my_hurt.Name = "my_hurt"
        Me.my_hurt.Size = New System.Drawing.Size(17, 12)
        Me.my_hurt.TabIndex = 4
        Me.my_hurt.Text = "10"
        '
        'my_life
        '
        Me.my_life.AutoSize = True
        Me.my_life.Location = New System.Drawing.Point(93, 199)
        Me.my_life.Name = "my_life"
        Me.my_life.Size = New System.Drawing.Size(23, 12)
        Me.my_life.TabIndex = 4
        Me.my_life.Text = "100"
        '
        'his_hurt
        '
        Me.his_hurt.AutoSize = True
        Me.his_hurt.Location = New System.Drawing.Point(93, 53)
        Me.his_hurt.Name = "his_hurt"
        Me.his_hurt.Size = New System.Drawing.Size(17, 12)
        Me.his_hurt.TabIndex = 4
        Me.his_hurt.Text = "10"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.my_hurt)
        Me.Controls.Add(Me.my_life)
        Me.Controls.Add(Me.his_hurt)
        Me.Controls.Add(Me.his_life)
        Me.Controls.Add(Me.His_inf)
        Me.Controls.Add(Me.My_inf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt3)
        Me.Controls.Add(Me.Bt2)
        Me.Controls.Add(Me.Bt1)
        Me.Name = "Form1"
        Me.Text = "戰鬥中"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bt1 As System.Windows.Forms.Button
    Friend WithEvents Bt2 As System.Windows.Forms.Button
    Friend WithEvents Bt3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents My_inf As System.Windows.Forms.Label
    Friend WithEvents His_inf As System.Windows.Forms.Label
    Friend WithEvents his_life As System.Windows.Forms.Label
    Friend WithEvents my_hurt As System.Windows.Forms.Label
    Friend WithEvents my_life As System.Windows.Forms.Label
    Friend WithEvents his_hurt As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
