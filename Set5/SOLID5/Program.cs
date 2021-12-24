// SingleResponsibility

var radio = new Radio { Name = "Radio Flash FM"};
radio.Broadcast(101.00m);



// OpenClosed

var photoEditor = new PhotoEditor();
photoEditor.OpenPhoto(new byte[] { });
photoEditor.SetFilter("bw");
photoEditor.SetFilterIntensity(1);
photoEditor.GetEditedPhoto();