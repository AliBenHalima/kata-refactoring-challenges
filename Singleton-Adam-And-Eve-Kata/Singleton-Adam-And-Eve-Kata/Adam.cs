using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Adam_And_Eve_Kata
{
    public sealed class Adam : Male
    {
        private static Adam? _instance = null;

        public static Adam GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Adam();
            }

            return _instance;
        }
    }
}
