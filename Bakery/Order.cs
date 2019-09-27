using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    class Order
    {
        public string Name { get; set;}
        public int BreadOrder { get; set;}
        public int PastryOrder { get; set;}

        public Order(string name, int breadOrder, int pastryOrder)
        {
            Name = name;
            BreadOrder = breadOrder;
            PastryOrder = pastryOrder;
        }


    }
}