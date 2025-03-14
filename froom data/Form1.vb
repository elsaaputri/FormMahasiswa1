Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFakultas.Items.Add("FMIPA")
        cmbFakultas.Items.Add("FKIP")
        cmbFakultas.Items.Add("FEB")

        cmbJurusan.Items.Add("Matematika")
        cmbJurusan.Items.Add("Kimia")
        cmbJurusan.Items.Add("Biologi")
        cmbJurusan.Items.Add("Fisika")
        cmbJurusan.Items.Add("Ilmu Komputer")
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub cmbFakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFakultas.SelectedIndexChanged

    End Sub

    Private Sub txtNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIP.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnProcces_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        If txtNIP.Text = "" Or txtNama.Text = "" Or cmbFakultas.Text = "" Or cmbJurusan.Text = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim message As String = "Hai: " & txtNIP.Text & vbCrLf &
                                "Nip: " & txtNama.Text & vbCrLf &
                                "Fakultas: " & cmbFakultas.Text & vbCrLf &
                                "Jurusan: " & cmbJurusan.Text
        MessageBox.Show(message, "Data Mahasiswa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLakiLaki.CheckedChanged
        If rbtnLakiLaki.Checked Then
            rbtnPerempuan.Checked = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPerempuan.CheckedChanged
        If rbtnPerempuan.Checked Then
            rbtnLakiLaki.Checked = False
        End If
    End Sub
End Class
