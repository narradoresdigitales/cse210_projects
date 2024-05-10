using System.Threading.Tasks.Dataflow;
using System.Text.RegularExpressions;

public class Word
{
    private string _text;
    private string _originalText;
    private bool _isHidden;

    
    public Word(string text)
    {
        _originalText = text;
        _text = text;
        _isHidden = false;

            
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