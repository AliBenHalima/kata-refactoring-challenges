using Bogus;
using System;
using System.Collections;
using System.Collections.Generic;
using Tennis.Data;
using Tennis.Refactorig;
using Xunit;

namespace Tennis.Tests
{
    public class TestDataGenerator_ : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {1, 0, "Fifteen-Love"},
            new object[] {1, 1, "Fifteen-All"},
            new object[] {2, 2, "Thirty-All"},
            new object[] {3, 3, "Deuce"},
            new object[] {4, 4, "Deuce"},
            new object[] {1, 0, "Fifteen-Love"},
            new object[] {0, 1, "Love-Fifteen"},
            new object[] {2, 0, "Thirty-Love"},
            new object[] {0, 2, "Love-Thirty"},
            new object[] {3, 0, "Forty-Love"},
            new object[] {0, 3, "Love-Forty"},
            new object[] {4, 0, "Win for player1"},
            new object[] {0, 4, "Win for player2"},
            new object[] {2, 1, "Thirty-Fifteen"},
            new object[] {1, 2, "Fifteen-Thirty"},
            new object[] {3, 1, "Forty-Fifteen"},
            new object[] {1, 3, "Fifteen-Forty"},
            new object[] {4, 1, "Win for player1"},
            new object[] {1, 4, "Win for player2"},
            new object[] {3, 2, "Forty-Thirty"},
            new object[] {2, 3, "Thirty-Forty"},
            new object[] {4, 2, "Win for player1"},
            new object[] {2, 4, "Win for player2"},
            new object[] {4, 3, "Advantage player1"},
            new object[] {3, 4, "Advantage player2"},
            new object[] {5, 4, "Advantage player1"},
            new object[] {4, 5, "Advantage player2"},
            new object[] {15, 14, "Advantage player1"},
            new object[] {14, 15, "Advantage player2"},
            new object[] {6, 4, "Win for player1"},
            new object[] {4, 6, "Win for player2"},
            new object[] {16, 14, "Win for player1"},
            new object[] {14, 16, "Win for player2"},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class RefactoredTennisTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator_))]
        public void Tennis1Test(int p1, int p2, string expected)
        {
            //Arrange

            var playerOne = new Player
            {
                Name = "player1",
                Score = p1
            };
            var playerTwo = new Player
            {
                Name = "player2",
                Score = p2
            };

            //Act
            var game = new RefactoredTennisGame1(playerOne.Name, playerTwo.Name);

            //Assert
            CheckAllScores(game, playerOne, playerTwo, expected);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator_))]
        public void Tennis2Test(int p1, int p2, string expected)
        {

            // Arrange
            var playerOne = new Player
            {
                Name = "player1",
                Score = p1
            };
            var playerTwo = new Player
            {
                Name = "player2",
                Score = p2
            };
            // Act
            var game = new RefactoredTennisGame1(playerOne.Name, playerTwo.Name);

            // Assert
            CheckAllScores(game, playerOne, playerTwo, expected);

        }

        //[Theory]
        //[ClassData(typeof(TestDataGenerator))]
        //public void Tennis3Test(int p1, int p2, string expected)
        //{
        //    var game = new TennisGame3("player1", "player2");
        //    CheckAllScores(game, p1, p2, expected);
        //}
        //[Theory]
        //[ClassData(typeof(TestDataGenerator))]
        //public void Tennis5Test(int p1, int p2, string expected)
        //{
        //    var game = new TennisGame5("player1", "player2");
        //    CheckAllScores(game, p1, p2, expected);
        //}
        //[Theory]
        //[ClassData(typeof(TestDataGenerator))]
        //public void Tennis6Test(int p1, int p2, string expected)
        //{
        //    var game = new TennisGame6("player1", "player2");
        //    CheckAllScores(game, p1, p2, expected);
        //}
        private void CheckAllScores(IRefactoredTennisGame game, Player playerOne, Player playerTwo, string expectedScore)
        {
            var highestScore = Math.Max(playerOne.Score, playerTwo.Score);
            for (var i = 0; i < highestScore; i++)  
            {
                if (i < playerOne.Score)
                    game.PlayerOneWonPoint();
                if (i < playerTwo.Score)
                    game.PlayerTwoOneWonPoint();
            }

            Assert.Equal(expectedScore, game.GetScore());
        }
    }
}