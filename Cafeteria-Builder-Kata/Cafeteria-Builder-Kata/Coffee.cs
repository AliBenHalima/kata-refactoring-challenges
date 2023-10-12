using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Builder_Kata
{
    public struct Coffee
    {
        public string Sort;
        public List<Milk> Milk = new List<Milk> ();
        public List<Sugar> Sugar = new List<Sugar>();
        public Coffee(string sort, List<Milk> milk, List<Sugar> sugar)
        {
            Sort = sort;
            Milk.AddRange(milk);
            Sugar.AddRange(sugar);
        }
       
    }
}
