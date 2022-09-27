using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 0, third = 0, fourth = 0, userNum = 0, firstSum = 0, secondSum = 0;
            bool isUserNumOk = false;
            do
            {
                Console.WriteLine("Enter your number: ");
                string strUserNum = Console.ReadLine();
                isUserNumOk = int.TryParse(strUserNum, out userNum);
                if (!isUserNumOk)
                {
                    Console.WriteLine("Please enter right number");
                }
                else if (userNum < 1000)
                {
                    Console.WriteLine("Please enter right number");
                }
            }
            while (!isUserNumOk || userNum < 1000);

            first = userNum / 1000;
            second = (userNum - first * 1000) / 100;
            third = (userNum - first * 1000 - second * 100) / 10;
            fourth = userNum - first * 1000 - second * 100 - third * 10;

            firstSum = first + second;
            secondSum = third + fourth;

            if(firstSum == secondSum)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
        }
    }
}
