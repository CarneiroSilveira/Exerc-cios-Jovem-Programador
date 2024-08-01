using View;

namespace ToDoList2._0;

static class Program
{
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new ToDoListView());
    }
}