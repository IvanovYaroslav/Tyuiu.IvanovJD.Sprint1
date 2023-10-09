using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint1.Task3.V2.Lib;

namespace Tyuiu.IvanovJD.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Иванов Я. Д. | ПКТБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Иванов Ярослав Дмитриевич | ПКТБ-23-2                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double cena;
            double cena2;
            int k;
            int t;


            Console.WriteLine("Введите цену карандашей:");
            cena = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену тетрадей:");
            cena2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во карандашей:");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во тетрадей:");
            t = Convert.ToInt32(Console.ReadLine());


            double b;
            b = ds.PurchaseAmount((double)cena, (int)k, (double)cena2, (int)t);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Стоимость товаров =" + b);





            Console.ReadLine();
        }
    }
}