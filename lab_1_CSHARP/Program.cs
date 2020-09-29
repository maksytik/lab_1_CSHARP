using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Введите число № 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число № 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Metod(num1, num2);
        }

        static void Metod(int a, int b)
        {
            Console.WriteLine($"Произведение {a} на {b}, равно = {a * b}, а его квадрат = {Math.Pow(a * b, 2)}");        
        }
    }
}
