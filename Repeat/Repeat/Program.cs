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
            Console.WriteLine("Choose your first number: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your second number: ");
            int z2 = Convert.ToInt32(Console.ReadLine());
            double ergebnis = z1 + z2;
            Console.Clear();
            Console.WriteLine($"Das ergebnis ist {ergebnis}!");

            Console.ReadKey();
        }


    }
}
