namespace SOLID.DependencyInversion
{
    public class BudgetReport
    {
        private MySqlDatabase _database = new MySqlDatabase();

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
