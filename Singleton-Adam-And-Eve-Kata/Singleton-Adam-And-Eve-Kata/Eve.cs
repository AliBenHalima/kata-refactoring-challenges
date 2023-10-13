using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Adam_And_Eve_Kata
{
    public sealed class Eve : Female
    {
        private Eve() { }

        private static Eve? _instance = null;
        public static Eve GetInstance(Adam adam)
        {
            if (adam is null)
            {
                throw new ArgumentNullException();
            }
            if (_instance is null)
            {
                _instance = new Eve();
            }
            return _instance;
        }
    }
}
