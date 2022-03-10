Public Class form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LivrosDataSet.Livro' table. You can move, or remove it, as needed.
        Me.LivroTableAdapter.Fill(Me.LivrosDataSet.Livro)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
