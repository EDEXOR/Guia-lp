Public Class F2
    'preguntas y respuestas 
    Dim hombres As Integer
    Dim mujeres As Integer
    Dim pregunta1y, pregunta1n, pregunta2y, pregunta2n, pregunta3y, pregunta3n As Integer
    Dim pregunta1ym, pregunta1nm, pregunta2ym, pregunta2nm, pregunta3ym, pregunta3nm As Integer

    Dim re1, re1n, re2, re2n, re3, re3n As Integer
    Dim re1m, re1mn, re2m, re2mn, re3m, re3mn As Integer
    Private Sub cal() 'calculo de resultados en respuestas
        Dim totalpersonas As Integer = hombres + mujeres
        re1 = ((pregunta1y / totalpersonas) * 100)
        re1n = ((pregunta1n / totalpersonas) * 100)
        re2 = ((pregunta2y / totalpersonas) * 100)
        re2n = ((pregunta2n / totalpersonas) * 100)
        re3 = ((pregunta3y / totalpersonas) * 100)
        re3n = ((pregunta3n / totalpersonas) * 100)
        re1m = ((pregunta1ym / totalpersonas) * 100)
        re1mn = ((pregunta1nm / totalpersonas) * 100)
        re2m = ((pregunta2ym / totalpersonas) * 100)
        re2mn = ((pregunta2nm / totalpersonas) * 100)
        re3m = ((pregunta3ym / totalpersonas) * 100)
        re3mn = ((pregunta3nm / totalpersonas) * 100)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text += 1
        If Label6.Text = "60" Then
            Label4.Text += 1
            Label6.Text = "00"
            If Label4.Text = "5" Then
                Timer1.Enabled = False
                Panel1.Enabled = False
                Button1.Enabled = True
                cal()
                MsgBox("¡Tiempo de encuesta agotado!", MsgBoxStyle.Exclamation)
                'llenado de char 1
                Me.Chart1.Series("1").Points.Add(re1)
                Me.Chart1.Series("1").Points.Item(0).Label = "Hombres SI"
                Me.Chart1.Series("1").Points.Add(re1n)
                Me.Chart1.Series("1").Points.Item(1).Label = "Hombres NO"
                Me.Chart1.Series("1").Points.Add(re1m)
                Me.Chart1.Series("1").Points.Item(2).Label = "Mujeres SI"
                Me.Chart1.Series("1").Points.Add(re1mn)
                Me.Chart1.Series("1").Points.Item(3).Label = "Mujeres NO"
                'llenado de char 2
                Me.Chart2.Series("2").Points.Add(re2)
                Me.Chart2.Series("2").Points.Item(0).Label = "Hombres SI"
                Me.Chart2.Series("2").Points.Add(re2n)
                Me.Chart2.Series("2").Points.Item(1).Label = "Hombres NO"
                Me.Chart2.Series("2").Points.Add(re2m)
                Me.Chart2.Series("2").Points.Item(2).Label = "Mujeres SI"
                Me.Chart2.Series("2").Points.Add(re2mn)
                Me.Chart2.Series("2").Points.Item(3).Label = "Mujeres NO"
                'llenado de char 3
                Me.Chart3.Series("3").Points.Add(re3)
                Me.Chart3.Series("3").Points.Item(0).Label = "Hombres SI"
                Me.Chart3.Series("3").Points.Add(re3n)
                Me.Chart3.Series("3").Points.Item(1).Label = "Hombres NO"
                Me.Chart3.Series("3").Points.Add(re3m)
                Me.Chart3.Series("3").Points.Item(2).Label = "Mujeres SI"
                Me.Chart3.Series("3").Points.Add(re3mn)
                Me.Chart3.Series("3").Points.Item(3).Label = "Mujeres NO"
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'setteo de inicio de encuesta
        Timer1.Start()
        Panel1.Enabled = True
        Button1.Enabled = False
        Label2.Text = "00"
        Label4.Text = "00"
        Label6.Text = "00"
        hombres = 0
        mujeres = 0
        If Chart1.Series("1").Points.Count > 0 Then
            Chart1.Series("1").Points.Clear()
            Chart2.Series("2").Points.Clear()
            Chart3.Series("3").Points.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'registro de la informacion
        If (RadioButton1.Checked Xor RadioButton2.Checked) And
            (RadioButton3.Checked Xor RadioButton4.Checked) And
            (RadioButton5.Checked Xor RadioButton6.Checked) And
            (RadioButton7.Checked Xor RadioButton8.Checked) Then

            'Ahora viene el calculo para los hombres'
            If RadioButton1.Checked Then
                hombres += 1
                If RadioButton3.Checked Then
                    pregunta1y += 1
                ElseIf RadioButton4.Checked Then
                    pregunta1n += 1
                End If
                If RadioButton5.Checked Then
                    pregunta2y += 1
                ElseIf RadioButton6.Checked Then
                    pregunta2n += 1
                End If
                If RadioButton7.Checked Then
                    pregunta3y += 1
                ElseIf RadioButton8.Checked Then
                    pregunta3n += 1
                End If
            End If
            'Ahora viene el calculo para las mujeres
            If RadioButton2.Checked Then
                mujeres += 1
                If RadioButton3.Checked Then
                    pregunta1ym += 1
                ElseIf RadioButton4.Checked Then
                    pregunta1nm += 1
                End If
                If RadioButton5.Checked Then
                    pregunta2ym += 1
                ElseIf RadioButton6.Checked Then
                    pregunta2nm += 1
                End If
                If RadioButton7.Checked Then
                    pregunta3ym += 1
                ElseIf RadioButton8.Checked Then
                    pregunta3nm += 1
                End If
            End If
            'reinicio de los radiobutton
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            Label7.Text = ""
        Else
            Label7.Text = "Selecciona una opcion para continuar"
        End If
    End Sub

    Private Sub Me_Closing() Handles Me.FormClosing
        Index.Show()
    End Sub
End Class