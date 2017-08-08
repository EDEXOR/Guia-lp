Public Class F4
    Dim ordenes() As Integer
    Dim total, totalfinal, vuelto, monto As Integer
    Dim i, j As Integer
    Dim ham, hot, pap, pag, sop, som, sog, papas, soda As Double

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        totalfinal = 0
        CCham = 0
        CChot = 0
        CCpap = 0
        CCpag = 0
        CCsop = 0
        CCsom = 0
        CCsog = 0
        j = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Cantidad de ordenes: " & j & vbNewLine & vbNewLine & "Dinero Total : $" & totalfinal & vbNewLine & vbNewLine &
               "Productos vendidos: " & vbNewLine & "    Hambuguesas: " & CCham & vbNewLine & "    Hotdog: " & CChot & vbNewLine &
               "    Papas Grandes: " & CCpag & vbNewLine & "    Papas Pequeñas: " & CCpap & vbNewLine & "    Soda pequeña: " & CCsop & vbNewLine &
               "    Soda mediana: " & CCsom & vbNewLine & "    Soda grande: " & CCsog & vbNewLine)

        Dim file As System.IO.StreamWriter
        My.Computer.FileSystem.CreateDirectory("C:\datoslp")
        My.Computer.FileSystem.CreateDirectory("C:\datoslp")
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\datoslp\recivo.txt", True)
        file.WriteLine("Cantidad de ordenes: " & j & vbNewLine & vbNewLine & "Dinero Total : $" & totalfinal & vbNewLine & vbNewLine &
               "Productos vendidos: " & vbNewLine & "    Hambuguesas: " & CCham & vbNewLine & "    Hotdog: " & CChot & vbNewLine &
               "    Papas Grandes: " & CCpag & vbNewLine & "    Papas Pequeñas: " & CCpap & vbNewLine & "    Soda pequeña: " & CCsop & vbNewLine &
               "    Soda mediana: " & CCsom & vbNewLine & "    Soda grande: " & CCsog & vbNewLine)
        file.Close()
    End Sub

    Dim CCham, CChot, CCpap, CCpag, CCsop, CCsom, CCsog, cantidad As Double
    Dim Cham, Chot, Cpap, Cpag, Csop, Csom, Csog As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Button3.Enabled = False
        TextBox5.Enabled = False
        Button4.Enabled = False
        ham = 3.0
        hot = 2
        pap = 0.5
        pag = 1.5
        sop = 1
        som = 1.5
        sog = 2
        j = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        total = 0
        Cham = 0
        Chot = 0
        Cpap = 0
        Cpag = 0
        Csop = 0
        Csom = 0
        Csog = 0
        If TextBox1.Text = "" Then
            Cham = 0
        Else
            Cham = TextBox1.Text
        End If
        If TextBox2.Text = "" Then
            Chot = 0
        Else
            Chot = TextBox1.Text
        End If



        Select Case ComboBox1.SelectedIndex

            Case 0
                Cpap = TextBox3.Text
                Cpag = 0
                papas = Cpap * pap
                CCpap = CCpap + Cpap
            Case 1
                Cpap = 0
                Cpag = TextBox3.Text
                papas = Cpag * pag
                CCpag = CCpag + Cpag
        End Select
        Select Case ComboBox1.SelectedIndex

            Case 0
                Csop = TextBox4.Text
                Csom = 0
                Csog = 0
                soda = Csop * sop
                CCsop = CCsop + Csop
            Case 1
                Csop = 0
                Csom = TextBox4.Text
                Csog = 0
                soda = Csom * som
                CCsom = CCsom + Csom
            Case 2
                Csop = 0
                Csom = 0
                Csog = TextBox4.Text
                soda = Csog * sog
                CCsog = CCsog + Csog

        End Select
        CCham = CCham + Cham
        CChot = CChot + Chot
        total = (soda + papas + (ham * Cham) + (hot * Chot))
        totalfinal = totalfinal + total

        Label6.Text = "$ " & total
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        TextBox5.Enabled = True
        Button4.Enabled = True
        If (TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "") Then
            MsgBox("Porfavor ingrese un dato")
            TextBox1.Text = 0
            TextBox2.Text = 0
            TextBox3.Text = 0
            TextBox4.Text = 0
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
            Button3.Enabled = True
            TextBox5.Enabled = False
            Button4.Enabled = False

        End If

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button2.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Button3.Enabled = False
        TextBox5.Enabled = False
        Button4.Enabled = False
        monto = TextBox5.Text
        total = (soda + papas + (ham * Cham) + (hot * Chot))
        If monto < total Then
            vuelto = (monto - total)
            MsgBox("El vuelto es: $ " & vuelto)
            MsgBox("Monto insuficiente")
            TextBox5.Enabled = True
            Button4.Enabled = True

        Else
            vuelto = (monto - total)
            MsgBox("El vuelto es: $ " & vuelto)
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        j = j + 1
        Label10.Text = "ORDEN: #"
        Label9.Text = j
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        Button3.Enabled = True
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        Label6.Text = "$ 0"
    End Sub
    Private Sub Me_Closing() Handles Me.FormClosing
        Index.Show()
    End Sub
End Class