using System;

class Scripture
{
    
    private Reference _reference;
    private List<Word> _words = new List<Word>();
            
    

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] linesInText = text.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string line in linesInText)
        {
            string [] wordsInLine = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string wordText in wordsInLine)
            {
                Word word = new Word(wordText);
                _words.Add(word);
            }
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random _randWord = new Random(); 

        int _randomWordIndex;
        int _totalWords = _words.Count;

        for (int i = 1; i <- numberToHide; i++)
        {
            _randomWordIndex = _randomWord.Next(0, _totalWords);

            if (_words[_randomWordIndex].IsHidden() != true)
            {
                _words[_randomeWordIndex].Hide();
            }
            else{
                foreach (Word word in _words)
                {
                    if (word.IsHidden() ! = true)
                    {
                        word.Hide();
                        break;
                    }
                }
            }
        }
        
    }
    
    public string GetDisplayText()
    {
        string textDisplayed = $"{_reference.GetDisplayText()}";

        foreach (Word word in _words)
        {
            textDisplayed += word.GetDisplayText() + " ";
        }
        
        return textDisplayed.Trim(); 
    }

    public bool IsCompletelyHidden;

} 
