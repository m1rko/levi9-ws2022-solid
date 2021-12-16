namespace SOLID.Example1
{
    public class Document
    {
        public Data Data { get; set; }

        public string FileName { get; set; }

        public void Open()
        {
            Console.WriteLine($"Openning { FileName } ...");
            Thread.Sleep(1000);
            Console.WriteLine($"Document { FileName } is open.");
        }

        public virtual void Save()
        {
            Console.WriteLine($"Document { FileName } is saved.");
        }
    }
}
