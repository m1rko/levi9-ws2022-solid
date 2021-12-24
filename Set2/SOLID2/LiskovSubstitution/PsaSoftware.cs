namespace SOLID2.LiskovSubstitution
{
    internal class PsaSoftware
    {
        private Employee _user;

        public PsaSoftware(Employee user)
        {
            Login(user);
        }

        private void Login(Employee user)
        {
            _user = user;
        }

        public void ApproveAllTimeSheets()
        {
            if (_user.GetType().Equals(typeof(Manager)))
                Console.WriteLine("All time sheets are approved.");
        }

        public void DeleteAllTimeSheets()
        {
            if (_user.GetType().Equals(typeof(Manager)))
                Console.WriteLine("All time sheets are deleted.");
        }
    }
}
