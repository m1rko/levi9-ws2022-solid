namespace SOLID4.OpenClosed
{
    internal class Navigation
    {
        private string _type;

        public string From { get; set; }
        public string To { get; set; }

        public void SetNavigationType(string type)
        {
            switch (type)
            {
                case "noTolls":
                case "avoidHwys":
                    _type = type;
                    break;
                default:
                    throw new ArgumentException("Invalid type");
            }
        }

        public TimeSpan GetTime()
        {
            switch (_type)
            {
                case "noTolls":
                    return new TimeSpan(1, 20, 0);
                case "avoidHwys":
                    return new TimeSpan(1, 20, 0);
                default:
                    throw new ArgumentException("Invalid type or is not set");
            }
        }

        public decimal GetDistance()
        {
            return decimal.Zero;
        }
    }
}
