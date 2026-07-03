using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNumString = Console.ReadLine();
            int favNum = int.Parse(favNumString);
            return favNum;
        }

        static int SquareNumber(int inputNum)
        {
            return inputNum * inputNum;
        }

        static void DisplayResult(string userName, int sqrNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqrNum}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int sqrNum = SquareNumber(favNum);
        DisplayResult(userName, sqrNum);
    }
}