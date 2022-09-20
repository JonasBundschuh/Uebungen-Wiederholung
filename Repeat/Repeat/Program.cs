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
            Console.WriteLine("Please enter a text: ");
            string ut = Console.ReadLine();
            string t = ut.PadRight(30, 'y');

            Console.Clear();

            Console.WriteLine($"The text u entered was: {ut}");
            Console.WriteLine($"The modified text is: {t}");

            Console.ReadKey();

        }


    }
}
