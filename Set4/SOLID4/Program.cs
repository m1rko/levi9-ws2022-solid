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