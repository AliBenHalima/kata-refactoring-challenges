using StartCraft_Visitor_Pattern_Kata.Implementations;

namespace StartCraft_Visitor_Pattern_Kata_Tests
{
    public class VisitorTests
    {
        [Fact]
        public void Marine_Health_Should_Be_Decreased_By_21()
        {
            //Arrange
            var sut = new Marine()
            {
                Health = 100,
            };
            var visitor = new TankBullet();
            //Act
            sut.Accept(visitor);
            //Assert
            Assert.Equal(79, sut.Health);
        }

        [Fact]
        public void Marauder_Health_Should_Be_Decreased_By_32()
        {
            //Arrange
            var sut = new Marauder()
            {
                Health = 125,
            };
            var visitor = new TankBullet();
            //Act
            sut.Accept(visitor);
            //Assert
            Assert.Equal(93, sut.Health);
        }
    }
}