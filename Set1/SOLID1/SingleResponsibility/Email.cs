namespace SOLID1.SingleResponsibility
{
    internal class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void InsertPicture(byte[] picture)
        {
            Console.WriteLine("Picture inserted.");
        }

        public void RotatePicture(short angle)
        {
            Console.WriteLine($"Picture rotated for {angle}°.");
        }

        public void Send()
        {
            Console.WriteLine("Email sent.");
        }
    }
}
