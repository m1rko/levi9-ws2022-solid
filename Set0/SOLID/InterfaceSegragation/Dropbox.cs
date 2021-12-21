namespace SOLID.InterfaceSegragation
{
    public class Dropbox : ICloudProvider
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
            throw new NotImplementedException();
        }

        public IEnumerable<Server> ListServers(string region)
        {
            throw new NotImplementedException();
        }

        public string GetCdnAddress()
        {
            throw new NotImplementedException();
        }
    }
}
