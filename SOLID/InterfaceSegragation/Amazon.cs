namespace SOLID.InterfaceSegragation
{
    public class Amazon : ICloudHostingProvider, ICdnProvider, ICloudStorageProvider
    {
        public void StoreFile(string name)
        {
            //...
        }

        public void GetFile(string name)
        {
            //...
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
