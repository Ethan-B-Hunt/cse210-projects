using System;
public class Job {
    public string _JobTitle;
    
    public string _Company;

    public int _StartDate;

    public int _EndDate;

    public void Display(){
        Console.WriteLine($"{_JobTitle} {_Company} {_StartDate}-{_EndDate}");
    }
}