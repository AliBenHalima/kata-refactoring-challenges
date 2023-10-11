using System.Collections.Generic;
using Trip_Service_Kata.Interfaces;
using TripServiceKata.Exception;
using TripServiceKata.Users;

namespace TripServiceKata.Trips
{
    public class TripService
    {
        private readonly IUserSession _userSession;
        private readonly ITripDAO _tripDAO;
        public List<Trip> TripList { get; set; } = new List<Trip>();

        public TripService(IUserSession userSession, ITripDAO tripDAO)
        {
            _userSession = userSession;
            _tripDAO = tripDAO;
        }

        public List<Trip> GetTripsByUser(User user)
        {
            User loggedUser = _userSession.GetLoggedUser();

            if (loggedUser is null)
            {
                throw new UserNotLoggedInException();
            }
            else
            {
                bool isFriend = user.Friends.Contains<User>(loggedUser);
                if (isFriend)
                {
                    TripList = _tripDAO.FindTripsByUser(user);
                }
                return TripList;
            }
        }
    }
}
