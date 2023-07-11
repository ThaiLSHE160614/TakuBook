using System.Net.Mail;

namespace Project.Services
{
    public class EmailSender : IEmailSender
    {
        //public Task SendEmailAsync(string email, string subject, string body)
        //{
        //    var mail = "lesythai123@gmail.com";
        //    var pw = "";

        //    var client = new SmtpClient();
        //}
        public Task SendEmailAsync(string email, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
