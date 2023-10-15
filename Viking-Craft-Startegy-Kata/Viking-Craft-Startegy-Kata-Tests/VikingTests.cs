using Viking_Craft_Startegy_Kata.Implementations;

namespace Viking_Craft_Startegy_Kata_Tests
{
    public class VikingTests
    {
        [Fact]
        public void Viking_Position_Should_Increase_By_10_When_It_Flys()
        {
            //Arrange
            var sut = new Viking();
            sut.MoveBehavior = new Fly();
            //Act
            sut.Move();
            //Assert
            Assert.Equal(10, sut.Position); 
        }

        [Fact]
        public void Viking_Position_Should_Increase_By_1_When_It_Walks()
        {
            //Arrange
            var sut = new Viking();
            sut.MoveBehavior = new Walk();
            //Act
            sut.Move();
            //Assert
            Assert.Equal(1, sut.Position);
        }

        [Fact]
        public void Viking_Position_Should_Increase_By_11_When_It_Walks_And_Flys()
        {
            //Arrange
            var sut = new Viking();
            sut.MoveBehavior = new Walk();
            //Act
            sut.Move();
            sut.MoveBehavior = new Fly();
            sut.Move();
            //Assert
            Assert.Equal(11, sut.Position);
        }

        [Fact]
        public void Viking_Position_Should_Increase_By_1_By_Default()
        {
            //Arrange
            var sut = new Viking();
            //Act
            sut.Move();
            //Assert
            Assert.Equal(1, sut.Position);
        }
    }
}