Public Class Form15
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f4 As New Form4
        f4.Show()
        Me.Hide()
    End Sub
End Class