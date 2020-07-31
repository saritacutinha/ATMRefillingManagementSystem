
using System;
using System.Dynamic;

namespace ATMRefillingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Main Menu\n");
                Console.WriteLine("1. Add Refilling Details\n");
                Console.WriteLine("2. Show Refilling Report\n");
                Console.WriteLine("3. Exit\n");

                Console.WriteLine("Please choose option [1,2,3]:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Hi");
                        break;
                    case 2:
                        Console.WriteLine("Hello");
                        break;
                    case 3: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("PLease Enter a valid Input\n");
                        break;
                }
            }
        }
    }
}
