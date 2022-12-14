using System;
using System.Xml.Schema;

namespace Deliverable2;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hi.Welcome to our Buffet.All you can eat for $9.99! We only charge extra for coffee.How many people are in your group ? Please, parties of 6 or lower.\r");
        string num1 =(Console.ReadLine());
        bool success=int.TryParse(num1, out int num);

        if (num > 6 || num == 0) 
        {
            Console.WriteLine("\nOh sorry, can only seat parties up to 6.Have a nice day.");
            System.Environment.Exit(0);
        }
        
        Console.WriteLine("\nA table for " + num + "! Please follow me and take a seat.\r\n\nLet's get everyone started with some drinks. We've got water or coffee.\r");
        
        int coffee = 0;
        int water= 0;
        
        for (int i = 1; i <= num; i++)

        {
            Console.WriteLine("\nAlright, person number " + i + ", water or coffee?\r");
            string beverage = Console.ReadLine().Trim();


            if (String.Equals(beverage, "coffee"))
            {
                coffee += 1;
                Console.WriteLine("\nCoffee, okay!");
            }
            else if (String.Equals(beverage, "water"))
            {
                water += 1;
                Console.WriteLine("\nWater, good choice!");
            }
            else
            {
                Console.WriteLine("\nWe don't have that. No drink for you!\r");
            }
        }
        double total = coffee * 2 + num * 9.99;

        Console.WriteLine("\nOkay, so that's " + coffee + " coffees and " + water + " waters. I'll be right back. Feel free to grab your food!\r");
        Console.WriteLine("\nHere's your bill! Total price: $" + total + "\r");
        }
}
