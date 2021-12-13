namespace SOLID.OpenClosed
{
    internal class Air : IShipping
    {
        public string Type => "air";

        public decimal GetCost(Order order)
        {
            return Math.Max(20, order.GetTotalWeight() * 3);
        }

        public DateTime GetDate(Order order)
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
