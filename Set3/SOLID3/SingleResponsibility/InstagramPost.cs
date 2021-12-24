namespace SOLID3.SingleResponsibility
{
    internal class InstagramPost
    {
        private string _authorsName = "John Doe";
        public byte[] Photo { get; set; }


        public void Publish()
        {

        }

        public string GetAuthorsName()
        {
            return _authorsName;
        }
    }
}
