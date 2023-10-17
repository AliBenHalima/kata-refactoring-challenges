using Mediator_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern_Kata.Implemntations
{
    public class GroupMediator : IMediator
    {
        public List<User> Users { get; set; } = new();
        public void notify(User user)
        {
            Console.WriteLine($"Hello From {user.Name}");
        }
       
    }
}
