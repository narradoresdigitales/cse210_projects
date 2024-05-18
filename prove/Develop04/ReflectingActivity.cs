using System.Diagnostics.Contracts;
using System.Reflection;

public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
    "---How did you feel when it was complete?---",
    "---Think of a time when you stood up for someone else.---",
    "---Think of a time when you did something really difficult.---",
    "---Think of a time when you helped someone in need.---",
    "---Think of a time when you did something truly selfless.---",
    };
    
    List<string> _questions = new List<string> 
    {
        " > Think of a time when you did something really difficult.",
        " > Why was this experience meaningful to you?",
        " > Have you ever done anything like this before?",
        " > How did you get started?",
        " > How did you feel when it was complete?",
        " > What made this time different than other times when you were not as successful?",
        " > What is your favorite thing about this experience?",
        " > What could you learn from this experience that applies to other situations?",
        " > What did you learn about yourself through this experience?",
        " > How can you keep this experience in mind in the future?",

    };

    
    public ReflectingActivity() 
    {
        Console.WriteLine();
        _name = "Reflecting Activity.";
        _description = "This Activity will help you reflect on times in your life when you have shown strength" +
        "and resilience.This will help you recognize the power you have and how you can use it in other aspects" +
        "of your life."; // I concatenate the text here to view it to avoid horizontal scrolling :/
    }
    public void Run() 
    {
        Console.WriteLine();
        Console.WriteLine("_________________________________________________"); //spacing
        DisplayStartingMessage();
        DateTime stopTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Thread.Sleep(1000);
        DisplayPrompts();
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.  ");
        Console.ReadLine(); // pauses the program until the user presses 'Enter'
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DisplayQuestions(stopTime);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt() 
    { 
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    
    }
    public string GetRandomQuestion(DateTime stopTime) 
    { 
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompts() 
    {
        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(3000);

    }
    public void DisplayQuestions(DateTime stopTime)
    {
        Random random = new Random();
        
        while (DateTime.Now < stopTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(10);
            Thread.Sleep(10000);
                        
        }
    

    }


}