class Comment
{
    public string _commenter { get; }
    public string _text { get; }

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }
}
