class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity() : base("Reflection Activity", "Reflect on times of strength and resilience.")
    {
    }

    protected override void PerformActivity()
    {
        string[] prompts = 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();

        Console.WriteLine();
        DateTime endTime = GetTimeDuration();
        Console.WriteLine();
        PrepareToBegin();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        AnimationSpinnin(2);
        while (DateTime.Now < endTime){
            AskReflectionQuestions();
        }
    }

    private void AskReflectionQuestions()
    {
        Random random = new Random();
        string[] questions =
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        string prompt = questions[random.Next(questions.Length)];
        Console.WriteLine(prompt);
        AnimationSpinnin(2);
    }
}