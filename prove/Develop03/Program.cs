using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Scripture Hiding Program!");

        // gets the scripture verse that you want to memerioze.
        ScriptureReference reference = new ScriptureReference("Deuteronomy 31:6");
        Scripture scripture = new Scripture(reference, "I have said these things to you, that in me you may have peace. In the world you will have tribulation. But take heart; I have overcome the world.");

        // this will run until all the words are hidden it also gets user input for entering or quiting
        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
                break;

            scripture.RemoveWords();
        }

        Console.WriteLine("Thank you for using the Scripture Hiding Program! Goodbye!");
    }
}