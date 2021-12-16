namespace SOLID.Example1
{
    public class ReadOnlyDocument : Document
    {
        public override void Save()
        {
            throw new Exception("Unable to save read-only file.");
        }
    }
}
