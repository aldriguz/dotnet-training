using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IEnumerableVsIQueriable.Data;
using IEnumerableVsIQueriable.Model;

namespace IEnumerableVsIQueriable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IEnumerableVsIQueriableContext _context;

        public OrdersController(IEnumerableVsIQueriableContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            return await _context.Order.ToListAsync();
        }

        // GET: api/Orders/Query
        [HttpGet("Query")]
        public IActionResult GetOrderIQueryable()
        {
            IQueryable<Order> orders = _context.Order.AsQueryable();

            var result = orders
                .Where(x => x.Total > 100)
                .OrderBy(x => x.ShippedDate);

            return Ok(result);
        }

        // GET: api/Orders/Enumerable
        [HttpGet("Enumerable")]
        public IActionResult GetOrderIEnumerable()
        {
            IEnumerable<Order> orders = _context.Order.AsQueryable();

            var result = orders
                .Where(x => x.Total > 100)
                .OrderBy(x => x.ShippedDate);

            return Ok(result);
        }
    }
}
