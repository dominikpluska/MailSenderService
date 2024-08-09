using MailSenderService.Interfaces;
using MailSenderService.MailSender;

namespace MailSenderService
{
    public class MailService
    {
        private readonly IMailSender _mailSender;

        public MailService(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public void SendMail(string recipient, string topic, string body)
        {
            _mailSender.SendMail(recipient, topic, body);
        }


    }
}
