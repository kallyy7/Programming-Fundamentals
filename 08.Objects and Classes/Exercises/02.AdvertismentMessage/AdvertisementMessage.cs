using System;

public class AdvertisementMessage
{
    public static void Main()
    {
        int countOfAdvertisements = int.Parse(Console.ReadLine());

        string[] phrases = 
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };
        string[] events = 
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        string[] authors =
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };
        string[] cities =
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };
        Random randomAdv = new Random();

        for (int i = 0; i < countOfAdvertisements; i++)
        {
            string phrase = phrases[randomAdv.Next(0, phrases.Length)];
            string eventa = events[randomAdv.Next(0, events.Length)];
            string author = authors[randomAdv.Next(0, authors.Length)];
            string city = cities[randomAdv.Next(0, cities.Length)];

            Console.WriteLine("{0} {1} {2} - {3}", phrase, eventa, author, city);
        }
    }
}