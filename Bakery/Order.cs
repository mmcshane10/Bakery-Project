using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    class Order
    {
        public string Name { get; set;}
        public int BreadOrder { get; set;}
        public int BreadSubTotal { get; set;}
        public int PastryOrder { get; set;}
        public int PastrySubTotal { get; set;}

        public Order(string name, int breadOrder, int pastryOrder)
        {
            Name = name;
            BreadOrder = breadOrder;
            BreadSubTotal = 0;
            PastryOrder = pastryOrder;
            PastrySubTotal = 0;
        }

        public static void OrderInput()
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
            int orderTotal = userOrder.BreadCalculator(userOrder) + userOrder.PastryCalculator(userOrder);

            Console.WriteLine(userOrder.BreadSubTotal);
            Console.WriteLine(userOrder.PastrySubTotal);
            Console.WriteLine(orderTotal);

        }

        public int BreadCalculator(Order userOrder)
        {
            for (int i = 1; i <= userOrder.BreadOrder; i ++)
            {
                if (i % 3 == 0)
                {
                    userOrder.BreadSubTotal += 0;
                }
                else 
                {
                    userOrder.BreadSubTotal += 5;
                }
            }

            return userOrder.BreadSubTotal;
        }

        public int PastryCalculator(Order userOrder)
        {
            for (int i = 1; i <= userOrder.PastryOrder; i ++)
            {
                if (i % 3 == 0)
                {
                    userOrder.PastrySubTotal += 1;
                }
                else 
                {
                    userOrder.PastrySubTotal += 2;
                }
            }

            return userOrder.PastrySubTotal;
        }

    }
}