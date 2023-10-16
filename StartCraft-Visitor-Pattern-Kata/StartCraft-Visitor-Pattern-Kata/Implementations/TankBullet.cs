using StartCraft_Visitor_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCraft_Visitor_Pattern_Kata.Implementations
{
    public class TankBullet : IVisitor
    {
        public void VisitArmored(IArmoredUnit unit)
        {
            unit.Health -= 32;
        }

        public void VisitLight(ILightUnit unit)
        {
            unit.Health -= 21;
        }
    }
}
