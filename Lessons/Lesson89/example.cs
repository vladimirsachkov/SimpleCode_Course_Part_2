namespace Lesson89;

public class example
{
    public delegate void Notify(string message);

    class MessagePublisher
    {
        public Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    class SmsSubscriber
    {
        public void ReveiveSms(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    class EmailSubscriber
    {
        public void ReveiveEmail(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }

    public static void Start()
    {
        var publisher = new MessagePublisher();
        
        var smsSubscriber = new SmsSubscriber();
        var emailSubscriber = new EmailSubscriber();

        publisher.OnNotify += smsSubscriber.ReveiveSms;
        publisher.OnNotify += emailSubscriber.ReveiveEmail;
        
        publisher.RaiseEvent("Hello World!");
        Console.WriteLine();
    }
}