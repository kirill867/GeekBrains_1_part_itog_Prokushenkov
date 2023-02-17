using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("длинна массива: ");
            int arrayLen = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[arrayLen];

            for(int i = 0; i < arrayLen; i++)
            {
                array[i] = Console.ReadLine();
            }

            PrintItogStrings(array);
        }

        private static void PrintItogStrings(string[] array)
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < array.Length; i++)
                if (array[i].Length <= 3)
                    Console.WriteLine(array[i]);
        }
    }
}