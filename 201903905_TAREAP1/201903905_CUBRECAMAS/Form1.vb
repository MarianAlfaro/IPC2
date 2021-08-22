Public Class Form1


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txthilo.Enabled = True
            txthilo.Text = "0"
        Else
            txthilo.Enabled = False
            txthilo.Text = "0"
        End If
    End Sub

    Private Sub Checkbox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtseda.Enabled = True
            txtseda.Text = "0"
        Else
            txtseda.Enabled = False
            txtseda.Text = "0"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            txtalgodon.Enabled = True
            txtalgodon.Text = "0"
        Else
            txtalgodon.Enabled = False
            txtalgodon.Text = "0"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            txtlino.Enabled = True
            txtlino.Text = "0"
        Else
            txtlino.Enabled = False
            txtlino.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "0.00"
        Label4.Text = "0.00"
        SumaYardas = Val(txthilo.Text) + Val(txtalgodon.Text) + Val(txtlino.Text) + Val(txtseda.Text)

        If RadioButton1.Checked = True Then
            If SumaYardas = MaterialK Then
                PrecioCosto = PrecioK + Val(txthilo.Text) * PrecioH + Val(txtalgodon.Text) * PrecioA + Val(txtlino.Text) * PrecioL + Val(txtseda.Text) * PrecioS
                PrecioTotal = PrecioCosto + PrecioCosto * 0.65
            Else MessageBox.Show("La cantidad de yardas no es adecuada para elaborar el tamaño de cubrecama solicitado.")
            End If
        ElseIf RadioButton2.Checked = True Then
            If SumaYardas = MaterialQ Then
                PrecioCosto = PrecioQ + Val(txthilo.Text) * PrecioH + Val(txtalgodon.Text) * PrecioA + Val(txtlino.Text) * PrecioL + Val(txtseda.Text) * PrecioS
                PrecioTotal = PrecioCosto + PrecioCosto * 0.65
            Else MessageBox.Show("La cantidad de yardas no es adecuada para elaborar el tamaño de cubrecama solicitado.")
            End If
        ElseIf RadioButton3.Checked = True Then
            If SumaYardas = MaterialM Then
                PrecioCosto = PrecioM + Val(txthilo.Text) * PrecioH + Val(txtalgodon.Text) * PrecioA + Val(txtlino.Text) * PrecioL + Val(txtseda.Text) * PrecioS
                PrecioTotal = PrecioCosto + PrecioCosto * 0.65
            Else MessageBox.Show("La cantidad de yardas no es adecuada para elaborar el tamaño de cubrecama solicitado.")
            End If
        ElseIf RadioButton4.Checked = True Then
            If SumaYardas = MaterialI Then
                PrecioCosto = PrecioI + Val(txthilo.Text) * PrecioH + Val(txtalgodon.Text) * PrecioA + Val(txtlino.Text) * PrecioL + Val(txtseda.Text) * PrecioS
                PrecioTotal = PrecioCosto + PrecioCosto * 0.65
            Else MessageBox.Show("La cantidad de yardas no es adecuada para elaborar el tamaño de cubrecama solicitado.")
            End If
        End If

        Label2.Text = Str(PrecioCosto)
        Label4.Text = Str(PrecioTotal)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtalgodon.Clear()
        txthilo.Clear()
        txtlino.Clear()
        txtseda.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
End Class
