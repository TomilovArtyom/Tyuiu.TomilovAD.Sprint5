using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.TomilovAD.Sprint5.Task3.V8.Lib
{
    public class DataService : ISprint5Task3V8
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y = Math.Round(((Math.Pow(x,2) + 1) / (3 * x + 4)), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), System.Text.Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            
            return path;
        }
    }
}
