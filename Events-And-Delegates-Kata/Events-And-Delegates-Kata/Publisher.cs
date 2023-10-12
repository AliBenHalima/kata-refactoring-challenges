using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates_Kata
{
    public class Publisher
    {
        public delegate void PersonDelegate(object sender, string person);
        public event PersonDelegate OnContactNotify;
        public IDictionary<string, uint> PersonDictionary = new Dictionary<string, uint>();
        public void SendNotifications(List<string> persons)
        {
            foreach (string person in persons)
            {
                bool keyExists = PersonDictionary.TryGetValue(person, out uint occurence);
                if (!keyExists)
                {
                    PersonDictionary.TryAdd(person, ++occurence);
                }
                else
                {
                    PersonDictionary[person] = ++occurence;
                }
                if (ShouldBeNotified(occurence))
                {
                    OnContactNotify(this, person);
                }

            }
        }
        private bool ShouldBeNotified(uint value)
        {
            return value % 3 == 0;
        }

    }
}
