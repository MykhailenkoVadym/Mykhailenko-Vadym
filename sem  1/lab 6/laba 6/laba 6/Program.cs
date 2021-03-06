﻿//Mykhailenko Vadym PD-22

using System;
namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 reverse an integer number");
            ReverseInt();

            Console.WriteLine();

            Console.WriteLine("2 reverse a string");
            ReverseString();

            Console.WriteLine();

            Console.WriteLine("3 reverse a double");
            ReverseDouble();

            Console.WriteLine();

            Console.WriteLine("4 reverse a string with a MAGICAL sign");
            ReverseStringWithAMagicalSign();

            Console.WriteLine();

            Console.WriteLine("using method overloading");
            int number;
            Console.Write(" Enter an int: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Enter a correct number: ");
            }
            Reverse(number);
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            Reverse(s);
            Console.Write("Enter a double: ");
            double dbNumber;
            while (!double.TryParse(Console.ReadLine(), out dbNumber))
            {
                Console.WriteLine("Enter a correct double: ");
            }
            Reverse(dbNumber);
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter a sign that divides your string: ");
            char magicalSign = Convert.ToChar(Console.ReadLine());
            Reverse(str, magicalSign);


        }

        static int Choice()
        {
            int choice;

            Console.Write("\nEnter your option: ");

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Enter a correct number");
            }
            return choice;
        }

        //task 1
        static void ReverseInt()
        {
            Console.Write("\nEnter a number you want to reverse: ");
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter a correct number: ");
            }
            Console.Write("Your reversed number: ");
            Console.Write(num % 10);
            while ((num /= 10) != 0)
                Console.Write(num % 10);
            Console.WriteLine();
        }

        //task 2
        static void ReverseString()
        {
            Console.Write("\nEnter a string you want to reverse: ");
            string str = Console.ReadLine();
            char[] strArr = str.ToCharArray();
            Console.Write("Your reversed string: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
            }
            Console.WriteLine();
        }

        //task 3
        static void ReverseDouble()
        {
            Console.Write("\nEnter a double to reverse: ");
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Enter a correct double:");
            }
            string[] splitedStr = number.ToString().Split(',');

            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
        }

        //task 4
        static void ReverseStringWithAMagicalSign()
        {
            Console.Write("\nEnter a string to reverse: ");
            string magString = Console.ReadLine();
            Console.Write("Which character will divide your string: ");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(sign);


            if (magString.IndexOf(sign) != -1)
            {
                string[] splitedStr = magString.Split(sign);

                Console.Write("Your reversed string: ");
                for (int j = splitedStr[0].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[0][j]);
                }
                Console.Write(sign);
                for (int j = splitedStr[1].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[1][j]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no selected sign in this string :(");
            }
        }

        static void Reverse(int number)
        {
            Console.Write("Your reversed integer: ");
            Console.Write(number % 10);
            while ((number /= 10) != 0)
                Console.Write(number % 10);
            Console.WriteLine();
        }

        static void Reverse(string s)
        {
            char[] strArr = s.ToCharArray();
            Console.Write("Your reversed string: ");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
            }
            Console.WriteLine();
        }

        static void Reverse(double doubleNumber)
        {
            string[] splitedStr = doubleNumber.ToString().Split(',');
            Console.Write("Your reversed double: ");
            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
            Console.WriteLine();
        }

        static void Reverse(string s, char sign)
        {
            if (s.IndexOf(sign) != -1)
            {
                string[] splitedStr = s.Split(sign);

                Console.Write("Your reversed string: ");
                for (int j = splitedStr[0].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[0][j]);
                }
                Console.Write(sign);
                for (int j = splitedStr[1].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[1][j]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no selected sign in this string :(");
            }
        }
    }
}