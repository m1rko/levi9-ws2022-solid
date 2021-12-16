//// Example4

//var employee = new Employee();
//employee.PrintTimeSheetReport();


//// Example2

//var lineItems = new List<Item> {
//    new Item { Price = 10, Weight = 0.6m },
//    new Item { Price = 8, Weight = 0.4m }
//};

//var order = new Order(lineItems);
//var shippingMethod = "ground";
//order.SetShippingType(shippingMethod);

//Console.WriteLine($"The weight by { shippingMethod } is: { order.GetTotalWeight() } || Total price is: { order.GetTotal() }");


//// Example1

//var documents = new List<Document> {
//    new ReadOnlyDocument { Data = new Data(), FileName = "BusinessPlan.docx" },
//    new Document { Data = new Data(), FileName = "ProjectStructure.docx" },
//    new Document { Data = new Data(), FileName = "Notes.txt" }
//};

//var project = new Project(documents);

//project.OpenAll();
//Console.WriteLine("Working on the project...");
//Thread.Sleep(2000);
//project.SaveAll();


//// Example3

//var amazonService = new Amazon();
//var file = new CloudFile() { Name = "Notes.txt" };
//var serverRegion = "Europe";

//amazonService.CreateServer(serverRegion);
//amazonService.ListServers(serverRegion);

//amazonService.StoreFile(file);
//amazonService.GetFile(file.Name);
//Thread.Sleep(2000);
//Console.WriteLine($"The file { file.Name } is downloaded.");

//// Example5

//var budgetReport = new BudgetReport();
//budgetReport.Save();






// Common

Console.ReadLine();