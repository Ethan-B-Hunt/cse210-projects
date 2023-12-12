class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {   
        speed = getUserInput("what is your Cycling Speed?");
        _speed = speed;
    }


    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    protected override string GetDetails()
    {
        return $"Speed: {_speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}