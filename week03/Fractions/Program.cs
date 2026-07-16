using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3,4);
        Fraction frac4 = new Fraction(1,3);

        string fracString1 = frac1.GetFractionString();
        string fracString2 = frac2.GetFractionString();
        string fracString3 = frac3.GetFractionString();
        string fracString4 = frac4.GetFractionString();
        
        int fractint1 = frac1.GetBottom();
        int fractint2 = frac2.GetTop();
        double fracdoub3 = frac3.GetDecimalValue();
        double fracdoub4 = frac4.GetDecimalValue();

        Console.WriteLine(fracString1);
        Console.WriteLine(fractint1);
        Console.WriteLine(fracString2);
        Console.WriteLine(fractint2);
        Console.WriteLine(fracString3);
        Console.WriteLine(fracdoub3);
        Console.WriteLine(fracString4);
        Console.WriteLine(fracdoub4);
    }
}