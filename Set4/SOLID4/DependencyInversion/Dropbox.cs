namespace SOLID4.DependencyInversion
{
    internal class Dropbox
    {
        private CloudFileTransfer cloudFileTransfer = new CloudFileTransfer();

        public void OpenConnection()
        {

        }

        public void StoreFile(string file)
        {
            cloudFileTransfer.File = file;
        }

        public void FindFile()
        {

        }

        public void CloseConnection()
        {

        }
    }
}
