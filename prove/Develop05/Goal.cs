public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _points = 0;
    }

    // Abstract method to record the goal completion
    public abstract void RecordCompletion();

    // Common method to display goal details
    public void DisplayGoal(bool showCompleted = false)
    {
        Console.Write(showCompleted ? "[X] " : "[ ] ");
        Console.WriteLine($"{Name} - {Description}");
    }

    // Common method to save goal details to a file
    public virtual string SaveGoal()
    {
        return $"{GetType().Name},{Name},{Description},{Points}";
    }

    // Common method to load goal details from a file
    public virtual void LoadGoal(string[] parts)
    {
        if (parts.Length == 4)
        {
            _name = parts[1];
            _description = parts[2];
            _points = int.Parse(parts[3]);
        }
    }
}