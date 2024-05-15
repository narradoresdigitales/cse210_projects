public class ReflectingActivity : Activity
{

    List<string> _prompts = new List<string> {

    };

    List<string> _questions = new List<string> {

    };

    public ReflectingActivity() {
        _name = "Reflecting Activity";
        _description = @"This Activity will help you reflect on times in your life when you have shown strength and resilience.
            This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run() 
    {
        DisplayStartingMessage();
    }

    public string GetRandomPrompt() {
        return "";

    }

    public string GetRandomQuestion() {
        return "";
    }

    public void DisplayPrompt() {

    }

    public void DisplayQuestions()
    {
        
    }


}