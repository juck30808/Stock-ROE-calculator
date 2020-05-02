<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LabelFirst = New System.Windows.Forms.Label()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDap = New System.Data.SqlClient.SqlDataAdapter()
        Me.Button_north = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataSet1 = New Game.DataSet1()
        Me.GameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelFirst
        '
        Me.LabelFirst.AutoSize = True
        Me.LabelFirst.Location = New System.Drawing.Point(45, 57)
        Me.LabelFirst.Name = "LabelFirst"
        Me.LabelFirst.Size = New System.Drawing.Size(209, 12)
        Me.LabelFirst.TabIndex = 3
        Me.LabelFirst.Text = "請選擇宇宙超級無敵剪刀石頭布的難度"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT          Game.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM              Game"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\inf\Desktop\Game\Game\Game" & _
    " set.mdf"";Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Game] ([難度], [血量]) VALUES (@難度, @血量)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@難度", System.Data.SqlDbType.NChar, 0, "難度"), New System.Data.SqlClient.SqlParameter("@血量", System.Data.SqlDbType.Int, 0, "血量")})
        '
        'SqlDap
        '
        Me.SqlDap.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDap.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDap.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Game", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("難度", "難度"), New System.Data.Common.DataColumnMapping("血量", "血量")})})
        '
        'Button_north
        '
        Me.Button_north.Location = New System.Drawing.Point(107, 193)
        Me.Button_north.Name = "Button_north"
        Me.Button_north.Size = New System.Drawing.Size(75, 23)
        Me.Button_north.TabIndex = 1
        Me.Button_north.Text = "Enter"
        Me.Button_north.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ComboBox1.DataSource = Me.DataSet1
        Me.ComboBox1.DisplayMember = "Game.難度"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "血量"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GameBindingSource
        '
        Me.GameBindingSource.DataMember = "Game"
        Me.GameBindingSource.DataSource = Me.DataSet1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LabelFirst)
        Me.Controls.Add(Me.Button_north)
        Me.Name = "Form2"
        Me.Text = "剪刀石頭布"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelFirst As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDap As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button_north As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Game.DataSet1
End Class
