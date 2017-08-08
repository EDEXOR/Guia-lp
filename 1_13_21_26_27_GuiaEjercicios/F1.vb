
Public Class F1
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox4.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value) 'Asignar color al textbox segun los valores de las barras
        TextBox1.Text = HScrollBar1.Value ' Se mostrara el valor entre el 0 y el 255 segun el idndicado por el usuario
        Label5.Text = HScrollBar1.Value & "," & HScrollBar2.Value & "," & HScrollBar3.Value 'numero en rgb
        Label6.Text = Hex(HScrollBar1.Value) & Hex(HScrollBar2.Value) & Hex(HScrollBar3.Value) 'numero en hexadecimal
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        TextBox4.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        TextBox2.Text = HScrollBar2.Value
        Label5.Text = HScrollBar1.Value & "," & HScrollBar2.Value & "," & HScrollBar3.Value
        Label6.Text = Hex(HScrollBar1.Value) & Hex(HScrollBar2.Value) & Hex(HScrollBar3.Value)
    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        TextBox4.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        TextBox3.Text = HScrollBar2.Value
        Label5.Text = HScrollBar1.Value & "," & HScrollBar2.Value & "," & HScrollBar3.Value
        Label6.Text = Hex(HScrollBar1.Value) & Hex(HScrollBar2.Value) & Hex(HScrollBar3.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Index.Show()
        Me.Hide()
    End Sub
    Private Sub Me_Closing() Handles Me.FormClosing
        Index.Show()
    End Sub
End Class