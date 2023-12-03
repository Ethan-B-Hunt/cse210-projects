class ListingActivity : MindfulnessActivity
{
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {

        DateTime endTime = GetTimeDuration();
        Console.WriteLine();

        PrepareToBegin();

        string[] prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        string prompt = prompts[new Random().Next(prompts.Length)];

        Console.WriteLine($"{prompt} (Think for a few seconds before listing)");
        AnimationSpinnin(2);
        int itemCount = 0;
        Console.WriteLine("List as many Things as you can: ");
        while (DateTime.Now < endTime){
            ListItems();
            itemCount++;  
        }
        Console.WriteLine($"\nYou listed {itemCount} items.");
        Thread.Sleep(3);
    }

    private void ListItems()
    {
        Console.Write(">");
        Console.ReadLine();

    }
}