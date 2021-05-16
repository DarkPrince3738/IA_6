using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { -2, 8, 9, -8, 0, -11 };
            int pos = 0;
            int neg = 0;
            int posSum = 0;
            int negSum = 0;
            int arfPos;
            int arfNeg;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    neg++;
                    negSum += arr[i];
                }
                if (arr[i] > 0)
                {
                    pos++;
                    posSum += arr[i];
                }
            }
            arfPos = posSum / pos;
            arfNeg = negSum / neg;
            Console.WriteLine($"{pos} {posSum} {arfPos}");
            Console.WriteLine($"{neg} {negSum} {arfNeg}");

        }
    }
}
