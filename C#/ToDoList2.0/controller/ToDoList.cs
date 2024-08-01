using Model;

namespace Controller
{
    public class ToDoListController
    {
        public static void Sincronizar()
        {
            Tasks.Sincronizar();
        }

        public static void CriarTask(string nome, string tarefa)
        {
            Tasks novaTask = new Tasks(nome, tarefa);
            Tasks.CriarTask(novaTask);
        }

        public static List<Tasks> ListarTask()
        {
            return Tasks.ListarTasks();
        }

        public static void AlterarTask(int id, string nome, string tarefa)
        {
            Tasks.AlterarTask(id, nome, tarefa);
        }

        public static void DeletarTask(int id)
        {
            List<Tasks> Task = ListarTask();

            Tasks taskToDelete = Task.Find(t => t.Id == id);
            if (taskToDelete != null)
            {
                Tasks.DeletarTask(id);
            }
            else
            {
                Console.WriteLine("ID inválido");
            }
        }
    }
}
