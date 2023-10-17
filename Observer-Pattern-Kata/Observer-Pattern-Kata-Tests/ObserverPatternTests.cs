using AutoFixture;
using Observer_Pattern_Kata.Implemntations;
using Observer_Pattern_Kata.Interfaces;

namespace Observer_Pattern_Kata_Tests
{
    public class ObserverPatternTests
    {
        private Fixture _fixture;

        public ObserverPatternTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void Notify_Method_Should_Notify_All_Subscribers()
        {
            //Arrange
            var sut = new Subject();
            //_fixture.Customize<IObserver>(x => x.FromFactory(() => new Observer(new User() { Name = string.Empty})));

            var observers = _fixture.CreateMany<Observer>(5).ToList();
            sut.Subscribers.AddRange(observers);
            var output = new StringWriter();
            Console.SetOut(output);

            //Act
            sut.Notify();

            //Arrange
            var stringOutput = output.ToString();
            foreach (var subscriber in sut.Subscribers)
            {
                Assert.Contains(subscriber.UserEntity.Name, stringOutput);
            }
        }


    }
}