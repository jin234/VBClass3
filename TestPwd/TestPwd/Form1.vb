Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.TextLength = 0 Then
            LabelResult.Text = ""
            LabelResult.BackColor = DefaultBackColor
        End If

        If TextBox1.TextLength >= 1 Then
            LabelResult.Text = "Low"
            LabelResult.BackColor = Color.Red
        End If

        If TextBox1.TextLength >= 7 Then
            LabelResult.Text = "Medium"
            LabelResult.BackColor = Color.Orange
        End If

        If TextBox1.TextLength >= 10 Then
            LabelResult.Text = "Hard"
            LabelResult.BackColor = Color.Green
        End If




    End Sub


End Class
