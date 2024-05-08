using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;

namespace CrossCutting.Services.EmailService
{
    public class EmailService
    {
        public async static Task<bool> Test()
        {
            try
            {
                var message = new MimeMessage();

                message.From.Add(new MailboxAddress("IcT",
                                                    "ict47194@gmail.com"));
                message.To.Add(new MailboxAddress("destino", "viniciusgabriel.z.lucas@gmail.com"));
                message.Subject = "Test";
                message.Body = new TextPart("html")
                {
                    Text = ""
                };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    await client.ConnectAsync("smtp.gmail.com",
                                              587, false);

                    await client.AuthenticateAsync("ict47194@gmail.com",
                                                    "ictcps2024");//efnysgkignxrmpt//ictcps2024

                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }

            return true;
        }
    }
}
