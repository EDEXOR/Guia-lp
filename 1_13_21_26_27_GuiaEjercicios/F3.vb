Public Class F3
    Dim x As Integer = 0 'Declaramos las variables a usar
    Dim s As Integer = 0 'Declaramos las variables a usar
    Private Sub Me_Closing() Handles Me.FormClosing
        Index.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Index.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click 'encendido del timer
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click ' apagado del timer
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'Funcion del timer
        s += 1
        If s = 5 Then
            s = 0
            x += 1
            If x = 8 Then x = 1
            sho(x)
        End If
    End Sub
    Private Sub sho(e As Integer)
        Select Case e
            Case 1 : PictureBox1.Image = My.Resources.uno 'Mandamos a llamar las imagenes
            Case 2 : PictureBox1.Image = My.Resources.dos   'Mandamos a llamar las imagenes
            Case 3 : PictureBox1.Image = My.Resources.tres 'Mandamos a llamar las imagenes
            Case 4 : PictureBox1.Image = My.Resources.cuatro 'Mandamos a llamar las imagenes
            Case 5 : PictureBox1.Image = My.Resources.cinco 'Mandamos a llamar las imagenes
            Case 6 : PictureBox1.Image = My.Resources.seis 'Mandamos a llamar las imagenes
            Case 7 : PictureBox1.Image = My.Resources.siete 'Mandamos a llamar las imagenes
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'primera imagen
        x = 1
        sho(x)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'ultima imagen
        x = 7
        sho(x)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'imagen anterior
        x -= 1
        If x = 0 Then x = 7
        sho(x)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'imagen siguiente
        x += 1
        If x = 8 Then x = 1
        sho(x)
    End Sub
End Class