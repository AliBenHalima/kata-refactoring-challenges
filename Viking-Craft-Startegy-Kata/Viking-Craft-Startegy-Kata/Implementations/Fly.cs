using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking_Craft_Startegy_Kata.Interfaces;

namespace Viking_Craft_Startegy_Kata.Implementations
{
    public class Fly : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 10;
        }
    }
}
