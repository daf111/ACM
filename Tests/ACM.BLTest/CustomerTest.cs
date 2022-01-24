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
    }
}
