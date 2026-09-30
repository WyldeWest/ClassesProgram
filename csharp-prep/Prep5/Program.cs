using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, favoriteNumber, birthYear);  
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome the this program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
       Console.WriteLine("Enter your favorite number:");
       return int.Parse(Console.ReadLine()); 
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int ageThisYear = currentYear - birthYear;

        Console.WriteLine($"\nHello {name}, your favorite number squared is {squaredNumber}.");
        Console.WriteLine($"You will turn {ageThisYear} years old in {currentYear}.");
}