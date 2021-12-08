namespace SOLID.LiskovSubstitution
{
    public class Document
    {
        public Data Data { get; set; }

        public string FileName { get; set; }

        public void Open()
        {

        }

        public virtual void Save()
        {

        }
    }
}
