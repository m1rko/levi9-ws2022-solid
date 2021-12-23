namespace SOLID1.OpenClosed
{
    internal class MapsPlace
    {
        public string Name { get; set; }
        public decimal[] Coordinates { get; set; }

        private string _category;

        public void SetCategory(string category)
        {
            _category = category;
        }

        public IEnumerable<string> GetSubcategories()
        {
            if (_category == "restaurant")
            {
                return new List<string> { "chinese", "italian" };
            }

            if (_category == "health")
            {
                return new List<string> { "hospital", "ambulance" };
            }

            throw new Exception("Selected category doesn't exist");
        }
    }
}
