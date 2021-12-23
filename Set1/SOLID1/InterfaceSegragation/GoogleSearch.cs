namespace SOLID1.InterfaceSegragation
{
    internal class GoogleSearch : ISearchEngine
    {
        private string _query;

        public GoogleSearch(string query)
        {
            _query = query;
        }

        public string BooksResults()
        {
            return string.Empty;
        }

        public string FinancialResults()
        {
            return string.Empty;
        }

        public string FlightResults()
        {
            return string.Empty;
        }

        public string ImageResults()
        {
            return string.Empty;
        }

        public string WebResults()
        {
            return string.Empty;
        }
    }
}
