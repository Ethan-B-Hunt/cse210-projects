public class EternalGoal : Goal
{
    private int _pointsPerCompletion;
    public EternalGoal(string name, string description, int pointsPerCompletion) : base(name, description)
    {
        _pointsPerCompletion = pointsPerCompletion;
    }

    public override void RecordCompletion()
    {
        _points += _pointsPerCompletion;
        Console.WriteLine($"{Name} completed! Earned {_pointsPerCompletion} points. Total points: {Points}");
    }
}
