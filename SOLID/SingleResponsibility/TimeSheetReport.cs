namespace SOLID.SingleResponsibility
{
    public class TimeSheetReport
    {
        public void Print(Employee employee)
        {
            Console.WriteLine($"A time sheet report for { employee.GetName() } is sent to a printer.");
        }
    }
}
