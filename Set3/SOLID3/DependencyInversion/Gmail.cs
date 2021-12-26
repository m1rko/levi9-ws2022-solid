namespace SOLID3.DependencyInversion
{
    internal class Gmail
    {
        private EmailClient _emailClient = new EmailClient();

        public void Send()
        {
            _emailClient.Send();
        }

        public void EncryptConnection()
        {

        }

        public void Receive()
        {

        }

        public void Delete()
        {

        }
    }
}
