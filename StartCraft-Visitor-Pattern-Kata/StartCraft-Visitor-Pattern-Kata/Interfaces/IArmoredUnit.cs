using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCraft_Visitor_Pattern_Kata.Interfaces
{
    public interface IArmoredUnit
    {
        int Health { get; set; }
        void Accept(IVisitor visitor);
    }
}
