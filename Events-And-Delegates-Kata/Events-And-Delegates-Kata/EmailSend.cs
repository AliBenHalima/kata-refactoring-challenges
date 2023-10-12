using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates_Kata
{
    public class EmailSend
    {
        public void HandleEvent(object sender, string person)
        {
            Console.WriteLine($"Email Sent to {person}");
        }
    }
}
