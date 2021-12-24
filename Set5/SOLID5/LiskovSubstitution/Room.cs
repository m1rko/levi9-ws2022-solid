namespace SOLID5.LiskovSubstitution
{
    internal class Room
    {
        public short Number { get; set; }

        public virtual IEnumerable<string> GetScheduledMeetings()
        {
            return new List<string>();
        }
    }
}
