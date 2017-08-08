Public Class F5
    'Palabras posibles y variables globales
    Private ReadOnly words4() As String = {"GUIA", "AUTO", "DAMN", "AZUL", "VACA", "BAÑO", "BAJO", "CARO", "CASA", "PELO"}
    Private ReadOnly words6() As String = {"LENGUA", "TARADO", "CUERVO", "LETRAS", "HOMBRO", "COCINA", "PAJARO", "PIERNA", "BRAZOS", "ALMEJA"}
    Private ReadOnly words8() As String = {"ESCUCHAR", "BARBACOA", "IMAGENES", "DESAYUNO", "BOLSILLO", "CELEBRAR", "CUBIERTO", "TRADUCTOR", "LIBERTAD", "ESCONDER"}
    Private sele As String = ""
    Private errer As Integer = 0
    Private ran As Random = New Random
    Private Sub fin() 'final del juego
        DataGridView1.Rows.Clear()
        Label1.Text = ""
        errer = 0
        PictureBox1.Image = Nothing
        Panel1.Enabled = False
        GroupBox1.Enabled = True
    End Sub
    Private Sub win() 'Partida ganada
        MsgBox("Ganaste amigo!!!!", MsgBoxStyle.Information)
        fin()
    End Sub
    Private Sub lose() 'Partida perdida
        MsgBox("Perdiste amigo!!!!", MsgBoxStyle.Information)
        fin()
    End Sub
    Private Sub put_let() 'Settear letras
        For Each c As Control In Me.TableLayoutPanel1.Controls
            Select Case c.Name
                Case "LabelA" : c.Text = "A"
                Case "LabelB" : c.Text = "B"
                Case "LabelC" : c.Text = "C"
                Case "LabelD" : c.Text = "D"
                Case "LabelE" : c.Text = "E"
                Case "LabelF" : c.Text = "F"
                Case "LabelG" : c.Text = "G"
                Case "LabelH" : c.Text = "H"
                Case "LabelI" : c.Text = "I"
                Case "LabelJ" : c.Text = "J"
                Case "LabelK" : c.Text = "K"
                Case "LabelL" : c.Text = "L"
                Case "LabelM" : c.Text = "M"
                Case "LabelN" : c.Text = "N"
                Case "LabelN_" : c.Text = "Ñ"
                Case "LabelO" : c.Text = "O"
                Case "LabelP" : c.Text = "P"
                Case "LabelQ" : c.Text = "Q"
                Case "LabelR" : c.Text = "R"
                Case "LabelS" : c.Text = "S"
                Case "LabelT" : c.Text = "T"
                Case "LabelU" : c.Text = "U"
                Case "LabelV" : c.Text = "V"
                Case "LabelW" : c.Text = "W"
                Case "LabelX" : c.Text = "X"
                Case "LabelY" : c.Text = "Y"
                Case "LabelZ" : c.Text = "Z"
            End Select
        Next
    End Sub
    Private Sub sett(opc As Integer, word As String) 'Inicio del juego
        sele = word
        Dim i As Integer
        Dim w() As Char = word
        Dim data As DataGridView = DataGridView1
        data.ColumnCount = opc
        For i = 0 To opc - 1 Step 1
            data.Rows(0).Cells(i).Value = "__"
            data.Columns(i).Width = 15
        Next i
        put_let()
        PictureBox1.Image = Nothing
        'Label1.Text = word & " -> " & opc
    End Sub
    Private Sub ver(letter As Char) 'verificacion de las letras
        Dim t As Boolean = True
        Dim i As Integer = 0
        For Each c As Char In sele
            If c.ToString.ToLower.Equals(letter.ToString.ToLower) Then
                DataGridView1.Rows(0).Cells(i).Value = c
                t = False
            End If
            i += 1
        Next
        If t Then errer += 1
        Select Case errer
            Case 1 : PictureBox1.Image = My.Resources.F5_1
            Case 2 : PictureBox1.Image = My.Resources.F5_2
            Case 3 : PictureBox1.Image = My.Resources.F5_3
            Case 4 : PictureBox1.Image = My.Resources.F5_4
            Case 5 : PictureBox1.Image = My.Resources.F5_5
            Case 6 : PictureBox1.Image = My.Resources.F5_6
            Case Else : PictureBox1.Image = Nothing
        End Select
        For Each c As Control In Me.TableLayoutPanel1.Controls
            If TypeOf c Is Label Then
                If c.Text.ToLower = letter.ToString.ToLower Then
                    'If t And c.Text.Equals("--") Then errer -= 1
                    c.Text = "--"
                End If
            End If
        Next
        t = True
        For Each c As DataGridViewCell In DataGridView1.Rows(0).Cells
            If c.Value.Equals("__") Then t = False
        Next
        If t Then win()
        If errer = 6 Then lose()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ComboBox1.SelectedItem Is Nothing Then
            Dim n As Integer = ran.Next(0, 2)
            Select Case ComboBox1.SelectedIndex 'seleccion de opciones
                Case 0 : sett(4, words4(n))
                Case 1 : sett(6, words6(n))
                Case 2 : sett(8, words8(n))
            End Select
            Panel1.Enabled = True
            GroupBox1.Enabled = False
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fin()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cons() = New String() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim letter As String = ""

        Dim correct As Boolean = False
        Do Until correct 'comprobacion de las letras
            letter = InputBox("Ingrese la letra: ")
            Dim result As String() = Array.FindAll(cons, Function(s) s.Equals(letter.Substring(0, 1).ToLower))
            If (result.Length = 1) Then correct = True
        Loop

        ver(letter.Substring(0, 1))

    End Sub
    Private Sub Me_Closing() Handles Me.FormClosing 'retorno
        Index.Show()
    End Sub
End Class