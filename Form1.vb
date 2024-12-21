Imports System.Reflection.Emit

Public Class Form1
    Private Sub btnafficher_Click(sender As Object, e As EventArgs) Handles btnafficher.Click
        If lsttaille.SelectedItem Is Nothing Then
            MessageBox.Show("veiullez verifier la taille du pizza")
        End If
        Dim taille As String = lsttaille.SelectedItem.ToString()
        Dim ingredient As String = ""
        If rdprop1.checked Then
            ingredient = "croute fine"
        ElseIf rdprop2.Checked Then
            ingredient = "croute classique"
        ElseIf rdprop3.Checked Then
            ingredient = "croute epaisse"
        End If

        Dim ingredient_supp As String = ""
        Dim aucun_ingredient As Boolean = True
        If chk1.Checked Then
            ingredient_supp = "Champingnons"
            aucun_ingredient = False
        ElseIf chk2.Checked Then
            ingredient_supp = "Olives"
            aucun_ingredient = False
        ElseIf chk3.Checked Then
            ingredient_supp = "Poivrons"
            aucun_ingredient = False
        ElseIf chk4.Checked Then
            ingredient_supp = "Fromages suplémentaires"
            aucun_ingredient = False
        End If
        If aucun_ingredient = True Then
            affichage.Text = ingredient + " aucun ingredient supplementaire"
        Else
            affichage.Text = ingredient + " " + ingredient_supp
        End If

    End Sub


End Class

