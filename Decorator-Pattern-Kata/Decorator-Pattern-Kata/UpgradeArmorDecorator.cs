using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Kata
{
    public class UpgradeArmorDecorator : IMarine
    {
        private IMarine _marine;
        public int Damage { get; set; }
        public int Armor { get; set; }

        public UpgradeArmorDecorator(IMarine marine)
        {
            _marine = marine;
            SetArmor();
        }
    
        private void SetArmor()
        {
            _marine.Armor += 1;
            Armor = _marine.Armor;
        }
    }
}
