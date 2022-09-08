using System;

namespace firstLessonCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, value, n = 6; ;
            int[,] array = new int[6,6];
            Random rnd = new Random();
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    value = rnd.Next(-100, 100);
                    array[i, j] = value;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }
            for (int i = 5; i > 0; i--)
            {
                int j = 0; n--;
                for (j = 0; j < n; j++)
                {
                    if (array[i,j] > 0) sum += array[i,j];
                }
            }
            Console.WriteLine("\n\nСума додатнiх елементiв: " + sum);
        }
    }
}

