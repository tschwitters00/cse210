using System.IO;
using System.Runtime.CompilerServices;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _goalsRecorded;

    public GoalManager()
    {
        _goalsRecorded = 0;
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        bool active = true;
        while(active == true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                CreateGoal();
            }

            else if(choice == "2")
            {
                ListGoalDetails();
            }
            else if(choice == "3")
            {
                SaveGoals();
            }
            else if(choice == "4")
            {
                LoadGoals();
            }
            else if(choice == "5")
            {
                RecordEvent();
            }
            else if(choice == "6")
            {
                active = false;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nGoals recorded: {_goalsRecorded}");
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalName()
    {
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            string name = goal.GetName();
            Console.WriteLine($"{counter}. {name}");
            counter += 1;
        }
    }

    public void ListGoalDetails()
    {
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            string complete;
            if(goal.IsComplete() == true)
            {
                complete = "x";
            }
            else
            {
                complete = " ";
            }
            string goalString = goal.GetDetailsString();
            Console.WriteLine($"{counter}. [{complete}] {goalString}");
            counter += 1;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the ammount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if(choice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points, false);
            _goals.Add(goal);
        }
        
        else if(choice == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        
        else if(choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("WWhat is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, 0);
            _goals.Add(goal);
        }

        
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalName();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            if(counter == choice)
            {
                if(goal.IsComplete() == false)
                {
                    int points = goal.RecordEvent();
                    _goalsRecorded += 1;
                    _score += points;
                    Console.WriteLine($"Congratulations! You have earned {points} points!");
                }
                else
                {
                    Console.WriteLine("Goal already complete.");
                }
                break;
            }
            counter += 1;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine($"{_score}|{_goalsRecorded}");
            foreach(Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();

        bool counter = false;
        foreach(string line in lines)
        {
            if(counter == false)
            {
                string[] splitLine = line.Split("|");
                _score = int.Parse(splitLine[0]);
                _goalsRecorded = int.Parse(splitLine[1]);
                counter = true;
            }
            else
            {
                string[] splitLine = line.Split(":");

                if(splitLine[0] == "SimpleGoal")
                {
                    string[] parts = splitLine[1].Split("|");
                    SimpleGoal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), Convert.ToBoolean(parts[3]));
                    _goals.Add(goal);
                }
                else if(splitLine[0] == "EternalGoal")
                {
                    string[] parts = splitLine[1].Split("|");
                    EternalGoal goal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                    _goals.Add(goal);
                }
                else if(splitLine[0] == "ChecklistGoal")
                {
                    string[] parts = splitLine[1].Split("|");
                    ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    _goals.Add(goal);
                }
                
            }
            
        }
    }
}