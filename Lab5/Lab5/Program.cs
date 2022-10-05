using System;

namespace Lab5
{
    class Program
    {
        static int similars(int[,] matrix, int index, string type)
        {
            int counter = 0;
            switch (type)
            {
                case "row":
                    for (int j1 = 0; j1 < matrix.GetLength(0) - 1; j1++)
                    {
                        (int, int) basic = (matrix[index, j1], matrix[index, j1 + 1]);

                        for (int i2 = 0; i2 < (matrix.Length / matrix.GetLength(0)); i2++)
                        {
                            for (int j2 = 0; j2 < matrix.GetLength(0) - 1; j2++)
                            {
                                if (i2 == index)
                                    break;

                                (int, int) comparable = (matrix[i2, j2], matrix[i2, j2 + 1]);

                                if (basic == comparable)
                                {
                                    counter++;
                                    break;
                                }
                            }
                        }
                    }
                    break;

                case "col":
                    for (int i1 = 0; i1 < (matrix.Length / matrix.GetLength(0) - 1); i1++)
                    {
                        (int, int) basic = (matrix[i1, index], matrix[i1 + 1, index]);

                        for (int j2 = 0; j2 < matrix.GetLength(0); j2++)
                            for (int i2 = 0; i2 < (matrix.Length / matrix.GetLength(0) - 1); i2++)
                            {
                                if (j2 == index)
                                    break;

                                (int, int) comparable = (matrix[i2, j2], matrix[i2 + 1, j2]);
                                if (basic == comparable)
                                {
                                    counter++;
                                    break;
                                }
                            }
                    }
                    break;
                default:
                    return -1;
            }
            return counter;
        }



        static void Main(string[] args)
        {
            const int N = 5, M = 5;
            int[,] arr = new int[M, N];

            Random rnd = new Random();
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }

            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Similar to first row: " + similars(arr, 0, "row"));
            Console.WriteLine("Similar to last row: " + similars(arr, N - 1, "row"));
            Console.WriteLine("Similar to first column: " + similars(arr, 0, "col"));
            Console.WriteLine("Similar to last column: " + similars(arr, N - 1, "col"));
        }
    }
}
