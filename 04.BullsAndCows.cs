using System;
using System.Globalization;
using System.Threading;

class BullsAndCows
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int guessNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool noAnswer = true;
        for (int candidate = 1111; candidate <= 9999; candidate++)
        {
            char[] digits = candidate.ToString().ToCharArray();
            if (digits[0] >= '1' && digits[1] >= '1' && digits[2] >= '1' && digits[3] >= '1')
            {
                char[] userNumber = guessNumber.ToString().ToCharArray();
                int candidateBulls = 0;
                int candidateCows = 0;

                for (int i = 0; i < userNumber.Length; i++)
                {
                    if (digits[i] == userNumber[i])
                    {
                        candidateBulls++;
                        digits[i] = '$';
                        userNumber[i] = '@';
                    }
                }

                for (int i = 0; i < userNumber.Length; i++)
                {
                    for (int j = 0; j < digits.Length; j++)
                    {
                        if (digits[j] == userNumber[i])
                        {
                            candidateCows++;
                            digits[j] = '$';
                            userNumber[i] = '@';
                        }
                    }
                }

                if (candidateBulls == bulls && candidateCows == cows)
                {
                    if (!noAnswer)
                    {
                        Console.Write(" {0}", candidate);
                    }
                    else
                    {
                        Console.Write("{0}", candidate);
                    }
                    noAnswer = false;
                }
            }
        }
        if (noAnswer)
        {
            Console.WriteLine("No");
        }
    }
}
