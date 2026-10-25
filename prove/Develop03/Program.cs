using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("Moses", 1, 39, "Behold, this is my work and my glory; to bring to pass the immortality and eternal life of man");
        string userInput = "";

        while(userInput != "quit" && !myScripture.IsCompletelyHidden())
        {
            Console.Clear();
            myScripture.ShowScripture();

            Console.WriteLine("Press enter to continue or type 'quit' to end the program");
            userInput = Console.ReadLine();

            if(userInput.ToLower() != "quit")
            {
                myScripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        myScripture.ShowScripture();
        Console.WriteLine("All Words Hidden. Thanks for using the Scripture Memorizer");
        
    }
}