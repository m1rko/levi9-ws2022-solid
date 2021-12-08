namespace SOLID.InterfaceSegragation
{
    public interface ICloudStorageProvider
    {
        public void StoreFile(string name);
        public void GetFile(string name);
    }
}
