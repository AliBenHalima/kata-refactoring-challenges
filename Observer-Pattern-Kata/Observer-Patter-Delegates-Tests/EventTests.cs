
using Observer_Patter_Delegates.Implementations;

namespace Observer_Patter_Delegates_Tests
{
    public class EventTests
    {
        [Fact]
        public void Subscribers_Must_Be_Notified()
        {
            //Arrange
            var subject = new Subject();
            var observer = new UserObserver(new User() { Name = "Ali" });
            var output = new StringWriter();
            Console.SetOut(output);
            //Act
            subject.OnUserUpdate += observer.HandleEvent;
            subject.SendMessage();

            //Assert
           
            var stringOutput = output.ToString();
            Assert.Contains("Notification From Ali", stringOutput);

        }
    }
}