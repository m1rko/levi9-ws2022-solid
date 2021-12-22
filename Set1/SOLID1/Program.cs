// SingleResponsibility

var email = new Email
{
    To = "john.doe@example.com",
    Subject = "Job offer",
    Body = "Dear John ..."
};

email.InsertPicture(new byte[] { });
email.Send();

