using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixDiagSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет разницы по модулю между суммой чисел в матрице по диагонали.");
            Console.WriteLine("Заполните матрицу 3х3. Цифры в столбцах вводить через пробел.\nПереход на следующий ряд - Enter.\n");

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int sumdiag1 = 0;
            int sumdiag2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sumdiag1 += arr[i][i];
                sumdiag2 += arr[i][arr.Count - 1 - i];

            }

            Console.WriteLine(Math.Abs(sumdiag1 - sumdiag2));

        }
    }
}

