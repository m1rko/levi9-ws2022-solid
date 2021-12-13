namespace SOLID.OpenClosed
{
    public class Order
    {
        private IShipping _shipping = new Ground();
        private IEnumerable<Item> _lineItems;

        public Order(IEnumerable<Item> lineItems)
        {
            _lineItems = lineItems;
        }

        public decimal GetTotal()
        {
            return _lineItems.Sum(i => i.Price);
        }

        public decimal GetTotalWeight()
        {
            return _lineItems.Sum(i => i.Weight);
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
