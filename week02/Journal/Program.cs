using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menu = new List<string> {"Write", "Display", "Load", "Save", "Quit"};

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

            if (userChoice == 1)
            {

            }
            else if (userChoice == 2)
            {

            }
            else if (userChoice == 3)
            {

            }
            else if (userChoice == 4)
            {

            }
            else
            {
                num = 5;
            }
        }

        Journal journal = new Journal();

        Entry entry = new Entry();

        PromptGenerator prompt = new PromptGenerator();

        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();

    }
}