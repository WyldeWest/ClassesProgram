using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");

        while (userNumber != 0)
        {
           Console.WriteLine("Enter a number: "); 
           string input = Console.ReadLine();
           int number = int.Parse(input);

           if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Enter a valid integer");
            }
        }
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The avearage is {average}");
        Console.WriteLine($"The maximum is {max}");

    }
}