namespace SOLID.Example4
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
            Console.WriteLine($"A time sheet report for { _name } is sent to a printer.");
        }
    }
}