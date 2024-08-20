using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<IEnumerableVsIQueriable.Model.Order> Order { get; set; } = default!;
    }
}
