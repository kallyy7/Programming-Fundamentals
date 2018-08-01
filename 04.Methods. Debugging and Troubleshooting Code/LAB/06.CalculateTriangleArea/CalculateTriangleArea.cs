using System;

public class CalculateTriangleArea
{
    public static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = GetTriangleArea(w, h);

        Console.WriteLine(area);
    }
    static double GetTriangleArea(double w, double h)
    {
        return w * h / 2;
    }
}