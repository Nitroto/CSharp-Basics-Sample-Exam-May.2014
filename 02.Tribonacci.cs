using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

class Tribonacci
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        BigInteger nextElement =0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 4; i <= n; i++)
        {
            nextElement = t1 + t2 + t3;
            t1 = t2;
            t2 = t3;
            t3 = nextElement;
        }
        if (n == 3)
        {
            nextElement = t3;
        }
        else if (n == 2)
        {
            nextElement = t2;
        }
        else if (n == 1)
        {
            nextElement = t1;
        }
        Console.WriteLine(nextElement);
    }
}
