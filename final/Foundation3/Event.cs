class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string FullDetails()
    {
        return $"{StandardDetails()}\nType: {GetEventType()}";
    }

    public virtual string ShortDescription()
    {
        return $"Type: {GetEventType()}\nTitle: {_title}\nDate: {_date}";
    }

    protected virtual string GetEventType()
    {
        return "Generic Event";
    }
}
