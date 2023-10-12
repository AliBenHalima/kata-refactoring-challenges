using Events_And_Delegates_Kata;

namespace Events_And_Delegates_Kata_Tests
{
    public class EventsTest
    {
        [Fact]
        public void Event_Should_Be_Consumed_By_Subscribers()
        {
            List<string> persons = new List<string>()
        {
            "Peter", "Mike", "Peter", "Bob", "Peter", "Peter", "Bob", "Mike", "Bob", "Peter", "Peter", "Mike", "Bob"
        };
            var publisher = new Publisher();
            var textMessage = new TextMessageSend();
            publisher.OnContactNotify += textMessage.HandleEvent;
            publisher.SendNotifications(persons);
            string output = textMessage.TextMessageList;
            string expected = "Peter, Bob, Peter, Mike";
            Assert.True(string.Equals(expected, output, StringComparison.OrdinalIgnoreCase));
        }
    }
}