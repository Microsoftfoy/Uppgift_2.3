using System;
namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("För hur många dagar och kilometer vill du hyra bilen?");
            Console.WriteLine("Dagar?");
            string Dagar = Console.ReadLine();
            Console.WriteLine("kilometer?");
            string Kilometer = Console.ReadLine();

            Double Dagar1 = Double.Parse(Dagar);
            Double Kilometer1 = Double.Parse(Kilometer);

            Double sum = Kilometer1 * 1;
            Double sum1 = Dagar1 * 500;
            Double sum2 = sum + sum1 + 300;

            Console.WriteLine("Total summan är:" + " " + sum2);

            Console.ReadKey();
        }
    }
}