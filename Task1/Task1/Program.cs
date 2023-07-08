using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Задание 1:
Составить алгоритм: если введенное число больше 7, то вывести “Привет”.
 */

namespace KopachCsharpHW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int receivedNumber;
            Console.WriteLine("Введите число: ");
            receivedNumber = int.Parse(Console.ReadLine());

            if (receivedNumber > 7)
            {
                Console.WriteLine("Привет!");
            }
            else if (receivedNumber <= 7)
            {
                Console.WriteLine("Попробуй еще!");
            }
            Console.ReadLine();
        }
    }
}