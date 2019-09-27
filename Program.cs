using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("**Welcome to Pierre's Artisan Bakery!**");
            Console.WriteLine("Please select one of the below options:");
            Console.WriteLine("1. Place an Order");
            Console.WriteLine("2. Submit a Complaint");
            string mainMenuInput = Console.ReadLine();

            if (mainMenuInput == "1")
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("**Here at Pierre's we offer two exquisite products: our world famous BREAD and our instagram-worthy PASTRIES!**");
                Console.WriteLine("Please select one of the below options:");
                Console.WriteLine("1. Gimme that delicious gluten");
                Console.WriteLine("2. I'm scared and want to go back");
                string beginOrderInput = Console.ReadLine();

                if (beginOrderInput == "1")
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

                    Bread newBread = new Bread (userBread);
                    Pastry newPastry = new Pastry (userPastry);

                    int orderTotal = newBread.BreadCalculator(newBread) + newPastry.PastryCalculator(newPastry);

                    Console.WriteLine(newBread.BreadOrder + " BREAD will cost $" + newBread.BreadSubTotal + ".00");
                    Console.WriteLine(newPastry.PastryOrder + " PASTRY will cost $" + newPastry.PastrySubTotal + ".00");
                    Console.WriteLine("Your grand total is: $" + orderTotal + ".00");
                }
                else if (beginOrderInput == "2")
                {
                    Main();
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("**Please enter a valid number**");
                    Main();
                }
            }
            else if (mainMenuInput == "2")
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Please direct all complaints to elly@epicodus.com");
                Main();
            }
            else{
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("**Please enter a valid number**");
                Main();
            }
        }
    }
}