using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Scripture Hiding Program!");

        // gets the scripture verse that you want to memerioze.
        ScriptureReference reference = new ScriptureReference("Psalm 23:4");
        Scripture scripture = new Scripture(reference, "Even though I walk through the valley of the shadow of death, I will fear no evil, for you are with me; your rod and your staff, they comfort me.");

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

        Console.WriteLine("Goodbye!");
    }
}