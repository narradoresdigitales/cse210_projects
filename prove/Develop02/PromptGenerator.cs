using System.Collections.Generic;
public class PromptGenerator {

    public List<string> _prompts = new List<string>()
    {
        "What has been the most memorable part of your day?"
        "How are you feeling? Explain."

    };

    Random _randomPrompt = new Random();
    public string GetRandomPrompt(string text)
    {
        int _randomIndex = _randomPrompt.Next(0, _prompts.Count);

        string _randomPromptString = _prompts[_randomIndex];

        return _randomPromptString;
    }
    }
}