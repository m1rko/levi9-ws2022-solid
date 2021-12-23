namespace SOLID1.InterfaceSegragation
{
    internal class BingSearch : ISearchEngine
    {
        public string BooksResults()
        {
            throw new NotImplementedException();
        }

        public string FinancialResults()
        {
            throw new NotImplementedException();
        }

        public string FlightResults()
        {
            throw new NotImplementedException();
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
