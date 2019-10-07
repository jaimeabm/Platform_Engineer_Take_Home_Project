using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CustomComponents
{
    public class GmailSender
    {
        private SmtpClient smtpClient = new SmtpClient();

        public string Host { get; set; }
        public string Port { get; set; }
        public string EnableSsl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string On { get; set; }

        public GmailSender()
        {
        }

        public void PrepareSMTPClient()
        {
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = Host;
            smtpClient.Port = Int32.Parse(Port);
            smtpClient.EnableSsl = Boolean.Parse(EnableSsl);
            smtpClient.Credentials = new NetworkCredential(UserName, Password);
        }

        public void SendMessage(string emailFrom, string emailTo, string subject, string body)
        {
            if (Boolean.Parse(On))
            {
                var message = new MailMessage(emailFrom, emailTo);
                message.From = new MailAddress(emailFrom);
                message.To.Add(new MailAddress(emailTo));
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = false;

                smtpClient.Send(message);
            }

        }
    }
}
