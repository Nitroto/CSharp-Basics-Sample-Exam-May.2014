﻿using System;
using System.Globalization;
using System.Threading;

class CartesianCoordinateSystem
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if (x == 0 && y == 0)
        {
            Console.WriteLine("0");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("4");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine("5");
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine("6");
        }
    }
}
