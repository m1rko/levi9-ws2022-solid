namespace SOLID.OpenClosed
{
    public class Order
    {
        private string _shipping = "ground";
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

        public void SetShippingType(string st)
        {
            _shipping = st;
        }

        public decimal GetShippingCost()
        {
            if (_shipping == "ground")
            {
                if (GetTotal() > 100)
                    return 0;

                return Math.Max(10, GetTotalWeight() * 1.5m);
            }

            if (_shipping == "air")
                return Math.Max(20, GetTotalWeight() * 3);

            throw new Exception("Proper shipping method must be set");
        }

        public DateTime GetShippingDate()
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
