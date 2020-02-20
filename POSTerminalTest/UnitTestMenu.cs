using System;
using Xunit;
using POSTerminal;

namespace POSTerminalTest
{
    public class UnitTestMenu
    {
        [Fact]
        public void Constructor_Instantiation_NameReturn()
        {
            Menu items = new Menu();
            Assert.Equal("Name: Runtz\nPrice: $20\nTHC Percent: 26\nType: Indica", items.PrintString());
           
        }
    }
}
