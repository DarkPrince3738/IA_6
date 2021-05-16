using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[7] {"hah", "sfymfm", "smm", "sym", "fsym", "sfym", "sym"};
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
