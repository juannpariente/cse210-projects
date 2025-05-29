using System;

// Added the mood field to capture the user's emotional state.

class Program
{
    static void Main(string[] args)
    {
        List<string> menu = new List<string> { "Write", "Display", "Load", "Save", "Quit" };

        Journal journal = new Journal();

        int num = -1;
        while (num != 5)
        {
            Console.WriteLine("Please select one of the following choice:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }
            Console.Write("What would you like to do? ");
            int userChoice = int.Parse(Console.ReadLine());

            Entry entry = new Entry();

            if (userChoice == 1)
            {
                Console.Write("How would you describe your mood in one word? ");
                string userMood = Console.ReadLine();

                PromptGenerator prompt = new PromptGenerator();
                string randomPrompt = prompt.GetRandomPrompt();

                Console.WriteLine(randomPrompt);
                string userEntry = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;

                entry._date = theCurrentTime.ToShortDateString();
                entry._entryText = userEntry;
                entry._mood = userMood;
                entry._promptText = randomPrompt;

                journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                journal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("What is the filename?");
                string loadFileName = Console.ReadLine();

                journal.LoadFromFile(loadFileName);
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("What is the filename?");
                string saveFileName = Console.ReadLine();

                journal.SaveToFile(saveFileName);
            }
            else if (userChoice == 5)
            {
                num = 5;
            }
            else
            {
                Console.WriteLine("Oops! That number doesn't seem right. Try again.");
                Console.WriteLine("");
            }
        }
    }
}