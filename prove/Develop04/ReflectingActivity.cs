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
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
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
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DisplayQuestions();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt() { // I am not sure how I'll be using this method.
        // Random random = new Random();
        // int index = random.Next(_prompts.Count);
        return "";
        
    }
    public string GetRandomQuestion() { // I am not sure how I'll be using this method.
        // Random random = new Random();
        // int index = random.Next(_questions.Count);
        return "";
        
    }
    public void DisplayPrompts() 
    {
        _prompts.Add("---How did you feel when it was complete?---");
        _prompts.Add("---Think of a time when you stood up for someone else.---");
        _prompts.Add("---Think of a time when you did something really difficult.---");
        _prompts.Add( "---Think of a time when you helped someone in need.---");
        _prompts.Add("---Think of a time when you did something truly selfless.---");

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        Thread.Sleep(3000);

    }
    public void DisplayQuestions()
    {
        _questions.Add(" > Think of a time when you did something really difficult.");
        _questions.Add(" > Why was this experience meaningful to you?");
        _questions.Add(" > Have you ever done anything like this before?");
        _questions.Add(" > How did you get started?");
        _questions.Add(" > How did you feel when it was complete?");
        _questions.Add(" > What made this time different than other times when you were not as successful?");
        _questions.Add(" > What is your favorite thing about this experience?");
        _questions.Add("  > What could you learn from this experience that applies to other situations?");
        _questions.Add(" > What did you learn about yourself through this experience?");
        _questions.Add(" > How can you keep this experience in mind in the future?");
        
        
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < stopTime)

        {
            Random random = new Random();
        
            //while(_duration > 0)
            //{
            int index = random.Next(_questions.Count);
            Console.WriteLine(_questions[index]);
            ShowSpinner(10);
            Thread.Sleep(10000);
            _duration--;
            //}
        }
        
        
        


    }


}