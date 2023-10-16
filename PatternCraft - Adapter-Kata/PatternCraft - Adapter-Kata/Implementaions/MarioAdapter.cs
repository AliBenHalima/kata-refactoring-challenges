using PatternCraft___Adapter_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCraft___Adapter_Kata.Implementaions
{
    public class MarioAdapter : IUnit
    {
        private readonly Mario _adaptee;

        public MarioAdapter(Mario adaptee)
        {
            _adaptee = adaptee;
        }

        public void Attack(Target target)
        {
            int attackValue = _adaptee.jumpAttack();
            target.Health -= attackValue;
        }
    }
}
