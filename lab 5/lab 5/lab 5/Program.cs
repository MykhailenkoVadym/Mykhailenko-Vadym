
//Mykhailenko Vadym PD-22
// вариант 16
//Дана квадратна матриця порядку M. Замінити нулями елементи матриці, що лежать 1) нижче 2) вище 3) головної; 4) побічної діагоналі. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("enter m ");
            Console.Write("m: ");
            m = Convert.ToInt32(Console.ReadLine());
            

            int[,] matrix1 = new int[m, m];
            int[,] matrix2 = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("matrix1[{0}][{1}] = ", i, j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    matrix2[i, j] = matrix1[i, j];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int space = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0 + space; j < m; j++)
                {
                    matrix1[i, j] = 0;
                }
                space++;
            }

            space = m-1;
            for (int i = 0; i < m; i++)
            {
                space = m - i;
                for (int j = 0; j < m-space; j++)
                {
                    matrix1[i, j] = 0;
             
                }
                space--;
            }

            Console.WriteLine("Замена нулями елементы матрицы, которые лежат ниже, выше главной диагонали");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            space = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m - space; j++)
                {
                    matrix2[i, j] = 0;
                }
                space++;
            }

            space = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0 + space; j < m; j++)
                {
                    matrix2[i, j] = 0;
                }
                space--;
            }
            Console.WriteLine("Замена нулями елементы матрицы, которые лежат ниже, выше побочной диагонали ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}