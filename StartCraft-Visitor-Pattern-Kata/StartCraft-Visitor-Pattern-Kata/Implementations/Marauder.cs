using StartCraft_Visitor_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCraft_Visitor_Pattern_Kata.Implementations
{
    public class Marauder : IArmoredUnit
    {
        public int Health { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitArmored(this);
        }
    }
}
