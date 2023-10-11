using AutoFixture;
using Moq;
using Trip_Service_Kata.Interfaces;
using TripServiceKata.Exception;
using TripServiceKata.Trips;
using TripServiceKata.Users;

namespace Trip_Service_Kata_Tests
{
    public class RefactoredTripServiceTests
    {
        private readonly Mock<IUserSession> _userSession = new Mock<IUserSession>();
        private readonly Mock<ITripDAO> _tripDAO = new Mock<ITripDAO>();
        private readonly TripService _sut;
        public RefactoredTripServiceTests()
        {
            _sut = new TripService(_userSession.Object, _tripDAO.Object);
        }

        [Fact]
        public void GetTripsByUser_Should_Return_List_Of_Trips_When_User_Is_Authenticated()
        {
            //Arrange
            var fixture = new Fixture();
            var user = new User();
            var loggedInUser = new User();

            var addedFriends = fixture
                .Build<User>()
                .Without(u => u.Friends)
                .CreateMany(10);

            var addedTrips = fixture.CreateMany<Trip>(10);
            _userSession.Setup((x => x.GetLoggedUser())).Returns(loggedInUser);
            _tripDAO.Setup((x => x.FindTripsByUser(It.Is<User>(x => ReferenceEquals(x, user))))).Returns(user.Trips);

            //Act
            user.Friends.AddRange(addedFriends);
            user.Friends.Add(loggedInUser);
            user.Trips.AddRange(addedTrips);
            var result = _sut.GetTripsByUser(user);
            //Assert
            Assert.Equal(result, user.Trips);
        }

        [Fact]
        public void GetTripsByUser_Should_Throw_Exception_When_User_Is_Not_Authenticated()
        {
            //Arrange
            var user = new User();
            _userSession.Setup(x => x.GetLoggedUser()).Returns(() => null);
            //Act
            Action resultMethod = () => _sut.GetTripsByUser(user);
            //Assert
            Assert.Throws<UserNotLoggedInException>(resultMethod);
        }
    }
}
