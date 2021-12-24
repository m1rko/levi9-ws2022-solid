namespace SOLID4.LiskovSubstitution
{
    internal class TextEditor
    {
        public IList<Element> Elements { get; set; }

        public void MoveAll()
        {
            foreach (var element in Elements)
                element.Move();
        }

        public void RotateAll()
        {
            foreach (var element in Elements)
            {
                if (element.GetType() != typeof(Text))
                    element.Rotate();
            }
        }
    }
}