using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking_Craft_Startegy_Kata.Interfaces
{
    public interface IUnit
    {
        int Position { get; set; }
        void Move();
        IMoveBehavior MoveBehavior { get; set; }
    }
}
