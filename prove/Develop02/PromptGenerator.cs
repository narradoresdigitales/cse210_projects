using System.Collections.Generic;
public class PromptGenerator {

    public List<string> _prompts = new List<string>()
    {
        "What has been the most memorable part of your day?",
        "How are you feeling? Explain.",
        "Did you drink yerba mate today?",
        "Did you read your scriptures? ",
        "Did you let your son play video games?"

    };
    Random _randomPrompt = new Random();
    public string GetRandomPrompt()
    {
        int _randomIndex = _randomPrompt.Next(0, _prompts.Count);

        string _randomPromptString = _prompts[_randomIndex];

        return _randomPromptString;
    }
    
}