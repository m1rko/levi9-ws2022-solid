namespace SOLID5.InterfaceSegregation
{
    internal interface IEmailService
    {
        public void SendAll();
        public void GetAll();
        public void SendPushNotification();
        public void EnablePushNotification();
        public void AdvancedEncryption();
    }
}
