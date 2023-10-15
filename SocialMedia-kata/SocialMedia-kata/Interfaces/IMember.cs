using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia_kata.Interfaces
{
    public interface IMember
    {
        int Id { get; }

        IMemberProfile Profile { get; }
        IList<IMember> Friends { get { return null; } }
        IList<IMember> Pending { get { return null; } }
        IList<IPost> Posts { get { return null; } }

        void AddFriendRequest(IMember from);

        void ConfirmFriend(IMember member);

        void RemoveFriendRequest(IMember member);

        void RemoveFriend(IMember member);

        IList<IMember> GetFriends(int level = 1, IList<int> filter = null);


        IPost AddPost(string message);


        void RemovePost(int id);


        IEnumerable<IPost> GetFeed();

    }
}
