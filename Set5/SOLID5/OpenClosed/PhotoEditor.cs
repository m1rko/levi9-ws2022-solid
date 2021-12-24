namespace SOLID5.OpenClosed
{
    internal class PhotoEditor
    {
        private byte[] _photo;
        private string _filter;

        public void OpenPhoto(byte[] photo)
        {
            _photo = photo;
        }

        public void SetFilter(string filter)
        {
            _filter = filter;
        }

        public void ApplyFilter()
        {
            switch (_filter)
            {
                case "vintige":
                case "sepia":
                case "bw":
                case "desert":
                    Console.WriteLine($"Filter { _filter } applied.");
                    break;
                default:
                    throw new Exception("Invalid filter or not set.");

            }
        }

        public void SetFilterBrightness(byte intensity)
        {

        }

        public void SetFilterIntensity(byte intensity)
        {

        }

        public byte[] GetEditedPhoto()
        {
            return _photo;
        }
    }
}
