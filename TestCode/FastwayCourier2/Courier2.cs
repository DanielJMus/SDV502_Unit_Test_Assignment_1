using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace FastwayCourier2
{
    [TestClass]
    public class Courier2
    {
        [TestMethod]
        public void Courier2PriceTest()
        {
            ParcelQuoteFromNelson priceCalculator = new ParcelQuoteFromNelson();
            var total = priceCalculator.CalculateQuote(20, "orange");
            Assert.AreEqual(0, total.ExcessTickets);
        }

        [TestMethod]
        public void Courier2ZoneTest()
        {
            ParcelQuoteFromNelson zoneCalculator = new ParcelQuoteFromNelson();
            var zone = zoneCalculator.GetDestinationZone("BadiNput");
            Assert.AreEqual("Orange", zone);
        }
    }
}
