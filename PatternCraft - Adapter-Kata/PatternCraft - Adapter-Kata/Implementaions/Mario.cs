using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCraft___Adapter_Kata.Implementaions
{
    public class Mario 
    {
        public virtual int jumpAttack()
        {
            Console.WriteLine("Mamamia!");
            return 3;
        }
    }
}
