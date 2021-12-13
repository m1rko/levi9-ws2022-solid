namespace SOLID.OpenClosed
{
    public class Ground : IShipping
    {
        public string Type => "ground";

        public decimal GetCost(Order order)
        {
            if (order.GetTotal() > 100)
                return 0;

            return Math.Max(10, order.GetTotalWeight() * 1.5m);
        }

        public DateTime GetDate(Order order)
        {
            return DateTime.Now.AddDays(7);
        }
    }
}
