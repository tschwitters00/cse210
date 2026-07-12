
/// Code written by Trevor Schwitters
/// My addition is the option to write your own prompt or to get a random one.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool active = true;
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        promptGen._prompts.Add("Who was the most interesting person I interacted with today?");
        promptGen._prompts.Add("What was the best part of my day?");
        promptGen._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGen._prompts.Add("What was the strongest emotion I felt today?");
        promptGen._prompts.Add("If I had one thing I could do over today, what would it be?");
        promptGen._prompts.Add("What was the most beautiful thing I saw today");
        
        while (active == true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt;
                Entry entry = new Entry();

                Console.WriteLine("1. Custom Prompt");
                Console.WriteLine("2. Random Prompt");
                string secondChoice = Console.ReadLine();
                
                if (secondChoice == "1")
                {
                    Console.Write("Prompt: ");
                    prompt = Console.ReadLine();
                }
                else
                {
                    prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                }

                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                entry._promptText = prompt;
                entry._date = DateTime.Now.ToString("M/d/yyyy");
                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }

            else if (choice == "5")
            {
                active = false;
            }

            else
            {
                Console.WriteLine("Please enter a vaild number.");
            }
        }
    }
}