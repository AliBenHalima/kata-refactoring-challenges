using PatternCraft___Adapter_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCraft___Adapter_Kata.Implementaions
{
    public class Marine : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 6;
        }
    }
}
