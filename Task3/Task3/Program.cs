using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Задание 3:
 Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные  3.
*/
namespace KopachCsharpHW3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[] { 44, 45, 60, 30, 90, 25, 16, 77, 99, 100, 33, 10, 3 };

            Console.WriteLine("Source array:");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nResult:");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 3 == 0)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
            Console.ReadKey();
        }
    }
}