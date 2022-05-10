using MongoCatalog.WebApi.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace MongoCatalog.WebApi.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Price = 950.00M,
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "IPhone 7 Plus",
                    Price = 450.00M,
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "IPhone 6s",
                    Price = 350.00M,
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "IPhone 13",
                    Price = 1500.00M,
                },
            };
        }
    }
}
