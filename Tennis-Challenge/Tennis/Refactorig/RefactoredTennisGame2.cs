using System.Collections.Generic;

namespace Tennis.Refactorig
{
    public class RefactoredTennisGame2 : IRefactoredTennisGame
    {
        private int _p1point;
        private int _p2point;

        private string _p1res = "";
        private string _p2res = "";
        private string _player1Name;
        private string _player2Name;

        public RefactoredTennisGame2(string player1Name, string player2Name)
        {
            _player1Name = _player1Name;
            _p1point = 0;
            _player2Name = _player2Name;
        }

        public bool AreScoresEqual(int score1, int score2)
        {
            return score1 == score2;
        }

        //private HashSet<int> _scores = new HashSet<int>()
        //{
        //    0,1,2, 3,
        //};
      public enum scoreValues
        {
            Love,
            Fifteen,
            Thirty,
            Forty,
        }
        public IDictionary<int, string> scoreNames = new Dictionary<int, string>()
        {
            { 0, Scores.Love },
            { 1, Scores.Fifteen },
            { 2, Scores.Thirty },
            { 3, Scores.Forty },
        };
        public string GetScore()
        {
            var score = "";

            if (AreScoresEqual(_p1point, _p2point))
            {
                if(_p1point != (int)scoreValues.Forty)
                {
                    scoreNames.TryGetValue(_p1point, out string scoreName);
                    score = $"{scoreName} -All";
                }
                if (_p1point > (int)scoreValues.Thirty)
                {
                    scoreNames.TryGetValue(_p1point, out score);

                }

            }
            else if ( _p1point <= (int)scoreValues.Forty && _p2point <= (int)scoreValues.Forty)
            {
                scoreNames.TryGetValue(_p1point, out string p1Score);
                scoreNames.TryGetValue(_p2point, out string p2Score);
                score = p1Score + "-" + p2Score;
            }
            else
            {
                if (_p1point > _p2point && _p2point >= (int)scoreValues.Forty)
                {
                    score = $"{Scores.Advantage} {_player1Name}";
                }

                if (_p2point > _p1point && _p1point >= (int)scoreValues.Forty)
                {
                    score = $"{Scores.Advantage} {_player2Name}";
                }

                if (_p1point >= (int)scoreValues.Forty + 1 && _p2point >= (int)scoreValues.Love && (_p1point - _p2point) >= 2)
                {
                    score = score = $"{Scores.WinFor} {_player1Name}";
                }
                if (_p2point >= (int)scoreValues.Forty + 1 && _p1point >= (int) scoreValues.Love && (_p2point - _p1point) >= 2)
                {
                    score = score = $"{Scores.WinFor} {_player2Name}";
                }
            }


          
            return score;
        }


        private void P1Score()
        {
            _p1point++;
        }

        private void P2Score()
        {
            _p2point++;
        }

        public void PlayerOneWonPoint()
        {
            P1Score();
        }
        public void PlayerTwoOneWonPoint()
        {
            P2Score();
        }
    }
}

