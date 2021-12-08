namespace SOLID.LiskovSubstitution
{
    public class Project
    {
        private IEnumerable<Document> _allDocs = new List<Document>();
        private IEnumerable<WritableDocument> _writableDocs = new List<WritableDocument>();

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
