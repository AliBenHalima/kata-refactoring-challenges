using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using SocialMedia_kata.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SocialMedia_kata.Implementations
{
        public class SocialNetwork : ISocialNetwork
        {
            public IList<IMember> Members { get; set; } = new List<IMember>();
            // Adds a new member and returns the added member
            public IMember AddMember(string firstName, string lastName, string city, string country)
            {
                int randomId = new Random().Next(1, 999);
                var member = new Member()
                {
                    Id = randomId,
                    Profile = new MemberProfile()
                    {
                        MemberId = randomId,
                        Firstname = firstName,
                        Lastname = lastName,
                        City = city,
                        Country = country,
                    }
                };
                Members.Add(member);
                MemberCount++;
                return member;
            }


            // Returns the member with the id
            public IMember FindMemberById(int id)
            {
                return Members.Where(x => x.Id == id).FirstOrDefault();

            }

            // Returns a list of members by searching all fields in the profile
            public IEnumerable<IMember> FindMember(string search)
            {
                return Members.Where(x => (x.Profile.Firstname == search) || (x.Profile.Lastname == search) || (x.Profile.City == search) || (x.Profile.Country == search))
                       .ToList();
            }

            // Total number of members currently in the social network
            public int MemberCount { get; set; }
        }
}
