<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 霧雨魔理沙
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

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Cmdsk1 = New WindowsApplication6.cmdsk()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.skll = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.Cmdsk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cmdsk1, "Table.招式", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.招式", True))
        Me.ComboBox1.DataSource = Me.Cmdsk1
        Me.ComboBox1.DisplayMember = "Table.招式"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(353, 440)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "Table.招式"
        '
        'Cmdsk1
        '
        Me.Cmdsk1.DataSetName = "cmdsk"
        Me.Cmdsk1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(482, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "技能"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "HP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 12)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 12)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "MP:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(92, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(8, 12)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "/"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(108, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 12)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(92, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(8, 12)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "/"
        '
        'skll
        '
        Me.skll.AutoSize = True
        Me.skll.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.招式", True))
        Me.skll.Location = New System.Drawing.Point(388, 396)
        Me.skll.Name = "skll"
        Me.skll.Size = New System.Drawing.Size(20, 12)
        Me.skll.TabIndex = 18
        Me.skll.Text = "....."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(452, 425)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 12)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "所耗Hp:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(351, 425)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 12)
        Me.Label16.TabIndex = 20
        Me.Label16.Tag = ""
        Me.Label16.Text = "所耗Mp:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(191, 349)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(149, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT          招式, MP, HP, 注解, 屬, 倍率, 固傷, 次數" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM              [Table]"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\WindowsApplication6\WindowsApplic" & _
    "ation6\東方.mdf;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Table] ([招式], [MP], [HP], [注解], [屬], [倍率], [固傷], [次數]) VALUES (@招式, " & _
    "@MP, @HP, @注解, @屬, @倍率, @固傷, @次數)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@招式", System.Data.SqlDbType.NVarChar, 0, "招式"), New System.Data.SqlClient.SqlParameter("@MP", System.Data.SqlDbType.Int, 0, "MP"), New System.Data.SqlClient.SqlParameter("@HP", System.Data.SqlDbType.Int, 0, "HP"), New System.Data.SqlClient.SqlParameter("@注解", System.Data.SqlDbType.NVarChar, 0, "注解"), New System.Data.SqlClient.SqlParameter("@屬", System.Data.SqlDbType.NVarChar, 0, "屬"), New System.Data.SqlClient.SqlParameter("@倍率", System.Data.SqlDbType.NChar, 0, "倍率"), New System.Data.SqlClient.SqlParameter("@固傷", System.Data.SqlDbType.Int, 0, "固傷"), New System.Data.SqlClient.SqlParameter("@次數", System.Data.SqlDbType.Int, 0, "次數")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("招式", "招式"), New System.Data.Common.DataColumnMapping("MP", "MP"), New System.Data.Common.DataColumnMapping("HP", "HP"), New System.Data.Common.DataColumnMapping("注解", "注解"), New System.Data.Common.DataColumnMapping("屬", "屬"), New System.Data.Common.DataColumnMapping("倍率", "倍率"), New System.Data.Common.DataColumnMapping("固傷", "固傷"), New System.Data.Common.DataColumnMapping("次數", "次數")})})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.次數", True))
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Cmdsk1, "Table.次數", True))
        Me.Label12.Location = New System.Drawing.Point(477, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 12)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Label12"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.倍率", True))
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Cmdsk1, "Table.倍率", True))
        Me.Label4.Location = New System.Drawing.Point(388, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 12)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Label4"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.固傷", True))
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Cmdsk1, "Table.固傷", True))
        Me.Label13.Location = New System.Drawing.Point(428, 463)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 12)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.屬", True))
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.TableBindingSource, "屬", True))
        Me.Label14.Location = New System.Drawing.Point(339, 463)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 12)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Label14"
        Me.Label14.Visible = False
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Cmdsk1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.HP", True))
        Me.Label18.Location = New System.Drawing.Point(504, 425)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 12)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "....."
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cmdsk1, "Table.MP", True))
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cmdsk1, "Table.MP", True))
        Me.ComboBox2.DataSource = Me.Cmdsk1
        Me.ComboBox2.DisplayMember = "Table.MP"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(405, 417)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(41, 20)
        Me.ComboBox2.TabIndex = 28
        Me.ComboBox2.ValueMember = "Table.MP"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(430, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 22)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "普通攻擊"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(430, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 19)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "戀符<支配閃光>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(430, 302)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 22)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "翠色彈幕"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(430, 330)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 22)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "星符<自由流星>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        '霧雨魔理沙
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 481)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.skll)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "霧雨魔理沙"
        Me.Text = "Form1"
        CType(Me.Cmdsk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents skll As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cmdsk1 As WindowsApplication6.cmdsk
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
