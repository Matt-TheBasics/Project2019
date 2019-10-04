
Public Class Hospital

    Private Sub btnStaff_CheckedChanged(sender As Object, e As EventArgs) Handles btnStaff.CheckedChanged
        Staff.ShowDialog()
    End Sub

    Private Sub btnPatients_CheckedChanged(sender As Object, e As EventArgs) Handles btnPatients.CheckedChanged
        Patients.ShowDialog()
    End Sub
End Class
