using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayResult(name, square);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    } 
    static string PromptUserName(){
        Console.Write("Please, Enter your name: ");
        return Console.ReadLine();
    } 
    static int PromptUserNumber(){
        Console.Write("What's your favorite number: ");
        return int.Parse(Console.ReadLine());
    } 
    static int SquareNumber(int number){
        return number * number;
    } 
    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}