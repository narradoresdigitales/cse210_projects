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
        


        Console.WriteLine("_________________________________________________"); //spacing
        Console.WriteLine(); //spacing
        Console.WriteLine(); //spacing
        var choice = "";
        do{
            DisplayPlayerInfo();
            
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
                
                if (choice1 == "1") {
                    CreateSimpleGoal();
                }
                else if (choice1 == "2") {
                    CreateEternalGoal();
                }
                else if (choice1 == "3") {
                    CreateChecklistGoal();
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
                Console.WriteLine();
            }
            else if (choice == "3") {

                SaveGoals();
            }
            else if (choice == "4") {

                LoadGoals();
            }
            else if (choice == "5") {

                RecordEvent();
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

    public void DisplayPlayerInfo() {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames() {
        if (_goals.Count ==0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        
        int counter = 1;
        foreach (Goal goal in _goals) 
        {
            Console.WriteLine($"{counter}.{goal.GetDetailsString()}");
            counter++;
        }
    }
    
    
    
    public void ListGoalDetails(Goal SimpleGoal, Goal EternalGoal, Goal ChecklistGoal) //call GetDetailsString()
    {
        Console.WriteLine($"{SimpleGoal.GetDetailsString()}");
        Console.WriteLine($"{EternalGoal.GetDetailsString()}");
        Console.WriteLine($"{ChecklistGoal.GetDetailsString()}");

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
        SimpleGoal simpleGoal = new SimpleGoal(name,description, points );
        _goals.Add(simpleGoal);
    
    }

    public void CreateEternalGoal() {
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


public void CreateChecklistGoal() {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("You have chosen to make an Eternal Goal.");
        Console.WriteLine();
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is its point value for this goal? ");
        string points = Console.ReadLine();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string targetInput = Console.ReadLine();
        int target = int.Parse(targetInput);
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        string bonusInput = Console.ReadLine();
        int bonus = int.Parse(bonusInput);
        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
        _goals.Add(checklistGoal);
    }

    public void RecordEvent() {

    }
    
                        /// <summary>
                        ///  This code is buggy. I runs and displays points but it does not update the _goals list and display the 'completed' representation of the goal
                        /// </summary>
    // {
    //     if (_goals.Count ==0)
    //     {
    //         Console.WriteLine("No goals available to record an event.");
    //         return;
    //     }
    //     ListGoalNames();
    //     Console.WriteLine("Select a goal to record an event: ");
    //     Console.Write("Enter the number of the goal you want to complete: ");
        
    //     if (int.TryParse(Console.ReadLine(), out int goalNumber ) && goalNumber > 0 && goalNumber <= _goals.Count) {

    //         Goal selectedGoal = _goals[goalNumber - 1];
    //         selectedGoal.RecordEvent();

    //         if (selectedGoal.IsComplete()) {

    //             _score =+ int.Parse(selectedGoal.Points);
    //             Console.WriteLine("Event recorded. ");                
    //         }
    //         else {
    //             Console.WriteLine("Event recorded. Goal progress updated.");
    //         }
    //     }
    //     else {
    //         Console.WriteLine("Invalid selection.kk Please try again.");
    //     }
        
    
        
        
    // }

    public void SaveGoals() {
        Console.WriteLine("What is the file name for the goal file? ");
        string filePath = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filePath))

        {
            foreach (Goal goal in _goals)
            {
                string line = $"{goal.ShortName}, {goal.Description}, {goal.Points}";
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Goals have been saved to " + filePath); 
    }

    public void LoadGoals() {
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
                    if (parts.Length >= 3) // ensure there are at least 3 parts
                    {
                        string name= parts[0].Trim().Trim('"'); //trim whitespace
                        string description = parts[1];
                        string points = parts[2].Trim().Trim('"');
                                                
                        Goal goal = new SimpleGoal(name, description, points);
                        
                        
                        if (goal != null)
                        {
                            _goals.Add(goal);
                        }
                                
                    }
                    else
                    {
                        Console.WriteLine($"Invalid line format: {line}");
                    }
                
                }
            }
        }
    }


} 

