using Bowling_Game_Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Kata_Test
{
    public class BowlingGameTests
    {

        [Theory]
        [InlineData(6, 4, 2)]
        public void Rolling_Spare_Returns_Correct_Value(int firstRoll, int secondRoll, int bonusRoll)
        {
            // Arrange
            var sut = new Game();
            // Act
            sut.Roll(firstRoll);
            sut.Roll(secondRoll);
            sut.Roll(bonusRoll);
            int score = sut.Score();
            // Assert
            Assert.Equal<int>(14, score);

        }

        [Fact]
        public void Bowling_Game_Returns_Correct_Score()
        {
            // Arrange
            var sut = new Game();
            int[] rolls = new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 };
            // Act
            sut.Roll(rolls);
            int score = sut.Score();
            // Assert
            Assert.Equal<int>(131, score);
        }

        [Fact]
        public void Bowling_Game_Returns_Zero_When_All_Rolls_Are_Strikes()
        {
            // Arrange
            var sut = new Game();
            int[] rolls = Enumerable.Repeat(10, 21).ToArray();
            sut.Roll(rolls);
            // Act

            int score = sut.Score();
            // Assert
            Assert.Equal<int>(300, score);
        }

        [Fact]
        public void Bowling_Game_Returns_Twenty_When_All_Rolls_have_Value_One()
        {
            // Arrange
            Game sut = new Game();
            RepeatSameRoll(sut, 20, 1, out sut);
            // Act

            int score = sut.Score();
            // Assert
            Assert.Equal<int>(20, score);
        }

        private void RepeatSameRoll(Game game, int rolls, int pinValue, out Game sut)
        {
            for (int index = 0; index < rolls; index++)
            {
                game.Roll(pinValue);
            }
            sut = game;
        }
    }
}
