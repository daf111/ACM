using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void ShouldRetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                //Id = 1,
                Email = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Email, actual.Email);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }
    }
}
