using Observer_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Kata.Implemntations
{
    public class Observer : IObserver
    {
        public User UserEntity { get; set; }
        public Observer(User user)
        {
            UserEntity = user;
        }
        public void update(ISubject subject)
        {
            Console.WriteLine(UserEntity.Name);
        }
    }
}
