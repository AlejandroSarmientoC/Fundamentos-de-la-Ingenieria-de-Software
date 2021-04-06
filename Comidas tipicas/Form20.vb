Public Class Form20
    Dim contador As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Haz completado con exito el cuestionario las respuestas seran enviadas a su profesor encargado")
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 250
        Me.Label23.Text = contador

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador = contador - 1
        Me.Label23.Text = contador
        If contador = 0 Then
            MsgBox("Se acabo el tiempo las respuestas seran enviadas a su profesor encargado")
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class