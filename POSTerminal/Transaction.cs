using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Transaction
    {
        public double CalcSub(Dictionary<string, int> transactionItems)
        {
            double subTotal = 0;
            foreach (KeyValuePair<string, int> kvp in transactionItems)
            {
                //Get the cost of the key (based on the name) and multiply by quantity
                double cost = GetCost(kvp.Key) * kvp.Value;
                subTotal += cost;
            }
            return subTotal;
        }

        public double GetTotal(double total)
        {

            return total * 1.06;
        }

        public double GetCost(string strain)
        {
            if (strain == "Runtz")
            {
                return 20;
            }
            else if (strain == "Dream Queen")
            {
                return 8;
            }
            else if (strain == "Dosi Dos")
            {
                return 20;
            }
            else if (strain == "Mac 1")
            {
                return 20;
            }
            else if (strain == "Bermuda")
            {
                return 20;
            }
            else if (strain == "Sherblatoo")
            {
                return 20;
            }
            else if (strain == "Thin Mints")
            {
                return 10;
            }
            else if (strain == "True North Collective Mimosa")
            {
                return 20;
            }
            else if (strain == "Purple Haze")
            {
                return 15;
            }
            else if (strain == "Guava Cake")
            {
                return 20;
            }
            else if (strain == "Sour OG Kush")
            {
                return 10;
            }
            else if (strain == "Kush Mints")
            {
                return 20;
            }
            else
            {
                return 0;
            }

        }


    }
}
