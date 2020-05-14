'declare global variables
Module globalvariables
    Public Rose As Integer
    Public totalrose As Double
    Public Daisies As Integer
    Public totaldaises As Double
    Public Hydranges As Integer
    Public totalhydranges As Double
    Public Lily As Integer
    Public totallily As Double
    Public totalflowers As Double


    Public accents As Double
    Public Containers As Double
    Public tax As Double = 0.08875
    Public total As Double
    Public totaltax As Double
    Public subtotal As Double

End Module







Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click


        'check textbox for flowers and quantity
        Rose = txtRose.Text
        totalrose = 2.8 * Rose

        Daisies = txtDaises.Text
        totaldaises = 2 * Daisies

        Lily = txtLily.Text
        totallily = 3 * Lily

        Hydranges = txtHydranges.Text
        totalhydranges = 5 * Hydranges








        'check accent for items that are checked


        If (chkBabyBreath.Checked = True) Then
            Form4.lstBox.Items.Add("Baby Breath -1.5")
            accents = accents

        End If
            If (chkMini.Checked = True) Then
            Form4.lstbox.items.add("Mini Spray Roses- 2.65")
            accents = accents + 2.65
            End If
            If (chkFern.Checked = True) Then
            Form4.lstBox.Items.Add("Leather Leaf Fern- 1.25")
            accents = accents + 1.25
            End If

        'select a container

        If (radBasket.Checked = True) Then
            Form4.lstBox.Items.Add("Basket")
            Containers = 6.0
        End If
            If (radMasonJar.Checked = True) Then
            Form4.lstBox.Items.Add("Mason Jar")
            Containers = 4.0

        End If
            If (radVase.Checked = True) Then
            Form4.lstBox.Items.Add("Vase")
        End If

        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class