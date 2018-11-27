Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBoxName.TextLength = 0 Then
            MessageBox.Show("คุณไม่ได้กรอกชื่อลูกค้า", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MessageBox.Show("คุณไม่ได้เลือกปริมาณข้าว", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False Then
            MessageBox.Show("คุณไม่ได้เลือกหน้า", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Cost As Integer = 0
        If RadioButton1.Checked Then
            Cost += 10
        ElseIf RadioButton2.Checked Then
            Cost += 15
        ElseIf RadioButton3.Checked Then
            Cost += 20
        Else
            Cost += 0
        End If
        If CheckBox1.Checked Then
            Cost += 45
        End If
        If CheckBox2.Checked Then
            Cost += 20
        End If
        If CheckBox3.Checked Then
            Cost += 30
        End If
        If CheckBox4.Checked Then
            Cost += 50
        End If
        Dim fontstyle As FontStyle = FontStyle.Regular
        fontstyle += FontStyle.Bold
        TextBoxTotal.Font = New Font("Arial", 14, fontstyle)
        TextBoxTotal.Text = Format(Cost, "#,###.00") & " บาท"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxName.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        TextBoxTotal.Text = ""
    End Sub
End Class
