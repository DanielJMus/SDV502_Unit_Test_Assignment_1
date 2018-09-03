using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastwayCourier
{
    [TestClass]
    public class Courier1
    {
        [TestMethod]
        public void ShouldReturnParcelPriceWhenValidWeight1()
        {
            // Arrange
            ParcelQuoteFromNelson priceCalculator = new ParcelQuoteFromNelson();
            // Act
            var total = priceCalculator.CalculateQuote(0, "pink");
            // Assert
            Assert.AreEqual(0, total.ExcessTickets);
        }

        [TestMethod]
        public void ShouldReturnParcelZoneWhenValidDestination1()
        {
            // Arrange
            ParcelQuoteFromNelson zoneCalculator = new ParcelQuoteFromNelson();
            // Act
            var zone = zoneCalculator.GetDestinationZone("Kaikoura");
            // Assert
            Assert.AreEqual("Orange", zone);
        }
    }
}
