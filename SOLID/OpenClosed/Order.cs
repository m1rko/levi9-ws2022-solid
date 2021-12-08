namespace SOLID.OpenClosed
{
    public class Order
    {
        private IShipping _shipping;

        public IEnumerable<Item> LineItems { get; set; }

        public decimal GetTotal()
        {
            return LineItems.Sum(i => i.Price);
        }

        public decimal GetTotalWeight()
        {
            return LineItems.Sum(i => i.Weight);
        }

        public void SetShippingType(IShipping st)
        {
            _shipping = st;
        }

        public decimal GetShippingCost()
        {
            return _shipping.GetCost(this);
        }

        public DateTime GetShippingDate()
        {
            return _shipping.GetDate(this);
        }
    }
}
