using Microsoft.EntityFrameworkCore;
using IEnumerableVsIQueriable.Model;

namespace IEnumerableVsIQueriable.Data
{
    public class IEnumerableVsIQueriableContext : DbContext
    {
        public IEnumerableVsIQueriableContext (DbContextOptions<IEnumerableVsIQueriableContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Order { get; set; } = default!;
    }
}
