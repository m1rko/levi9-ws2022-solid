// SingleResponsibility

var email = new Email
{
    To = "john.doe@example.com",
    Subject = "Job offer",
    Body = "Dear John ..."
};

email.InsertPicture(new byte[] { });
email.Send();



//// OpenClosed

var place = new MapsPlace { Coordinates = new[] { 5.3817077m, 20.3906528m } };
var category = "restaurant";
place.SetCategory(category);
var subcategories = place.GetSubcategories();

Console.WriteLine($"Subcategories for the '{ category }' are:");
foreach (var subcategory in subcategories)
    Console.WriteLine(subcategory);



// LiskovSubstitution

var firstEvent = new Event { Title = "Breakfast", Atendees = new List<string> { "John Doe <john.doe@example.com>, Will Smith <will.smith@example.com>" }, Description = "The menu is on the link below" };
var secondEvent = new Event { Title = "Meeting", Atendees = new List<string> { "John Doe <john.doe@example.com>, Will Smith <will.smith@example.com>" }, Description = "Sprint planning" };
var thirdEvent = new AllDayEvent { Title = "Conference", Atendees = new List<string> { "John Doe <john.doe@example.com>, Will Smith <will.smith@example.com>" }, Description = "Tech Conference 2022" };

var calendar = new Calendar();
calendar.CreateEvent(firstEvent.Title, firstEvent.Atendees, firstEvent.Description, DateTime.Parse("02/14/2022 08:00 AM", CultureInfo.InvariantCulture), DateTime.Parse("02/14/2022 08:30 AM", CultureInfo.InvariantCulture));
calendar.CreateEvent(secondEvent.Title, secondEvent.Atendees, secondEvent.Description, DateTime.Parse("02/14/2022 12:15 PM", CultureInfo.InvariantCulture), DateTime.Parse("02/14/2022 01:15 PM", CultureInfo.InvariantCulture));
calendar.CreateEvent(thirdEvent.Title, thirdEvent.Atendees, thirdEvent.Description, DateTime.Parse("02/15/2022", CultureInfo.InvariantCulture), DateTime.Parse("02/14/2022", CultureInfo.InvariantCulture), true);

calendar.ListAllStartEndTime();





// Common
Console.ReadLine();