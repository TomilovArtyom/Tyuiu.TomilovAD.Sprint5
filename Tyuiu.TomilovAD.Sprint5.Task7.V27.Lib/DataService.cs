using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TomilovAD.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V27.txt");
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        strLine = Regex.Replace(line, @"\s+", " ");
                    }

                    File.AppendAllText(pathSaveFile, strLine);
                }
            }

            return pathSaveFile;
        }
    }
}
