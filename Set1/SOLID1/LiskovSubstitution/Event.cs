namespace SOLID1.LiskovSubstitution
{
    internal class Event
    {
        public string Title { get; set; }

        public IEnumerable<string> Atendees { get; set; }

        public string Description { get; set; }

        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }
        public TimeOnly StartTime { get; private set; }
        public TimeOnly EndTime { get; private set; }

        public void SetDate(DateTime start, DateTime end)
        {
            StartDate = DateOnly.FromDateTime(start);
            EndDate = DateOnly.FromDateTime(end);
        }

        public virtual void SetTime(DateTime start, DateTime end)
        {
            StartTime = TimeOnly.FromDateTime(start);
            EndTime = TimeOnly.FromDateTime(end);
        }
    }
}
