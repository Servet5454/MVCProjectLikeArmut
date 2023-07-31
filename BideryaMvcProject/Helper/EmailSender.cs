using System.Net.Mail;
using System.Net;

namespace BideryaMvcProject.Helper
{
    public class EmailSender
    {
        private string smtpServer = "smtp.gmail.com";//Kendi Email Adresim İle Çalışıyor
        private int port = 587;
        private string emailname = "Biderya@gmail.com";
        private string password = "mcyubicpoaidrwbx";


        public void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                MailMessage mail = new MailMessage();
                client.Credentials = new NetworkCredential("Biderya@gmail.com", "mcyubicpoaidrwbx");
                client.Port = 587;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = true;



                mail.From = new MailAddress("Biderya@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                client.Send(mail);

                Console.WriteLine("E-posta gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("E-posta gönderilirken bir hata oluştu: " + ex.Message);
            }
        }


    }
}
