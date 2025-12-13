using System.IO;
using Tyuiu.TomilovAD.Sprint5.Task5.V13.Lib;

namespace Tyuiu.TomilovAD.Sprint5.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V13.txt");

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
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