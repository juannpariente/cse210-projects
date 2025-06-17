public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _goalsCompleted;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _goalsCompleted = 0;
        _level = 0;
    }

    public void Start()
    {
        List<string> menu = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quite"};

        int num = -1;
        while (num != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {menu[i]}");
            }
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                CreateGoal();
            }
            else if (userChoice == 2)
            {
                ListGoalDetails();
            }
            else if (userChoice == 3)
            {
                SaveGoals();
            }
            else if (userChoice == 4)
            {
                LoadGoals();
            }
            else if (userChoice == 5)
            {
                ListGoalNames();
                RecordEvent();
            }
            else if (userChoice == 6)
            {
                num = 6;
            }
            else
            {
                Console.WriteLine("Oops! That number doesn't seem right. Try again.");
                Console.WriteLine("");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Level: {_level} | Score: {_score} points");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        int num = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{num}. {goal.GetShortName()}");
            num++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int num = 1;
        foreach (Goal goal in _goals)
        {
            if (goal is SimpleGoal)
            {
                Console.WriteLine($"{num}. {goal.GetDetailsString()}");
            }
            else if (goal is EternalGoal)
            {
                Console.WriteLine($"{num}. {goal.GetDetailsString()}");
            }
            else if (goal is ChecklistGoal)
            {
                Console.WriteLine($"{num}. {goal.GetDetailsString()}");
            }
            num++;
        }
    }

    public void CreateGoal()
    {
        List<string> menuGoals = new List<string> { "Simple Goal", "Eternal Goal", "Checklist Goal" };

        Console.WriteLine("The types of Goals are:");
        for (int i = 0; i < menuGoals.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {menuGoals[i]}");
            }
            Console.Write("Which type of goal would you like to create? ");
            int goalChoice = int.Parse(Console.ReadLine());
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

        if (goalChoice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalChoice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalChoice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What us the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.Write("which goal did you accomplish? ");
        int userNum = int.Parse(Console.ReadLine());

        Goal goalAccomplish = _goals[userNum - 1];
        goalAccomplish.RecordEvent();

        int pointsEarned = int.Parse(goalAccomplish.GetPoints());

        if (goalAccomplish is ChecklistGoal && goalAccomplish.IsComplete())
        {
            string[] data = goalAccomplish.GetStringRepresentation().Split("|");
            int bonus = int.Parse(data[3]);
            pointsEarned += bonus;

            _score += pointsEarned;
        }
        
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            _score += pointsEarned;

        if (goalAccomplish is SimpleGoal || goalAccomplish is EternalGoal || goalAccomplish is ChecklistGoal && goalAccomplish.IsComplete())
        {
            _goalsCompleted++;
        }

        if (_goalsCompleted == 3)
        {
            _level++;
            Console.WriteLine($"You level up! You are level {_level} now!");
            _goalsCompleted = 0;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outPutFile = new StreamWriter(filename))
        {
            outPutFile.WriteLine(_score);
            outPutFile.WriteLine(_level);

            foreach (Goal goal in _goals)
            {
                outPutFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        for (int i = 2; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(":");
            string[] data = parts[1].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(data[0], data[1], data[2]);
                bool isComplete = bool.Parse(data[3]);
                if (isComplete)
                {
                    goal.SetIsComplete(isComplete);
                }
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], data[2]));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                int data3 = int.Parse(data[3]);
                int data4 = int.Parse(data[4]);
                int data5 = int.Parse(data[5]);
                _goals.Add(new ChecklistGoal(data[0], data[1], data[2], data4, data3, data5));
            }
        }
    }
}