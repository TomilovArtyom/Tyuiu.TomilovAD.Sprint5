using Tyuiu.TomilovAD.Sprint5.Task4.V6.Lib;
using System.IO;

namespace Tyuiu.TomilovAD.Sprint5.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V6.txt";

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Данные находятся в файле " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}