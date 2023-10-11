using System.Collections.Generic;
using Trip_Service_Kata.Interfaces;
using TripServiceKata.Exception;
using TripServiceKata.Users;

namespace TripServiceKata.Trips
{
    public class TripDAO : ITripDAO
    {
        public List<Trip> FindTripsByUser(User user)
        {
            return user.Trips;
        }
    }
}
