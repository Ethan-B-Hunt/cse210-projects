class Program
{
    static void Main()
    {
        while (true)
        {
            int choice = MenuMenu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    MindfulnessActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartActivity();
                    break;
                case 2:
                    MindfulnessActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.StartActivity();
                    break;
                case 3:
                    MindfulnessActivity listingActivity = new ListingActivity();
                    listingActivity.StartActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting the Mindfulness. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number from 1 to 4.");
                    break;
            }
        }
    }
}
