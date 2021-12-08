namespace SOLID.OpenClosed
{
    internal interface IShipping
    {
        public decimal GetCost(Order order);
        public DateTime GetDate (Order order);
    }
}