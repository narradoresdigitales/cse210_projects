using System.Diagnostics.Contracts;
using System.Reflection;

public class ReflectingActivity : Activity
{

    List<string> _prompts = new List<string> ();

    List<string> _questions = new List<string> ();

    
    public ReflectingActivity() 
    {
        _name = "Reflecting Activity";
        _description = @"This Activity will help you reflect on times in your life when you have shown strength and resilience.
            This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run() 
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready");
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        
        

    }

    public string GetRandomPrompt() {
        return "";

    }

    public string GetRandomQuestion() {
        return "";
    }

    public void DisplayPrompt() 
    {
        _prompts.Add("Think of a time when you did something really difficult.");
        Console.WriteLine(_prompts[0]);
    }

    public void DisplayQuestions()
    {
        _questions.Add("How did you feel when it was complete?");
        Console.WriteLine(_questions[0]);
    }


}