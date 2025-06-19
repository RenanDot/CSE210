using System;

public class GoalManager
{
    private List<Goal> _goals;

    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        DisplayPlayerInfo();

        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                ListGoalDetails();
                break;
            case "3":
                SaveGoals();
                break;
            case "4":
                LoadGoals();
                break;
            case "5":
                RecordEvent();
                break;
            case "6":
                Console.WriteLine("\nGoodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour current score is: {_score}");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        int i = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($" {i} - {goal.GetShortName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        int i = 1;

        Console.WriteLine("\nHere are your goals:");

        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{i}. [X] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{i}. [ ] {goal.GetDetailsString()}");
            }
            i++;
        }
    }

    public void CreateGoal()
    {
        
        int i = 0;
        while (i == 0)
        {
            Console.Clear();
            Console.WriteLine("Choose the type of goal to create:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.Write("Enter the number of your goal type: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateSimpleGoal();
                    i = 1;
                    break;
                case "2":
                    CreateEternalGoal();
                    i = 1;
                    break;
                case "3":
                    CreateChecklistGoal();
                    i = 1;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.Write("Enter the number of your goal type: ");
                    choice = Console.ReadLine();
                    break;
            }
        }
        

    }

    public void CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        string points = Console.ReadLine();

        Goal newGoal = new SimpleGoal(name, description, points);
        _goals.Add(newGoal);
        Console.WriteLine("\nSimple Goal added successfully!");
    }

    public void CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        string points = Console.ReadLine();

        Goal newGoal = new EternalGoal(name, description, points);
        _goals.Add(newGoal);
        Console.WriteLine("\nEternal Goal added successfully!");
    }

    public void CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        string points = Console.ReadLine();
        Console.Write("How many times does this goal need to be completed? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for completing this goal? ");
        int bonus = int.Parse(Console.ReadLine());

        Goal newGoal = new ChecklistGoal(name, description, points, target, bonus);
        _goals.Add(newGoal);
        Console.WriteLine("\nChecklist Goal added successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? (Enter the number): ");
        int input = int.Parse(Console.ReadLine());

        if (input < 1 || input > _goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }
        else
        {
            Goal selectedGoal = _goals[input - 1];
            selectedGoal.RecordEvent();
            int pointsEarned = int.Parse(selectedGoal.GetPoints());

            if (selectedGoal is ChecklistGoal checklistGoal)
            {
                if (checklistGoal.GetAmountCompleted() > checklistGoal.GetTarget())
                {
                    int module = checklistGoal.GetAmountCompleted() % checklistGoal.GetTarget();
                    if (module == 0)
                    {
                        pointsEarned += checklistGoal.GetBonus();
                        Console.WriteLine($"You earned a bonus of {checklistGoal.GetBonus()} points for completing the checklist goal: {selectedGoal.GetShortName()}");
                    }
                }
                else if (checklistGoal.GetAmountCompleted() == checklistGoal.GetTarget())
                {
                    pointsEarned += checklistGoal.GetBonus();
                    Console.WriteLine($"You earned a bonus of {checklistGoal.GetBonus()} points for completing the checklist goal: {selectedGoal.GetShortName()}");
                }
            }

            _score += pointsEarned;


            Console.WriteLine($"\nYou earned a total of {pointsEarned} points for completing the goal: {selectedGoal.GetShortName()}");
        }


    }

    public void SaveGoals()
    {
        Console.WriteLine("\nWhat is the filename to save your goals to? ");
        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        using (StreamWriter writer = new StreamWriter(filename))
        {
            if (lines[0] != null || lines[0] != "" || int.Parse(lines[0]) > 0)
            {
                _score += int.Parse(lines[0]);
                writer.WriteLine(_score);

                for (int i = 1; i < lines.Length; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
            else
            {
                writer.WriteLine(_score);
            }

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }

            Console.WriteLine("Goals saved successfully!");
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("\nWhat is the filename to load your goals from? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
            return;
        }
        else
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                if (line.StartsWith("SimpleGoal:"))
                {
                    string[] parts = line.Split(",");
                    string name = parts[0];
                    string[] correctName = name.Split(':');
                    name = correctName[1];

                    SimpleGoal goal = new SimpleGoal(name, parts[1], parts[2]);
                    goal.SetComplete(bool.Parse(parts[3]));
                    _goals.Add(goal);
                }
                else if (line.StartsWith("EternalGoal:"))
                {
                    string[] parts = line.Split(",");
                    string name = parts[0];
                    string[] correctName = name.Split(':');
                    name = correctName[1];

                    EternalGoal goal = new EternalGoal(name, parts[1], parts[2]);
                    _goals.Add(goal);
                }
                else if (line.StartsWith("ChecklistGoal:"))
                {
                    string[] parts = line.Split(",");
                    string name = parts[0];
                    string[] correctName = name.Split(':');
                    name = correctName[1];

                    int bonus = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int amountCompleted = int.Parse(parts[5]);

                    ChecklistGoal goal = new ChecklistGoal(name, parts[1], parts[2], target, bonus);
                    goal._amountCompleted = amountCompleted;
                    _goals.Add(goal);
                }
                else
                {
                    _score = int.Parse(line);
                }

            }
            Console.WriteLine("Goals loaded successfully!");
        }
    }    
}
