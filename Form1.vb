Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim counter As Integer
        For counter = 1 To 15
            ListBox1.Items.Add(counter)
        Next
    End Sub
End Class
