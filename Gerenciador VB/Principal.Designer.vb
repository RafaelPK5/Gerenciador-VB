<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        AdicionarToolStripMenuItem = New ToolStripMenuItem()
        ExibirTodasToolStripMenuItem = New ToolStripMenuItem()
        ExibirPendentesToolStripMenuItem = New ToolStripMenuItem()
        ExibirConcluídas = New ToolStripMenuItem()
        DadosPrincipais = New DataGridView()
        titulo = New DataGridViewTextBoxColumn()
        Descricao = New DataGridViewTextBoxColumn()
        dataDaEntrega = New DataGridViewTextBoxColumn()
        statusColumn = New DataGridViewComboBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DadosPrincipais, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AdicionarToolStripMenuItem, ExibirTodasToolStripMenuItem, ExibirPendentesToolStripMenuItem, ExibirConcluídas})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AdicionarToolStripMenuItem
        ' 
        AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        AdicionarToolStripMenuItem.Size = New Size(70, 20)
        AdicionarToolStripMenuItem.Text = "Adicionar"
        ' 
        ' ExibirTodasToolStripMenuItem
        ' 
        ExibirTodasToolStripMenuItem.Name = "ExibirTodasToolStripMenuItem"
        ExibirTodasToolStripMenuItem.Size = New Size(81, 20)
        ExibirTodasToolStripMenuItem.Text = "Exibir Todas"
        ' 
        ' ExibirPendentesToolStripMenuItem
        ' 
        ExibirPendentesToolStripMenuItem.Name = "ExibirPendentesToolStripMenuItem"
        ExibirPendentesToolStripMenuItem.Size = New Size(106, 20)
        ExibirPendentesToolStripMenuItem.Text = "Exibir Pendentes"
        ' 
        ' ExibirConcluídas
        ' 
        ExibirConcluídas.Name = "ExibirConcluídas"
        ExibirConcluídas.Size = New Size(110, 20)
        ExibirConcluídas.Text = "Exibir Concluídas"
        ' 
        ' DadosPrincipais
        ' 
        DadosPrincipais.AllowUserToAddRows = False
        DadosPrincipais.AllowUserToDeleteRows = False
        DadosPrincipais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DadosPrincipais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DadosPrincipais.Columns.AddRange(New DataGridViewColumn() {titulo, Descricao, dataDaEntrega, statusColumn})
        DadosPrincipais.Dock = DockStyle.Fill
        DadosPrincipais.Location = New Point(0, 24)
        DadosPrincipais.Name = "DadosPrincipais"
        DadosPrincipais.RowTemplate.Height = 25
        DadosPrincipais.Size = New Size(800, 426)
        DadosPrincipais.TabIndex = 1
        ' 
        ' titulo
        ' 
        titulo.HeaderText = "Título"
        titulo.Name = "titulo"
        ' 
        ' Descricao
        ' 
        Descricao.HeaderText = "Descrição"
        Descricao.Name = "Descricao"
        ' 
        ' dataDaEntrega
        ' 
        dataDaEntrega.HeaderText = "Data da Entrega"
        dataDaEntrega.Name = "dataDaEntrega"
        dataDaEntrega.Resizable = DataGridViewTriState.True
        ' 
        ' statusColumn
        ' 
        statusColumn.HeaderText = "Status"
        statusColumn.Items.AddRange(New Object() {"Concluída", "Pendente"})
        statusColumn.Name = "statusColumn"
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DadosPrincipais)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Principal"
        Text = "Gerenciador de Tarefas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DadosPrincipais, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadosPrincipais As DataGridView
    Friend WithEvents ExibirTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExibirPendentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExibirConcluídas As ToolStripMenuItem
    Friend WithEvents titulo As DataGridViewTextBoxColumn
    Friend WithEvents Descricao As DataGridViewTextBoxColumn
    Friend WithEvents dataDaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents statusColumn As DataGridViewComboBoxColumn
End Class
