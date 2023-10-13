using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Kata
{
    public class Marine : IMarine
    {
        public int Damage { get; set; }
        public int Armor { get; set; }

        public Marine(int damage, int armor)
        {
            Armor = armor;
            Damage = damage;
        }
    }
}
