// SingleResponsibility

var instagramPost = new InstagramPost { Photo = new byte[] { } };
instagramPost.Publish();



// OpenClosed


var calendar = new Calendar();
calendar.SetEntryTitle("Company updates meeting");
calendar.InsertEntry("event");
calendar.GetEntryDate("Company updates meeting");