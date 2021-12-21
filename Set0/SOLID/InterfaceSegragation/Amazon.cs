namespace SOLID.InterfaceSegragation
{
    public class Amazon : ICloudProvider
    {
        public void StoreFile(CloudFile file)
        {
            Console.WriteLine($"Uploading { file.Name } ...");
            Thread.Sleep(1500);
            Console.WriteLine($"Uploaded.");
        }

        public CloudFile GetFile(string name)
        {
            Console.WriteLine($"Downloading { name } started ...");
            return new CloudFile { Name = name };
        }

        public void CreateServer(string region)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"New server is created for { region }.");
        }

        public IEnumerable<Server> ListServers(string region)
        {
            return new List<Server>
            {
                new Server { Name = "AmazonServer1", Region = region },
                new Server { Name = "AmazonServer2", Region = region }
            };
        }

        public string GetCdnAddress()
        {
            return "\\\\cdn.aws.com\\";
        }
    }
}
