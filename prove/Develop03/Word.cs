using System;
using System.Runtime.CompilerServices;

class Word
{
    private string _text;
    private bool _isHidden;

    
    public Word(string text)
    {
            _text = text;
            string [] words = _text.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

            
    } 
    
    public void Hide()
    {
        
    }

    public void Show()
    {

    }

    public bool IsHidden;
    
    public string GetDisplayText()
    {
        return _text;  
    }



}