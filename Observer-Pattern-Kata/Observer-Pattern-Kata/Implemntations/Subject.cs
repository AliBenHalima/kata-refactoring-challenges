using Observer_Pattern_Kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Kata.Implemntations
{
    public class Subject : ISubject
    {
        public int State { get; set; }
        public List<IObserver> Subscribers { get; set; } = new();
        public void Subscribe(IObserver observer)
        {
            Subscribers.Add(observer);
        }
        public void Unsubscribe(IObserver observer)
        {
            Subscribers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.update(this);
            }
        }


    }
}
