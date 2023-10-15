using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia_kata.Interfaces;

namespace SocialMedia_kata.Implementations
{
    public class MemberProfile : IMemberProfile
    {
        // Id of the Member this profile belongs to
        public int MemberId { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
