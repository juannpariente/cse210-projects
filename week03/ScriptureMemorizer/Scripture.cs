public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
           _words.Add(new Word(part)); 
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                hiddenCount++;
            }
            
            if (IsCompletelyHidden() == true)
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string verse = "";
        foreach (Word word in _words)
        {
            verse += word.GetDisplayText() + " ";
        }
        verse = verse.TrimEnd();
        return $"{_reference.GetDisplayText()} {verse}"; 
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }

        }
        return true;
    }
}