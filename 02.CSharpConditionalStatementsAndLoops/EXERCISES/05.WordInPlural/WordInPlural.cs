using System;

public class WordInPlural
{
    public static void Main()
    {
        string word = Console.ReadLine();
        bool nounEndsWith = word.EndsWith("o") ||
                            word.EndsWith("ch") ||
                            word.EndsWith("s") ||
                            word.EndsWith("sh") || 
                            word.EndsWith("x") || 
                            word.EndsWith("z");

        if (word.EndsWith("y"))
        {
            word = word.Replace("y", "ies");
            Console.WriteLine(word);
        }
        else if (nounEndsWith)
        {
            Console.WriteLine($"{word}es");
        }
        else
        {
            Console.WriteLine($"{word}s");
        }
    }
}