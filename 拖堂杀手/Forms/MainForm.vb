Public Class MainForm
    Const Question As Boolean = True
    Const Shutdown As Boolean = False
    Dim SQuest, SShut As Boolean
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Visible = False
        Me.ShowInTaskbar = False
        Dim c1, c2, c3, t1, t2, t3 As String
        Dim time As Short
        Dim dbset As Double = txtTime.Text
        Dim tnow As Date = Date.Now
        Dim tset As Date = DateAdd(DateInterval.Minute, dbset, tnow)
        c1 = Cx1.Text
        c2 = Cx2.Text
        c3 = Cx3.Text
        t1 = Tx1.Text
        t2 = Tx2.Text
        t3 = Tx3.Text
        time = txtSet.Text
        Do
        Loop Until DateDiff(DateInterval.Second, tset, Date.Now) = 0
        If chkForce.Checked = False Then
            If chkSelect.Checked = True Then
                If RB1.Checked = True Then
                    If (MessageBox.Show(c1, t1, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then
                        End
                    End If
                ElseIf RB2.Checked = True Then
                    If (MessageBox.Show(c1, t1, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.No Then
                        End
                    End If
                ElseIf RB3.Checked = True Then
                    If (MessageBox.Show(c1, t1, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.No Then
                    End If
                End If
            Else
                MessageBox.Show(c1, t1, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            tset = DateAdd(DateInterval.Second, 30, Date.Now)
            Do
            Loop Until DateDiff(DateInterval.Second, tset, Date.Now) = 0
            MessageBox.Show(c2, t2, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tset = DateAdd(DateInterval.Second, 30, Date.Now)
            Do
            Loop Until DateDiff(DateInterval.Second, tset, Date.Now) = 0
            MessageBox.Show(c3, t3, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Shell("C:\Windows\System32\shutdown.exe -s " & "-t " & time, AppWinStyle.Hide, False)
        Else
            Shell("C:\Windows\System32\shutdown.exe -s " & "-t " & time, AppWinStyle.Hide, False)
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQuest = Question
        chkSelect.Checked = SQuest
        RB1.Enabled = True
        RB2.Enabled = True
        RB3.Enabled = True

    End Sub

    Private Sub chkSelect_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelect.CheckedChanged
        RB1.Enabled = Not (RB1.Enabled)
        RB2.Enabled = Not (RB2.Enabled)
        RB3.Enabled = Not (RB3.Enabled)
    End Sub
End Class
