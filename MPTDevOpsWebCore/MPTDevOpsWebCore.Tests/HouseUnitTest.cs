using System;
using Xunit;
using MPTDevOpsWebCore;

namespace MPTDevOpsWebCore.Tests
{
    public class HouseUnitTest
    {
       
        [Fact]
        public void T001_HousePriceTest()
        {
            House h = new House();
            h.Price = 100000;
            h.Location = "BKK";
            h.HCode = "BKK-100K";

            Assert.True(h.Price >= 0, "Price must GT zero");
           // Assert.False(result, "1 should not be prime");
        }
    }
}
