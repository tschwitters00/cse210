using System.Security.Principal;

public class Activity
{
    private string _name;
    private string _description;
    protected string _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"This activity will help you {_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < (seconds * 2); i++)
        {
            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("x");
            Thread.Sleep(250);
            Console.Write("\b \b"); 
        }
        Console.WriteLine("");
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds -= 1;
        }
    }
}