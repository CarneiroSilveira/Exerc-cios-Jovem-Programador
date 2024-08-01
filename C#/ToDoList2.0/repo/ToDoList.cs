using Model;
using MySqlConnector;

namespace Repo
{
    public class ToDoListRepo
    {
        private static MySqlConnection conexao;
        static List<Tasks> tasks = new();

        public static List<Tasks> ListTasks()
        {
            return tasks;
        }

        public static void InitConexao()
        {
            string info = "server=localhost;database=todolist;user id=root;password=''";
            conexao = new MySqlConnection(info);
            try
            {
                conexao.Open();
            }
            catch
            {
                Console.WriteLine("Não foi possível abrir a conexão com o banco de dados.");
            }
        }

        public static void CloseConexao()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public static List<Tasks> Sincronizar()
        {
            tasks.Clear();
            InitConexao();
            string query = "SELECT * FROM tasks";
            MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Tasks task = new()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Nome = reader["nome"].ToString(),
                    Tarefa = reader["tarefa"].ToString(),
                    CriadoEm = DateTime.Parse(reader["criado_em"].ToString()),
                    Concluida = Convert.ToBoolean(reader["concluido"])
                };
                tasks.Add(task);
            }
            reader.Close();
            CloseConexao();
            return tasks;
        }

        public static void Criar(Tasks task)
        {
            InitConexao();
            string insert = "INSERT INTO tasks (nome, tarefa, criado_em) VALUES (@Nome, @Tarefa, @CriadoEm)";
            MySqlCommand command = new MySqlCommand(insert, conexao);
            try
            {
                if (string.IsNullOrEmpty(task.Nome) || string.IsNullOrEmpty(task.Tarefa))
                {
                    Console.WriteLine("Favor preencher a task.");
                }
                else
                {
                    command.Parameters.AddWithValue("@Nome", task.Nome);
                    command.Parameters.AddWithValue("@Tarefa", task.Tarefa);
                    command.Parameters.AddWithValue("@CriadoEm", task.CriadoEm);

                    int rowsAffected = command.ExecuteNonQuery();
                    task.Id = Convert.ToInt32(command.LastInsertedId);

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Task cadastrada com sucesso.");
                        tasks.Add(task);
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível adicionar a task.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally
            {
                CloseConexao();
            }
        }

        public static void UpdateTask(int id, string nome, string tarefa)
        {
            InitConexao();
            string query = "UPDATE tasks SET nome = @Nome, tarefa = @Tarefa WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(query, conexao);
            try
            {
                if (!string.IsNullOrEmpty(nome) || !string.IsNullOrEmpty(tarefa))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Tarefa", tarefa);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Tasks task = tasks.Find(t => t.Id == id);
                        if (task != null)
                        {
                            task.Nome = nome;
                            task.Tarefa = tarefa;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma linha foi afetada.");
                    }
                }
                else
                {
                    Console.WriteLine("Dados inválidos para atualização.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro durante a execução do comando: " + ex.Message);
            }
            finally
            {
                CloseConexao();
            }
        }

        public static void Delete(int id)
        {
            InitConexao();
            string delete = "DELETE FROM tasks WHERE id = @Id";
            MySqlCommand command = new MySqlCommand(delete, conexao);
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    tasks.RemoveAll(t => t.Id == id);
                    Console.WriteLine("Task deletada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Task não encontrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro durante a execução do comando: " + ex.Message);
            }
            finally
            {
                CloseConexao();
            }
        }
    }
}