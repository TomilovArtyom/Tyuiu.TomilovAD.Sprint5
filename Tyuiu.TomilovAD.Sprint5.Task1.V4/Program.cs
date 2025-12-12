using System.IO;
using Tyuiu.TomilovAD.Sprint5.Task1.V4.Lib;

namespace Tyuiu.TomilovAD.Sprint5.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startvalue =-5;
            int endvalue =5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startvalue = " + startvalue + ", endvalue = " + endvalue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startvalue, endvalue);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");

            Console.ReadKey();

        }
    }
}