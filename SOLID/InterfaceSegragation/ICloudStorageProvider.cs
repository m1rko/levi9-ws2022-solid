namespace SOLID.InterfaceSegragation
{
    public interface ICloudStorageProvider
    {
        public void StoreFile(CloudFile file);
        public CloudFile GetFile(string name);
    }
}
