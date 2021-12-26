namespace SOLID2.DependencyInversion
{
    internal class SamsungPhone
    {
        private BtFileTransfer btFileTransfer = new BtFileTransfer();
        public void OpenConnection()
        {

        }

        public void TransferFiles(string file)
        {
            btFileTransfer.File = file;
            btFileTransfer.Send();
        }

        public void CloseConnection()
        {

        }
    }
}
