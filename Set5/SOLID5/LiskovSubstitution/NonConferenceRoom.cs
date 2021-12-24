namespace SOLID5.LiskovSubstitution
{
    internal class NonConferenceRoom : Room
    {
        public override IEnumerable<string> GetScheduledMeetings()
        {
            throw new Exception("Non-converence room cannot have meetings.");
        }
    }
}
