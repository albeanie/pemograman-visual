Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Staff")
        cmbRole.Items.Add("Manager")

        cmbRole.SelectedIndex = -1
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

        Try
            Dim folderGambar As String = IO.Path.Combine(Application.StartupPath, "..", "..", "..", "My Project", "image")
            folderGambar = IO.Path.GetFullPath(folderGambar)

            If cmbRole.Text = "Staff" Then

                Dim fileStaff As String = IO.Path.Combine(folderGambar, "staff.jpg")

                If IO.File.Exists(fileStaff) Then
                    picImage.Image = Image.FromFile(fileStaff)
                End If

            ElseIf cmbRole.Text = "Manager" Then

                Dim fileManager As String = IO.Path.Combine(folderGambar, "manager.jpg")

                If IO.File.Exists(fileManager) Then
                    picImage.Image = Image.FromFile(fileManager)
                End If

            Else

                picImage.Image = Nothing

            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso
           Not Char.IsWhiteSpace(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim role As String = cmbRole.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        If role = "" Then

            MessageBox.Show(
                "Silakan pilih role terlebih dahulu.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            cmbRole.Focus()
            Return

        End If

        If nama = "" Then

            MessageBox.Show(
                "Nama belum diisi.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNama.Focus()
            Return

        End If

        If nim = "" OrElse Not IsNumeric(nim) Then

            MessageBox.Show(
                "NIM harus berupa angka.",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNIM.Focus()
            Return

        End If

        Dim loginBerhasil As Boolean = False

        ' Debug info - show exactly what was entered
        Dim debugMsg As String = "Role: [" & role & "]" & vbCrLf &
                                 "Nama: [" & nama & "]" & vbCrLf &
                                 "NIM: [" & nim & "]" & vbCrLf & vbCrLf &
                                 "Expected Nadya: [Nadya] vs [241712051]" & vbCrLf &
                                 "Expected Alfisyhary: [Alfisyhary Matondang] vs [241712088]" & vbCrLf &
                                 "Expected Manager: [Shata Diyaul Haq] vs [241712061]"

        ' Try Staff - Nadya
        If role = "Staff" AndAlso
           nama.Equals("Nadya", StringComparison.OrdinalIgnoreCase) AndAlso
           nim.Equals("241712051", StringComparison.OrdinalIgnoreCase) Then
            loginBerhasil = True
            debugMsg &= vbCrLf & vbCrLf & "MATCHED: Nadya"

        ' Try Staff - Alfisyhary Matondang  
        ElseIf role = "Staff" AndAlso
               nama.Equals("Alfisyhary Matondang", StringComparison.OrdinalIgnoreCase) AndAlso
               nim.Equals("241712088", StringComparison.OrdinalIgnoreCase) Then
            loginBerhasil = True
            debugMsg &= vbCrLf & vbCrLf & "MATCHED: Alfisyhary Matondang"

        ' Try Manager
        ElseIf role = "Manager" AndAlso
               nama.Equals("Shata Diyaul Haq", StringComparison.OrdinalIgnoreCase) AndAlso
               nim.Equals("241712061", StringComparison.OrdinalIgnoreCase) Then
            loginBerhasil = True
            debugMsg &= vbCrLf & vbCrLf & "MATCHED: Shata Diyaul Haq"

        End If

        If loginBerhasil Then

            MessageBox.Show(
                "Login berhasil.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtNama.Clear()
            txtNIM.Clear()
            cmbRole.SelectedIndex = -1

            Try
                Dim formPajak As New FrmPajak()
                formPajak.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else

            MessageBox.Show(
                "Login Gagal" & vbCrLf & vbCrLf & debugMsg,
                "Login Gagal",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            txtNIM.Focus()

        End If

    End Sub
End Class