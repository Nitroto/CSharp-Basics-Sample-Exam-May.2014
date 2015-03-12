using System;
using System.Globalization;
using System.Threading;

class SandGlass
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int spaces = 0;
        int figure = n;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', spaces));
            Console.Write(new string('*', figure));
            Console.Write(new string('.', spaces));
            Console.WriteLine();
            if (i < n / 2)
            {
                spaces++;
                figure -= 2;
            }
            else
            {
                spaces--;
                figure += 2;
            }
        }
    }
}
