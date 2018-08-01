using System;

public class GeometryCalc
{
    public static void Main()
    {
        string shape = Console.ReadLine();

        double result = GeometryCalculator(shape);

        Console.WriteLine($"{result:f2}");
    }

    static double GeometryCalculator(string shape)
    {
        double area = 0;

        switch (shape)
        {
            case "triangle":
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = side * height / 2;
                break;
            case "square":
                side = double.Parse(Console.ReadLine());

                area = side * side;
                break;
            case "rectangle":
                double width = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());

                area = width * height;
                break;
            case "circle":
                double radius = double.Parse(Console.ReadLine());

                area = Math.PI * radius * radius;
                break;
        }
        return area;
    }
}