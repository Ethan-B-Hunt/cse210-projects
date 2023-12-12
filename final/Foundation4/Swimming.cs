using System.ComponentModel.DataAnnotations;

class Swimming : Activity
{
    private double _laps;
    public void Display(){
        Console.WriteLine("swimming");
    }

    public Swimming(DateTime date, double laps, double minutes) : base(date, minutes)
    {
        laps = getUserInput("How many laps did you do?");
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Convert laps to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    protected override string GetDetails()
    {
        return $"Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
