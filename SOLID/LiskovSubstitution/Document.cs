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

    public class Project
    {
        private IEnumerable<Document> _documents = new List<Document>();

        public void OpenAll()
        {
            foreach (var doc in _documents)
            {
                doc.Open();
            }
        }

        public void SaveAll()
        {
            foreach (var doc in _documents)
            {
                if (doc.GetType() != typeof(ReadOnlyDocument))
                {
                    doc.Save();
                }
            }
        }
    }
}
