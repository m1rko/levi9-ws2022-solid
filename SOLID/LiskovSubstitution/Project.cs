namespace SOLID.LiskovSubstitution
{
    public class Project
    {
        private IEnumerable<Document> _documents;

        public Project(IEnumerable<Document> documents)
        {
            _documents = documents;
        }

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
