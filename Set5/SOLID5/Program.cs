// SingleResponsibility

var radio = new Radio { Name = "Radio Flash FM"};
radio.Broadcast(101.00m);



// OpenClosed

var photoEditor = new PhotoEditor();
photoEditor.OpenPhoto(new byte[] { });
photoEditor.SetFilter("bw");
photoEditor.SetFilterIntensity(1);
photoEditor.GetEditedPhoto();



// LiskovSubstitution

var room402 = new Room { Number = 402 };
var room401 = new Room { Number = 401 };
var office = new Office { Rooms = new List<Room> { room402, room401 } };
office.GetScheduledMeetings();



// InterfaceSegregation

var email = new Gmail();
email.SendAll();