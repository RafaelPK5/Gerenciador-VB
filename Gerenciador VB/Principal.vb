Imports System.Xml

Public Class Principal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub AdicionarTarefaAoDataGridView(titulo As String, descricao As String, dataEntrega As DateTime, status As String)
        Dim dadosPrin As DataGridView = DadosPrincipais
        dadosPrin.Rows.Add(titulo, descricao, dataEntrega, status)
    End Sub

    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        Dim tarefa As New AdicionarTarefa()

        tarefa.Show()


    End Sub

    Private Sub ExibirConcluídas_Click(sender As Object, e As EventArgs) Handles ExibirConcluídas.Click
        If DadosPrincipais IsNot Nothing AndAlso DadosPrincipais.Rows.Count > 0 Then
            For Each linha As DataGridViewRow In DadosPrincipais.Rows
                Dim statusCell As DataGridViewComboBoxCell = TryCast(linha.Cells("statusColumn"), DataGridViewComboBoxCell)
                linha.Visible = statusCell IsNot Nothing AndAlso statusCell.Value IsNot Nothing AndAlso statusCell.Value.ToString() = "Concluída"
            Next
        End If
    End Sub

    Private Sub ExibirPendentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExibirPendentesToolStripMenuItem.Click
        If DadosPrincipais IsNot Nothing AndAlso DadosPrincipais.Rows.Count > 0 Then
            For Each linha As DataGridViewRow In DadosPrincipais.Rows
                Dim statusCell As DataGridViewComboBoxCell = TryCast(linha.Cells("statusColumn"), DataGridViewComboBoxCell)
                linha.Visible = statusCell IsNot Nothing AndAlso statusCell.Value IsNot Nothing AndAlso statusCell.Value.ToString() = "Pendente"
            Next
        End If
    End Sub

    Private Sub ExibirTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExibirTodasToolStripMenuItem.Click
        If DadosPrincipais IsNot Nothing AndAlso DadosPrincipais.Rows.Count > 0 Then
            For Each linha As DataGridViewRow In DadosPrincipais.Rows
                linha.Visible = True
            Next
        End If
    End Sub
End Class
