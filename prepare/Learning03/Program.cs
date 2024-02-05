using System;

class Program
{
    static void Main(string[] args)
    {
        // add the fraction class for fraction one as the default
        Fraction f1 = new Fraction();
        // write the output for the fraction
        Console.WriteLine(f1.GetFractionString());
        // write the ouput in decimal value for the fraction
        Console.WriteLine(f1.GetDecimalValue());

        // add a perameter
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}