using Events_And_Delegates_Kata;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public delegate void MyDelegate(string argument);
    public static void Main(string[] args)
    {
        //var publisher = new Publisher();
        //var firstSubscriber = new FirstSubscriber();
        //var secondSubscriber = new secondSubscriber();
        //publisher.OnTest += firstSubscriber.HandleEvent;
        //publisher.OnTest += secondSubscriber.HandleEvent;
        //publisher.FireEvent();

        List<string> persons = new() { "Peter", "Mike", "Peter", "Bob", "Peter", "Peter", "Bob", "Mike", "Bob", "Peter", "Peter", "Mike", "Bob" };
        var publisher = new Publisher();
        var textMessage = new TextMessageSend();
        var email = new EmailSend();
        publisher.OnContactNotify += textMessage.HandleEvent;
        publisher.OnContactNotify += email.HandleEvent;
        publisher.SendNotifications(persons);

    }
}