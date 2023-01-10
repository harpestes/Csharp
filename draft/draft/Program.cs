using System;

    //Створити клас Cars, в якому міститься набір з 5 машин американського виробництва, для кожної з машин визначені 4 характеристики: 
    //колекція кольорів в якому вона представлена, рік випуску і ціна. 
    //Четверту характеристику оберіть самі. Реалізувати можливість для покупця обрати машину з набору за її параметрами. 
    //Повідомити якщо не існує машини з потрібними параметрами, якщо існує – вивести на екран повний опис машини.
namespace draft
{
    class Program
    {
        static int Choice()
        {
            int res;
            bool check = int.TryParse(Console.ReadLine(), out res);
            if(check)
                return res;
            return 0;
        }

        static int Choice(string str)
        {
            if (str == "Red" || str == "red" || str == "RED")
                return 1;
            else if (str == "Black" || str == "black" || str == "BLACK")
                return 2;
            else if (str == "White" || str == "white" || str == "WHITE")
                return 3;
            else if (str == "Khaki" || str == "khaki" || str == "KHAKI")
                return 4;
            return 0;
        }

        static void Main(string[] args)
        {
            Cars[] cars = {new Cars("Jeep", 120000, 2020, Cars.Colors.Black),
                           new Cars("Dodge", 210000, 2022, Cars.Colors.White),
                           new Cars("Ford", 16000, 2009, Cars.Colors.Khaki),
                           new Cars("Tesla", 1600000, 2022, Cars.Colors.Black),
                           new Cars("GMC", 305000, 2012, Cars.Colors.Red)};

            bool flag1 = true, flag2 = true;
            int choice, price, yearOfManufactoring;
            Cars.Colors color;
            string stop;

            do
            {
                price = 0;
                yearOfManufactoring = 0;
                color = Cars.Colors.NULL;

                Console.WriteLine("PRICE:\nBigger than(1)\nLess than(2)");
                choice = Choice();
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Choose price: ");
                            price = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Choose price: ");
                            price = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            choice = 0;
                            break;
                        }
                }

                Console.WriteLine("YEAR OF MANUFACTURING:\n2009(1)\n2012(2)\n2020(3)\n2022(4)");
                Console.Write("Choose year: ");
                switch (Choice())
                {
                    case 1:
                    case 2009:
                        {
                            yearOfManufactoring = 2009;
                            break;
                        }
                    case 2:
                    case 2012:
                        {
                            yearOfManufactoring = 2012;
                            break;
                        }
                    case 3:
                    case 2020:
                        {
                            yearOfManufactoring = 2020;
                            break;
                        }
                    case 4:
                    case 2022:
                        {
                            yearOfManufactoring = 2022;
                            break;
                        }
                    default: break;
                }

                Console.WriteLine("COLOR:\nRed(1)\nBlack(2)\nWhite(3)\nKhaki(4)");
                Console.Write("Choose color: ");
                switch (Choice(Console.ReadLine()))
                {
                    case 1:
                        {
                            color = Cars.Colors.Red;
                            break;
                        }
                    case 2:
                        {
                            color = Cars.Colors.Black;
                            break;
                        }
                    case 3:
                        {
                            color = Cars.Colors.White;
                            break;
                        }
                    case 4:
                        {
                            color = Cars.Colors.Khaki;
                            break;
                        }
                    default: break;
                }

                if(price == 0 && yearOfManufactoring == 0 && color == Cars.Colors.NULL)
                {
                    Console.WriteLine(new string('-', 50));
                    for(int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                        flag2 = false;
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price != 0 && yearOfManufactoring == 0 && color == Cars.Colors.NULL)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if(choice == 1)
                        {
                            if (cars[i].Price > price)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            }
                        }
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price == 0 && yearOfManufactoring != 0 && color == Cars.Colors.NULL)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].YearOfManufacturing == yearOfManufactoring)
                        {
                            Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                            flag2 = false;
                        }
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price == 0 && yearOfManufactoring == 0 && color != Cars.Colors.NULL)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Color == color)
                        {
                            Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                            flag2 = false;
                        }
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price != 0 && yearOfManufactoring != 0 && color == Cars.Colors.NULL)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (choice == 1)
                        {
                            if (cars[i].Price > price && cars[i].YearOfManufacturing == yearOfManufactoring)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price && cars[i].YearOfManufacturing == yearOfManufactoring)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            } 
                        }
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price != 0 && yearOfManufactoring == 0 && color != Cars.Colors.NULL)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (choice == 1)
                        {
                            if (cars[i].Price > price && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            }
                        }
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price == 0 && yearOfManufactoring != 0 && color != Cars.Colors.NULL)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].YearOfManufacturing == yearOfManufactoring && cars[i].Color == color)
                        {
                            Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                            flag2 = false;
                        }
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                else
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (choice == 1)
                        {
                            if (cars[i].Price > price && cars[i].YearOfManufacturing == yearOfManufactoring && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price && cars[i].YearOfManufacturing == yearOfManufactoring && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Mark + "\t\t" + cars[i].Price + "\t" + cars[i].YearOfManufacturing + "\t" + cars[i].Color);
                                flag2 = false;
                            }
                                
                        }
                    }
                    if (flag2) Console.WriteLine("There is no such a vehicle");
                    Console.WriteLine(new string('-', 50));
                }

                Console.WriteLine("Should we stop the program(yes/no): ");
                stop = Console.ReadLine();
                if (stop == "yes" || stop == "Yes" || stop == "YES") flag1 = false;
            }
            while (flag1);
        }
    }
}