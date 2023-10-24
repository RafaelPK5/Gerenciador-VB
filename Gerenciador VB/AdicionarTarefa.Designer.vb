<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdicionarTarefa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        titulo = New Label()
        descricao = New Label()
        MonthCalendar1 = New MonthCalendar()
        dataEntrega = New Label()
        enviarTarefa = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(448, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 89)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(448, 95)
        TextBox2.TabIndex = 1
        ' 
        ' titulo
        ' 
        titulo.AutoSize = True
        titulo.Location = New Point(12, 17)
        titulo.Name = "titulo"
        titulo.Size = New Size(40, 15)
        titulo.TabIndex = 2
        titulo.Text = "Título:"
        ' 
        ' descricao
        ' 
        descricao.AutoSize = True
        descricao.Location = New Point(12, 71)
        descricao.Name = "descricao"
        descricao.Size = New Size(61, 15)
        descricao.TabIndex = 3
        descricao.Text = "Descrição:"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.CalendarDimensions = New Size(2, 1)
        MonthCalendar1.Location = New Point(12, 212)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 4
        ' 
        ' dataEntrega
        ' 
        dataEntrega.AutoSize = True
        dataEntrega.Location = New Point(12, 197)
        dataEntrega.Name = "dataEntrega"
        dataEntrega.Size = New Size(98, 15)
        dataEntrega.TabIndex = 5
        dataEntrega.Text = "Prazo de Entrega:"
        ' 
        ' enviarTarefa
        ' 
        enviarTarefa.AutoSize = True
        enviarTarefa.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        enviarTarefa.ForeColor = Color.Black
        enviarTarefa.Location = New Point(113, 403)
        enviarTarefa.Name = "enviarTarefa"
        enviarTarefa.Size = New Size(239, 50)
        enviarTarefa.TabIndex = 6
        enviarTarefa.Text = "Enviar"
        enviarTarefa.UseVisualStyleBackColor = False
        ' 
        ' AdicionarTarefa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 465)
        Controls.Add(enviarTarefa)
        Controls.Add(dataEntrega)
        Controls.Add(MonthCalendar1)
        Controls.Add(descricao)
        Controls.Add(titulo)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "AdicionarTarefa"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents titulo As Label
    Friend WithEvents descricao As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents dataEntrega As Label
    Friend WithEvents enviarTarefa As Button
End Class
