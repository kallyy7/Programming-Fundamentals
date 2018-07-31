using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MunipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if(command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                 
                }
                else if(command[0] == "Distinct")
                {
                    Distinct(arr);
                    arr = arr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                   
                }
                else if(command[0] == "Replace")
                {
                    int index = Convert.ToInt32(command[1]);
                    string word = arr[index];
                    string replaceWord = command[2];

                    Replace(arr, index, replaceWord, word);

                    


                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
        static string Distinct (string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        arr[j] = null;
                    }
                }
            }

            return string.Join("", arr);
        }
        static string Replace (string[] arr, int index, string replaceWord, string word)
        {
            return arr[Array.IndexOf(arr, word)] = replaceWord;
        }
    }
}
