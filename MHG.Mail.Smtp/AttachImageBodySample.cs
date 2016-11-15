using System.Net.Mail;
using System.Net.Mime;

namespace MHG.Mail.Smtp
{
    public class AttachImageBodySample
    {
        public static void Send(string host, string username, string password, bool ssl, int port, string body, string subject, string from, string to)
        {
            //create an instance of new mail message
            MailMessage mail = new MailMessage();

            //set the HTML format to true
            mail.IsBodyHtml = true;

            //create Alrternative HTML view
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

            //Add Image
            LinkedResource theEmailImage = new LinkedResource("image.jpg", MediaTypeNames.Image.Jpeg);
            theEmailImage.ContentId = "myImageID";

            //Add the Image to the Alternate view
            htmlView.LinkedResources.Add(theEmailImage);

            //Attach Image
            mail.Attachments.Add(new Attachment("image.jpg"));

            //Add view to the Email Message
            mail.AlternateViews.Add(htmlView);

            //set the "from email" address and specify a friendly 'from' name
            mail.From = new MailAddress(from);

            //set the "to" email address
            mail.To.Add(to);

            //set the Email subject
            mail.Subject = subject;

            //set the SMTP info
            System.Net.NetworkCredential cred = new System.Net.NetworkCredential(username, password);
            SmtpClient smtp = new SmtpClient(host, port);
            smtp.EnableSsl = ssl;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = cred;
            //send the email
            smtp.Send(mail);
        }
    }
}
