namespace SOLID.InterfaceSegragation
{
    public interface ICloudProvider
    {
        public void StoreFile(CloudFile file);
        public CloudFile GetFile(string name);
        public void CreateServer(string region);
        public IEnumerable<Server> ListServers(string region);
        public string GetCdnAddress();
    }
}
