using System;
using System.Runtime.CompilerServices;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)

    {
        _book = "Proverbs";
        _chapter = 3;
        _verse = 5;
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = "Proverbs";
        _chapter = 3;
        _verse = 5;
        _endVerse = 6;
    }
        
    public string GetDisplayText()
    {
        string text = $"{_book} {_chapter}: {_verse} - {_endVerse}";
        return text;
    }

}
