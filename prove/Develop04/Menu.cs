public class Menu {
    public string Display(){
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string userInput = Console.ReadLine();
        if (check(userInput)){
            return userInput;
        } else {
            Console.WriteLine("Invalid input. Please enter a valid option.");
            Thread.Sleep(500);
            return Display();
        }
    }
    public bool check(string inputUser) {
        return (inputUser == "1" || inputUser == "2" || inputUser == "3" || inputUser == "4");
    }
}
