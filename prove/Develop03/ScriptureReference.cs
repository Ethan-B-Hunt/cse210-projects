class ScriptureReference
{
    private string Book { get; }
    private int Chapter { get; }
    private int VerseStart { get; }
    private int VerseEnd { get; }

    public ScriptureReference(string reference)
    {
        string[] parts = reference.Split(':');
        Book = parts[0];

        string[] chapterVerse = parts[1].Split('-');
        Chapter = int.Parse(chapterVerse[0]);

        if (chapterVerse.Length > 1)
            VerseEnd = int.Parse(chapterVerse[1]);
        else
            VerseStart = VerseEnd = int.Parse(chapterVerse[0]);
    }

    public override string ToString()
    {
        if (VerseStart == VerseEnd)
            return $"{Book} {Chapter}:{VerseStart}";
        else
            return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
    }
}