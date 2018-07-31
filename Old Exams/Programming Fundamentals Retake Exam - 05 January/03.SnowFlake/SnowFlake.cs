using System;
using System.Text.RegularExpressions;

public class SnowFlake
{
    public static void Main()
    {
        string surface = Console.ReadLine();
        string mantle = Console.ReadLine();
        string core = Console.ReadLine();
        string lowerMantle = Console.ReadLine();
        string lowerSurface = Console.ReadLine();

        string surfacePattern = @"[\D][^\w]";
        string mantlePattern = @"[\d_]";
        string corePattern = @"([-+!\\\/?.*,]+)+([\d_]+)+([a-zA-Z]+)+([\d_]+)+([-+!\\\/?.*,]+)";

        Match matchSurface = Regex.Match(surface, surfacePattern);
        Match matchMantle = Regex.Match(mantle, mantlePattern);
        Match matchCore = Regex.Match(core, corePattern);
        Match matchLowerSurface = Regex.Match(lowerSurface, surfacePattern);
        Match matchLowerMantle = Regex.Match(lowerMantle, mantlePattern);

        bool validSnowFlake = matchSurface.Success && matchMantle.Success
        && matchCore.Success && matchLowerSurface.Success && matchLowerMantle.Success;

        if (validSnowFlake)
        {
            Console.WriteLine("Valid");
            Console.WriteLine(matchCore.Groups[3].Length);
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}