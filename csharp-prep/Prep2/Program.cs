using System;

class Program
{
    static void Main(string[] args)
    {
        string grade;
        string gradeLetter = "";
        Console.WriteLine("What is your grade percentage? ");
        grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        if (percentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (percentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (percentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (percentage >= 60)
        {
            gradeLetter = "D";
        }
        else if (percentage < 60)
        {
            gradeLetter = "F";
        }
        else
        {
            Console.WriteLine("That is not an acceptable percentage");
        }
        Console.WriteLine($"Your grade is {gradeLetter}");
        if (percentage >= 70)
        {
            Console.WriteLine("Hooray! You are on track to pass");
        }
        else
        {
            Console.WriteLine("Not looking so good. Time to study harder");
        }
    }
}