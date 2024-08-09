using MailSenderService.MailSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderService.Interfaces
{
    public interface IMailSender
    {
        public void SendMail(string recipient, string subject, string body, string[] attachmentPaths = null);
    }
}
