namespace SOLID.InterfaceSegragation
{
    public interface ICloudHostingProvider
    {
        public void CreateServer(string region);
        public IEnumerable<Servers> ListServers(string region);
    }
}
