using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripServiceKata.Users;

namespace Trip_Service_Kata.Interfaces
{
    public interface IUserSession
    {
        bool IsUserLoggedIn(User user);
        User? GetLoggedUser();

    }
}
