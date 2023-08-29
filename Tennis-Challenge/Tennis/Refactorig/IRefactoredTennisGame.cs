using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Refactorig
{
    public interface IRefactoredTennisGame
    {
        public void PlayerOneWonPoint();
        public void PlayerTwoOneWonPoint();
        string GetScore();
    }
}
