using Grpc.Core;
using ProductProto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsService.Server.Services
{
    public class ProductsService : ProductProto.ProductsService.ProductsServiceBase
    {
        private readonly List<Product> products = new List<Product>();

        public ProductsService()
        {
            products.Add(new Product() { Id = 1, Name = "His Dark materials", IsAvailable = true, Price = 49.99, Category = ProductProto.Category.Books });
            products.Add(new Product() { Id = 1, Name = "Apple", IsAvailable = true, Price = 0.99, Category = ProductProto.Category.Food });
        }

        //public override Task<ProductProto.Product> GetById(ProductProto.Product product, Grpc.Core)
        public override Task<Product> GetProductsById(ProductRequest request, ServerCallContext context)
        {
            return Task.FromResult(products.FirstOrDefault(p => p.Id == request.Id));
        }

    }
}
