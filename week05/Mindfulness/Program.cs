/// My addition is a activity counter that only shows up once the user has done at least one activity.
/// 
/// 

using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> reflectionPrompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        List<string> questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        List<string> listingPrompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
 
        BreathingActivity bActivity = new BreathingActivity();
        ReflectingActivity rActivity = new ReflectingActivity(reflectionPrompts, questions);
        ListingActivity lActivity = new ListingActivity(listingPrompts);

        int count = 0;
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            if (count != 0)
            {
                Console.WriteLine($"Completed activity count: {count}");
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                bActivity.Run();
                count += 1;
            }
            else if (choice == "2")
            {
                rActivity.Run();
                count += 1;
            }
            else if (choice == "3")
            {
                lActivity.Run();
                count += 1;
            }
        }
    }
}