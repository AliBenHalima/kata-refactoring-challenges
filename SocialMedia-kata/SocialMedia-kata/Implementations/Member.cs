using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using SocialMedia_kata.Interfaces;

namespace SocialMedia_kata.Implementations
{
    public class Member : IMember
    {

        // Id of member. Must be unique and sequential. 
        public int Id { get; init; }
        // Member profile
        public IMemberProfile Profile { get; init; }
        // List of friends
        public IList<IMember> Friends { get; } = new List<IMember>();
        // List of pending friend requests
        public IList<IMember> Pending { get; } = new List<IMember>();
        // Members posts
        public IList<IPost> Posts { get; set; } = new List<IPost>();

        // Adds a friend request for this member. from - the member making the friend request 
        public void AddFriendRequest(IMember from)
        {
            bool hasPendingRequest = Pending.Contains(from);
            if (hasPendingRequest)
            {
                throw new Exception("Already has a friend request from this member");
            }
            bool isFriend = Friends.Contains(from);
            if (isFriend)
            {
                throw new Exception("Already a friend");
            }
            Pending.Add(from);
        }

        // Confirms a pending friend request
        public void ConfirmFriend(IMember member)
        {
            var request = Pending.Where(x => x.Id == member.Id).FirstOrDefault();
            if (request is null)
            {
                throw new Exception("Unvalid Request");
            }
            bool isFriend = Friends.Any(x => x.Id == member.Id);
            if (isFriend)
            {
                throw new Exception("Already a friend");
            }
            Pending.Remove(member);
            Friends.Add(member);
        }

        // Removes a pending friend request
        public void RemoveFriendRequest(IMember member)
        {
            var pendingRequest = Pending.Where(x => x.Id == member.Id).FirstOrDefault();
            if (pendingRequest is null)
            {
                throw new Exception("Invalid Request");
            }
            Pending.Remove(member);

        }

        // Removes a friend
        public void RemoveFriend(IMember member)
        {
            var isfriend = Friends.Any();
            if (!isfriend)
            {
                throw new Exception($"{member.Profile.Firstname} is not a friend");
            }
            Friends.Remove(member);

        }

        // Returns a list of all friends. level - depth (1 - friends, 2 - friends of friends ...)
        public IList<IMember> GetFriends(int level = 1, IList<int> filter = null)
        {
            return null;
        }

        // Adds a new post to members feed
        public IPost AddPost(string message)
        {
            var post = new Post()
            {
                Id = new Random().Next(1, 999),
                Member = this,
                Message = message,
                Date = DateTime.Now,
                Likes = 0,
            };
            Posts.Add(post);
            return post;
        }

        // Removes the post with the id
        public void RemovePost(int id)
        {
            var post = Posts.FirstOrDefault(x => x.Id == id);
            if (post is null)
            {
                throw new Exception("Invalid Post");
            }
            Posts.Remove(post);
        }

        // Returns members feed as a list of posts. Should also return posts of friends.
        public IEnumerable<IPost> GetFeed()
        {
            var friendsPost = GetFriendsPosts();
            return Posts.Concat(friendsPost);
        }
        private List<IPost> GetFriendsPosts()
        {
            var posts = new List<IPost>();
            foreach (var friend in Friends)
            {
                posts.AddRange(friend.Posts);
            }
            return posts;
        }
    }
}
