namespace SOLID1.LiskovSubstitution
{
    internal class AllDayEvent : Event
    {
        public override void SetTime(DateTime start, DateTime end)
        {
            throw new Exception("Unable to set time for all-day event.");
        }
    }
}
