using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft_State_Pattern_Kata.Interfaces
{
    public interface IUnit
    {
        IUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }
}
