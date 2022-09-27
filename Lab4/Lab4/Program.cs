using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, temp = 0, N = 7;
            bool isKOk;

            int[] arr = new int[N];

            Random generator = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = generator.Next(-10, 10);
            }

            do
            {
                Console.Write("Please enter your number: ");
                string strK = Console.ReadLine();
                isKOk = int.TryParse(strK, out k);
                if (!isKOk)
                {
                    Console.Write("Please enter right value");
                }
                else if (k < 1 && k > N)
                {
                    Console.Write("Please enter right value");
                }
            }
            while (!isKOk || k < 1 || k > N);

            Console.WriteLine("Ogiginal massive: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            for (int i = 0; i < k; i++)
            {
                temp = arr[N - 1];
                for (int j = N - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = temp;
            }

            Console.WriteLine("\nChanged massive: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }
}
