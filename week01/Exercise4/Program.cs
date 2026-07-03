using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int sum = 0;
        int greatestNumber = 0; 
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string NumIn = Console.ReadLine();
            number = int.Parse(NumIn);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        foreach (int num in numbers)
        {
            sum += num;

            if (greatestNumber <= num)
            {
                greatestNumber = num;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {greatestNumber}");
    }
}