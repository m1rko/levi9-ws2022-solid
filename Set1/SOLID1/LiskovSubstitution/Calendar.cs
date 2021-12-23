namespace SOLID1.LiskovSubstitution
{
    internal class Calendar
    {
        private IList<Event> _events = new List<Event>();

        public void CreateEvent(string title, IEnumerable<string> atendees, string description, DateTime start, DateTime end, bool allDay = false)
        {
            var newEvent = new Event();

            if (allDay)
            {
                newEvent = new AllDayEvent { Title = title, Description = description, Atendees = atendees };
                newEvent.SetDate(start, end);
            }
            else
            {
                newEvent = new Event { Title = title, Description = description, Atendees = atendees };
                newEvent.SetDate(start, end);
                newEvent.SetTime(start, end);
            }

            _events.Add(newEvent);
        }

        public void ListAllStartEndTime()
        {
            foreach (var calEvent in _events)
            {
                var result = calEvent.GetType() != typeof(AllDayEvent)
                    ? $"Event: { calEvent.Title } Start: { calEvent.StartDate.ToDateTime(calEvent.StartTime) }, End: { calEvent.EndDate.ToDateTime(calEvent.EndTime) }"
                    : $"All day: { calEvent.StartDate }";

                Console.WriteLine(result);
            }
        }
    }
}
