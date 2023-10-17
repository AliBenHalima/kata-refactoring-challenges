using AutoFixture;
using Mediator_Pattern_Kata.Implemntations;
using Mediator_Pattern_Kata.Interfaces;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace Mediator_Pattern_Kata_Tests
{
    public class MediatorTests
    {
        private Fixture _fixture;
        public MediatorTests()
        {
            _fixture = new Fixture();
        }
        [Fact]
        public void Notify_Method_Should_Output_Messages_To_Console()
        {
            //Arrange
            _fixture.Customize<IMediator>(x => x.FromFactory(() => new GroupMediator()));

            var sut = new GroupMediator();
            var users = _fixture.CreateMany<User>(2).ToList();

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            //Act
            foreach (var user in users)
            {
                user.SendMessage($"Hello From {user.Name}");
            }
            string consoleOutputString = consoleOutput.ToString();

            //Assert
            foreach (var user in users)
            {
                Assert.Contains($"Hello From {user.Name}", consoleOutputString);
            }
        }
    }
}