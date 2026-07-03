using System;

class Program
{
    static void Main(string[] args)
    {
        int guessInt;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        do
        {
            Console.Write("What is your guess? ");
            string Guess = Console.ReadLine();
            guessInt = int.Parse(Guess);

            if (guessInt == magicNumber)
            {
                Console.WriteLine("You Guessed it!");
            }
            else if (guessInt >= magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessInt <= magicNumber)
            {
                Console.WriteLine("Higher");
            }
        } while (guessInt != magicNumber);
    }
}