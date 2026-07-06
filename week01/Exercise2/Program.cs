using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter;
        Console.Write("Enter Grade %");
        string grade = Console.ReadLine();
        float gradeNum = float.Parse(grade);

        if (gradeNum >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNum >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNum >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNum >= 60)
        {
            gradeLetter = "D";
        }
        else if (gradeNum < 60)
        {
            gradeLetter = "F";
        }
        else
        {
            gradeLetter = "Error";
        }

        Console.WriteLine($"Your Grade is {gradeLetter}");

        if (gradeNum >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }

        else
        {
            Console.WriteLine("You failed, better luck next time.");
        }
    }
}