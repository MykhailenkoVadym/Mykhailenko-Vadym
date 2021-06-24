/*Mykhailenko Vadym PD-22
  вариант 16
Даний масив розміру N. Визначити кількість його проміжків монотонності (інтервалів індексів, для яких його елементи монотонно зростають (спадають)). 
*/

using System;
class Program
{

    static void Main()
    {

        int n, k = 0, m = 0,b = 0;
        Console.WriteLine("введите размер масива");
        n = int.Parse(Console.ReadLine());
        int[] a;

        a = new int[n];

        for (int i = 0; i < n; i++)
        {

            Console.Write("n[" + (i) + "] = ");

            a[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < n - 1; i++)
        {
            if (a[i] < a[i + 1])
            {
                if (b!=1)
                {
                    k++;
                    b = 1;
                }
            }
            if (a[i] > a[i + 1])
            {
                if (b != -1)
                {
                    m++;
                    b = -1;
                }
            }
        }


        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Количество интервалов роста: " + k);
        Console.WriteLine("Количество интервалов спада: " + m);
    }
}