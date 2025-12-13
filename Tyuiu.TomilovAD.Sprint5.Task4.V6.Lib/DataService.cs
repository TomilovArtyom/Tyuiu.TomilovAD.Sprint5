using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.TomilovAD.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");
            double x = Convert.ToDouble(strx);
            double y = Math.Round((1 / Math.Cos(x) + 2.2 * Math.Pow(x, 2)), 3);
            return y;
        }
    }
}
