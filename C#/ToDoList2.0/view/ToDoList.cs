using Controller;
using Model;

namespace View
{
    public class ToDoListView : Form
    {
        private readonly Label LblNome;
        private readonly Label LblTarefa;
        private readonly TextBox InpNome;
        private readonly TextBox InpTarefa;
        private readonly Button BtnCadastrar;
        private readonly Button BtnAlterar;
        private readonly Button BtnDeletar;
        private readonly DataGridView DgvTasks;

        public ToDoListView()
        {
            ToDoListController.Sincronizar();

            Size = new Size(600, 400);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.LightGray;

            LblNome = new Label
            {
                Text = "Nome:",
                Location = new Point(50, 30),
                AutoSize = true, // Ajusta o tamanho automaticamente ao texto
                Font = new Font("Arial", 12, FontStyle.Bold), // Estilo da fonte
                ForeColor = Color.DarkBlue // Cor do texto
            };

            LblTarefa = new Label
            {
                Text = "Tarefa:",
                Location = new Point(50, 80),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkBlue
            };

            InpNome = new TextBox
            {
                Name = "Nome",
                Location = new Point(150, 30),
                Size = new Size(400, 25), // Ajustei o tamanho da caixa de texto
                Font = new Font("Arial", 12),
                BackColor = Color.White // Cor de fundo da caixa de texto
            };

            InpTarefa = new TextBox
            {
                Name = "Tarefa",
                Location = new Point(150, 80),
                Size = new Size(400, 25),
                Font = new Font("Arial", 12),
                BackColor = Color.White
            };

            BtnCadastrar = new Button
            {
                Text = "Cadastrar",
                Location = new Point(50, 130),
                Size = new Size(100, 30), // Ajustei o tamanho do botão
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White, // Cor do texto
                BackColor = Color.Green, // Cor de fundo
                FlatStyle = FlatStyle.Flat, // Estilo de borda plana
                FlatAppearance = { BorderSize = 0 } // Tamanho da borda zero
            };
            BtnCadastrar.Click += ClickCadastrar;

            BtnAlterar = new Button
            {
                Text = "Alterar",
                Location = new Point(170, 130),
                Size = new Size(100, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Orange,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            BtnAlterar.Click += ClickAlterar;

            BtnDeletar = new Button
            {
                Text = "Deletar",
                Location = new Point(290, 130),
                Size = new Size(100, 30),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Red,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };
            BtnDeletar.Click += ClickDeletar;

            DgvTasks = new DataGridView
            {
                Location = new Point(50, 180),
                Size = new Size(500, 150),
                Font = new Font("Arial", 10),
                AutoGenerateColumns = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.DimGray,
                    ForeColor = Color.White
                },
                EnableHeadersVisualStyles = false
            };

            Controls.Add(LblNome);
            Controls.Add(LblTarefa);
            Controls.Add(InpNome);
            Controls.Add(InpTarefa);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnDeletar);
            Controls.Add(DgvTasks);

            Listar();
        }

        private void ClickCadastrar(object? sender, EventArgs e)
        {
            if (InpNome.Text == "")
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }
            ToDoListController.CriarTask(InpNome.Text, InpTarefa.Text);
            Listar();
        }

        private void ClickAlterar(object? sender, EventArgs e)
        {
            if (DgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma tarefa para alterar.");
                return;
            }

            int index = DgvTasks.SelectedRows[0].Index;
            Tasks task = (Tasks)DgvTasks.SelectedRows[0].DataBoundItem;

            if (InpNome.Text == "")
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }
            ToDoListController.AlterarTask(task.Id, InpNome.Text, InpTarefa.Text);
            Listar();
        }

        private void Listar()
        {
            List<Tasks> Tasks = ToDoListController.ListarTask();
            DgvTasks.Columns.Clear();
            DgvTasks.DataSource = Tasks;

            if (DgvTasks.Columns.Count == 0)
            {
                DgvTasks.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Id",
                    HeaderText = "Id",
                    Name = "Id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    ReadOnly = true
                });
                DgvTasks.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Nome",
                    HeaderText = "Nome",
                    Name = "Nome",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    ReadOnly = true
                });
                DgvTasks.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Tarefa",
                    HeaderText = "Tarefa",
                    Name = "Tarefa",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    ReadOnly = true
                });
                DgvTasks.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CriadoEm",
                    HeaderText = "CriadoEm",
                    Name = "CriadoEm",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    ReadOnly = true
                });
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                {
                    DataPropertyName = "Concluida",
                    HeaderText = "Concluida",
                    Name = "Concluida",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    ReadOnly = false
                };
                DgvTasks.Columns.Add(chk);
            }
        }

        private void ClickDeletar(object? sender, EventArgs e)
        {
            if (DgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma tarefa para deletar.");
                return;
            }

            int index = DgvTasks.SelectedRows[0].Index;
            Tasks task = (Tasks)DgvTasks.SelectedRows[0].DataBoundItem;

            ToDoListController.DeletarTask(task.Id);
            Listar();
        }
    }
}
