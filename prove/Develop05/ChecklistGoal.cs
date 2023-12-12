public class ChecklistGoal : Goal
{
    private int _targetCompletions;
    private int _completions;
    private int _pointsPerCompletion;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int pointsPerCompletion, int targetCompletions, int bonusPoints) : base(name, description)
    {
        _pointsPerCompletion = pointsPerCompletion;
        _targetCompletions = targetCompletions;
        _bonusPoints = bonusPoints;
        _completions = 0;
    }


    public override void RecordCompletion()
    {
        _completions++;
        _points += _pointsPerCompletion;

        Console.WriteLine($"{Name} completed! Earned {_pointsPerCompletion} points. Total points: {Points}");

        if (_completions == _targetCompletions)
        {
            _points += _bonusPoints;
            Console.WriteLine($"Bonus achieved! Earned {_bonusPoints} bonus points. Total points: {Points}");
        }

    }

    public int Completions => _completions;
    public int TargetCompletions => _targetCompletions;

    // Override DisplayGoal to include completed count and target count
    public void DisplayGoal(bool showCompleted = false)
    {
        Console.Write(showCompleted ? "[X] " : $"[{_completions}/{_targetCompletions}] ");
        base.DisplayGoal();
    }

    // Override SaveGoal to include completed and target counts
    public override string SaveGoal()
    {
        return $"{base.SaveGoal()},{_completions},{_targetCompletions}";
    }

    // Override LoadGoal to load completed and target counts
    public override void LoadGoal(string[] parts)
    {
        base.LoadGoal(parts);

        if (parts.Length == 6)
        {
            _completions = int.Parse(parts[4]);
            _targetCompletions = int.Parse(parts[5]);
        }
    }
}