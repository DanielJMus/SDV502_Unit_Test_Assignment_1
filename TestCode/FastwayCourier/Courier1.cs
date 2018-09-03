using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastwayCourier
{
    [TestClass]
    public class Courier1
    {
        [TestMethod]
        public void Courier1PriceTest()
        {
            ParcelQuoteFromNelson priceCalculator = new ParcelQuoteFromNelson();
            var total = priceCalculator.CalculateQuote(20, "orange");
            Assert.AreEqual(0, total.ExcessTickets);
        }

        [TestMethod]
        public void Courier1ZoneTest()
        {
            ParcelQuoteFromNelson zoneCalculator = new ParcelQuoteFromNelson();
            var zone = zoneCalculator.GetDestinationZone("Kaikoura");
            Assert.AreEqual("Orange", zone);
        }
    }
}
