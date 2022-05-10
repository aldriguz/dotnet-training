using MongoCatalog.WebApi.Entities;
using MongoDB.Driver;

namespace MongoCatalog.WebApi.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
