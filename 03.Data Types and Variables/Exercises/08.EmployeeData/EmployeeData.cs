using System;

public class EmployeeData
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string secoundName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        double personalIdNumber = double.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {secoundName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Personal ID: {personalIdNumber}");
        Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
    }
}