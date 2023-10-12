using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates_Kata
{
    public class TextMessageSend
    {
        public string TextMessageList { get; set; }
        public void HandleEvent(object sender, string person)
        {
            string name;
            if (string.IsNullOrEmpty(TextMessageList)) {
                name =  $"{person}";
            }
            else
            {
                name = $", {person}";
            }
            TextMessageList += name;
        }
    }
}
