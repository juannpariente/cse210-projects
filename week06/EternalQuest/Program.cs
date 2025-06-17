using System;

// I added the GetDetailsString method to each derived class.
// I added a level system: the user levels up for every 3 goals completed.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}