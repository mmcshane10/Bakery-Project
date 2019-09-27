using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    public class Bread
    {
        public int BreadOrder { get; set;}
        public int BreadSubTotal { get; set;}

        public Bread(int breadOrder)
        {
            BreadOrder = breadOrder;
            BreadSubTotal = 0;
        }

        public int BreadCalculator(Bread newBread)
        {
            for (int i = 1; i <= newBread.BreadOrder; i ++)
            {
                if (i % 3 == 0)
                {
                    newBread.BreadSubTotal += 0;
                }
                else 
                {
                    newBread.BreadSubTotal += 5;
                }
            }

            return newBread.BreadSubTotal;
        }
    }
}