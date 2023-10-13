using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern_Kata
{
    public class UpgradeWeaponDecorator : IMarine
    {
        private IMarine _marine;
        public int Damage { get; set; }
        public int Armor { get; set; }

        public UpgradeWeaponDecorator(IMarine marine)
        {
            _marine = marine;
            SetDamage();
        }
    
        private void SetDamage()
        {
            _marine.Damage += 1;
            Damage = _marine.Damage;
        }
    }
}
