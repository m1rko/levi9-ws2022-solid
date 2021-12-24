namespace SOLID2.InterfaceSegregation
{
    internal interface ICalendarItem
    {
        public void SetTitle();
        public void SetStartDate();
        public void Delete();
        public void SetEndDate();
        public void SetDoneStatus();
    }
}
