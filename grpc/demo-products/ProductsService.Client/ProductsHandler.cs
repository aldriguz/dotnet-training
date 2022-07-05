using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductsService.Client
{
    internal static class ProductsHandler
    {
        private static readonly string _productsServer = "https://localhost:5001";

        public static async Task GetProductById(int id)
        {
            var channel = GrpcChannel.ForAddress(_productsServer);
            var client = new ProductProto.ProductsService.ProductsServiceClient(channel);
            var request = new ProductProto.ProductRequest() { Id = id };
            var product = await client.GetProductsByIdAsync(request);

            Console.WriteLine($"{product.Name} - {product.Category}");

            Console.ReadKey();
        }
    }
}
