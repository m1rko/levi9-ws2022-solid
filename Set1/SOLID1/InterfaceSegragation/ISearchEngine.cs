namespace SOLID1.InterfaceSegragation
{
    internal interface ISearchEngine
    {
        public string WebResults();
        public string ImageResults();
        public string BooksResults();
        public string FlightResults();
        public string FinancialResults();
    }
}