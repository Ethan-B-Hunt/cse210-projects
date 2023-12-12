public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        _points = points;
    }

    public override void RecordCompletion()
    {
        Console.WriteLine($"{Name} completed! Earned {Points} points.");
    }
}
