using Mediator_Pattern_Kata.Implemntations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern_Kata.Interfaces
{
    public interface IMediator
    {
        void notify(User user);
    }
}
