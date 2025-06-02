using System;

// I added a ScriptureLibrary class that reads a file and returns both the scripture text and a Reference object. It also allows the user to choose which scripture to use.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose one scripture: A. Mosiah 2:17 | B. 2 Nefi 2:25-26 | C. Helaman 5:12");
        Console.Write("Letter: ");
        string letter = Console.ReadLine();

        ScriptureLibrary scriptureLibrary = new ScriptureLibrary(letter);

        Scripture scripture = new Scripture(scriptureLibrary.GetReference(), scriptureLibrary.GetScripture());

        string userQuit = "";
        while (userQuit != "quit")
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userQuit = Console.ReadLine();
        }
    }
}