using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class Word
{
    private string _text;
    private bool _isHidden;

    
    public Word(string text)
    {
           

           /* foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }*/

            
    } 
    
    public void Hide()
    {
        if (_isHidden != true)
        {
            Regex wordRegex = new Regex(@"\b\b\w+\b");

            string newWord = wordRegex.Replace(_text, match => new string('_', match.Length));

            _text = newWord;

            _isHidden = true;
        }
    }

    public void Show()
    {
        _text = _originalText;
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;  
    }



}