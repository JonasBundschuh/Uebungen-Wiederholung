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
            Console.WriteLine("Please enter a text containing spaces: ");
            string t = Console.ReadLine();
            string mt = t.Trim(' ');
            Console.Clear();

            Console.WriteLine($"This is the text you entered: {t}");            
            Console.WriteLine("------------------------------------------------------------");            
            Console.WriteLine($"This is your text without spaces in front & behind it: {mt}");

            Console.ReadKey();

        }


    }
}
