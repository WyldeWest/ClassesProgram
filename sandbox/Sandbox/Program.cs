using System;

class Program
{

    
    static double AddNumbers(double x, int y)
        {
            return x + y;
        }

        static void DisplayGreeting(string name)
        {
            Console.WriteLine($"Welcome {name}, pleased to meet you.");
        }
    static void Main(string[] args)
    {

        DisplayGreeting("West");
        double answer = AddNumbers(12.234, 10);
        Console.WriteLine(answer);

        // Console.WriteLine("Bonjour tout le monde!");
        // bool done = false;

        // while (! done)
        // {
        //     Console.WriteLine("Are we done yet? (y/n)");
        //     done = Console.ReadLine().ToLower() == "y";
        // }

        // bool done;
        // do
        // {
        //     Console.WriteLine("Are we done yet? (y/n)");
        //     done = Console.ReadLine().ToLower() == "y";  
        // } while(! done); 

        // for (int i = 10000; i > -10000; i-=100)
        // {
        //     Console.WriteLine(i);
        // }

    //     List<string> myFriends = new List<string> {"John", "Sam", "Aaron", "Isaac", "Michael"};
    //     foreach(string name in myFriends)

    //     {
    //         Console.WriteLine(name);
    //     }
    }

}