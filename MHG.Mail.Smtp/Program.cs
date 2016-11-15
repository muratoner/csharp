namespace MHG.Mail.Smtp
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "smtp.muratoner.net";
            string userName = "muratoner.net";
            string password = "muratoner.net";
            bool ssl = false;
            int port = 587; //Default SMTP Ports 587, 465, 25.
            string body = "Test mail body sample";
            string subject = "Test mail subject";
            string from = "from@muratoner.net";
            string to = "to@muratoner.net";

            // Basic Smtp Client Sample
            //BasitSmtp.Send(host, userName, password, ssl, port, body, subject, from, to);
            // Attach Image and Use In Body
            body = "Test mail body sample with attach image <img src='cid:myImageID' />";
            AttachImageBodySample.Send(host, userName, password, ssl, port, body, subject, from, to);
        }
    }
}
