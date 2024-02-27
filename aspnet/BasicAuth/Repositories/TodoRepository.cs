using BasicAuth.Models;
using BasicAuth.Repositories.Interfaces;

namespace BasicAuth.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public IEnumerable<TodoModel> GetAll()
        {
            var todos = new List<TodoModel>() 
            {
                new TodoModel { Id = 1, Task = "Go to the supermarket", DueDate = DateTime.Now },
                new TodoModel { Id = 2, Task = "Buy books", DueDate = DateTime.Now },
                new TodoModel { Id = 3, Task = "Work for 2 hours", DueDate = DateTime.Now },
                new TodoModel { Id = 4, Task = "Buy medicine", DueDate = DateTime.Now },
            };

            return todos;
        }
    }
}
