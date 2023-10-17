using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Patter_Delegates.Implementations
{
    public class Subject
    {
        public delegate void EventHandler(object sender);
        public event EventHandler OnUserUpdate;
        public void SendMessage()
        {
            OnUserUpdate(this);
        }
    }
}
