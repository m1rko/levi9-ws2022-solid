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



// LiskovSubstitution

var developer = new Developer();
developer.Name = "John Doe";


var psaSoftware = new PsaSoftware(developer);
psaSoftware.ApproveAllTimeSheets();