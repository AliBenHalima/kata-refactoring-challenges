using StarCraft_State_Pattern_Kata.Implementations;

namespace StarCraft_State_Pattern_Kata_Tests
{
    public class StatePatternTests
    {
        [Fact]
        public void Starting_With_Tank_State_Should_Not_Move()
        {
            //Arrange
            var sut = new Tank();
            //Assert
            Assert.Equal(5, sut.Damage);
            Assert.Equal(true, sut.CanMove);

        }

        [Fact]
        public void Starting_With_Siege_State_Should_Move()
        {
            //Arrange
            var sut = new Tank();
            sut.State = new SiegeState();
            //Assert
            Assert.Equal(20, sut.Damage);
            Assert.Equal(false, sut.CanMove);

        }

    }
}