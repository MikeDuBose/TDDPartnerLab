using System;
using Xunit;
using POSTerminal;
using System.Collections.Generic;

namespace POSTerminalTest
{
    public class UnitTestTransaction
    {
        [Fact]
        public void Constructor_Instantiation_NameReturn()
        {
            Transaction t = new Transaction();
            Assert.Equal(20, t.GetCost("Runtz"));
        }
        [Fact]
        public void Constructor_Instantiation_PriceReturn()
        {
            Transaction t = new Transaction();
            Assert.Equal(8, t.GetCost("Dream Queen"));

        }
        [Fact]
        public void Constructor_Instantiation_NoPriceReturn()
        {
            Transaction t = new Transaction();
            Assert.Equal(0, t.GetCost("Cookies"));
        }
        [Fact]
        public void Constructor_Instantiation_SubTotalReturn()
        {
            Dictionary<string, int> subTotal = new Dictionary<string, int>();
            Transaction transaction = new Transaction();
            subTotal.Add("Runtz", 2);
            subTotal.Add("Mac 1", 1);
            Assert.Equal(60, transaction.CalcSub(subTotal));
        }
        [Fact]
        public void Constructor_Instantiation_TotalReturn()
        {
            Dictionary<string, int> subTotal = new Dictionary<string, int>();
            Transaction transaction = new Transaction();
            subTotal.Add("Runtz", 2);
            subTotal.Add("Mac 1", 1);
            Assert.Equal(63.6, transaction.GetTotal(transaction.CalcSub(subTotal)));
        }



    }
}
