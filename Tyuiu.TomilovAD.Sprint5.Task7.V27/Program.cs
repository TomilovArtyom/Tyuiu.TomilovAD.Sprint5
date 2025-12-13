using Tyuiu.TomilovAD.Sprint5.Task7.V27.Lib;
using System.IO;

namespace Tyuiu.TomilovAD.Sprint5.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V10.txt");

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Данные находятся в файле " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadDataAndSave(path);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}