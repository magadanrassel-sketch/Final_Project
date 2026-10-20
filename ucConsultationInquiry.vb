Public Class ucConsultationInquiry
    Private Sub ucConsultationInquiry_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPersonnel.SelectedIndexChanged

    End Sub

    Private Sub btnConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtStudentID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentID.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cmbStatus.Focus()
        End If
    End Sub

    Private Sub cmbStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cmbPersonnel.Focus()
        End If
    End Sub
    Private Sub cmbPersonnel_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPersonnel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cmbTime.Focus()
        End If
    End Sub
    Private Sub cmbTime_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cmbReason.Focus()
        End If
    End Sub
End Class