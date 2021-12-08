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
            //...
        }
        public void Save()
        {
            //...
        }
    }
}
