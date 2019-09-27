using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    public class Script
    {

        public static void MainMenu()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("**Welcome to EpiDoughdus!**");
            Console.WriteLine("Please select one of the below options:");
            Console.WriteLine("1. Place an Order");
            Console.WriteLine("2. Complain About The Pun Made Above");
            string mainMenuInput = Console.ReadLine();

            if (mainMenuInput == "1")
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("**Here at EpiDoughdus we offer two exquisite products: our world famous BREAD and our instagram-worthy PASTRIES!**");
                Console.WriteLine("Please select one of the below options:");
                Console.WriteLine("1. Gimme that delicious gluten");
                Console.WriteLine("2. I'm scared and want to go back");
                string beginOrderInput = Console.ReadLine();

                if (beginOrderInput == "1")
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("**Bread is $5/loaf. Every third loaf you purchase is FREE**");
                    Console.WriteLine("**Pastries are $2 each or 3 for $5**");
                    Console.WriteLine("**10% taken off all orders over $40**");
                    Script.BeginOrder();
                    Script.ConfirmOrder();
                }
                else if (beginOrderInput == "2")
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("**Please enter a valid number**");
                    MainMenu();
                }
            }
            else if (mainMenuInput == "2")
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Please direct all complaints to elly@epidoughdus.com");
                MainMenu();
            }
            else{
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("**Please enter a valid number**");
                MainMenu();
            }
        }

        public static void BeginOrder()
        {
            Console.WriteLine("Please enter the number of BREADS you would like to order:");
            int userBread = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of PASTRIES you would like to order:");
            int userPastry = int.Parse(Console.ReadLine());

            Bread newBread = new Bread (userBread);
            Pastry newPastry = new Pastry (userPastry);
        
            int orderTotal = newBread.BreadCalculator(newBread) + newPastry.PastryCalculator(newPastry);

            if (orderTotal >= 40)
            {
                orderTotal = (int)(orderTotal * 0.9);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(newBread.BreadOrder + " BREAD will cost $" + newBread.BreadSubTotal + ".00");
                Console.WriteLine(newPastry.PastryOrder + " PASTRY will cost $" + newPastry.PastrySubTotal + ".00");
                Console.WriteLine("**You qualify for the 10% discount!**");
                Console.WriteLine("Your grand total is: $" + orderTotal + ".00");
                Console.WriteLine("-----------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(newBread.BreadOrder + " BREAD will cost $" + newBread.BreadSubTotal + ".00");
                Console.WriteLine(newPastry.PastryOrder + " PASTRY will cost $" + newPastry.PastrySubTotal + ".00");
                Console.WriteLine("Your grand total is: $" + orderTotal + ".00");
                Console.WriteLine("-----------------------------------------------------------");
            }
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
                Console.WriteLine("Thank you for ordering from EpiDoughdus! [press any key to return to the Main Menu]");
                Console.ReadKey();
                MainMenu();
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