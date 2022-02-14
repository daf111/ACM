using ACM.BL;
using Acme.Common;
using System;
using System.Collections.Generic;
using Xunit;

namespace Acme.CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggeable>();

            var customer = new Customer(1)
            {
                Email = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                Addresses = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // Nothing here to assert
        }
    }
}
