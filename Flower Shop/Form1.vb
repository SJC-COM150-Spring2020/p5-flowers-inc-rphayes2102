Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnBouquet_Click(sender As Object, e As EventArgs) Handles btnBouquet.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
