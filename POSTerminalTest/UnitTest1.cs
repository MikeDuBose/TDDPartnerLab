using System;
using Xunit;
using POSTerminal;

namespace POSTerminalTest
{
    public class UnitTest1
    {
        [Fact]
        public void Constructor_Instantiation_NameReturn()
        {
            Product bananakush = new Product("Banana Kush", 40, 27.40, "Sativa");
            Assert.Equal("Banana Kush", bananakush.Name);
        }
        [Fact]
        public void Constructor_Instantiation_PriceReturn()
        {
            Product bananakush = new Product("Banana Kush", 40, 27.40, "Sativa");
            Assert.Equal(40, bananakush.Price);
        }
        [Fact]
        public void Constructor_Instantiation_THCReturn()
        {
            Product bananakush = new Product("Banana Kush", 40, 27.40, "Sativa");
            Assert.Equal(27.40, bananakush.ThcPercent);
        }
        [Fact]
        public void Constructor_Instantiation_TypeReturn()
        {
            Product bananakush = new Product("Banana Kush", 40, 27.40, "Sativa");
            Assert.Equal("Sativa", bananakush.Type);
        }

        [Fact]
        public void Constructor_Instantiation_ToStringReturn()
        {
            Product bananakush = new Product("Banana Kush", 40, 27.40, "Sativa");
            Product pineappleexpress = new Product("Pineapple Express", 40, 27.40, "Indica");
            Assert.Equal("Name: Banana Kush\nPrice: $40\nTHC Percent: 27.4\nType: Sativa", bananakush.ToString());
        }
    }
}
