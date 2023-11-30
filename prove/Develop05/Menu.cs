public class Menu{
    
    public string Display(){
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("You have 0 points");
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine(" 1. Create New Gaols");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Evant");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from menu: ");

        string userInput = Console.ReadLine();

        if (check(userInput)){
            return userInput;
        } else {
            Console.WriteLine("Invalid input. Please enter a valid option.");
            Thread.Sleep(500);
            return Display();
        }
    }

    public string displayGoals(){
        Console.Clear();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Gaol");
        Console.WriteLine(" 3. Checklist Gaol");
        Console.WriteLine(" 3. Back");
        Console.WriteLine("Which type of goal would you like to create? ");
        
        string userInput = Console.ReadLine();

        if (check(userInput) && userInput != "5" && userInput != "6"){
            return userInput;
        } else {
            Console.WriteLine("Invalid input. Please enter a valid option.");
            Thread.Sleep(500);
            return displayGoals();
        }  
    }

    public bool check(string inputUser) {
        return inputUser == "1" || inputUser == "2" || inputUser == "3" || inputUser == "4" ||
               inputUser == "5" || inputUser == "6";
    }
}