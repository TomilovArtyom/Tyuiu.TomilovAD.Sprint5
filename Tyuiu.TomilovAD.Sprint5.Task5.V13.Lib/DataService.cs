using System.IO;
using System.Reflection.PortableExecutable;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TomilovAD.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double i = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim().Replace(".", ",");
                    string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string numberstr in numbers)
                    {
                        if (double.TryParse(numberstr, out double num))
                        {
                            i++;
                            if (Math.Abs(num) >= -1.5 && Math.Abs(num) <= 1.5)
                            {
                                res = res + num;
                            }
                        }
                    }
                }
            }
            return Math.Round((res/i), 3);
        }
    }
}
