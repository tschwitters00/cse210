using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    Random rnd = new Random();

    public ListingActivity(List<string> prompts) : base("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        List<string> list = GetListFromUser();
        _count = list.Count();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        string prompt = _prompts[rnd.Next(_prompts.Count())];
        Console.WriteLine($" --- {prompt} ---");
    }

    public List<string> GetListFromUser()
    {
        int number = int.Parse(_duration);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(number);
        DateTime currentTime = DateTime.Now;
        List<string> list = new List<string>();

        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string word = Console.ReadLine();
            list.Add(word);
            currentTime = DateTime.Now;
        }
        
        return list;
    }
}