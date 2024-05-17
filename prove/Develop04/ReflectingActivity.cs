using System.Diagnostics.Contracts;
using System.Reflection;

public class ReflectingActivity : Activity
{

    List<string> _prompts = new List<string> ();

    List<string> _questions = new List<string> ();

    
    public ReflectingActivity() 
    {
        Console.WriteLine();
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
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Thread.Sleep(1500);
        DisplayPrompt();
        Thread.Sleep(1500);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine();
        Console.WriteLine();
        DisplayQuestions();
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt() {
        return "";

    }

    public string GetRandomQuestion() {
        return "";
    }

    public void DisplayPrompt() 
    {
        _prompts.Add("How did you feel when it was complete?");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add( "Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        
    }

    public void DisplayQuestions()
    {
        _questions.Add("Think of a time when you did something really difficult.");
        _questions.Add(" Why was this experience meaningful to you?");
        _questions.Add(" Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add(" What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        
        Random random = new Random();
        int index = random.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
    }


}