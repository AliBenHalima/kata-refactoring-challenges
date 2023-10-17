using Mediator_Pattern_Kata.Abstracts;
using Mediator_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern_Kata.Implemntations
{
    public class User : BaseUser
    {
        public string Name { get; set; }

        public User(IMediator mediator) : base(mediator) { }
        public override void SendMessage(string message)
        {
            _mediator.notify(this);
        }
    }
}
