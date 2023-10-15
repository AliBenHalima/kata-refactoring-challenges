using AutoFixture;
using SocialMedia_kata.Implementations;
using SocialMedia_kata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SocialMedia_Kata_Tests
{
    public class MembersCustomTests
    {
        private Fixture _fixture;
        public MembersCustomTests()
        {
            _fixture = new Fixture();
            _fixture.Customize<IMemberProfile>(x => x.FromFactory(() => new MemberProfile()));
            _fixture.Customize<IMember>(x => x.FromFactory(() => new Member()));
            _fixture.Customize<IPost>(x => x.FromFactory(() => new Post()));
        }
        [Fact]
        public void AdAddFriendRequest_Should_Add_Friend_To_Pending_List()
        {
            //Arrange
            var sut = new Member();
            var from = _fixture.Create<Member>();
            //Act
            sut.AddFriendRequest(from);
            //Assert
            Assert.Contains(sut.Pending, x => x.Id == from.Id);
        }

        [Fact]
        public void ConfirmFriend_Should_Confirm_Friend_Request()
        {
            //Arrange
            var sut = new Member();
            var pendingMemberRequest = _fixture.Create<Member>();
            sut.Pending.Add(pendingMemberRequest);
            //Act
            sut.ConfirmFriend(pendingMemberRequest);
            //Assert
            Assert.NotNull(pendingMemberRequest);
            Assert.DoesNotContain(pendingMemberRequest, sut.Pending);
            Assert.Contains(pendingMemberRequest, sut.Friends);
        }

        [Fact]
        public void RemoveFriendRequest_Should_Remove_Friend_Request_From_Pending_List()
        {
            //Arrange
            var sut = new Member();
            var pendingMemberRequest = _fixture.Create<Member>();
            sut.Pending.Add(pendingMemberRequest);
            //Act
            sut.RemoveFriendRequest(pendingMemberRequest);
            //Assert
            Assert.NotNull(pendingMemberRequest);
            Assert.DoesNotContain(pendingMemberRequest, sut.Pending);
        }

        [Fact]
        public void RemoveFriend_Should_Remove_Friend_Request_From_Friends_List()
        {
            //Arrange
            var sut = new Member();
            var friend = _fixture.Create<Member>();
            sut.Friends.Add(friend);
            //Act
            sut.RemoveFriend(friend);
            //Assert
            Assert.NotNull(friend);
            Assert.DoesNotContain(friend, sut.Friends);
        }


        [Fact]
        public void AddPost_Should_Add_Post_To_Posts_List()
        {
            //Arrange 
            var sut = new Member();

            //Act
            var addedPost = sut.AddPost(string.Empty);

            //Assert
            Assert.Contains(addedPost, sut.Posts);
        }

        [Fact]
        public void RemovePost_Should_Remove_Post_From_Feed()
        {
            //Arrange
            var sut = new Member();
            var post = _fixture.Create<Post>();
            sut.Posts.Add(post);
            //Act
            sut.RemovePost(post.Id);
            //Assert
            Assert.DoesNotContain(post, sut.Posts);
        }

        [Fact]
        public void GetFeed_Should_Return_Posts_Along_With_Friends_Posts()
        {
            //Arrange
            var sut = new Member();
            var posts = _fixture
                        .Build<Post>()
                        .With(x => x.Member, sut)
                        .CreateMany(5)
                        .ToList();

            foreach (var post in posts)
            {
                sut.Posts.Add(post);
            }

            var friends = _fixture.Build<Member>()
                    .Without(x => x.Posts)
                   .CreateMany(3).ToList();

            foreach (var friend in friends)
            {
                var friendPosts = _fixture.Build<Post>()
                                  .With(x => x.Member, friend)
                                  .CreateMany(2).ToList();
                foreach( var newPost in friendPosts)
                {
                    friend.Posts.Add(newPost);
                }
            }
            //Act
            var result = sut.GetFeed();
            //Assert
            List<IPost> friendsPost = new();
            foreach (var friend in friends)
            {
                friendsPost.AddRange(friend.Posts.ToList());
            }
            Assert.True(result.All(x => sut.Posts.Concat(friendsPost).Contains(x)));
           


        }
    }
}
