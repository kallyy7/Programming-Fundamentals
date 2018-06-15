using System;
using System.Text;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            StringBuilder messages = new StringBuilder();

            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake");
                Console.WriteLine(input);
                return;
            }

            while (true)
            {
                int firstOccureence = input.IndexOf(pattern);
                int lastOccureence = input.LastIndexOf(pattern);

                if (firstOccureence > -1 && lastOccureence > -1 && pattern.Length > 0)
                {
                    input = input.Remove(lastOccureence, pattern.Length);
                    input = input.Remove(firstOccureence, pattern.Length);
                    messages.AppendLine("Shaked it");

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                }
                else
                {
                    messages.AppendLine("No shake");
                    break;
                }

            }

            Console.Write(messages.ToString());
            Console.WriteLine(input);
        }
    }
}
