using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void ShouldReturnAValidFullName()
        {

            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Espinoza";
            customer.FirstName = "Juan";
            string expectedFullName = "Espinoza, Juan";

            //-- Act
            string actualFullname = customer.FullName;

            //-- Assert
            Assert.Equal(expectedFullName, actualFullname);
        }

        [Fact]
        public void ShouldReturnAValidFullNameWithLastNameEmpty()
        {

            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Juan";
            string expectedFullName = "Juan";

            //-- Act
            string actualFullname = customer.FullName;

            //-- Assert
            Assert.Equal(expectedFullName, actualFullname);
        }

        [Fact]
        public void ShouldReturnAValidFullNameWithFirstNameEmpty()
        {

            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Espinoza";
            string expectedFullName = "Espinoza";

            //-- Act
            string actualFullname = customer.FullName;

            //-- Assert
            Assert.Equal(expectedFullName, actualFullname);
        }

        [Fact]
        public void ShouldCount3InInstanceCounterStaticProperty()
        {

            //-- Arrange
            Customer customer1 = new Customer();
            customer1.FirstName = "Ana";
            Customer.InstanceCounter += 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Juan";
            Customer.InstanceCounter += 1;

            Customer customer3 = new Customer();
            customer3.FirstName = "Pedro";
            Customer.InstanceCounter += 1;

            //-- Act

            //-- Assert
            Assert.Equal(3, Customer.InstanceCounter);
        }

        [Fact]
        public void ShouldValidate()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                Email = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldNotValidate()
        {
            //-- Arrange
            var customer = new Customer
            {
                Email = "fbaggins@hobbiton.me"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}
