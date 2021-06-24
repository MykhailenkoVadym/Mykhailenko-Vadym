//Mykhailenko Vadym PD-22

using System;
using System.Collections.Generic;

namespace lab_7_dimass
{
    class Program
    {
        public static void enterlist(ref List<int> listInt)
        {
            int sizeList = int.Parse(Console.ReadLine());
            for (int i = 0; i < sizeList; i++)
            {
                Console.Write($"Введите {i}-ий елемент листа: ");
                listInt.Add(int.Parse(Console.ReadLine()));
            }
        }
        public static void index(ref List<int> listInt, int k)
        {
            bool temp = false;
            for (int i = 0; i < listInt.Count; i++)
            {
                if (listInt[i] == k)
                {
                    Console.Write("{0 } ", i);
                    temp = true;
                }
            }
            if (!temp)
                Console.Write("--Таких елементов нет--");

        }
        public static void printarrayint(in int[] ArrFromList)
        {
            Console.WriteLine();
            Console.Write("Масив по исходному листу: ");
            for (int i = 0; i < ArrFromList.Length; i++)
                Console.Write($"{ArrFromList[i]} ");
        }
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();
            Console.Write("Введите размер листа: ");
            enterlist(ref listInt);

            Console.Write("Введите проверочную переменную: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Индекси елементов которие имеют значение проверочной перенной: ");
            index(ref listInt, k);
            int[] ArrFromList = new int[listInt.Count];
            for (int i = 0; i < listInt.Count; i++)
                ArrFromList[i] = listInt[i];
            printarrayint(in ArrFromList);
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}