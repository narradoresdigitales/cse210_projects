using System.IO;
using System.IO.Enumeration;
public class Journal 
{

    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {
        Console.Write("What is the file name? \n >");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(filename);  
                
            }

    }

    public void LoadFromFile(string file)
    {
        
    }
}
