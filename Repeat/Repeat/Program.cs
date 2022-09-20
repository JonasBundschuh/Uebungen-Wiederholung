using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatUebung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a decimal number: ");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another decimal number: ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            double s = z1 + z2;
            Console.Clear();

            Console.WriteLine($"The numbers ypu entered were {z1} and {z2}.");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"The solution is: {s}!");

            Console.ReadKey();

        }


    }
}
