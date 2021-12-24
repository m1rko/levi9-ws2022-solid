namespace SOLID3.OpenClosed
{
    internal class Calendar
    {
        private string _entryTitle;
        private IList<string> _events = new List<string>();
        private IList<string> _tasks = new List<string>();

        public void SetEntryTitle(string title)
        {
            _entryTitle = title;
        }

        public void InsertEntry(string type)
        {
            if (type.Equals("event"))
                _events.Add(_entryTitle);

            if (type.Equals("task"))
                _tasks.Add(_entryTitle);

            throw new Exception("Invalid entry type");
        }

        public DateOnly GetEntryDate(string title)
        {
            return DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
