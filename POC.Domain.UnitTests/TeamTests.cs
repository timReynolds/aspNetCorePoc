using System.Linq;
using NUnit.Framework;

namespace POC.Domain.UnitTests
{
    [TestFixture]
    public class TeamTests
    {
        [Test]
        public void Team_WhenCreated_ShoudlPopulateProperties()
        {
            // Arrange 
            var name = "TeamTeam";
            var sport = Sport.Snooker;

            // Act
            var result = new Team(name, sport);

            // Assert
            Assert.IsNotNull(result.CreatedDate);
            Assert.AreEqual(result.Name, name);
            Assert.AreEqual(result.Sport, sport);
            Assert.IsEmpty(result.Members);
        }

        [Test]
        public void RegisterMember_WhenGivenPerson_ShoudlPopulateAddMemberToTeam()
        {
            // Arrange 
            var name = "TeamTeam";
            var sport = Sport.Snooker;
            var person = new Person("Tim", 28, "t.co");

            // Act
            var result = new Team(name, sport);
            result.RegisterMember(person);

            // Assert
            Assert.IsNotNull(result.CreatedDate);
            Assert.AreEqual(result.Name, name);
            Assert.AreEqual(result.Sport, sport);
            Assert.AreEqual(1, result.Members.Count);
            Assert.AreEqual(person, result.Members.First());
        }

        [Test]
        public void RemoveMember_WhenGivenPerson_ShoudlPopulateAddMemberToTeam()
        {
            // Arrange 
            var name = "TeamTeam";
            var sport = Sport.Snooker;
            var person = new Person("Tim", 28, "t.co");

            // Act
            var result = new Team(name, sport);
            result.RegisterMember(person);
            result.RemoveMember(person);

            // Assert
            Assert.IsNotNull(result.CreatedDate);
            Assert.AreEqual(result.Name, name);
            Assert.AreEqual(result.Sport, sport);
            Assert.IsEmpty(result.Members);
        }

    }
}