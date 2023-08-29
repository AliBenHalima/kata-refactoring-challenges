using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis.Refactorig;
using Xunit;

namespace Tennis.Tests
{
    public class RefactoredGame1Tests
    {
        [Fact]
        public void IsScoreEqual_Should_Return_True_When_Scores_Are_Equals()
        {

            // Arrange
            int score1 = 2;
            int score2 = 2;
            var sut = new RefactoredTennisGame1("Name1", "Name2");
            // Act
            bool result = sut.IsScoreEqual(score1, score2);
            // Assert
            result.Should().BeTrue();
        }
    }
}
