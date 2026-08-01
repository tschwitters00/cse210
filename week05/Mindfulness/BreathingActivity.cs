public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        int number = int.Parse(_duration);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(number);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(6);

            currentTime = DateTime.Now;
        }

        DisplayEndingMessage();
    }
}