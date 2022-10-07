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

        static string str3 = "";
        static string revRecursion(string start, int stringLengthM)
        {
            char[] stringConverted = start.ToCharArray();
            if (stringLengthM != 0)
            {
                stringLengthM--;
                str3 = str3 + stringConverted[stringLengthM];
                string str = new string(stringConverted);
                return revRecursion(str, stringLengthM);
            }
            return str3;
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

        static double revRecursion(double doubleNumF)
        {
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

            addedNum = 0;
            string string1 = revRecursion(integerPart).ToString();
            addedNum = 0;
            string string2 = revRecursion(decimalPart).ToString();

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

        static string rev(char[] str)
        {
            int length = str.Length, temp = 0;

            string firstPart = "", secondPart = "";
            for (int i = 0; i < length; i++)
            {
                if (str[i] == ',')
                {
                    temp = i;
                    break;
                }
                firstPart += str[i];
            }
            for (int i = temp + 1; i < length; i++)
            {
                secondPart += str[i];
            }

            string str1 = "", str2 = "";
            for (int i = firstPart.Length - 1; i >= 0; i--)
            {
                str1 = str1 + firstPart[i];
            }

            for (int i = secondPart.Length - 1; i >= 0; i--)
            {
                str2 = str2 + secondPart[i];
            }

            string resultStr = "";
            for (int i = 0; i < str1.Length; i++)
            {
                resultStr += str1[i];
            }

            resultStr += ",";

            for (int i = 0; i < str2.Length; i++)
            {
                resultStr += str2[i];
            }

            string Result = Convert.ToString(resultStr);
            return Result;
        }

        static string revRecursion(char[] str)
        {
            int length = str.Length, temp = 0, firstPartLength = 0, secondPartLength = 0;

            string firstPart = "", secondPart = "";
            for (int i = 0; i < length; i++)
            {
                if (str[i] == ',')
                {
                    temp = i;
                    break;
                }
                firstPart += str[i];
                firstPartLength++;
            }
            for (int i = temp + 1; i < length; i++)
            {
                secondPart += str[i];
                secondPartLength++;
            }

            string resultStr = "";

            str3 = "";
            resultStr += revRecursion(firstPart, firstPartLength);
            str3 = "";
            resultStr += ",";
            resultStr += revRecursion(secondPart, secondPartLength);

            return resultStr;
        }

        static void reverseArrayMethod(ref int[] arr, int[] tempArray)
        {
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = arr[tempArray.Length - i - 1];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = tempArray[i];
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter integer num: ");
            int intNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(revRecursion(intNum));
            Console.WriteLine(rev(intNum) + "\n");

            Console.Write("Please enter letters: ");
            string userString = Convert.ToString(Console.ReadLine());

            int stringLength = userString.Length;
            Console.WriteLine("");
            Console.WriteLine(rev(userString));
            Console.WriteLine(revRecursion(userString, stringLength) + "\n");

            Console.Write("Please enter float num: ");
            double doubleNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(rev(doubleNum));
            Console.WriteLine(revRecursion(doubleNum) + "\n");

            Console.Write("Please enter letters with coma: ");
            string userUnusualString = Convert.ToString(Console.ReadLine());
            char[] userCharArray = new char[userUnusualString.Length];

            for (int i = 0; i < userUnusualString.Length; i++)
            {
                userCharArray[i] = userUnusualString[i];
            }
            Console.WriteLine("");
            Console.WriteLine(rev(userCharArray));
            Console.WriteLine(revRecursion(userCharArray) + "\n");

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] tempArray = new int[arr.Length];
            Console.WriteLine("Array before reversing:");
            foreach (int num in arr)
            {
                Console.Write(num + "\t");
            }
            reverseArrayMethod(ref arr, tempArray);
            Console.WriteLine("\nArray after reversing:");
            foreach (int num in arr)
            {
                Console.Write(num + "\t");
            }
        }
    }
}
