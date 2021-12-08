namespace SOLID.OpenClosed
{
    internal class Order
    {
        private readonly IShipping _shipping;

        public decimal Total { get; set; }

        public Order(IShipping shipping)
        {
            _shipping = shipping;
        }

        public IEnumerable<Item> LineItems { get; set; }

        public decimal GetTotal()
        {
            return Total;
        }
    }
}
