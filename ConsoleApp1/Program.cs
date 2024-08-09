using MailSenderService;
using MailSenderService.Interfaces;
using MailSenderService.MailSender;

IMailSender mailSender = new MailSenderImplementation("test", "test", true, false, 547, "dwadwadaw");
MailService mailService = new MailService(mailSender);

mailService.SendMail("test.test@com", "dwadwa", "dwadwa");

Console.ReadLine();