namespace SOLID.DependencyInversion
{
    public class BudgetReport
    {
        private MySqlDatabase _database = new MySqlDatabase();

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
