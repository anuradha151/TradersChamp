using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace TradersChamp.Service
{
    public class MailService
    {
        private readonly SmtpClient client;

        public MailService()
        {
            client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("56fc7bb8e4051f", "327c1031e8fae8"),
                EnableSsl = true
            };
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            try
            {
                Console.WriteLine("Sending email to: " + toEmail);
                await client.SendMailAsync("no-reply@abctraders.com", toEmail, subject, body);
                Console.WriteLine("Email sent successfully to: " + toEmail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
