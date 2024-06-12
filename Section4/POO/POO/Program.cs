using System;
using System.Globalization;
using Poo.Models;

namespace ChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the x sides values:");
            double a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.WriteLine("Insert the y sides values:");
            double d = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Triangle x = new Triangle(a, b, c);
            Triangle y = new Triangle(d, e, f);

            if(x.Area() > y.Area()) Console.WriteLine("X is bigger!");
            else Console.WriteLine("Y is bigger!");


        }
    }
}