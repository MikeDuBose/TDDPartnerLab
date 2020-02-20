using System;
using Xunit;
using POSTerminal;
using System.Collections.Generic;

namespace POSTerminalTest
{
    public class UnitTestCart
    {
        [Fact]
        public void Constructor_Instantiation_NameReturn()
        {
            Cart items = new Cart();
            Product a = new Product("TestMike", 5, 25, "Mean");
            KeyValuePair<string, int> kvp = new KeyValuePair<string, int>("TestMike", 3);
            
            Assert.Equal(kvp, items.AddCart(a, 3));

        }
    }
}
