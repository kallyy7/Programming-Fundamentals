using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = Console.ReadLine();
            string secondLetter = Console.ReadLine();
            string thirdLetter = Console.ReadLine();

            string order = firstLetter + secondLetter + thirdLetter;

            char[] charArray = order.ToCharArray();

            Array.Reverse(charArray);

            Console.WriteLine(charArray);
        }
    }
}
