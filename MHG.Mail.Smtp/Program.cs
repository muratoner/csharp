using System.Net;
using System.Net.Mail;

namespace MHG.Mail.Smtp {
    class Program {
        static void Main( string[] args ) {
            try {
                var client = new SmtpClient();
                client.Host = "[Host Address]";
                client.Port = 587; //Default SMTP Ports 587, 465, 25.
                client.Timeout = 5000; //Default timeout very long then write 5 second.
                client.Credentials = new NetworkCredential( "[Username]", "[Password]" );
                client.EnableSsl = false;

                var mailMessage = new MailMessage();
                mailMessage.Body = "[Message Body]";
                mailMessage.IsBodyHtml = true;
                mailMessage.Subject = "[Subject]";
                mailMessage.From = new MailAddress( "[Sender User Mail Address]" );

                //Sended User Mail Address
                mailMessage.To.Add( "[Sended User Mail Address]" );
                mailMessage.To.Add( "[Sended User Mail Address]" );
                mailMessage.To.Add( "[Sended User Mail Address]" );

                client.Send( mailMessage );
            } catch ( System.Exception ex ) {
                System.Console.Write( ex.Message );
            }
        }
    }
}
