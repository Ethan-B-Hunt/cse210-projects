using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // Creates list to use later on
        List<int> num = new List<int>();

        // gets user input for list we created and will get userinput until user puts in 0
        while (true) {        
            Console.Write("Hello, Please enter a number: ");
            string string_enter = Console.ReadLine();
            int num_enter = int.Parse(string_enter);  
            if (num_enter == 0){
                break;
            }
            num.Add(num_enter);
        }

        num.Sort();

        // creates a list of only postive numbers so we can use the Min(
        //  to find the smallest number to zero
        List<int> smNumber = new List<int>();
        foreach (int number in num){
            if (number > 0){
                smNumber.Add(number);
            }
        }
        
        float avg = ((float)num.Sum())/num.Count();

        // all of our print statements 
        Console.WriteLine($"The sum is: {num.Sum()}");

        Console.WriteLine($"The average is:{avg}");

        Console.WriteLine($"The largest number is: {num.Max()}");

        Console.WriteLine($"The smallest positive number is: {smNumber.Min()}");

        Console.WriteLine("The sorted list is: ");
        foreach (int number in num) {
            Console.WriteLine(number);
        }
    }
}