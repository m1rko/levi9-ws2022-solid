namespace SOLID.InterfaceSegragation
{
    public interface ICloudHostingProvider
    {
        public void CreateServer(string region);
        public IEnumerable<Server> ListServers(string region);
    }
}
