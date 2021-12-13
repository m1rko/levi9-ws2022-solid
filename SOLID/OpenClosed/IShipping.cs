namespace SOLID.OpenClosed
{
    public interface IShipping
    {
        public string Type { get; }
        public decimal GetCost(Order order);
        public DateTime GetDate(Order order);
    }
}
