using System.ComponentModel;

public class Gaol{
    protected string _name;
    protected string _description;
    protected int _point;
    public string Name(){
        Console.WriteLine("What is your name of goal?");
        _name = Console.ReadLine();
        return _name;
    }

    public string Description(){
        Console.WriteLine("What is description of Goal?");
        _description = Console.ReadLine();
        return _description;
    }
    public int Point(){
        Console.WriteLine("How many point do you want for Goal");
        _point = int.Parse(Console.ReadLine());
        return _point;
    }
    public string GoalList(){
        
        string cool = $"[ ] - {_name} ({_description}) - Points: {_point}";
        return cool;

    } 
}