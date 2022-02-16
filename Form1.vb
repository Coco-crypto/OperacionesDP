Public Class Form1

    Dim servicio As New ServiceReference1.CalculadoraSoapClient

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        Dim nro1, nro2 As Double
        nro1 = txt1.Text
        nro2 = txt2.Text
        Dim suma As Double = servicio.Suma(nro1, nro2)
        tresultado.Text = suma.ToString()
    End Sub

    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        Dim nro1, nro2 As Double
        nro1 = txt1.Text
        nro2 = txt2.Text
        Dim resta As Double = servicio.Resta(nro1, nro2)
        tresultado.Text = resta.ToString()
    End Sub

    Private Sub residuo_Click(sender As Object, e As EventArgs) Handles residuo.Click
        Dim nro1, nro2 As Double
        nro1 = txt1.Text
        nro2 = txt2.Text
        Dim residuo As Double = servicio.Residuo(nro1, nro2)
        tresultado.Text = residuo.ToString()
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        Dim nro1, nro2 As Double
        nro1 = txt1.Text
        nro2 = txt2.Text
        Dim division As Double = servicio.Division(nro1, nro2)
        tresultado.Text = division.ToString()
    End Sub

    Private Sub potencia_Click(sender As Object, e As EventArgs) Handles potencia.Click
        Dim nro1, nro2 As Double
        nro1 = txt1.Text
        nro2 = txt2.Text
        Dim potencia As Double = servicio.Potencia(nro1, nro2)
        tresultado.Text = potencia.ToString()
    End Sub

    Private Sub factorial_Click(sender As Object, e As EventArgs) Handles factorial.Click
        Dim nro1 As Double
        nro1 = txt1.Text
        Dim factorial As Double = servicio.Fact(nro1)
        tresultado.Text = factorial.ToString()
    End Sub

    Private Sub multiplicacion_Click(sender As Object, e As EventArgs) Handles multiplicacion.Click
        Dim nro1, nro2 As Double
        nro1 = txt1.Text
        nro2 = txt2.Text
        Dim multiplicacion As Double = servicio.Multiplicacion(nro1, nro2)
        tresultado.Text = multiplicacion.ToString()
    End Sub

    Private Sub raiz_Click(sender As Object, e As EventArgs) Handles raiz.Click
        Dim nro1 As Double
        nro1 = txt1.Text
        Dim raiz As Double = servicio.Raiz_cuadrada(nro1)
        tresultado.Text = raiz.ToString()
    End Sub

    Private Sub logn_Click(sender As Object, e As EventArgs) Handles logn.Click
        Dim nro1 As Double
        nro1 = txt1.Text
        Dim logn As Double = servicio.Logaritmo_Natural(nro1)
        tresultado.Text = logn.ToString()
    End Sub

    Private Sub logb10_Click(sender As Object, e As EventArgs) Handles logb10.Click
        Dim nro1 As Double
        nro1 = txt1.Text
        Dim logb10 As Double = servicio.Logaritmo_base10(nro1)
        tresultado.Text = logb10.ToString()
    End Sub
End Class
