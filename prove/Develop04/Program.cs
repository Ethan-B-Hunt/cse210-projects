using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        while (true){
            Menu menu = new Menu();
            string choice = menu.Display();
            if (choice == "1"){
                Breathing breathing = new Breathing("Breathing Activity", "This activity will do somthing");
            } else if (choice == "2") {
                Console.WriteLine("you chose 2");
            } else if (choice == "3") {
                Console.WriteLine("you chose 3");
            } else if (choice == "4") {
                int num = 0;
                Console.Write("Exiting");
                while (num < 3){
                    Console.Write(".");
                    Thread.Sleep(1000);
                    num++;
                }
                Thread.Sleep(500);
                Console.Clear();
                break;
            } else {
                Console.WriteLine("error");
                Thread.Sleep(1000);
                menu.Display();
            }
        }
    }
}
