namespace SOLID.DependencyInversion
{
    public class BudgetReport
    {
        private IDatabase _database;

        public BudgetReport(IDatabase database)
        {
            _database = database;
        }

        public void Open(DateTime date)
        {
            Console.WriteLine("Opening Budget report...");
            Thread.Sleep(1500);
            Console.WriteLine("Opened");
        }

        public void Save()
        {
            Console.WriteLine("Budget report is saved.");
        }
    }
}
