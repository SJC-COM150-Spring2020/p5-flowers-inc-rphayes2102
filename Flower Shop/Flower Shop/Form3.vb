Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        'check textbox for flowers and quantity
        Dim Flowers As Double
        Dim textbox.text As String
        txtFlower.Text("pick your flwowes")

        If Flowers Then



            'check accent for items that are checked
            Dim accents As Double


            If (chkBabyBreath.Checked = True) Then
            lstbox.items.add("Baby Breath- 1.5")
                accents = accents

            End If
        If (chkMini.Checked = True) Then
            lstbox.items.add("Mini Spray Roses- 2.65")
            accents = accents + 2.65
        End If
        If (chkFern.Checked = True) Then
            lstbox.items.add("Leather Leaf Fern- 1.25")
            accents = accents + 1.25
        End If

            'select a container
            Dim container As String
            Dim Price As Double
            If (radBasket.Checked = True) Then
                container = "Basket"
                Price = 6.0
            End If
            If (radMasonJar.Checked = True) Then
                container = "Mason Jar"
                Price = 4.0
            End If
            If (radVase.Checked = True) Then
                container = "Vase"
                Price = 8.0
            End If
        End If

    End Sub
End Class