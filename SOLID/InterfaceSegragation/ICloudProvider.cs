﻿namespace SOLID.InterfaceSegragation
{
    public interface ICloudProvider
    {
        public void StoreFile(string name);
        public File GetFile(string name);
        public void CreateServer(string region);
        public IEnumerable<Servers> ListServers(string region);
        public string GetCdnAddress();
    }
}
