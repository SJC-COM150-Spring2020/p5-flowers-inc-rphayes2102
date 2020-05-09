Public Class Form2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radSunflowers_CheckedChanged(sender As Object, e As EventArgs) Handles radSunflowers.CheckedChanged

        Dim Description As String
        If (radSunflowers.Checked = True) Then
            Description = "You love to be around people and make new friends"
        End If

    End Sub

    Private Sub radRoses_CheckedChanged(sender As Object, e As EventArgs) Handles radRoses.CheckedChanged
        Dim Description As String
        If (radRoses.Checked = True) Then
            Description = "You think with your heart and know how to make a statement"
        End If
    End Sub

    Private Sub radTulips_CheckedChanged(sender As Object, e As EventArgs) Handles radTulips.CheckedChanged
        Dim Description As String
        If (radTulips.Checked = True) Then
            Description = "You are thoughtful and confident and are always coordinated."

        End If
    End Sub

    Private Sub radDaisies_CheckedChanged(sender As Object, e As EventArgs) Handles radDaisies.CheckedChanged
        Dim description As String
        If (radDaisies.Checked = True) Then
            description = " You are an optimist who can find the good in any bad situation"
        End If
    End Sub

    Private Sub radDaffodils_CheckedChanged(sender As Object, e As EventArgs) Handles radDaffodils.CheckedChanged
        Dim Description As String
        If (radDaffodils.Checked = True) Then
            Description = "You are fun and laid-back and always put friends and family first"
        End If
    End Sub

    Private Sub radLilies_CheckedChanged(sender As Object, e As EventArgs) Handles radLilies.CheckedChanged
        Dim Description As String
        If (radLilies.Checked = True) Then
            Description = "You are hard worker and proud of all you accomplish."
        End If
    End Sub
End Class