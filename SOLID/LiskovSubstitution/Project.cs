namespace SOLID.LiskovSubstitution
{
    public class Project
    {
        private IEnumerable<Document> _allDocs = new List<Document>();
        private IEnumerable<WritableDocument> _writableDocs = new List<WritableDocument>();

        public Project(IEnumerable<Document> documents)
        {
            _allDocs = documents;
            _writableDocs = documents.Where(d => d.GetType() == typeof(WritableDocument)).Select(d => (WritableDocument) d);
        }

        public void OpenAll()
        {
            foreach (var doc in _allDocs)
            {
                doc.Open();
            }
        }

        public void SaveAll()
        {
            foreach (var doc in _writableDocs)
            {
                doc.Save();
            }
        }
    }
}
