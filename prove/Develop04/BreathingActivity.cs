class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "Relax by pacing your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine();
        DateTime endTime = GetTimeDuration();
        Console.WriteLine();
        PrepareToBegin();
        Console.WriteLine("Clear your mind and focus on your breathing.");
        while (DateTime.Now < endTime){
            Console.WriteLine();
            Console.Write("Breathe in...");
            AnimationCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe out...");
            AnimationCountDown(3);
            Console.WriteLine();
        }
    }
}