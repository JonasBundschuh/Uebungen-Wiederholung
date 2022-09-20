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
            Console.WriteLine("Please enter your text: ");
            string userText = Console.ReadLine();

            string moddedText = userText.Replace("U", "G").Replace("u", "g");
            Console.WriteLine($"The old text was: {userText}");
            Console.WriteLine($"The neew text is {moddedText}");

        }


    }
}
