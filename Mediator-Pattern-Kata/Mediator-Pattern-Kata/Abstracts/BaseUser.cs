using Mediator_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern_Kata.Abstracts
{
    public abstract class BaseUser
    {
        public IMediator _mediator {  get; set; }
        public BaseUser(IMediator mediator)
        {
            _mediator = mediator;
        }
        public abstract void SendMessage(string message);
    }
}
