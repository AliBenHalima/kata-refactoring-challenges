using System.Collections.Generic;
using TripServiceKata.Trips;

namespace TripServiceKata.Users
{
    public class User
    {
        public List<Trip> Trips { get; set; } = new List<Trip>();
        public List<User> Friends { get; set; } = new List<User>();

        public void AddFriend(User user)
        {
            Friends.Add(user);
        }

        public void AddTrip(Trip trip)
        {
            Trips.Add(trip);
        }

    }
}
