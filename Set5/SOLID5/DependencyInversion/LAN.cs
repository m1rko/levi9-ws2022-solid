namespace SOLID5.DependencyInversion
{
    internal class LAN
    {
        private NetworkFileTransfer _networkFileTransfer = new NetworkFileTransfer();

        public void OpenConnection()
        {

        }

        public void TransferFile(string file)
        {
            _networkFileTransfer.File = file;
        }

        public void CloseConnection()
        {

        }
    }
}
