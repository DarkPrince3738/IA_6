using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7] { 12, 65, 75, 34, 15, 5, 4 };
            int val;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        val = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = val;
                    }
                }
            }
            Console.WriteLine($"{array[0]}, {array[1]}, {array[2]}");
            for(int i = array.Length-1; i > array.Length - 4; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
