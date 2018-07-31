using System;

public class EmployeeData
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int id = int.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine("Employee ID: {0:d8}", id);
        Console.WriteLine("Salary: {0:f2}", salary);
    }
}