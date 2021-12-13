namespace SOLID.LiskovSubstitution
{
    public class WritableDocument : Document
    {
        public void Save()
        {
            Console.WriteLine($"Document { FileName } is saved.");
        }
    }
}
