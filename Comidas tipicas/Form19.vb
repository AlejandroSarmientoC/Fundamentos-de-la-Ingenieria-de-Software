Public Class Form19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("debe completar el campo")
            Return
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("debe completar el campo")
            Return
        ElseIf String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("debe completar el campo")
            Return
        Else
            Form2.Show()
            Me.Hide()

        End If



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""



    End Sub
End Class