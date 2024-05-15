public class ListingActivity : Activity
{

    int _count;
    
    List<string> list = new List<string>
    {

    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = @"This activity will help you reflect on the good things in your life by having you list as many 
            things you can in a certain area";
        _duration = 0; 
    }

    public void Run()
    {
        DisplayStartingMessage();
    }

    public void GetRandomPrompt()
    {

    }

    public void GetListFromUser() //this should not be void. I need to edit!!!
    {
        //List<string>
    }

}