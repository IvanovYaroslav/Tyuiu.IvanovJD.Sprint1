using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint1.Task1.V1.Lib;

namespace Tyuiu.IvanovJD.Sprint1.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт №1 | Выполнил: Иванов Я. Д. | ПКТБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #0                                                                *");
            Console.WriteLine("* Тема: Создание решения выражения                                         *");
            Console.WriteLine("* Задания #0                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Иванов Ярослав Дмитриевич  | ПКТБ-23-2                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программуна С#, которая вычисляет выражение x / 3 / y + 6 * a   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine(ds.Calculate(x,y,a));
            Console.ReadLine();
        }
    }
    }
}