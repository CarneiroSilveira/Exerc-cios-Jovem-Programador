using Repo;

namespace Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tarefa { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Concluida { get; set; } = false;

        public Tasks() { }

        public Tasks(string nome, string tarefa)
        {
            Nome = nome;
            Tarefa = tarefa;
            CriadoEm = DateTime.Now;
        }

        public static List<Tasks> Sincronizar()
        {
            return ToDoListRepo.Sincronizar();
        }

        public static List<Tasks> ListarTasks()
        {
            return ToDoListRepo.ListTasks();
        }

        public static void CriarTask(Tasks task)
        {
            ToDoListRepo.Criar(task);
        }

        public static void AlterarTask(int id, string nome, string tarefa)
        {
            ToDoListRepo.UpdateTask(id, nome, tarefa);
        }

        public static void DeletarTask(int id)
        {
            ToDoListRepo.Delete(id);
        }
    }
}
