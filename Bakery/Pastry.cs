using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    public class Pastry
    {
        public int PastryOrder { get; set;}
        public int PastrySubTotal { get; set;}

        public Pastry(int pastryOrder)
        {
            PastryOrder = pastryOrder;
            PastrySubTotal = 0;
        }

        public int PastryCalculator(Pastry newPastry)
        {
            for (int i = 1; i <= newPastry.PastryOrder; i ++)
            {
                if (i % 3 == 0)
                {
                    newPastry.PastrySubTotal += 1;
                }
                else 
                {
                    newPastry.PastrySubTotal += 2;
                }
            }

            return newPastry.PastrySubTotal;
        }
    }
}