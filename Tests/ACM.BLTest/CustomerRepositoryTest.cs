using ACM.BL;
using System;
using System.Collections.Generic;
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

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                Addresses = new List<Address>()
                    {
                        new Address()
                        {
                            AddressType = 1,
                            Street = "Bag End",
                            City = "Hobbiton",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "144"
                        },
                        new Address()
                        {
                            AddressType = 2,
                            Street = "Green Dragon",
                            City = "Bywater",
                            State = "Shire",
                            Country = "Middle Earth",
                            PostalCode = "146"
                        }
                    }
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Email, actual.Email);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.Addresses[i].AddressType, actual.Addresses[i].AddressType);
                Assert.Equal(expected.Addresses[i].Street, actual.Addresses[i].Street);
                Assert.Equal(expected.Addresses[i].City, actual.Addresses[i].City);
                Assert.Equal(expected.Addresses[i].State, actual.Addresses[i].State);
                Assert.Equal(expected.Addresses[i].Country, actual.Addresses[i].Country);
                Assert.Equal(expected.Addresses[i].PostalCode, actual.Addresses[i].PostalCode);
            }
        }
    }
}
