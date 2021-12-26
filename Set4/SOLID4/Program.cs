// SingleResponsibility

var album = new Album();
album.GetAlbumDuration();
album.PlaySong("Californication");



// OpenClosed

var navigation = new Navigation
{
    From = "Belgrade",
    To = "Zrenjanin"
};

navigation.SetNavigationType("noTolls");
navigation.GetDistance();


// LilskovSubstitution

var picture = new Picture();
var textEditor = new TextEditor();

textEditor.Elements.Add(new Picture());
textEditor.Elements.Add(new Text());

textEditor.RotateAll();



// InterfaceSegregation

var email = new EmailService();
email.InsertText();
email.InsertPicture();
email.Send();



// DependencyInversion

var dropbox = new Dropbox();
var file = "File to transfer";
dropbox.StoreFile(file);