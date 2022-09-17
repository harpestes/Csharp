using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk; 
            double result = 0;
            bool isNNOk, isNKOk;
            do
            {
                Console.WriteLine("NN: ");
                string strNN = Console.ReadLine();
                isNNOk = int.TryParse(strNN, out nn);
                if (!isNNOk && nn < 0)
                {
                    Console.WriteLine("Введiть вiрне nn");
                }
            }
            while (!isNNOk);
            do
            {
                Console.WriteLine("NK: ");
                string strNK = Console.ReadLine();
                isNKOk = int.TryParse(strNK, out nk);
                if (!isNKOk && nk < 0)
                {
                    Console.WriteLine("Введiть вiрне nk");
                }
            }
            while (!isNNOk);
            for(int k = nn; k < nk; k++)
            {
                result *= (Math.Pow(-1, (Math.Pow(k, 2) + k + 1)) * Math.Pow(k, 2)) / (2 * Math.Pow(k, 2) + 5);
            }
            Console.WriteLine(result);
        }
    }
}
