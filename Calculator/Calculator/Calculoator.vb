Imports CalcDLLProject

Public Class Calculoator
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add As New CalcDLLProject.MyFunctions
        lblResult.Text = add.AddValues(CDbl(txtVal1.Text), CDbl(txtValue2.Text)).ToString
    End Sub
End Class
