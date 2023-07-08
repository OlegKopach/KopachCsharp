using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задание 2:
Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени".*/
namespace KopachCsharpHW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inscribedName;
            string requiredName = "Вячеслав";

            Console.WriteLine("Введите имя: ");
            inscribedName = Console.ReadLine();

            if (inscribedName == requiredName)
            {
                Console.WriteLine("Привет, Вячеслав!");
            }
            else
            {
                Console.WriteLine("Нет такого имени!");
            }
            Console.ReadLine();
        }
    }
}
