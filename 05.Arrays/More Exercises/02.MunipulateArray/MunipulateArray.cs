using System;
using System.Linq;

public class MunipulateArray
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
            .Split()
            .ToArray();
        int numbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers; i++)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            if (command[0] == "Reverse")
            {
                Array.Reverse(input);

            }
            else if (command[0] == "Distinct")
            {
                Distinct(input);
                input = input.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            }
            else if (command[0] == "Replace")
            {
                int index = Convert.ToInt32(command[1]);
                string word = input[index];
                string replaceWord = command[2];

                Replace(input, index, replaceWord, word);
            }
        }

        Console.WriteLine(string.Join(", ", input));
    }
    private static string Distinct(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    arr[j] = null;
                }
            }
        }

        return string.Join("", arr);
    }
    private static string Replace(string[] arr, int index, string replaceWord, string word)
    {
        return arr[Array.IndexOf(arr, word)] = replaceWord;
    }
}