Public Class entrada
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 2
        Me.Label3.Text = "A carregar...( " & Me.ProgressBar1.Value & "%)"

        If Me.ProgressBar1.Value = 100 Then
            Me.Timer1.Enabled = False
            Me.Hide()
            form1.Show()

        End If

        If Me.ProgressBar1.Value = 5 Then
            Me.Label2.Text = "A carregar formularios..."
        ElseIf Me.ProgressBar1.Value = 10 Then
            Me.Label2.Text = "A preparar a base de dados..."
        ElseIf Me.ProgressBar1.Value = 50 Then
            Me.Label2.Text = "A Operacional..."
        ElseIf Me.ProgressBar1.Value = 70 Then
            Me.Label2.Text = "A a carregar o sistema de gestão da biblioteca..."

        End If

    End Sub
End Class