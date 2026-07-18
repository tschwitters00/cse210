/// Scripture Memorizer by Trevor Schwitters.
///
/// My addition is a randomly picked verse from a couple different ones.
/// 
/// 
using System;

class Program
{
    static void Main(string[] args)
    {
        bool active = true;
        Random random = new Random();
        Reference reference = null;
        string scrip = null;

        int randomScripture = random.Next(1,6);
        if(randomScripture == 1)
        {
            scrip = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            reference = new Reference("Proverbs", 3, 5, 6);
        }

        else if(randomScripture == 2)
        {
            scrip = "And see that all these things are done in wisdom and order; for it is not requisite that a man should run faster than he has strength. And again, it is expedient that he should be diligent, that thereby he might win the prize; therefore, all things must be done in order.";
            reference = new Reference("Mosiah", 4, 27);
        }

        else if(randomScripture == 3)
        {
            scrip = "Let thy bowels also be full of charity towards all men, and to the household of faith, and let virtue garnish thy thoughts unceasingly; then shall thy confidence wax strong in the presence of God; and the doctrine of the priesthood shall distil upon thy soul as the dews from heaven.";
            reference = new Reference("D&C", 121, 45);
        }

        else if(randomScripture == 4)
        {
            scrip = "And I said unto them: Have ye inquired of the lord?";
            reference = new Reference("1 Nephi", 15, 8);
        }

        else if(randomScripture == 5)
        {
            scrip = "The lord is my light and my salvation; whom shall I fear? the Lord is the strength of my life; of whom shall i be afraid?";
            reference = new Reference("Psalm", 27, 1);
        }

        else
        {
            scrip = "But behold, Laman and Lemuel, I fear exceedingly because of you; for behold, methought I saw in my dream, a dark and dreary wilderness.";
            reference = new Reference("1 Nephi", 8, 4);
        }

        Scripture scripture = new Scripture(reference, scrip);

        Console.WriteLine(scripture.GetDisplayText());

        while(active == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if(input == "quit" || scripture.IsCompletelyHidden() == true)
            {
                active = false;    
            }

            else
            {
                int randInt = random.Next(1,5);
                scripture.HideRandomWords(randInt);
            }
        }
    }
}