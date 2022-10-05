using System;

namespace Lab6
{
    class Program
    {
        static int switchingNum, addedNum = 0;
        static int revRecursion(int intNumM)
        {
            if (intNumM != 0)
            {
                switchingNum = intNumM % 10;
                addedNum = addedNum * 10 + switchingNum;
                intNumM /= 10;
                return revRecursion(intNumM);
            }
            return addedNum;
        }

        static int rev(int intNumM)
        {
            int switchingNum, addingNum = 0;
            while (intNumM != 0)
            {
                switchingNum = intNumM % 10;
                addingNum = addingNum * 10 + switchingNum;
                intNumM /= 10;
            }
            return addingNum;
        }

        static string rev(string str)
        {
            char[] stringConverted = str.ToCharArray();
            string start2 = "";
            for (int i = stringConverted.Length - 1; i >= 0; i--)
            {
                start2 = start2 + stringConverted[i];
            }
            return start2;
        }

        static string str2 = "";
        static string revRecursion(string start, int stringLengthM)
        {
            char[] stringConverted = start.ToCharArray();
            if (stringLengthM != 0)
            {
                stringLengthM--;
                str2 = str2 + stringConverted[stringLengthM];
                string str = new string(stringConverted);
                return revRecursion(str, stringLengthM);
            }
            return str2;
        }
        static double rev(double doubleNumF)
        {
            int switchingNumber1, addedNumber1 = 0, switchingNumber2, addedNumber2 = 0;

            string num = Convert.ToString(doubleNumF);
            int length = num.Length;
            int decimalCounter = 0;
            for (int i = 0; i < length; i++)
            {
                if (num[i] == ',')
                {
                    decimalCounter = length - i - 1;
                }
            }

            int incrementNum = 1;
            for (int i = 0; i < decimalCounter; i++)
            {
                incrementNum *= 10;
            }

            int integerPart = Convert.ToInt32(Math.Truncate(doubleNumF));
            int decimalPart = Convert.ToInt32((doubleNumF - Math.Truncate(doubleNumF)) * incrementNum);

            while (integerPart != 0 && decimalPart != 0)
            {
                switchingNumber1 = integerPart % 10;
                addedNumber1 = addedNumber1 * 10 + switchingNumber1;
                integerPart /= 10;
                switchingNumber2 = decimalPart % 10;
                addedNumber2 = addedNumber2 * 10 + switchingNumber2;
                decimalPart /= 10;
            }

            string string1 = addedNumber1.ToString();
            string string2 = addedNumber2.ToString();

            string resultStr = "";
            for (int i = 0; i < string1.Length; i++)
            {
                resultStr += string1[i];
            }

            resultStr += ",";

            for (int i = 0; i < string2.Length; i++)
            {
                resultStr += string2[i];
            }

            double Result = Convert.ToDouble(resultStr);
            return Result;
        }

        static void Main(string[] args)
        {
            int intNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(revRecursion(intNum));
            Console.WriteLine(rev(intNum) + "\n");


            string userString = Convert.ToString(Console.ReadLine());

            int stringLength = userString.Length;
            Console.WriteLine("");
            Console.WriteLine(rev(userString));
            Console.WriteLine(revRecursion(userString, stringLength) + "\n");

            double doubleNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(rev(doubleNum)+ "\n");
        }
    }
}
