using BasicAuth.Models;

namespace BasicAuth.Repositories.Interfaces
{
    public interface ITodoRepository
    {
        public IEnumerable<TodoModel> GetAll();
    }
}
