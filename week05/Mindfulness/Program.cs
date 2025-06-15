using System;

// I added code to the GetRandomQuestion method to ensure it always returns a new question.

class Program
{
    static void Main(string[] args)
    {
        List<string> menu = new List<string> { "Start breathing activity", "Start reflecting activity", "Start listing activity", "Quit" };

        int num = -1;
        while (num != 4)
        {
            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userChoice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userChoice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (userChoice == 4)
            {
                num = 4;
            }
            else
            {
                Console.WriteLine("Oops! That number doesn't seem right. Try again.");
                Console.WriteLine("");
            }
        }
    }
}