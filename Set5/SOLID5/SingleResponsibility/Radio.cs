namespace SOLID5.SingleResponsibility
{
    internal class Radio
    {
        public string Name { get; set; }

        public void Broadcast(decimal frequency)
        {
            Console.WriteLine($"Broadcasting { Name } to radio on { frequency } MHz...");
        }
    }
}
