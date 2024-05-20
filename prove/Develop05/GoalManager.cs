
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
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("You have chosen to make a Simple Goal.");
                    Console.WriteLine();
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is its point value? ");
                    string points = Console.ReadLine();
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);


                }
                else if (choice1 == "2")
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("You have chosen to make an Eternal Goal.");
                    Console.WriteLine();
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
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"Name: {goal._shortName}, Description: {goal._description}, Points: {goal._points}");
                    Console.WriteLine();
                }
                
            }
            else if (choice == "3")
            {
                
                
            }
            else if (choice == "4")
            {
                
                
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

    }

    public void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal?");

        
    }

    // public RecordEvent()

    // public void SaveGoals()

    // public void LoadGoals()




}

