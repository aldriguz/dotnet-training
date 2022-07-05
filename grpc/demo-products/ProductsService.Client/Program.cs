using System;
using System.Threading.Tasks;

namespace ProductsService.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            if(args.Length > 0 && Int32.TryParse(args[0], out int id))
            {
                await ProductsHandler.GetProductById(id);
            }
        }
    }
}
