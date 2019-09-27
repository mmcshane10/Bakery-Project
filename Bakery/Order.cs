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