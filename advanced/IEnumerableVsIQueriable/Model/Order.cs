namespace IEnumerableVsIQueriable.Model
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Address { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
