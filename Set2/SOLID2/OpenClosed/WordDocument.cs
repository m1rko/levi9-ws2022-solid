namespace SOLID2.OpenClosed
{
    internal class WordDocument
    {
        private IList<string> _shapes = new List<string>();

        public void Open()
        {

        }

        public void Save()
        {

        }

        public void InsertObject(string obj)
        {
            switch (obj)
            {
                case "text":
                case "textbox":
                case "picture":
                case "shape":
                    _shapes.Add(obj);
                    break;
                default:
                    throw new ArgumentException("Unrecognised shape.");
            }
        }

        public void RotateObject(string obj, short degrees)
        {
            if (obj.Equals("text"))
                throw new Exception("Unable to rotate text. Please use a textbox.");

            Console.WriteLine($"Object { obj } is rotated for { degrees }°");
        }

        public void GetObjectPosition()
        {

        }
    }
}
