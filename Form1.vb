Public Class frmCalculDeducereTVA


    Private Sub btnCalcul_Click(sender As Object, e As EventArgs) Handles btnCalcul.Click
        txtTVA.Text = Val(txtValFTVA.Text) * 0.24
        txtValCuTVA.Text = Val(txtValFTVA.Text) + Val(txtTVA.Text)
    End Sub
    Private Sub btnDeducere_Click(sender As Object, e As EventArgs) Handles btnDeducere.Click
        txtDTVA.Text = Val(txtDValCuTVA.Text) * 24 / 124
        txtDValFTVA.Text = Val(txtDValCuTVA.Text) * 100 / 124
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValFTVA.Clear()
        txtTVA.Clear()
        txtValCuTVA.Clear()
        txtDValCuTVA.Clear()
        txtDTVA.Clear()
        txtDValFTVA.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

End Class

