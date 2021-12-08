namespace SOLID.OpenClosed
{
    public interface IShipping
    {
        public decimal GetCost(Order order);
        public DateTime GetDate(Order order);
    }
}
