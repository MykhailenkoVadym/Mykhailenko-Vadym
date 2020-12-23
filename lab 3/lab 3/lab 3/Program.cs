/*Mykhailenko Vadym PD-22 
вариант 16
Перевірити істинність вислову: "Цифри даного тризначного числа утворюють геометричну прогресію".
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int x, y, z;
        Console.WriteLine("введите трёхзначне число по одной цифре");
        Console.WriteLine("x = ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("y = ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("z = ");
        z = int.Parse(Console.ReadLine());
        if (2*x == y&&2*y==z)
        {
            Console.WriteLine("утврорюе геометричну прогресію");
        }
        else
        {
            Console.WriteLine("не утврорюе геометричну прогресію");
        }
    }
}