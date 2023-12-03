class MenuMenu
{
    public static int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("\nMindfulness App Menu:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");

        Console.Write("Choose an activity (1-4): ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return DisplayMenu();
        }
    }
}