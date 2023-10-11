using System.Collections.Generic;
using TripServiceKata.User;

namespace Trip_Service_Kata_Tests
{
    public class UserTests
    {
        [Fact]
        public void GetFriends_Should_Return_List_Of_Friends()
        {
            //Arrange
            User user = new User();
            //Act
            var friends = user.GetFriends();
            //Assert
            Assert.IsAssignableFrom<IList<User>>(friends);
        }

        [Fact]
        public void AddFriend_Should_Add_Friend_To_Friends_List()
        {
            //Arrange
            User user = new User();
            User addedUser = new User();
            //Act
            user.AddFriend(addedUser);
            //Assert
            Assert.Contains<User>(addedUser, user.GetFriends());
        }


    }
}