using System;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int Lgrade = int.Parse(grade);

        // goes throuh and gives a letter grade for user input of grade percentage
        String letter = "None";

        if (Lgrade >= 90) {
            letter = "A";
        } else if (Lgrade >= 80) {
            letter = "B";
        } else if (Lgrade >= 70) {
            letter = "C";
        } else if (Lgrade >= 60) {
            letter = "D";
        } else if (Lgrade < 60) {
            letter = "F";
        }

        // looks through and creates the - or + sign where need for letter grade
        int num = Lgrade % 10; 
        string sign = null;

        if (Lgrade < 94 && Lgrade >= 60){
            if (num > 6){
                sign = "+";
            } else if (num < 4){
                sign = "-";
            } else {
                sign = null;
            }
        }

        // output for grade
        Console.WriteLine($"Your grade is, {letter}{sign}");

        // lets them know if they passed or failed 
        if (Lgrade > 70) {
            Console.WriteLine("you passed!!!");
        } else {
            Console.WriteLine("dang, you didn't pass keep tryting!!!!");
        }
    }
}