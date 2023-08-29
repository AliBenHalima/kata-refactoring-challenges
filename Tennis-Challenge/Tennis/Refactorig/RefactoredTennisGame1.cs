using System.Collections.Generic;

namespace Tennis.Refactorig
{
    public class RefactoredTennisGame1 : IRefactoredTennisGame
    {
        private int _scorePlayerOne = 0;
        private int _scorePlayerTwo = 0;
        private string _playerOneName;
        private string _playerTwoName;

        IDictionary<int, string> IdenticalScores = new Dictionary<int, string>()
        {
            {0,  $"{Scores.Love}-All" },
            {1,  $"{Scores.Fifteen}-All" },
            {2,  $"{Scores.Thirty}-All" },
        };

        IDictionary<int, string> DifferentScores = new Dictionary<int, string>()
        {
            { 0, Scores.Love },
            { 1, Scores.Fifteen },
            { 2, Scores.Thirty },
            { 3, Scores.Forty },
        };

        public RefactoredTennisGame1(string player1Name, string player2Name)
        {
            _playerOneName = player1Name;
            _playerTwoName = player2Name;
        }

        public void PlayerOneWonPoint()
        {
            _scorePlayerOne += 1;
        }
        public void PlayerTwoOneWonPoint()
        {
            _scorePlayerTwo += 1;
        }

        public string GetScore()
        {
            string result = string.Empty;

            if (IsScoreEqual(_scorePlayerOne, _scorePlayerTwo))
            {
                result = IdenticalScores.TryGetValue(_scorePlayerOne, out string score) ? score : Scores.Deuce;
            }
            else if (IsScoreOverPassDeuce(_scorePlayerOne, _scorePlayerTwo))
            {
                var minusResult = _scorePlayerOne - _scorePlayerTwo;
                if (minusResult == 1) result = $"{Scores.Advantage} {_playerOneName}";
                else if (minusResult == -1) result = $"{Scores.Advantage} {_playerTwoName}";
                else if (minusResult >= 2) result = $"{Scores.WinFor} {_playerOneName}";
                else result = $"{Scores.WinFor} {_playerTwoName}";
            }
            else
            {
                DifferentScores.TryGetValue(_scorePlayerOne, out string p1);
                DifferentScores.TryGetValue(_scorePlayerTwo, out string p2);
                result = $"{p1}-{p2}";
            }
            return result;

        }

        public bool IsScoreEqual(int scorePlayerOne, int scorePlayerTwo)
        {
            return scorePlayerOne == scorePlayerTwo;
        }
        public bool IsScoreOverPassDeuce(int scorePlayerOne, int scorePlayerTwo)
        {
            return (scorePlayerOne >= 4) || (scorePlayerTwo >= 4);
        }
    }
}
