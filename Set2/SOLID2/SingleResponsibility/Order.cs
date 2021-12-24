namespace SOLID2.SingleResponsibility
{
    internal class Order
    {
        public string FiscalBillHeader { get; set; }
        public int OrderNumber { get; set; }
        public IEnumerable<string> Items { get; set; }
        public decimal Total { get; set; }

        public void PrintFiscalBill()
        {

        }
    }
}
