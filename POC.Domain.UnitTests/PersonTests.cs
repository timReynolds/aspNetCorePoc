using NUnit.Framework;

namespace POC.Domain.UnitTests
{
    [TestFixture]
    public class PersonTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void Person_WhenCreated_ShouldHaveACreateDate()
        {
            // Arrange 
            var name = "tim reynolds";
            var age = 28;
            var email = "tim@timothyreynolds.co.uk";

            // Act 
            var result = new Person(name, age, email);

            // Assert
            Assert.IsNotNull(result.CreatedDate);
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(age, result.Age);
            Assert.AreEqual(email, result.Email);
        }

        [Test]
        public void Person_WhenUpdated_ShouldUpdateEmailAddress()
        {
            // Arrange 
            var name = "tim reynolds";
            var age = 28;
            var email = "tim@timothyreynolds.co.uk";
            var emailLatest = "T@t.co";
            
            // Act 
            var result = new Person(name, age, email);
            result.Update(emailLatest);

            // Assert
            Assert.AreEqual(name, result.Name);
            Assert.AreEqual(age, result.Age);
            Assert.AreEqual(emailLatest, result.Email);
        }
    }
}