using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;

namespace W2L8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
        }

        private static void Task10()
        {
            Console.Write("Enter the first number: ");
            int number1 = enterTheNumber();
            Console.Write("Enter the second number: ");
            int number2 = enterTheNumber();

            int numberMin = Math.Min(number1, number2);
            int result = 0;
            for (int i = 1; i <= numberMin; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    result = i;
                }
            }
            Console.WriteLine(number1*number2 / result);
        }

        private static void Task9()
        {
            Console.Write("Enter the number: ");
            int number = enterTheNumber();
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
        }

        private static void Task8()
        {
            Console.Write("Enter the string: ");
            string userString = Console.ReadLine();

            char[] userStringArray = userString.ToCharArray();
            Array.Reverse(userStringArray);
            string userStringReverse = String.Concat(userStringArray);

            Console.WriteLine(userStringReverse);
        }

        private static void Task7()
        {
            Console.Write("Enter the number: ");
            int number = enterTheNumber();
            int number2 = number;
            int halfNumber = number / 2 - 1;
            int stars = 1;

            for (int i = 0; i < number / 2; i++)
            {
                for (int z = halfNumber; z >= 0; z--)
                {
                    Console.Write(" ");
                }
                halfNumber--;
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write('*');
                }
                stars += 2;
                Console.WriteLine();
            }

            number = number2;
            int spaces = 1;
            stars = number + 1;

            for (int i = 0; i <= number / 2; i++)
            {
                for (int z = 1; z <= spaces - 1; z++)
                {
                    Console.Write(' ');
                }
                spaces++;
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write('*');
                }
                stars -= 2;
                Console.WriteLine();
            }


        }

        private static void Task6()
        {
            double helper = 1;
            double result = 0;
            for (int i = 1; i <= 20; i++)
            {
                result += helper / i;
            }
            Console.WriteLine(result);
        }

        private static void Task5()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(Math.Pow(i,3) + " ");
            }
        }        

        public static void Task4()
        {
            int count = 1;
            Console.Write("Enter the number: ");
            int userNumber = enterTheNumber();
            for (int i = 1; i <= (userNumber/2) - 1; i++)
            {
                for (int Number = 1; Number <= i; Number++)
                {
                    Console.Write(count++ + " ");

                   if (userNumber+1 == count) break;
                }
                Console.WriteLine();

                if (userNumber + 1 == count) break;
            }
        }

        private static void Task3()
        {/*
            int[] fibArr = new int[20];
            fibArr[0] = 0;
            fibArr[1] = 1;
            fibArr[2] = 1;
            for (int i = 3; i < fibArr.Length; i++)
            {
                fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
                Console.WriteLine(fibArr[i]);
            }*/
            int n = 20;
            uint f = 0, f0 = 1, f1 = 1;            
            while (n>=2)
            {
                if (f == 0 && f0 == 1 && f1 == 1)
                {
                    Console.WriteLine(f);
                    Console.WriteLine(f0);
                    Console.WriteLine(f1);
                }
                f = f0 + f1;
                f0 = f1;
                f1 = f;
                n--;
                Console.WriteLine(f);
            }
        }

        private static void Task2()
        {
            int i = 0;
            do
            {
                if (i == 0) Console.WriteLine(i);
                Console.WriteLine(i += 2);
            } while (i<1000);
        }

        private static void Task1()
        {
            Console.Write("Enter the integer number: ");
            int number = enterTheNumber();
            int flag = 0;

            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    flag = 1; 
                    break;
                }
            }

            if (number == 1) Console.WriteLine("1 is neither prime nor composite.");
            else
            {
                if (flag == 0) Console.WriteLine($"{number} is a prime number");
                else Console.WriteLine($"{number} isn't a prime number");
            }
        }

        private static int enterTheNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(),out number))
            {
                Console.Write("Enter correct integer number: ");
            }
            if (number < 0) number *= (-1);
            return number;
        }
    }
}
