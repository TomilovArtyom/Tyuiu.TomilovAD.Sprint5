using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TomilovAD.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string pathsavefile = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V27.txt");
            FileInfo fileinfo = new FileInfo(pathsavefile);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(pathsavefile);
            }

            string strLine = "";
            using ()
        }
    }
}
