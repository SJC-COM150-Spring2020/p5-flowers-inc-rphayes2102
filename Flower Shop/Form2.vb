Public Class Form2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (radSunflowers.Checked) = True Then
            lstBox.Items.Add(" You love to be around people and make new friends.")

        ElseIf (radRoses.Checked) = True Then
            lstBox.Items.Add("You think with your heart and know how to make a statement")

        ElseIf (radLilies.Checked) = True Then
            lstBox.Items.Add("You are hard worker and proud of all you accomplish.")
        ElseIf (radDaisies.Checked) = True Then
            lstBox.Items.Add(" You are an optimist who can find the good in any bad situation")
        ElseIf (radDaffodils.Checked) = True Then
            lstBox.Items.Add("You are fun and laid-back and always put friends and family first")
        ElseIf (radTulips.Checked) = True Then
            lstBox.Items.Add("You are thoughtful and confident and are always coordinated.")
        End If

        If radRoses.Checked = True Then
            lstBox.Items.Add("You chose Rose")
            picRose.Visible = True
        ElseIf radSunflowers.Checked = True Then
            lstBox.Items.Add("You chose Sunflower")
            picSunflower.Visible = True
        ElseIf radDaffodils.Checked = True Then
            lstBox.Items.Add("You chose Daffodil")
            picDafodil.Visible = True
        ElseIf radDaisies.Checked = True Then
            lstBox.Items.Add("You chose Daisies")
            picDaises.Visible = True
        ElseIf radLilies.Checked = True Then
            lstBox.Items.Add("You chose Lily")
            picLily.Visible = True
        ElseIf radTulips.Checked = True Then
            lstBox.Items.Add("You chose Tulips")
            picTulip.Visible = True





        End If







    End Sub

End Class