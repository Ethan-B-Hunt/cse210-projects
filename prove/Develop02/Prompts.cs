using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
public class Prompts{
    public string userAnswer;
    public string userQ;

    public void Display(){
        List<string> question = new List<string>(){
            "What was the best part of my day?",
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random random = new Random();
        int randomIndex = random.Next(0, question.Count);
        userQ = question[randomIndex];
        Console.WriteLine(userQ);
        userAnswer = Console.ReadLine();
    }

}