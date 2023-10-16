using Moq;
using PatternCraft___Adapter_Kata.Implementaions;

namespace PatternCraft_Adapter_Kata_Tests
{
    public class AdapterTests
    {
        [Fact]
        public void MarioAdapter_Attacks_Reduce_Target_Health()
        {
            //Arrange
            var mario = new Mario();
            var target = new Target() { Health = 100 };
            var sut = new MarioAdapter(mario);

            //Act
            sut.Attack(target);
            //Assert
            Assert.Equal(97, target.Health);
        }

        [Fact]
        public void MarioAdapter_Attacks_Reduce_Target_Health_Using_Moq()
        {
            //Arrange
            var mario = new Mock<Mario>();
            mario.Setup(x => x.jumpAttack()).Returns(10);
            var target = new Target() { Health = 100 };
            var sut = new MarioAdapter(mario.Object);

            //Act
            sut.Attack(target);
            //Assert
            Assert.Equal(90, target.Health);
        }

    }
}