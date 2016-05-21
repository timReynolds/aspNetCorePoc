using System;
using NUnit.Framework;

namespace POC.Domain.UnitTests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void GivenAPersonIsCreated_ShouldHaveACreateDate()
        {
            // Arrange 
            // Act 
            var result = new Person();
            // Assert
            Assert.IsNotNull(result.CreatedDate);
        }
    }
}