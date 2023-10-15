using AutoFixture;
using NUnit.Framework;
using SocialMedia_kata.Implementations;
using SocialMedia_kata.Interfaces;
using Xunit;

namespace SocialMedia_Kata_Tests
{
    public class SocialMediaCustomTests
    {
        public Fixture fixture;
        public SocialMediaCustomTests()
        {
            fixture = new Fixture();
            fixture.Customize<IMemberProfile>(x => x.FromFactory(() => new MemberProfile()));
        }

        [Fact]
        public void AddMember_Adds_Member_To_Members_List()
        {
            //Arrange
           
            var member = fixture.Create<Member>();

            var sut = new SocialNetwork();
            //Act
            var addedMember = sut.AddMember(member.Profile.Firstname, member.Profile.Lastname, member.Profile.City, member.Profile.Country);

            //Assert
            Xunit.Assert.Equal(1, sut.MemberCount);
            Xunit.Assert.Contains(addedMember, sut.Members);
        }

        [Fact]
        public void FindMemberById_Returns_Member_When_Member_Exists()
        {
            //Arrange   
            var sut = new SocialNetwork();

            var member = fixture.Create<Member>();
            member.Profile.MemberId = member.Id;


            //Act
            var addedMember = sut.AddMember(member.Profile.Firstname, member.Profile.Lastname, member.Profile.City, member.Profile.Country);
            var result = sut.FindMemberById(addedMember.Id);

            //Assert
            Xunit.Assert.Equal(member.Profile.Firstname, result.Profile.Firstname);
            Xunit.Assert.Equal(member.Profile.Lastname, result.Profile.Lastname);
            Xunit.Assert.Equal(member.Profile.City, result.Profile.City);
            Xunit.Assert.Equal(member.Profile.Country, result.Profile.Country);
        }

        [Fact]
        public void FindMember_Returns_Member_When_Search_Condition_Met()
        {
            //Arrange
            var sut = new SocialNetwork();

            var member = fixture.Create<Member>();
            member.Profile.MemberId = member.Id;

            string searchCondition = member.Profile.Firstname;
            //Act
            var addedMember = sut.AddMember(member.Profile.Firstname, member.Profile.Lastname, member.Profile.City, member.Profile.Country);
            var result = sut.FindMember(searchCondition);

            //Assert
            Xunit.Assert.NotNull(result);
            Xunit.Assert.Contains(result, x => x.Profile.Firstname == addedMember.Profile.Firstname);
        }

    }
}
