
using brevo_csharp.Api;
using brevo_csharp.Model;

namespace Ecommerce.Services;

public class EmailSender
{
    public static void SendEmail(string senderName, string senderEmail, string toName, string toEmail
        , string subject, string textContent)
    {
        var apiInstance = new TransactionalEmailsApi();
        SendSmtpEmailSender email = new SendSmtpEmailSender(senderName, senderEmail);
        SendSmtpEmailTo smtpEmailTo = new SendSmtpEmailTo(toEmail, toName);
        List<SendSmtpEmailTo> To = new List<SendSmtpEmailTo>();
        To.Add(smtpEmailTo);


        try
        {
            var sendSmtpEmail = new SendSmtpEmail(email, To, null, null, null, textContent, subject);
            CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);
            Console.WriteLine("Email Sender OK: \n" + result.ToJson());
        }
        catch (Exception e)
        {
            Console.WriteLine("Email Sender Failure: \n" + e.Message);
        }
    }
}