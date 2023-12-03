class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"\n{_name} - {_description}");
        PerformActivity();
        FinishActivity();
    }

    protected void PrepareToBegin()
    {
        Console.Clear();
        Console.Write("Get ready!");
        AnimationSpinnin(2);
        Console.WriteLine();
    }

    protected void FinishActivity()
    {
        Console.WriteLine($"\nGood job! You have completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on {_name}.");
        AnimationSpinnin(2);
    }

    protected DateTime GetTimeDuration(){
        Console.WriteLine("How long in seconds, would you like the program to run for?");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration + 3;
        DateTime startTime = DateTime.Now;
        DateTime EndTime = startTime.AddSeconds(_duration);
        return EndTime;
    }

    protected virtual void PerformActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Performing the default activity.");
    }

    protected void AnimationSpinnin(int timeSpinnin){

        List<String> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        
        while (timeSpinnin != 0) {
            foreach(string s in animationString){
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            timeSpinnin -= 1;
        }  
    }

    protected void AnimationCountDown(int num){
        for (int i = 1; i <= num; num--){
            Console.Write(num);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }   
}
