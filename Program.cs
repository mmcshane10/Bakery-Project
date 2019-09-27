using System;
using System.Collections.Generic;

namespace Bakery.Order
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("**Welcome to Mike's Artisan Bakery!**");
            Console.WriteLine("Please select one of the below options:");
            Console.WriteLine("1. Place an Order");
            Console.WriteLine("2. Submit a Complaint");
            string mainMenuInput = Console.ReadLine();

            if (mainMenuInput == "1")
            {

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