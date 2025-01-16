using Microsoft.EntityFrameworkCore;
using IEnumerableVsIQueriable.Model;

namespace IEnumerableVsIQueriable.Data
{
    public class IEnumerableVsIQueryableContext : DbContext
    {
        public IEnumerableVsIQueryableContext (DbContextOptions<IEnumerableVsIQueryableContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; } = default!;
    }
}
