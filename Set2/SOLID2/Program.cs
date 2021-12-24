// SingleResponsibility

var order = new Order
{
    OrderNumber = 1,
    FiscalBillHeader = "Company Name",
    Items = new List<string> { "Pizza", "Coffee" },
    Total = 5
};

order.PrintFiscalBill();



// OpenClosed

var document = new WordDocument();
document.Open();
document.InsertObject("text");