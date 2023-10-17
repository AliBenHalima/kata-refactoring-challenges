using StarCraft_State_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft_State_Pattern_Kata.Implementations
{
    public class TankState : IUnitState
    {
        public bool CanMove { get; set; } = true;
        public int Damage { get; set; } = 5;
    }
}
