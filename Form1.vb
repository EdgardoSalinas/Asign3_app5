Public Class Form1
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim costo_auto As Double
        Dim pct_vendedor As Double
        Dim impuesto As Double
        Dim costototal As Double

        Dim r_ganancia As Double
        Dim r_impuesto As Double

        costo_auto = txt_costo.Text
        pct_vendedor = txt_pctganancia.Text
        impuesto = txt_impuesto.Text

        r_ganancia = costo_auto * (pct_vendedor / 100)
        r_impuesto = costo_auto * (impuesto / 100)
        costototal = costo_auto + r_ganancia + r_impuesto

        txt_costototalauto.Text = costototal

    End Sub
End Class
