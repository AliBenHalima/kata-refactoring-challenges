using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking_Craft_Startegy_Kata.Interfaces;

namespace Viking_Craft_Startegy_Kata.Implementations
{
    public class Viking : IUnit
    {
        public Viking()
        {
            MoveBehavior = new Walk();
        }

        public int Position { get; set; }
        public IMoveBehavior MoveBehavior { get; set; }

        public void Move()
        {
            MoveBehavior.Move(this);
        }
        //public void Move()
        //{
        //    switch (MoveBehavior)
        //    {
        //        case Fly:
        //            Position += 10;
        //            break;

        //        case Walk:
        //            Position += 1;
        //            break;
        //        default:
        //            Position += 1;
        //            break;

        //    }
        //  }
    }
}
