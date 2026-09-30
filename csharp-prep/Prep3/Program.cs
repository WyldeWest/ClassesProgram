using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string userGuess;
        Random random = new Random();
        int magicAnswer = random.Next(1, 100);
        Console.WriteLine("What is your guess?");
        userGuess = Console.ReadLine();
        int numberGuess = int.Parse(userGuess);

        while (numberGuess != magicAnswer)
        {
            if (numberGuess > magicAnswer)
            {
                Console.WriteLine("Lower");
            }
            else if (numberGuess < magicAnswer)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}