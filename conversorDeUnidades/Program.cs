using System;

namespace Unitconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de longitud en metros");

            double meters = Convert.ToDouble(Console.ReadLine());

            double feet = meters * 3.28084;

            Console.WriteLine("{0} metros son {1} pies ", meters, feet);


        }
    }
}