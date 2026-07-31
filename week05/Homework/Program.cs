using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "problems 8-19");
        
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}