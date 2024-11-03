using MessageApp.Core.Services;

namespace MessageApp.Infrastructure.Services
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sms sent: {message}");
        }
    }


}
