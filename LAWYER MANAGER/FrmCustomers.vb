Public Class FrmCustomers
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmcustomer2 As New FrmCustomers2
        'frmcustomer2.MdiParent = MDIParent1
        frmcustomer2.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frmcustomerdoc As New FrmCustomerDocs
        frmcustomerdoc.Show()
    End Sub
End Class