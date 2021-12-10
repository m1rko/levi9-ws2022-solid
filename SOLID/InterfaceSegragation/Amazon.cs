namespace SOLID.InterfaceSegragation
{
    public class Amazon : ICloudProvider
    {
        public void StoreFile(string name)
        {
            Console.WriteLine("The file is stored successfully.");
        }

        public File GetFile(string name)
        {
            Console.WriteLine($"Downloading { name } started ...");
            return new File { Name = name };
        }

        public void CreateServer(string region)
        {
            //...
        }

        public IEnumerable<Servers> ListServers(string region)
        {
            return new List<Servers>();
        }

        public string GetCdnAddress()
        {
            return string.Empty;
        }
    }
}
