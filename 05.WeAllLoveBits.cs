using System;
using System.Globalization;
using System.Threading;

class WeAllLoveBits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            int p = int.Parse(Console.ReadLine());
            int pTilda = GetInverted(p);
            int pUmlaut = GetReversed(p);
            string binary = Convert.ToString(p, 2);
            int pNew = (p ^ pTilda) & pUmlaut;
            Console.WriteLine(pNew);
        }
    }
    static int GetInverted(int input)
    {
        string binary = Convert.ToString(input, 2);
        int returnval = ((1 << binary.Length) - 1) ^ input;
        return returnval;
    }
    static int GetReversed(int input)
    {
        string binary = Convert.ToString(input, 2);
        int returnval = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            returnval <<= 1;
            int bit = input & 1;
            returnval |= bit;
            input >>= 1;
        }
        return returnval;
    }
}
