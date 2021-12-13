namespace SOLID.InterfaceSegragation
{
    public class Dropbox : ICloudStorageProvider
    {
        public void StoreFile(CloudFile file)
        {
            Console.WriteLine($"Uploading { file.Name } ...");
            Thread.Sleep(1500);
            Console.WriteLine($"Done");
        }

        public CloudFile GetFile(string name)
        {
            Console.WriteLine($"Downloading { name } started ...");
            return new CloudFile { Name = name };
        }
    }
}
