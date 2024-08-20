using System.Security.Principal;

namespace IEnumerableVsIQueriable.Model
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
