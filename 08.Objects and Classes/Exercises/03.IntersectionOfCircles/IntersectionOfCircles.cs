﻿using System;
using System.Linq;

public class IntersectionOfCircles
{
    public static void Main()
    {
        Circle circle1 = ReadCircle(Console.ReadLine());
        Circle circle2 = ReadCircle(Console.ReadLine());

        int deltaX = circle1.Center.X - circle2.Center.X;
        int deltaY = circle1.Center.Y - circle2.Center.Y;
        double distanceBetweenCenters = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        if (distanceBetweenCenters > circle1.Radius + circle2.Radius)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }

    private static Circle ReadCircle(string input)
    {
        int[] tokens = input.Split(' ').Select(int.Parse).ToArray();
        return new Circle { Center = new Point { X = tokens[0], Y = tokens[1] }, Radius = tokens[2] };
    }
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
}