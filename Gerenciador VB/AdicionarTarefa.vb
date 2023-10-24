Public Class AdicionarTarefa
    Private Sub EnviarTarefa_Click(sender As Object, e As EventArgs) Handles enviarTarefa.Click
        Dim titulo As String = TextBox1.Text
        Dim descricao As String = TextBox2.Text
        Dim dataEntrega As DateTime = MonthCalendar1.SelectionStart
        Dim dataFormatada As String = dataEntrega.ToString("dd/MM/yyyy")
        Dim status As String = "Pendente"
        If titulo = "" OrElse descricao = "" Then
            MsgBox("Necessário adicionar titulo", MsgBoxStyle.Critical, "Erro ao adicionar informação")
        Else
            Dim formularioPrincipal As Principal = CType(Application.OpenForms("Principal"), Principal)
            formularioPrincipal.AdicionarTarefaAoDataGridView(titulo, descricao, dataFormatada, status)
            Me.Close()
        End If


    End Sub

    Private Sub AdicionarTarefa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If e.Start < Date.Now Then
            MsgBox("Impossível escolher uma data do passado!", MsgBoxStyle.Critical, "Erro ao selecionar Data")

        End If

    End Sub
End Class