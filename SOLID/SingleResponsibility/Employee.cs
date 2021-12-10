namespace SOLID.SingleResponsibility
{
    public class Employee
    {
        private string _name = "John Doe";

        public string GetName()
        {
            return _name;
        }

        public void PrintTimeSheetReport()
        {
            Console.WriteLine($"Printing a time sheet report for {_name}...");
        }
    }
}