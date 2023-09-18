using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        //
        int guess_num = -1;
        int num_of_guess = 0;

        Console.WriteLine("Welcome to guess the number");

        Random randomGenerator = new Random();
        int random_number = randomGenerator.Next(1, 101);


        while (random_number != guess_num) {
            Console.Write("What is your guess: ");
            string guess = Console.ReadLine();
            guess_num = int.Parse(guess);
            if (guess_num < random_number){
                Console.WriteLine("Nope, Guess was too low");
            }
            else if (guess_num > random_number){
                Console.WriteLine("Nope, Guess was too high");
            }
            num_of_guess += 1;
       }
       Console.WriteLine($"You Won!!!!, the number was {random_number}!");
       Console.WriteLine($"The number of Guesses {num_of_guess}");
    }
}