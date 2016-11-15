using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MHG.Mail.Smtp
{
    public class BasitSmtp
    {
        public static void Send(string host, string username, string password, bool ssl, int port, string body, string subject, string from, string to)
        {
            try
            {
                var client = new SmtpClient();
                client.Host = host;
                client.Port = port; //Default SMTP Ports 587, 465, 25.
                client.Timeout = 5000; //Default timeout very long then write 5 second.
                client.Credentials = new NetworkCredential(username, password);
                client.EnableSsl = ssl;

                var mailMessage = new MailMessage();
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;
                mailMessage.Subject = subject;
                mailMessage.From = new MailAddress(from);

                //Sended User Mail Address
                mailMessage.To.Add(to);

                client.Send(mailMessage);
            }
            catch (System.Exception ex)
            {
                System.Console.Write(ex.Message);
            }
        }
    }
}
