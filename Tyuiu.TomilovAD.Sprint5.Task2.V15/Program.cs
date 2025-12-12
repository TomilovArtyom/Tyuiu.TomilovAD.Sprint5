using System.IO;
using Tyuiu.TomilovAD.Sprint5.Task2.V15.Lib;

namespace Tyuiu.TomilovAD.Sprint5.Task2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 6, 1, 7 }, { 1, 8, 5 }, { 6, 6, 4 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

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
            Console.WriteLine("Массив");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{ mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан");

            Console.ReadKey();

        }
    }
}