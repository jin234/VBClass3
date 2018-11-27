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
            LabelPasswordCheck.Text = ""
            LabelPasswordCheck.ForeColor = DefaultBackColor
        End If

        If TextBoxPassword.Text = TextBoxPasswordCheck.Text Then
            LabelPasswordCheck.Text = "Correct"
            LabelPasswordCheck.ForeColor = Color.Green
        Else
            LabelPasswordCheck.Text = "Incorrect"
            LabelPasswordCheck.ForeColor = Color.Red
        End If

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click

        If TextBoxUsername.TextLength = 0 Then
            MessageBox.Show("Please Insert Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TextBoxPassword.TextLength = 0 Or TextBoxPasswordCheck.TextLength = 0 Then
            MessageBox.Show("Please Insert password or Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TextBoxPassword.Text <> TextBoxPasswordCheck.Text Then
            MessageBox.Show("Password And Confirm Password Missmatch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Please Choose Your Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckBoxLanguageThai.Checked = False And CheckBoxLanguageEnglish.Checked = False And CheckBoxLanguageJapaness.Checked = False And CheckBoxLanguageChiness.Checked = False And CheckBoxLanguageOther.Checked = False Then
            MessageBox.Show("Please Choose Your Language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckBoxLanguageOther.Checked And TextBoxLanguageOther.TextLength = 0 Then
            MessageBox.Show("Please insert your Other Language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Gender As String = ""
        Dim Language As String = ""
        If RadioButton1.Checked = True Then
            Gender = "Male"
        Else
            Gender = "Female"
        End If

        If CheckBoxLanguageThai.Checked Then
            Language += "Thai "
        End If
        If CheckBoxLanguageEnglish.Checked Then
            Language += "English "
        End If
        If CheckBoxLanguageChiness.Checked Then
            Language += "chiness "
        End If
        If CheckBoxLanguageJapaness.Checked Then
            Language += "Japaness "
        End If
        If CheckBoxLanguageOther.Checked Then
            Language += TextBoxLanguageOther.Text
        End If

        MessageBox.Show("Username : " & TextBoxUsername.Text & vbNewLine &
                        "Gender : " & Gender & vbNewLine &
                        "You can speak : " & Language)




    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        TextBoxPasswordCheck.Text = ""
        TextBoxLanguageOther.Text = ""
        LabelPasswordCheck.Text = ""
        LabelPasswordResult.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        CheckBoxLanguageChiness.Checked = False
        CheckBoxLanguageEnglish.Checked = False
        CheckBoxLanguageJapaness.Checked = False
        CheckBoxLanguageOther.Checked = False
        CheckBoxLanguageThai.Checked = False



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
