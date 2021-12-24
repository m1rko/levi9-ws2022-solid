namespace SOLID5.LiskovSubstitution
{
    internal class Office
    {
        public IEnumerable<Room> Rooms { get; set; }
        public void GetScheduledMeetings()
        {
            foreach (var room in Rooms)
            {
                if (room.GetType() != typeof(NonConferenceRoom))
                {
                    Console.WriteLine("The scheduled meetings are next:");
                }
            }
        }
    }
}
