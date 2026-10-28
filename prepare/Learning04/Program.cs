using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment A1 = new Assignment("John Smith", "Grammar");
        Console.WriteLine($"{A1.GetSummary()}");
    }
}