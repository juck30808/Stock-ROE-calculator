<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 開始
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(開始))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.consk = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.skill = New System.Data.SqlClient.SqlDataAdapter()
        Me.cmdsk = New WindowsApplication6.cmdsk()
        CType(Me.cmdsk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(162, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "開始遊戲"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(162, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "存取資料"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(162, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 28)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "結束遊戲"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT          Id, 姓名, 力量, 敏捷, 智力, 體力, 靈力, HP, MP, AP, 物理攻擊, 物理防禦, 魔法攻擊, 魔法防禦" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F" & _
    "ROM              [Table]"
        Me.SqlSelectCommand1.Connection = Me.consk
        '
        'consk
        '
        Me.consk.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\WindowsApplication6\WindowsApplic" & _
    "ation6\東方.mdf;Integrated Security=True"
        Me.consk.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Table] ([Id], [姓名], [力量], [敏捷], [智力], [體力], [靈力], [HP], [MP], [AP], " & _
    "[物理攻擊], [物理防禦], [魔法攻擊], [魔法防禦]) VALUES (@Id, @姓名, @力量, @敏捷, @智力, @體力, @靈力, @HP, " & _
    "@MP, @AP, @物理攻擊, @物理防禦, @魔法攻擊, @魔法防禦)"
        Me.SqlInsertCommand1.Connection = Me.consk
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 0, "Id"), New System.Data.SqlClient.SqlParameter("@姓名", System.Data.SqlDbType.NVarChar, 0, "姓名"), New System.Data.SqlClient.SqlParameter("@力量", System.Data.SqlDbType.NVarChar, 0, "力量"), New System.Data.SqlClient.SqlParameter("@敏捷", System.Data.SqlDbType.NVarChar, 0, "敏捷"), New System.Data.SqlClient.SqlParameter("@智力", System.Data.SqlDbType.NVarChar, 0, "智力"), New System.Data.SqlClient.SqlParameter("@體力", System.Data.SqlDbType.NVarChar, 0, "體力"), New System.Data.SqlClient.SqlParameter("@靈力", System.Data.SqlDbType.NVarChar, 0, "靈力"), New System.Data.SqlClient.SqlParameter("@HP", System.Data.SqlDbType.NChar, 0, "HP"), New System.Data.SqlClient.SqlParameter("@MP", System.Data.SqlDbType.NChar, 0, "MP"), New System.Data.SqlClient.SqlParameter("@AP", System.Data.SqlDbType.NChar, 0, "AP"), New System.Data.SqlClient.SqlParameter("@物理攻擊", System.Data.SqlDbType.NChar, 0, "物理攻擊"), New System.Data.SqlClient.SqlParameter("@物理防禦", System.Data.SqlDbType.NChar, 0, "物理防禦"), New System.Data.SqlClient.SqlParameter("@魔法攻擊", System.Data.SqlDbType.NChar, 0, "魔法攻擊"), New System.Data.SqlClient.SqlParameter("@魔法防禦", System.Data.SqlDbType.NChar, 0, "魔法防禦")})
        '
        'skill
        '
        Me.skill.InsertCommand = Me.SqlInsertCommand1
        Me.skill.SelectCommand = Me.SqlSelectCommand1
        Me.skill.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("姓名", "姓名"), New System.Data.Common.DataColumnMapping("力量", "力量"), New System.Data.Common.DataColumnMapping("敏捷", "敏捷"), New System.Data.Common.DataColumnMapping("智力", "智力"), New System.Data.Common.DataColumnMapping("體力", "體力"), New System.Data.Common.DataColumnMapping("靈力", "靈力"), New System.Data.Common.DataColumnMapping("HP", "HP"), New System.Data.Common.DataColumnMapping("MP", "MP"), New System.Data.Common.DataColumnMapping("AP", "AP"), New System.Data.Common.DataColumnMapping("物理攻擊", "物理攻擊"), New System.Data.Common.DataColumnMapping("物理防禦", "物理防禦"), New System.Data.Common.DataColumnMapping("魔法攻擊", "魔法攻擊"), New System.Data.Common.DataColumnMapping("魔法防禦", "魔法防禦")})})
        '
        'cmdsk
        '
        Me.cmdsk.DataSetName = "cmdsk"
        Me.cmdsk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '開始
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(499, 318)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "開始"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.cmdsk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents consk As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents skill As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents cmdsk As WindowsApplication6.cmdsk

End Class
