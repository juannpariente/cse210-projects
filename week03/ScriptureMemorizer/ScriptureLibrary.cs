using System.IO;

public class ScriptureLibrary
{
    private string _scriptureText;
    private Reference _reference;

    public ScriptureLibrary(string letter)
    {
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");

        if (letter == "A")
        {
            _scriptureText = lines[0];
            _reference = new Reference("Mosiah", 2, 17);
        }
        else if (letter == "B")
        {
            _scriptureText = lines[1];
            _reference = new Reference("2 Nefi", 2, 25, 26);
        }
        else if (letter == "C")
        {
            _scriptureText = lines[2];
            _reference = new Reference("Helaman", 5, 12);
        }
        else
        {
            Console.WriteLine("Invalid option. Defaulting to Mosiah 2:17.");
            _scriptureText = lines[0];
            _reference = new Reference("Mosiah", 2, 17);
        }
    }

    public string GetScripture()
    {
        return _scriptureText;
    }

    public Reference GetReference()
    {
        return _reference;
    }
}