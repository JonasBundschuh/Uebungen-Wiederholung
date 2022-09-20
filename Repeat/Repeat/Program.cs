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

            int textlenght = userText.Length;
            Console.Clear();
            Console.WriteLine($"The text you entered is: {userText}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"The length of the text is {textlenght}!");

            Console.ReadKey();

        }


    }
}
