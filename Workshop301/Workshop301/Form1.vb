Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MessageBox.Show("กรุณาเลือกบัตรสมาชิก", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            Dim NumPerson As Integer = CInt(TextBox1.Text)
            Dim CostPerPerson As Integer = 299
            Dim Total As Integer = NumPerson * CostPerPerson

            If RadioButton1.Checked Then
                Total *= 0.95
            End If

            If RadioButton2.Checked Then
                Total *= 0.9
            End If

            If RadioButton3.Checked Then
                Total *= 1
            End If

            Label4.Text = Format(Total, "#,###.00") & " บาท"

        Catch ex As Exception
            MessageBox.Show("กรุณาป้อนจำนวนลูกค้าเป็นตัวเลข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = False
        TextBox1.Text = ""
        Label4.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength <> 0 Then
            Button1.Enabled = True
            Button2.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False

        End If

    End Sub

End Class
