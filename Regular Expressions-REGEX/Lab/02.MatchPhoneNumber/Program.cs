using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ -])2{1}\1\d{3}\1\d{4}\b";


            string phoneNumbers = Console.ReadLine();

            var phonesMatch = Regex.Matches(phoneNumbers, pattern);

            string[] matchedPhones = phonesMatch
                .Select(p => p.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));

        }
    }
}
