using MongoCatalog.WebApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoCatalog.WebApi.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Get(string id);
        Task Create(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(string id);
        Task<IEnumerable<Product>> GetByName(string name);
    }
}
