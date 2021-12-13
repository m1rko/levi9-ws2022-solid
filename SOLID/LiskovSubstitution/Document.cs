namespace SOLID.LiskovSubstitution
{
    public class Document
    {
        public Data Data { get; set; }

        public string FileName { get; set; }

        public void Open()
        {
            Console.WriteLine($"Openning { FileName } ...");
            Thread.Sleep(1000);
            Console.WriteLine($"{ FileName } is open.");
        }
    }
}
