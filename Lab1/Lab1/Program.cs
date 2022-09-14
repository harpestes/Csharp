using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double t, V, g = 9.81, h;
            bool isOkV = true, isOkH = true;
            do
            {
                Console.WriteLine("Введiть значення V: ");
                string strV = Console.ReadLine();
                Console.WriteLine("Введiть значення H: ");
                string strH = Console.ReadLine();

                V = double.Parse(strV);
                h = double.Parse(strH);

                isOkV = double.TryParse(strV, out V);
                isOkH = double.TryParse(strH, out h);
            }
            while (!isOkV && !isOkH);

            t = (Math.Sqrt(2 * g * h) - V) / g;
            Console.WriteLine("Час: " + Math.Round(t, 2, MidpointRounding.AwayFromZero) + " с");
        }
    }
}
