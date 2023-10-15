namespace SocialMedia_kata.Interfaces
{
    public interface ISocialNetwork
    {
        IList<IMember> Members { get; set; }
        IMember AddMember(string firstName, string lastName, string city, string country);

        // Returns the member with the id
        IMember FindMemberById(int id);


        // Returns a list of members by searching all fields in the profile
        IEnumerable<IMember> FindMember(string search);

        // Total number of members currently in the social network
        int MemberCount { get; set; }
    }
}