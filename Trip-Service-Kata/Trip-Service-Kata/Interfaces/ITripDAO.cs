using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripServiceKata.Trips;
using TripServiceKata.Users;

namespace Trip_Service_Kata.Interfaces
{
    public interface ITripDAO
    {
        List<Trip> FindTripsByUser(User user);
    }
}
