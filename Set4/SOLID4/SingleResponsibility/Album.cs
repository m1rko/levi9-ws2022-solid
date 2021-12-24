namespace SOLID4.SingleResponsibility
{
    internal class Album
    {

        private string _name = "Californication";
        private IEnumerable<string> _songs = new List<string> { "Otherside", "Californication", "Scar Tissue" };
        public TimeSpan _duration = new TimeSpan(0, 56, 24);

        public TimeSpan GetAlbumDuration()
        {
            return _duration;
        }

        public TimeSpan GetSongDuration()
        {
            return TimeSpan.Zero;
        }

        public void PlayAlbum()
        {
            Console.WriteLine($"Playing album { _name } ...");
        }

        public void PlaySong(string name)
        {
            var song = _songs.FirstOrDefault(x => x.Equals(name));

            if (song == null)
                throw new Exception($"The song { name } doesn't exist in the album.");

            Console.WriteLine($"Playing { name } ...");
        }
    }
}
