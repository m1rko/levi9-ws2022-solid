// SingleResponsibility

var instagramPost = new InstagramPost { Photo = new byte[] { } };
instagramPost.Publish();



// OpenClosed


var calendar = new Calendar();
calendar.SetEntryTitle("Company updates meeting");
calendar.InsertEntry("event");
calendar.GetEntryDate("Company updates meeting");



// LiskovSubstitution

var cameraApp = new CameraApp();
cameraApp.TakePhoto(new Camera(), true);
cameraApp.TakePhoto(new FrontCamera());