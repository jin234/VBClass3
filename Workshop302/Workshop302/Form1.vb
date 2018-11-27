Public Class Form1

    Private Sub TextBoxpassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

        If TextBoxPassword.TextLength = 0 Then
            LabelPasswordResult.Text = ""
            LabelPasswordResult.ForeColor = DefaultBackColor
        End If

        If TextBoxPassword.TextLength >= 1 Then
            LabelPasswordResult.Text = "Quality : Low"
            LabelPasswordResult.ForeColor = Color.Red
        End If

        If TextBoxPassword.TextLength >= 5 Then
            LabelPasswordResult.Text = "Quality : Medium"
            LabelPasswordResult.ForeColor = Color.OrangeRed
        End If

        If TextBoxPassword.TextLength >= 10 Then
            LabelPasswordResult.Text = "Quality : Hard"
            LabelPasswordResult.ForeColor = Color.Green
        End If

    End Sub

    Private Sub TextBoxPasswordCheck_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPasswordCheck.TextChanged, TextBoxPassword.TextChanged

        If TextBoxPasswordCheck.TextLength = 0 Then
            LabelPasswordResult.Text = ""
            LabelPasswordResult.ForeColor = DefaultBackColor
        End If

        If TextBoxPassword.Text = TextBoxPasswordCheck.Text Then
            LabelPasswordCheck.Text = "Correct"
            LabelPasswordCheck.BackColor = Color.Green
        Else
            LabelPasswordCheck.Text = "Incorrect"
            LabelPasswordCheck.BackColor = Color.Red
        End If

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click

        If TextBoxUsername.TextLength = 0 Then
            MessageBox.Show("Please Insert Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If TextBoxPassword.TextLength = 0 Or TextBoxPasswordCheck.TextLength = 0 Then
            MessageBox.Show("Please Insert password or Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Please Choose Your Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If CheckBoxLanguageThai.Checked = False And CheckBoxLanguageEnglish.Checked = False And CheckBoxLanguageJapaness.Checked = False And CheckBoxLanguageChiness.Checked = False And CheckBoxLanguageOther.Checked = False Then
            MessageBox.Show("Please Choose Your Language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If CheckBoxLanguageOther.Checked And TextBoxLanguageOther.TextLength = 0 Then
            MessageBox.Show("Please insert your Other Language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
