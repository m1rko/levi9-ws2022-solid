// SingleResponsibility

var email = new Email
{
    To = "john.doe@example.com",
    Subject = "Job offer",
    Body = "Dear John ..."
};

email.InsertPicture(new byte[] { });
email.Send();



// OpenClosed

var place = new MapsPlace { Coordinates = new[] { 5.3817077m, 20.3906528m } };
var category = "restaurant";
place.SetCategory(category);
var subcategories = place.GetSubcategories();

Console.WriteLine($"Subcategories for the '{ category }' are:");
foreach (var subcategory in subcategories)
    Console.WriteLine(subcategory);