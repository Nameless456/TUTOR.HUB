Public Class frm_14
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        frm_15.Show()
        Me.Hide()
    End Sub

    Public TimeStart As Date
    Private Sub frm_14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeStart = Now
        lblDateTime.Text = TimeStart
    End Sub
End Class