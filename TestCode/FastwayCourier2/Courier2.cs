using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace FastwayCourier2
{
    [TestClass]
    public class Courier2
    {

        // This method will return the correct parcel price based on the weight and zone color given, if either of these values are incorrect the function will throw an error.
        [TestMethod]
        public void ShouldReturnParcelPriceWhenValidWeight2()
        {
            // Arrange
            ParcelQuoteFromNelson priceCalculator = new ParcelQuoteFromNelson();
            // Act
            var total = priceCalculator.CalculateQuote(20, "orange");
            // Assert
            Assert.AreEqual(19.15m, total.Price);
        }

        // This method will return the correct zone colour based on the destination given, if either of these values are incorrect the function will throw an error.
        [TestMethod]
        public void ShouldReturnOrangeWhenDestinationValid2()
        {
            // Arrange
            ParcelQuoteFromNelson zoneCalculator = new ParcelQuoteFromNelson();
            // Act
            var zone = zoneCalculator.GetDestinationZone("Reefton");
            // Assert
            Assert.AreEqual("Orange", zone);
        }
    }
}
