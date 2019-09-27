using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    public class Script
    {
        public static void BeginOrder()
        {
        Console.WriteLine("Please enter the number of BREADS you would like to order:");
        int userBread = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of PASTRIES you would like to order:");
        int userPastry = int.Parse(Console.ReadLine());

        Bread newBread = new Bread (userBread);
        Pastry newPastry = new Pastry (userPastry);
        
        int orderTotal = newBread.BreadCalculator(newBread) + newPastry.PastryCalculator(newPastry);

        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(newBread.BreadOrder + " BREAD will cost $" + newBread.BreadSubTotal + ".00");
        Console.WriteLine(newPastry.PastryOrder + " PASTRY will cost $" + newPastry.PastrySubTotal + ".00");
        Console.WriteLine("Your grand total is: $" + orderTotal + ".00");
        Console.WriteLine("-----------------------------------------------------------");
        }

        public static void ConfirmOrder()
        {
            Console.WriteLine("**Is your order correct?**");
            Console.WriteLine("1. Confirm Order");
            Console.WriteLine("2. Modify Order");
            string confirmOrderInput = Console.ReadLine();

            if (confirmOrderInput == "1")
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Thank you for your order! [press any key to return to the Main Menu]");
                Console.ReadKey();
                Program.Main();
            }
            else if (confirmOrderInput == "2")
            {
                Console.WriteLine("-----------------------------------------------------------");
                Script.BeginOrder();
                Script.ConfirmOrder();
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("**Please enter a valid number**");
                Script.BeginOrder();    
            }
        }
    }
}