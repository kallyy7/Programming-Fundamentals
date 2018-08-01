using System;
using System.Collections.Generic;

public class FixEmails
{
    public static void Main()
    {
        var emails = new Dictionary<string, string>();

        while (true)
        {
            string name = Console.ReadLine();

            if (name == "stop")
            {
                break;
            }
            string email = Console.ReadLine();
            emails[name] = email;
        }

        foreach (var email in emails)
        {
            if (!email.Value.Contains(".us") && !email.Value.Contains(".uk"))
            {
                Console.WriteLine("{0} -> {1}", email.Key, email.Value);
            }
        }
    }
}