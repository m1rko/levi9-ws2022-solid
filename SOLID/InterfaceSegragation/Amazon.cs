﻿namespace SOLID.InterfaceSegragation
{
    public class Amazon : ICloudHostingProvider, ICdnProvider, ICloudStorageProvider
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
                new Server { Name = "AmazonEu1", Region = "Europe" },
                new Server { Name = "AmazonEu2", Region = "Europe" }
            };
        }

        public string GetCdnAddress()
        {
            return "\\\\cdn.aws.com\\";
        }
    }
}
