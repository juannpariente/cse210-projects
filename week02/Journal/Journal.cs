using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file;

        using (StreamWriter outPutFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outPutFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._mood}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._mood = parts[2];
            entry._entryText = parts[3];

            _entries.Add(entry);
        }
    }
}