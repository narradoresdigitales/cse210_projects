using System.IO;
using System.ComponentModel;

public class GoalManager

{
    List<Goal> _goals = new List<Goal>();
    public int _score = 0;



    public void Start()
    {
        Console.WriteLine("_________________________________________________"); //spacing
        Console.WriteLine(); //spacing
        DisplayPlayerInfo();



        Console.WriteLine("_________________________________________________"); //spacing
        Console.WriteLine(); //spacing
        Console.WriteLine(); //spacing
        var choice = "";
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine(); //spacing
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit:");

            Console.WriteLine("_________________________________________________"); //spacing
            Console.WriteLine(); //spacing
            Console.WriteLine(); //spacing
            Console.Write(" Select a choice from the menu: > ");
            choice = Console.ReadLine();
            
            if (choice == "1")
            {
                //menu for Creating a New Goal
                var choice1 = "";
                Console.WriteLine("Menu Options:");
                Console.WriteLine(); //spacing
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goals");
                Console.WriteLine(" 3. Checklist Goals");
                Console.WriteLine(); //spacing
                Console.Write(" Which type of goal would you like to create?  > ");
                choice1 = Console.ReadLine();
                

                if (choice1 == "1")
                {
                    CreateSimpleGoal();
                }
                else if (choice1 == "2")
                {
                    CreateEternalGoal();
                }
                else if (choice1 == "3")
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("You have chosen to make an Checklist Goal.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Invalid Choice. Try again.");
                    Console.WriteLine();
                }
                                
            }
            else if (choice == "2")
            {
                Console.WriteLine("List of Goals: ");
                ListGoalNames();
                // foreach (Goal goal in _goals)
                // {
                //     Console.WriteLine($"{goal._shortName} ({goal._description})");
                // }
                
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                
                
            }
            else if (choice == "6")
            {
                Console.WriteLine("You selected to exit. Goodbye");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid Choice. Try again.");
            }

        }
        while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
        Console.WriteLine($"{goal._shortName} ({goal._description})");
        }
    }

    public void CreateSimpleGoal()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("You have chosen to make a Simple Goal.");
        Console.WriteLine();
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is its point value for this goal? ");
        string points = Console.ReadLine();
        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
        _goals.Add(simpleGoal);
    
    }

    public void CreateEternalGoal()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("You have chosen to make an Eternal Goal.");
        Console.WriteLine();
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is its point value for this goal? ");
        string points = Console.ReadLine();
        EternalGoal eternalGoal = new EternalGoal(name, description, points);
        _goals.Add(eternalGoal);
    }

    // public RecordEvent()

    public void SaveGoals()
    {
        Console.WriteLine("What is the file name for the goal file? ");
        string filePath = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filePath))

        {
            foreach (Goal goal in _goals)
            {
                string line = $"{goal._shortName}, {goal._description}, {goal._points}";
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Goals have been saved to " + filePath); 
    }

    public void LoadGoals()

    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filePath = Console.ReadLine();
        if (File.Exists(filePath))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Goal goal = new Goal(parts[0], parts[1], parts[2]);
                        _goals.Add(goal);
                    }
                
                }
            }
        }
    }




} 

