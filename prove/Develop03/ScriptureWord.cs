class ScriptureWord
{
    public string Text { get; }
    public bool Hidden { get; private set; }

    public ScriptureWord(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }
}