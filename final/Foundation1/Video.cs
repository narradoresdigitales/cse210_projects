
using System.CodeDom.Compiler;
using System.Security.AccessControl;

public class Video

{
    
    // Set attributes  // Encapsulate attributes with Getters/Setters
    public string _title { get;set; }
    public string _author { get;set; }
    public int _length { get;set; }


    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayInfo()

    {
        
        Console.Write($"Video Title: {_title},  Presented by: {_author}, Length: {_length} seconds\n");
        Console.WriteLine($"Number of Comments: {_comments.Count}");
        Console.WriteLine();
        Console.WriteLine("Comments: ");
        
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment._name}: {comment._text}");
        }
    }


}
