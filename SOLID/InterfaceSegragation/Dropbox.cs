namespace SOLID.InterfaceSegragation
{
    public class Dropbox : ICloudStorageProvider
    {

        public void StoreFile(string name)
        {
            //...
        }

        public void GetFile(string name)
        {
            //...
        }
    }
}
