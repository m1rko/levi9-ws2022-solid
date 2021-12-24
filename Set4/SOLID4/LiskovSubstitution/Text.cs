namespace SOLID4.LiskovSubstitution
{
    internal class Text : Element
    {
        public override void Rotate()
        {
            throw new Exception("Text cannot be rotated.");
        }
    }
}
