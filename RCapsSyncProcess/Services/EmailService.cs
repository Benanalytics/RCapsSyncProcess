using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace RCapsSyncProcess.Services;
public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void SendEmail(string fileName, int totalCount, int failedCount)
    {
        var emailSettings = _configuration.GetSection("EmailSettings");
        var smtpServer = emailSettings["SmtpServer"];
        var smtpPort = int.Parse(emailSettings["SmtpPort"]);
        var smtpUsername = emailSettings["SmtpUsername"];
        var smtpPassword = emailSettings["SmtpPassword"];
        var senderEmail = emailSettings["SenderEmail"];
        var senderName = emailSettings["SenderName"];
        var ReceiverName = emailSettings["ReceiverName"];
        var ReceiverEmail = emailSettings["ReceiverEmail"];
        var email = new MimeMessage();
        email.From.Add(new MailboxAddress(senderName, senderEmail));
        email.To.Add(new MailboxAddress(ReceiverName, ReceiverEmail));
        email.Subject = $"File '{fileName}' Processed Successfully";
        email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = $"Hello Sir/Madam,<br><br>" +
                               $"The file '{fileName}' has been processed.<br>" +
                               $"Total Records={totalCount}.<br>" +
                               $"Failed Records={failedCount}.<br>" +
                               $"Records Updated={totalCount}<br><br>" +
                               $"With regards,<br>{senderName}"
        };
        using (var smtp = new SmtpClient())
        {
            smtp.Connect(smtpServer, smtpPort, false);
            smtp.Authenticate(smtpUsername, smtpPassword);

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
