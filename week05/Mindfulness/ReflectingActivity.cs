public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    Random rnd = new Random();

    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.Write("When you have somthing in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int number = int.Parse(_duration);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(number);
        DateTime currentTime = DateTime.Now;
        
        while (currentTime < futureTime)
        {
            DisplayQuestions();
            currentTime = DateTime.Now;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[rnd.Next(_prompts.Count())];
    }

    public string GetRandomQuestion()
    {
        return _questions[rnd.Next(_questions.Count())];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- \n");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(15);
    }
}