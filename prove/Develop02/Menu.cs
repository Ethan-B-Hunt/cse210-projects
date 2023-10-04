using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
public class Menu{
    public List<string> userA = new List<string>();
    public List<string> userQ = new List<string>();
    public void Display(){
        string fileName = "myFile.txt";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        while (true){
            Console.WriteLine("Please Select one of the following choices: ");
            Console.WriteLine("1. Write: ");
            Console.WriteLine("2. Display: ");
            Console.WriteLine("3. Load: ");
            Console.WriteLine("4. Save: ");
            Console.WriteLine("5. Quit: ");
            Console.Write("What would you like to do? ");

            int userInput = int.Parse(Console.ReadLine());
            
            Prompts prompts = new Prompts();
        
            Journal journal = new Journal();
            switch (userInput){
                case 1:
                    prompts.Display();
                    userA.Add(prompts.userAnswer);
                    userQ.Add(prompts.userQ);
                    break;
                case 2:
                    journal.Display(dateText, userA, userQ);
                    break;
                case 3:
                    journal.Load(fileName);
                    break;
                case 4:
                    journal.Save(fileName, dateText, userA, userQ);
                    break;
                case 5:
                    Console.WriteLine("GoodBye!");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}