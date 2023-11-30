class Scripture
{
    private ScriptureReference reference;
    private List<ScriptureWord> words;

    int numberToTakeOut = 3;

    public bool AllWordsHidden
    {
        get { return words.TrueForAll(word => word.Hidden); }
    }

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        words = new List<ScriptureWord>();

        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            words.Add(new ScriptureWord(word));
        }
    }

    public void Display() 
    {
        Console.WriteLine($"{reference.ToString()}: {GetVisibleText()}");
    }

    public void RemoveWords()
    {
        Random random = new Random();

        // Ensure we have at least 3 visible words
        List<int> visibleWordIndices = Enumerable.Range(0, words.Count)
            .Where(i => !words[i].Hidden).ToList();

        if (visibleWordIndices.Count < 3){
            numberToTakeOut = 2;
            return;
        }

        // Randomly select 3 different visible words
        List<int> selectedIndices = new List<int>();
        for (int i = 0; i < numberToTakeOut; i++)
        {
            int index;
            do {
                index = visibleWordIndices[random.Next(visibleWordIndices.Count)];
            } 
            while (selectedIndices.Contains(index));

            selectedIndices.Add(index);
            words[index].Hide();
        }
    }

    private string GetVisibleText()
    {
        List<string> visibleWords = new List<string>();
        foreach (ScriptureWord word in words)
        {
            if (!word.Hidden)
                visibleWords.Add(word.Text);
            else
            // Placeholder for hidden words
                visibleWords.Add("______"); 
        }

        return string.Join(" ", visibleWords);
    }
}