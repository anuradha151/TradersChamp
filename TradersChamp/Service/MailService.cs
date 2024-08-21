
using System.Net.Mail;
using System.Net;

namespace TradersChamp.Service
{
    public class MailService
    {
        public void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("56fc7bb8e4051f", "327c1031e8fae8"),
                    EnableSsl = true
                };               


                Console.WriteLine("Sending email to: " + toEmail);
                client.Send("no-reply@abctraders.com", toEmail, subject, body);
                Console.WriteLine("Email sent successfully to: " + toEmail);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
