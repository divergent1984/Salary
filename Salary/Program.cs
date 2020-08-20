using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем массив из трёх элементов.
            int[] nums = new int [3];
            Random rnd = new Random();
          {
                // рандомно выбираем числа элементам массива.
                nums[0] = rnd.Next(100, 1000);
                nums[1] = rnd.Next(100, 1000);
                nums[2] = rnd.Next(100, 1000);
                // находим минимальное и максимальное число в массиве.
                int min = nums.Min();
                int max = nums.Max();
                // находим разницу между максимальным и минимальным значением.
                int sum = max - min;
                Console.WriteLine($" максимальная зарплата: {max}, минимальная зарплата:  {min}, разница между ними равна:  {sum}");
                Console.ReadKey();

            }
        }
    }
}
