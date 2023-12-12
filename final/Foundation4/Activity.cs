using System.Reflection.Metadata;

class Activity
{
    private DateTime _date;
    protected double _minutes;

    protected string _message;
    protected double _userInput;

    public Activity(DateTime date, double minute)
    {
        _date = date;
        _minutes = getUserInput("How many minutes did you go for?");
    }

    public virtual double GetDistance()
    {

        return 0; // Default implementation for base class
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation for base class
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation for base class
    }

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} - {GetType().Name} ({_minutes} min) - {GetDetails()}";
    }

    protected virtual string GetDetails()
    {
        return ""; // Default implementation for base class
    }

    public double getUserInput(string Message){
        _message = Message;
        Console.WriteLine(_message);
        _userInput = double.Parse(Console.ReadLine());
        return _userInput;
    }
}