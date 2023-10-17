using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Patter_Delegates.Implementations
{
    public class UserObserver
    {
        public User User { get; set; }
        public UserObserver(User user)
        {
            User = user;
        }

        public void HandleEvent(object sender)
        {
            Console.WriteLine("Notification From "+User.Name);
        }
    }
}
