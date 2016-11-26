<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtSet = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkSelect = New System.Windows.Forms.CheckBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkForce = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tx3 = New System.Windows.Forms.TextBox()
        Me.Cx3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tx2 = New System.Windows.Forms.TextBox()
        Me.Cx2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tx1 = New System.Windows.Forms.TextBox()
        Me.Cx1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(547, 298)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtSet)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.RB3)
        Me.TabPage1.Controls.Add(Me.RB2)
        Me.TabPage1.Controls.Add(Me.RB1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.chkSelect)
        Me.TabPage1.Controls.Add(Me.txtTime)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.chkForce)
        Me.TabPage1.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(539, 268)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "通用"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtSet
        '
        Me.txtSet.Location = New System.Drawing.Point(163, 230)
        Me.txtSet.Name = "txtSet"
        Me.txtSet.Size = New System.Drawing.Size(70, 23)
        Me.txtSet.TabIndex = 11
        Me.txtSet.Text = "30"
        Me.txtSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 21)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "自动关机倒数秒数"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Checked = True
        Me.RB3.Location = New System.Drawing.Point(56, 201)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(214, 21)
        Me.RB3.TabIndex = 9
        Me.RB3.TabStop = True
        Me.RB3.Text = "无论选""是""或""否""都不取消自动关机"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(56, 184)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(288, 21)
        Me.RB2.TabIndex = 8
        Me.RB2.Text = "第一次提醒选""否""将取消自动关机，并关闭该应用"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Location = New System.Drawing.Point(56, 167)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(288, 21)
        Me.RB1.TabIndex = 7
        Me.RB1.Text = "第一次提醒选""是""将取消自动关机，并关闭该应用"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(280, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "第一次提醒将变为带有""是""，""否""两选项的消息框。"
        '
        'chkSelect
        '
        Me.chkSelect.AutoSize = True
        Me.chkSelect.Checked = True
        Me.chkSelect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSelect.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.chkSelect.Location = New System.Drawing.Point(29, 119)
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Size = New System.Drawing.Size(205, 25)
        Me.chkSelect.TabIndex = 6
        Me.chkSelect.Text = "将第一次提醒变为选择框"
        Me.chkSelect.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.txtTime.Location = New System.Drawing.Point(57, 17)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(37, 29)
        Me.txtTime.TabIndex = 5
        Me.txtTime.Text = "45"
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(53, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "警告：关机不可阻止。"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(53, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "这将跳过提醒，在设定时间到达后自动关机。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(100, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "分钟后开始提醒"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "在"
        '
        'chkForce
        '
        Me.chkForce.AutoSize = True
        Me.chkForce.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.chkForce.Location = New System.Drawing.Point(29, 53)
        Me.chkForce.Name = "chkForce"
        Me.chkForce.Size = New System.Drawing.Size(205, 25)
        Me.chkForce.TabIndex = 0
        Me.chkForce.Text = "我不想给拖堂老师留面子"
        Me.chkForce.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(539, 268)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "定制你的提醒内容"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tx3)
        Me.GroupBox3.Controls.Add(Me.Cx3)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(523, 82)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "关机信息"
        '
        'Tx3
        '
        Me.Tx3.Location = New System.Drawing.Point(80, 22)
        Me.Tx3.Name = "Tx3"
        Me.Tx3.Size = New System.Drawing.Size(437, 23)
        Me.Tx3.TabIndex = 9
        Me.Tx3.Text = "很抱歉！"
        '
        'Cx3
        '
        Me.Cx3.Location = New System.Drawing.Point(80, 54)
        Me.Cx3.Name = "Cx3"
        Me.Cx3.Size = New System.Drawing.Size(437, 23)
        Me.Cx3.TabIndex = 10
        Me.Cx3.Text = "现在将自动关机。"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "消息框标题"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "消息框内容"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tx2)
        Me.GroupBox2.Controls.Add(Me.Cx2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 76)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "第二次提醒"
        '
        'Tx2
        '
        Me.Tx2.Location = New System.Drawing.Point(80, 19)
        Me.Tx2.Name = "Tx2"
        Me.Tx2.Size = New System.Drawing.Size(437, 23)
        Me.Tx2.TabIndex = 7
        Me.Tx2.Text = "警告"
        '
        'Cx2
        '
        Me.Cx2.Location = New System.Drawing.Point(80, 48)
        Me.Cx2.Name = "Cx2"
        Me.Cx2.Size = New System.Drawing.Size(437, 23)
        Me.Cx2.TabIndex = 8
        Me.Cx2.Text = "下课不可拖堂。警告：即将自动关机！"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "消息框标题"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "消息框内容"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tx1)
        Me.GroupBox1.Controls.Add(Me.Cx1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 73)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "第一次提醒"
        '
        'Tx1
        '
        Me.Tx1.Location = New System.Drawing.Point(80, 13)
        Me.Tx1.Name = "Tx1"
        Me.Tx1.Size = New System.Drawing.Size(437, 23)
        Me.Tx1.TabIndex = 5
        Me.Tx1.Text = "温馨提示"
        '
        'Cx1
        '
        Me.Cx1.Location = New System.Drawing.Point(80, 42)
        Me.Cx1.Name = "Cx1"
        Me.Cx1.Size = New System.Drawing.Size(437, 23)
        Me.Cx1.TabIndex = 6
        Me.Cx1.Text = "生命诚可贵，节操价更高，若为拖堂故，二者皆可抛？"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "消息框内容"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "消息框标题"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.btnStart.Location = New System.Drawing.Point(205, 316)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(143, 32)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "开始"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(480, 316)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.btnAbout.Location = New System.Drawing.Point(16, 316)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 32)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "关于"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 356)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(587, 385)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "拖堂杀手"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkForce As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tx3 As System.Windows.Forms.TextBox
    Friend WithEvents Cx3 As System.Windows.Forms.TextBox
    Friend WithEvents Cx2 As System.Windows.Forms.TextBox
    Public WithEvents Tx1 As System.Windows.Forms.TextBox
    Public WithEvents Cx1 As System.Windows.Forms.TextBox
    Private WithEvents Tx2 As System.Windows.Forms.TextBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkSelect As System.Windows.Forms.CheckBox
    Friend WithEvents txtSet As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
