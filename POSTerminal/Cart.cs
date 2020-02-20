using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Cart
    {
        Dictionary<string, int> productItems = new Dictionary<string, int>();



        public KeyValuePair<string, int> AddCart(Product p, int n)
        {
            if (productItems.ContainsKey(p.Name) && productItems != null)
            {
                productItems[p.Name] = productItems[p.Name] + n;
            }
            else
            {
                productItems.Add(p.Name, n);
            }
            return new KeyValuePair<string, int>(p.Name, productItems[p.Name]);
        }
    }






}

