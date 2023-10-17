using StarCraft_State_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft_State_Pattern_Kata.Implementations
{
    public class Tank : IUnit
    {
        public IUnitState State { get; set; }
        public bool CanMove { get { return State.CanMove; }  }
        public int Damage { get { return State.Damage; } }
        public Tank()
        {
            State = new TankState();
        }
    }
}
