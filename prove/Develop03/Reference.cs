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
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
        
    public string GetDisplayText() //print to console the book, chapter and verse(s) to study
    {
        string text = $"{_book} {_chapter}: {_verse}-{_endVerse}   ";
        return text;
    }

}
