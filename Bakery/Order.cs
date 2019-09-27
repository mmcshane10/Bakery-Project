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

        public static void beginOrderInput()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("**Bread is $5/loaf. Every third loaf you purchase is FREE**");
            Console.WriteLine("**Pastries are $2 each or 3 for $5**");
            Console.WriteLine("Please enter the number of BREADS you would like to order:");
            int userBread = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of PASTRIES you would like to order:");
            int userPastry = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the name for your order:");
            string userName = Console.ReadLine();

            Order userOrder = new Order (userName, userBread, userPastry);

        }


    }
}