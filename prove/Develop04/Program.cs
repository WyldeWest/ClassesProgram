using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Breath breathing = new Breath(
                        "Breathing Activity", 
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                    );
                    breathing.RunActivity();
                    break;

                case "2":
                    Reflection reflection = new Reflection(
                        "Reflection Activity", 
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                    );
                    reflection.RunActivity();
                    break;

                case "3":
                    Listing listing = new Listing(
                        "Listing Activity", 
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                    );
                    listing.RunActivity();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    Thread.Sleep(1500);
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please select a valid option from 1 to 4.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}