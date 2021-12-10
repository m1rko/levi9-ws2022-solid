namespace SOLID.InterfaceSegragation
{
    public class Dropbox : ICloudProvider
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
            throw new NotImplementedException();
        }

        public IEnumerable<Servers> ListServers(string region)
        {
            throw new NotImplementedException();
        }

        public string GetCdnAddress()
        {
            throw new NotImplementedException();
        }
    }
}
